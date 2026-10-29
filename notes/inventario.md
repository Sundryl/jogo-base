# Inventário de port/UnityProject (Fase 2, AssetRipper 2.0.0 — 2026-10-29)

Fonte: export UnityProject do build IL2CPP original. Estrutura real de projeto Unity
(`Assets/`, `Packages/`, `ProjectSettings/`) + `port/UnityProjectAux` (GameAssemblies dummy
usadas pelo ripper + path_id_map.json). Backup do export parcial: `work/export_parcial_001` (160MB).

## Estado do projeto
- ProjectVersion.txt = **2021.3.36f1** (idêntica ao original; bate com globalgamemanagers)
- GraphicsSettings: `m_CustomRenderPipeline: {fileID: 0}` ⇒ **Built-in Rasterizer CONFIRMADO**
  (hipótese da Fase 0 confirmada; game provavelmente não usa URP/HDRP)
- EditorBuildSettings: 1 cena configurada (level0)
- Export 692MB / ~3968 arquivos em port/UnityProject

## Assets exportados (pastas em Assets/)
AnimationClip, AnimatorController, AudioClip, Font, GameObject (prefabs), Material,
MonoBehaviour (ScriptableObjects/assets), Plugins, RenderTexture, Resources, Scripts,
Shader, Sprite, StreamingAssets, TextAsset

## Scripts (Fase 3KFase pendente)
- 941 .cs em Assets/Scripts/ (layout por namespace, ex. Assembly-CSharp/Michsky/MUIP/...)
- **Corpos são stub decompilados de dummy DLLs**: estrutura/assinaturas/atributos reais;
  métodos `return null;`/`return false;` (ex.: ButtonManager.cs 619 linhas, 0 threw null)
- Lógica real virá de: work/cpp2il (dll_il_recovery → ilspycmd) + Ghidra GameAssembly
  + REA método-a-método para os importantes (Update/Awake/AiTick etc.)
- Marcas obrigatórias por regra: `[DECOMPILADO addr=0x..]`, `[INFERIDO]`, `// PENDENTE`

## Terceiros com código stub no projeto (mirá-los na Fase 4)
Michsky.MUIP (MPUIKit), shapes, LeTai.TrueShadow, DOTween, Crosstales.FileBrowser,
I2.Loc, puerts core/ts-loader, ByteDance.Live*, Steamworks.NET,
NuGet libs (Newtonsoft etc.) → Hypotese: SUBSTITUIR por assemblies reais / NuGet no
manifest/packages na Fase 4 (não decompilar o que já existe open-source completo)

## PENDENTE / quebrado a resolver na Fase 4
- Referências a Shapes/TrueShadow (assets pagos — verificar funcionalmente)
- Plugin nativo x86_64 Windows (DyCloudSDK etc.) — não roda em Linux; checar códigos de uso
- Steamworks.NET vs Goldberg — original usa api fake; nova build: Steamworks real ou stub
-重生 Verificar compilação no Unity Editor 2021.3.36f1 (Fase 4)
