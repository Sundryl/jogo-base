# Plano 04 — Fase 2: Export do projeto Unity (re-tentativa sequencial)

**Objetivo:** port/UnityProject completo (cenas/prefabs/sprites/áudio/SoB) a partir do build IL2CPP.

**Já sei:**
- AssetRipper 2.0 tem pipeline IL2CPP embutido (LibCpp2IL) — load processa 101k métodos sozinho
- Export parcial anterior (160 MB, cancelado pelo restart do host) fica como backup:
  move para work/export_parcial_001 (não apagar)
- API: nohup GUI.Free --headless --port 61111 → /Settings/Update TargetVersion=2021.3.36f1 →
  POST /LoadFile (302 na conclusão) → POST /Export/UnityProject (302 na conclusão) → semântica verificada

**Passos (um script único, serial):**
1. mover parcial → work/export_parcial_001
2. iniciar servidor headless; aguardar HTTP 200
3. Settings/Update TargetVersion=2021.3.36f1
4. LoadFile FantasyMapSimulator.exe; aguardar "Finished processing assets" no log
5. Export/UnityProject para port/UnityProject; aguardar return
6. validar estrutura (Assets, ProjectSettings, Packages) + contagem de arquivos
7. notes/inventario.md parcial; commit

**Riscos:** export grande (memória ok, 6.5GB assets ~ OK). Server crash → log /tmp/assetripper.log.
**Como sei que terminou:** pasta completa + log sem erros + commit.
