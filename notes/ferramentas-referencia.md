# Ferramentas de referência (pesquisa GitHub 2026-10-29)

Status dos 10 repos sugeridos — todos existem e ativos, exceto game-hacking (última atualização 2024, ok).

## Direto no nosso pipeline (usar)
| Projeto                                  | Versão escolhida            | Papel aqui                                                                 |
|------------------------------------------|-----------------------------|----------------------------------------------------------------------------|
| NationalSecurityAgency/ghidra (95.5k★)   | **12.2** (out/2026)         | Decompilar métodos de `GameAssembly.dll` (headless + via REA)               |
| SamboyCoding/Cpp2IL (3k★)                | **2022.1.0-pre-release.21** (Linux bin, Fev/2026) | Dummy DLLs + script.json do IL2CPP (primário)          |
| Perfare/Il2CppDumper (9.5k★)             | v6.7.46 **net6** (ativação: `DOTNET_ROLL_FORWARD=LatestMajor` no dotnet 10) | Dummy DLLs (fallback se Cpp2IL falhar) |
| AssetRipper/AssetRipper (8.7k★)          | **2.0.0** (ago/2026, tar.xz linux x64) | Extrair cenas/prefabs/assets → `port/UnityProject/`                    |
| morluto/rea (REA 6.8.0)                  | já rodando como MCP         | `inspect_il2cpp_metadata` target-free (fase 3), pseudocódigo Ghidra, JSON views |

## Contexto/auxiliares (não instalar agora)
| Projeto                        | Relevância |
|--------------------------------|------------|
| frida/frida 17.24.3            | Runtime dinâmico — nosso caminho é estático; REA tem sessões Frida BYO se um dia precisar rodar o player Windows via Wine |
| radareorg/radare2 6.2.4        | CLI de PE rápido; REA/Ghidra cobrem o caso |
| songshikang0111/awesome-REA-cases (360★, ativo) | Casos REA — consultar padrão IL2CPP antes de Fase 3 |
| SubmitGame/awesome-decomp-games (2.6k★) | Como projetos grandes de decompile se organizam — visitar na Fase 3/4 |
| dsasmblr/game-hacking (5.6k★)  | Técnicas gerais de game RE; consulta |

## Notas de compatibilidade (Unity 2021.3.36f1, IL2CPP, Windows x64)
- AssetRipper: suporta IL2CPP "native side"? Il2cpp está embutido; AssetRipper lança erro em games IL2CPP que usam Direct3D12+; nosso build é WindowsD3D11 tipicamente. AssetRipper precisa dos dummy DLLs (Cpp2IL/Il2CppDumper) PARA SCRIPTS; assets ele extrai independente.
- Cpp2IL pre-release.21: gera dummy dlls `.NETStandard2.1`-compat com 2021.3 → Unity pode redeclarar classes recriadas por AssetRipper; conferir opções `--output-assemblies-srgs`/`--use-processor` no `--help`.
- AssetRipper 2.0 CLI: verificar nome do executável no tar (possível `AssetRipper.GUI.Free` + flag web; alternativa CLI: `AssetRipper.Tools...`). Confirmar `--help` na instalação.
- Ghidra 12.2 com JDK Temurin 25 instalado (Ghidra 12 pede JDK 21+; 25 ok, testar `analyzeHeadless --help`).
