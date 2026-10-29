# Plano 01 — Fase 0: Auditoria e identificação

**Objetivo:** mapear ambiente e o build original; registrar evidência em notes/.

**Já sei (evidência coletada, 2026-10-29):**
- Build Windows x64 **IL2CPP**: `FantasyMapSimulator.exe`, `GameAssembly.dll` (53 MB),
  `UnityPlayer.dll`, `FantasyMapSimulator_Data/il2cpp_data/Metadata/global-metadata.dat`
- Versão Unity: **2021.3.36f1** (string no cabeçalho de `globalgamemanagers`)
- app.info: "The Stranger Studio" / "FantasyMapSimulator"; 1 cena (`level0`, 6.3 MB)
- boot.config: gfx-jobs habilitados, single-instance
- Third party (ScriptingAssemblies.json, RuntimeInitializeOnLoads.json): puerts+ts-loader,
  ByteDance.LiveOpenSdk (12 dlls), MPUIKit, Shapes(+Samples), LeTai.TrueShadow(+Demo),
  DOTween, Steamworks.NET(+Goldberg em steam_settings), Crosstales.FileBrowser,
  I2 Localization (+TMP targets), NuGet: Newtonsoft, Serilog(+3 sinks), NodaTime,
  Refit(+2), Google.Protobuf, System.Reactive, System.Text.Json/Http/Channels/Unsafe,
  Bcl.AsyncInterfaces, PriorityQueue, LiveWallpaperCore(ns), SteamManager(ns)
- StreamingAssets: 65 arquivos JSON/CSV de dados de simulação (cristandade/religião,
  culturas, buffs, traits, militares) + JS/relatives-tree.bundle.js
- SRP: nenhum byte de URP/HDRP em globalgamemanagers ⇒ **Built-in provável**
- Plugins/x86_64: DyCloudSDK, libnode, lib_burst_generated, metasecml, parfait,
  PcMsgChan, ProcessMainModuleName, puerts, sscronet, steam_api64

**Passos:**
1. [x] Auditar RAM/swap/disco/JDK/dotnet/git
2. [x] Ler metadados do build (globalgamemanagers, app.info, boot.config, jsons)
3. [x] Inventariar assemblies e plugins
4. [ ] Escrever notes/identificacao.md
5. [ ] git init + commit base

**Riscos:** versão exata 2D/3D e RP ainda "provável" — AssetRipper na Fase 2 confirma.
**Instalações:** nenhuma nesta fase (só leitura).
**Como sei que terminou:** identificacao.md preenchido + commit + fases marcadas no PROGRESS.
