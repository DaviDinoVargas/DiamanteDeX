# 💎 **Diamante de Caracteres**  

## 📌 **Introdução**  

O **DiamanteDeX** é uma aplicação **ConsoleApp** **C#** que exibe um diamante formado pelo caractere `'X'` na saída do console. O usuário insere um número ímpar que define a altura e largura do diamante, realizando sua simétrica com base nesse valor e assim formando um belo Diamante.  

## 🚀 **Funcionalidades**  

✅ **Entrada do Usuário:**  
- O usuário insere um número **ímpar** para definir a altura e largura do diamante.  
- O programa valida a entrada, garantindo que seja um número válido e dentro do limite estabelecido para que não ocorra **bugs ou travamento**.  

✅ **Construção do Diamante:**  
- O diamante é gerado em duas partes:  
  - **Metade Superior:** A partir de uma única linha, o programa expande a estrutura do diamante.  
  - **Metade Inferior:** Após atingir o ponto central, a estrutura se contrai de volta ao formato original.  

✅ **Validação de Entrada:**  
- O programa impede a inserção de números **pares** ou **inválidos** *(caracteres vazios, letras e símbolos)* exibe uma mensagem de erro caso a entrada não seja aceita.  
- O valor máximo permitido é **99** para evitar que a saída fique desformatada no console ou ocorra algum problema.  

✅ **Espaçamento Automático:**  
- O diamante é centralizado corretamente utilizando espaços antes dos caracteres `'X'` para formar o Diamante.  

✅ **Opção de Repetição:**  
- Após a exibição do diamante, o usuário pode optar por gerar outro ou encerrar o programa.  

## 🎮 **Como Funciona?**  

1️⃣ O programa exibe um menu solicitando um número ímpar.  
2️⃣ O usuário insere um valor válido.  
3️⃣ O programa gera e exibe o diamante correspondente.  
4️⃣ Após a exibição, o usuário pode decidir continuar ou sair.  

## 💻 Exemplo de Execução:  

![](https://i.imgur.com/2KnKJcZ.gif)

## 🛠 Como utilizar:
🚀 Passo a Passo

1. Clone o repositório ou baixe o código fonte.
2. Abra o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as dependências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução o comando:
```
dotnet build --configuration Release
```
5. Para executar o projeto compilando em tempo real
```
dotnet run --project DiamanteDeX
```
6. Para executar o arquivo compilado, navegue até a pasta: ./DiamanteDeX/bin/Release/net8.0/ e execute o arquivo:
```
DiamanteDeX.exe
```
## ✅ Requisitos
.NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
