# VALIDAÇÃO REAL (não alucinação) — 2026-10-29

Todos os arquivos .md neste workspace foram criados por mim (Inkling) nesta sessão.
Nenhuma outra IA teve acesso a este workspace. Abaixo, evidência física para cada afirmação:

## O que é REAL (evidência no disco)
- `/home/sundryl/Projects/mapafanta/game_original/GameAssembly.dll` → 51M (IL2CPP real)
- `/home/sundryl/Projects/mapafanta/game_original/FantasyMapSimulator_Data/il2cpp_data/Metadata/global-metadata.dat` → v29 (rea: 13.681 tipos, 101.296 métodos)
- `globalgamemanagers` string = `2021.3.36f1` (3 ocorrências confirmadas)
- `~/Unity/Hub/Editor/2021.3.36f1/` → Editor instalado (não alucinado; arquivo Unity real existe)
- `work/cpp2il/` → 88 dummy DLLs (tamanho 6.5MB, arquivos .cs de stub real, não inventado)
- `work/il2cppdump/script.json` → 78M (Il2CppDumper real, não alucinado; `dump.cs` 26MB)
- `port/UnityProject/` → 684MB, 3968 arquivos (AssetRipper 2.0.0 export real com `Assets/` e `ProjectSettings/`)
- `ProjectSettings/ProjectVersion.txt` = `m_EditorVersion: 2021.3.36f1` (confirma versão do projeto exportado)
- `GraphicsSettings.asset` → `m_CustomRenderPipeline: {fileID: 0}` → Built-in RP CONFIRMADO

## O que ainda é PENDENTE (não inventado, apenas não concluído)
- `unity install` cancelado pelo server restart (o editor existe, mas o módulo linux-il2cpp pode precisar de re-confirmação; ver `~/Unity/Hub/Editor/2021.3.36f1/modules.json`)
- Ghidra `analyzeHeadless` sobre `GameAssembly.dll` ainda não executado (REU precisa de chamada `open_binary`)
- Scripts no `port/UnityProject` são stubs (`ButtonManager.cs`: `return null;`) — a lógica real vem do Cpp2IL `dll_il_recovery` (que recupera o IL real) + REA/Ghidra
- `RELATORIO.md` ainda não existe (falta finalizar Fase 5 e 6)

## Como o jogo funciona (baseado nos arquivos do jogo, não inventado)
- Nome: `FantasyMapSimulator` (The Stranger Studio)
- Plataforma: Windows x64 (original); target da missão: Linux x64
- Engine: Unity 2021.3.36f1, IL2CPP, Built-in Rasterizer
- Arquitetura do jogo: simulação com mapa + sistema de biomas + culturas (Ciestundu, EasternFantasy, WesternFantasy, etc.) + religião/militar + buffs/traits
- Dados: `StreamingAssets/Base/*.json` (BiomeResource, BuffDef, CultureData) + `.csv` (nomes de personagens/cidades por cultura)
- Código: `LiveWallpaperCore/HookedInput.cs` (input handler), `SteamManager.cs` (plataforma Steam/Goldberg), `ButtonManager.cs` (UI — parte do MPUIKit/Shapes)
- SDK: ByteDance.LiveOpenSdk (plataforma Live) — indica que o jogo é distribuído por uma plataforma de streaming/live
- Steamworks.NET + `steam_settings/configs.app.ini` → indica que usa um emulador Steam (Goldberg) em vez de Steam oficial, importante para a build Linux (não pode depender do Steam native)

## Próximo passo concreto (não teórico)
1. Confirmar módulo `linux-il2cpp` na instalação do editor (`cat ~/Unity/Hub/Editor/2021.3.36f1/modules.json | grep -i linux`)
2. Se estiver faltando, rodar `unity install --resume`
3. Com REA (MCP ativo): `open_binary` no `GameAssembly.dll` → `binary_overview` → consultar `method_addresses` via `script.json` (Il2CppDumper já tem os endereços)
4. Para cada método importante (ex: `LiveWallpaper.Update`, `HookedInput`): Ghidra `analyzeHeadless` com `provider_id: "ghidra"` (já instalado)
5. Substituir os stub do `port/UnityProject/Assets/Scripts/` com o código recuperado (marcado `[DECOMPILADO]`/`[INFERIDO]`/`PENDENTE`)
6. Compilar no Unity Editor 2021.3.36f1 (já instalado) para gerar `port/Build/`
