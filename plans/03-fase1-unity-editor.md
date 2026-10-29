# Plano 03 — Fase 1: Instalar Unity Editor 2021.3.36f1

**Objetivo:** Editor 2021.3.36f1 (versão EXATA do build original) + módulo linux-il2cpp.

**Já sei:**
- Licença Unity Personal atribuída (evidência: `unity license`, 2026-10-29 — sem bloqueio de login)
- Comando suportado: `unity install <version> --module <id> --accept-eula --non-interactive -y`
- Editor errado (6000.6.7f1) já instalado, será mantido (não atrapalha)

**Passos:**
1. `unity install 2021.3.36f1 -m linux-il2cpp --accept-eula --non-interactive -y` (background)
2. Validar: `unity editors` mostra 2021.3.36f1 com módulo linux-il2cpp
3. Falha → `--resume`; 3 falhas → registrar bloqueio em PROGRESS.md e parar

**Riscos:** download ~4-5 GB e disco 84 GB ok; janela de download longa.
**Execução:** download público da Unity via CLI oficial, escopo usuário.
**Como sei que terminou:** `unity editors | grep 2021.3.36f1` e PROGRESS atualizado.
