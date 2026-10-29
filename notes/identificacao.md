# Identificação do build original (evidência, 2026-10-29)

Fonte: `game_original/` (somente leitura). Todas as afirmações abaixo têm evidência citada.

## a) Backend de scripts
**IL2CPP** — evidência: `GameAssembly.dll` (53 MB), `il2cpp_data/Metadata/global-metadata.dat`,
ausência de `Managed/*.dll` em `_Data` (assemblies listados em ScriptingAssemblies.json mas
não presentes no disco).

## b) Versão exata Unity
**2021.3.36f1** — evidência: string no cabeçalho de `globalgamemanagers` (offset <64B, `head -c 64 | strings`).

## c) 2D/3D e pipeline de render
- Pipeline: nenhum byte de `UniversalRenderPipeline`/`HDRenderPipeline`/`LightweightRenderPipeline`
  ou `UnityEngine.CoreModule` em `globalgamemanagers` (grep -ac = 0) ⇒ **Built-in Rasterizer provável**
  (confirmação final na Fase 2 com AssetRipper).
- 2D/3D: **PENDENTE** — módulos Physics2D + SpriteShape + SpriteMask presentes na lista de
  assemblies; Shapes/TrueShadow/TMP sugere UI 2D-ish; level0 6,3 MB. Confirmar na Fase 2
  (inspeção de GameObjects em level0 compartilha qual componente-física).
- Graphics API Windows típico: D3D11 (Unity 2021 default). boot.config: `gfx-enable-gfx-jobs=1`.

## d) Plataforma do build original
**Windows x64** — evidência: `FantasyMapSimulator.exe`, `UnityPlayer.dll`, `Plugins/x86_64/*.dll`.

## e) Terceiros / pacotes (fontes: ScriptingAssemblies.json 121 itens; RuntimeInitializeOnLoads.json; Plugins/)
- **Jogo:** Assembly-CSharp (+firstpass), SteamManager, LiveWallpaperCore(ns), MPUIKit
- **Engines de script:** com.tencent.puerts core+ts-loader (+libnode.dll, puerts.dll)
- **SDK Live (ByteDance):** 12 dlls ByteDance.LiveOpenSdk*/ByteCloudGameSdk/DyCloudSDK/sscronet
- **UI/visual:** Shapes (runtime+samples), LeTai.TrueShadow (+Demo), TextMeshPro (via I2)
- **Animação:** DOTween
- **Plataforma:** Steamworks.NET com.rlabrecque.steamworks.net + steam_api64.dll
  (contém `steam_settings/` ⇒ **Goldberg Steam Emulator**, não Steam oficial)
- **Localização:** I2 Localization (AutoRegister em TMP_UGUI/Audio)
- **NuGet (restauráveis via code real):** Newtonsoft.Json, Google.Protobuf, Serilog(+File/Async/Map),
  NodaTime, Refit(+Newtonsoft), System.Reactive, System.Text.Json/Encodings/Http.Json/Channels,
  Bcl.AsyncInterfaces, System.Runtime.CompilerServices.Unsafe, Microsoft.Bcl.AsyncInterfaces,
  System.Diagnostics.DiagnosticSource, PriorityQueue
- **Nativos:** DyCloudSDK, libnode, lib_burst_generated (Burst), metasecml, parfait,
  PcMsgChan, ProcessMainModuleName, puerts, sscronet, steam_api64

## Outros
- StreamingAssets: 65 arquivos JSON/CSV — dados de simulação (BiomeResource, BuffDef,
  Culturas x5 com CSVs de nomes, Military, Religion, Traits, BasicMap) + JS/relatives-tree.bundle.js
-__Informação edita-e-continua__ não aplicável. Documento vivo na Fase 2.
