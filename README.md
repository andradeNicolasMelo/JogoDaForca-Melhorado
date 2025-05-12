# 🎮 Jogo da Forca em C#

Este é um jogo da forca simples e interativo desenvolvido em **C#**. O jogador escolhe uma categoria e deve adivinhar a palavra secreta letra por letra. A cada erro, uma parte do boneco da forca aparece. O jogador tem até **5 tentativas** antes do jogo terminar.

## 📚 Categorias disponíveis

O jogo oferece **3 categorias de palavras** para o usuário escolher:

- 🐾 **Animais**
- 🍎 **Frutas**
- 🌍 **Países**

## 🧠 Como funciona

- O jogador escolhe uma categoria no início do jogo.
- Uma palavra aleatória da categoria escolhida é selecionada.
- O jogador tem **5 tentativas** para errar.
- A cada erro, uma parte do boneco da forca é desenhada.
- O jogo usa **arrays** para:
  - Armazenar letras já digitadas.
  - Mostrar letras corretas na palavra.

## 🚫 Regras

- Não é permitido repetir letras já usadas.
- Se o jogador digitar uma letra repetida, o jogo avisa e pede outra letra.
- O jogo termina quando:
  - A palavra é adivinhada corretamente.
  - O número de erros chega a 5.
