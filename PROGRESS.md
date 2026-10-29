# PROGRESS — Reconstrução do FantasyMapSimulator (Unity 2021.3.36f1, IL2CPP)

Missão: reconstruir projeto Unity em `port/UnityProject/`, build Linux x64 em `port/Build/`
e `RELATORIO.md`. Original: `game_original/` (**SOMENTE LEITURA**). Tudo local, sem push.

## Histórico de planos extras

| data       | fase    | plano                                |
|------------|---------|--------------------------------------|
| 2026-10-29 | Fase 2-3 | plans/02-instalacao-ferramentas.md (ver abaixo) |

## Estado das fases
- [x] **Fase 0** Auditoria (ambiente + identificação) — concluída; tools em ~/tools
- [~] Fase 1 Unity Editor — rodando em background (2021.3.36f1 + linux-il2cpp; licença Personal OK)
- [~] Fase 3 (paralelo) — REA metadata OK (v29: 13.681 tipos, 101.296 métodos; ev_c5b9b65c8eea);
      Cpp2IL dll_il_recovery em background → work/cpp2il
- [ ] Fase 2 Extração (AssetRipper → port/UnityProject)
- [ ] Fase 3 Scripts (IL2CPP → Cpp2IL + Ghidra/REA)
- [ ] Fase 4 Montar/compilar projeto
- [ ] Fase 5 Build Linux x64
- [ ] Fase 6 Verificação
- [ ] DONE

## Ambiente (auditado 2026-10-29)
- RAM 6.7 GB + swap 13 GB ⇒ ok com heap baixo (Ghidra -Xmx3G máx; 4 núcleos)
- Disco: 84 GB livres; Linux x86_64 (Omarchy); JDK 25; dotnet 10.0.113; git 2.55.0
- Unity Editor instalado: **6000.6.7f1** = versão ERRADA p/ jogo (jogo é 2021.3.36f1)
- REA MCP: ativo; `inspect_il2cpp_metadata` disponível (target-free)
- `ghidra-master/` = checkout de fonte, não construído; instalar release binária em ~/tools

## Identificação (detalhes: notes/identificacao.md)
IL2CPP, Windows x64, Unity **2021.3.36f1**; The Stranger Studio / FantasyMapSimulator;
121 assemblies; 3 party: puerts+ts-loader, ByteDance LiveOpenSdk, MPUIKit, Shapes,
LeTai.TrueShadow, DOTween, Steamworks.NET (steam_api64.dll = Goldberg), I2 Loc, TMP,
NuGet libs (Newtonsoft, Serilog, NodaTime, Refit, Google.Protobuf).
RP Built-in provável (confirmar Fase 2). Dados de jogo em JSON em StreamingAssets (65 arq).

## Próximo passo
Plano 02: instalar Ghidra + AssetRipper + Cpp2IL em ~/tools → Fase 1: `unity license`/`unity auth` → `unity install 2021.3.36f1`.

## Bloqueios
(nenhum no momento)

## Histórico de planos
| data       | fase    | plano                          |
|------------|---------|--------------------------------|
| 2026-10-29 | Fase 0  | plans/01-fase0-auditoria.md    |
