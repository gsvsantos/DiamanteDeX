# Diamante De X
Um projeto desenvolvido em C# capaz de gerar um diamante utilizando a letra 'X'.

![](https://i.imgur.com/60WDnss.gif)

## Funcionalidades
- Geração de diamante com o tamanho de acordo com o número digitado pelo usuário.
- Validação de entrada para garantir que seja um número inteiro válido.
- Exibição colorida do diamante e dos textos no console para melhor visualização.

## Organização do Projeto
O projeto está organizado na seguinte forma:

- [`Program.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Program.cs): É o arquivo principal, o primeiro a rodar quando você executa o programa.
- **Entities/**
  - [`Diamond.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Diamond.cs): Contém a lógica que constrói e imprime o diamante.
- **Entities/Utils/**
  - [`Validators.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Utils/Validators.cs): Contém métodos para validar a entrada do usuário.
  - [`ViewColors.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Utils/ViewColors.cs): Define as cores dos textos, resultando em uma interação mais divertida.
  - [`ViewUtils.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Utils/ViewUtils.cs): Lida com a impressão das interações com o usuário.
  - [`ViewWrite.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Utils/ViewWrite.cs): Imprime o cabeçalho e o texto de número escolhido.
  - [`ViewWriteErrors.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Utils/ViewWriteErrors.cs): Contém os métodos para imprimir as mensagens de erros, conforme contexto em [`Validators.cs`](https://github.com/gsvsantos/DiamanteDeX/blob/master/DiamanteDeX/Entities/Utils/Validators.cs).

## Requisitos
- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.
  
## Tecnologias
[![Tecnologias](https://skillicons.dev/icons?i=git,github,visualstudio,cs,dotnet)](https://skillicons.dev)

## Como Utilizar
1. **Clone o Repositório:**
```
git clone https://github.com/gsvsantos/DiamanteDeX.git
```

2. Abra o terminal ou prompt de comando e navegue até a pasta raiz do programa.

3. Utilize o comando abaixo para restaurar as dependências do projeto.
```
dotnet restore
```

4. Compile e execute o arquivo *.exe* do programa.
```
dotnet build --configuration Release
```
```
DiamanteDeX.exe
```

### Opcional
- Executar o projeto compilando em tempo real
```
dotnet run --project DiamanteDeX
```

# Sobre o Projeto

Este projeto foi desenvolvido como parte de um trabalho da [Academia do Programador](https://www.instagram.com/academiadoprogramador/).
