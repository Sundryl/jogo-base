# Plano 02 — Instalação de ferramentas de análise em ~/tools

**Objetivo:** ter Ghidra, AssetRipper, Cpp2IL e Il2CppDumper funcionais, versão testada
para Unity 2021.3.36f1 IL2CPP (evidência: notes/ferramentas-referencia.md).

**Passos:**
1. `mkdir -p ~/tools && cd ~/tools`
2. Baixar em paralelo (só Linux x64):
   - Ghidra 12.2: `ghidra_12.2_PUBLIC_20261016.zip` (~450 MB) —https://github.com/NationalSecurityAgency/ghidra/releases/download/Ghidra_12.2_build/ghidra_12.2_PUBLIC_20261016.zip
   - AssetRipper 2.0.0: `AssetRipper_linux_x64.tar.xz` — https://github.com/AssetRipper/AssetRipper/releases/download/2.0.0/AssetRipper_linux_x64.tar.xz
   - Cpp2IL 2022.1.0-pre-release.21: `Cpp2IL-2022.1.0-pre-release.21-Linux` (binário único)
   - Il2CppDumper v6.7.46: `Il2CppDumper-net6-v6.7.46.zip` (fallback; rode com DOTNET_ROLL_FORWARD=LatestMajor)
3. Extrair cada um para subpasta própria; `chmod +x` nos binários.
4. Verificação: `./analyzeHeadless --help` (ghidra), binário AssetRipper `--help`,
   Cpp2IL `--help`, Il2CppDumper com roll-forward.
5. Registrar caminhos em PROGRESS.md; commit.

**Riscos:** tamanho do download Ghidra (450 MB) — se falhar, tentar release 11.4.2.
Ghidra 12.2 + JDK 25 não testado — se o JVM recusar, trocar para JDK 21 (Temurin, user-scoped em ~/tools/jdk21).
Cpp2IL pre-release pode gerar dummy DLLs imperfeitas — plano B Il2CppDumper já instalado.

**O que vou executar:** downloads públicos do GitHub no usuário corrente; nada de sudo.
**Como sei que terminou:** 4 ferramentas respondem --help/rodam e estão registradas.
