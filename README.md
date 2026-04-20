# 🌀 Labirinto 3D - Unity Project

![Unity](https://img.shields.io/badge/Unity-2022.3%2B-black?style=for-the-badge&logo=unity)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Finalizado-success?style=for-the-badge)

Este repositório contém o código-fonte e os ativos de um jogo de labirinto desenvolvido na **Unity**. O projeto foca em mecânicas de física, sistemas de progressão por chaves e uma interface de usuário altamente dinâmica utilizando **TextMeshPro**.

## 🚀 Principais Funcionalidades

### 🎮 Gameplay e Mecânicas
* **Controle de Personagem:** Movimentação de esfera (`BallMovement.cs`, `MoveBall.cs`) com física avançada, suporte a pulo e integração com o **New Input System**.
* **Sistema de Inventário:** Lógica de coleta de itens (`Key.cs`, `PlayerKeys.cs`) e desbloqueio de passagens condicionais (`Door.cs`).
* **Gestão de Estado:** Sistema de checkpoint e respawn automático baseado em altura e gatilhos de mudança de andar, gerenciados via `GameManager.cs`.
* **VFX:** Scripts customizados para animação de shaders e efeito de dissolução de objetos (`Dissolver.cs`).

### 🖥️ UI/UX & TextMeshPro
* **Efeitos de Vértices:** Implementação de *Jitter*, *Zoom*, *Shake* e animação de cores via script.
* **Sistemas de Feedback:** Simulador de digitação de console e controlador de chat funcional.
* **Ferramentas de Debug:** Contador de FPS e analisadores de performance de texto integrados.

## 🛠️ Tecnologias Utilizadas
* **Engine:** Unity 2022.3 (LTS)
* **Linguagem:** C# (Programação Orientada a Objetos e Corotinas)
* **Renderização:** TextMeshPro & URP (Universal Render Pipeline)

## 📂 Como Utilizar este Repositório

### Para consulta de código:
Os scripts principais estão organizados na pasta `/Scripts` para visualização rápida da lógica de programação.

### Para importar o projeto completo na Unity:
Devido ao tamanho dos assets, o pacote completo está disponível na seção de **Releases**:

1.  Acesse a aba [**Releases**](https://github.com/Javier-Agustin/trabalho-final-unity/releases) deste repositório.
2.  Faça o download do arquivo **`versaofinal5.unitypackage`**.
3.  No seu projeto Unity, vá em `Assets > Import Package > Custom Package`.
4.  Selecione o arquivo e importe todos os componentes.

> [!IMPORTANT]
> **Nota sobre Materiais Rosas (Shader Issue):**
> Caso os objetos apareçam rosas após a importação, converta os materiais para o seu Render Pipeline:
> 1. Vá em `Window > Rendering > Render Pipeline Converter`.
> 2. Selecione `Built-in to URP`.
> 3. Clique em `Initialize` e depois em `Convert Assets`.

## 🎬 Demonstração
* https://drive.google.com/file/d/1Uc0vuA8oh00CAhk1lVKla68-CUNNCvG8/view?usp=sharing
