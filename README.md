# Sistema de Hospedagem

Desafio do curso .NET Explorando da [DIO](https://www.dio.me/), com o objetivo de praticar conceitos de Programação Orientada a Objetos (POO) utilizando C# e .NET.

## Sobre o projeto

Neste projeto, foi desenvolvido um sistema básico de hospedagem em um hotel, contendo:

- Classe `Pessoa`: representa os hóspedes.
- Classe `Suíte`: define o tipo, capacidade e valor da diária.
- Classe `Reserva`: faz a ligação entre suíte e hóspedes, além de calcular o valor total da hospedagem.

O sistema realiza:

- Cadastro de hóspedes  
- Cadastro da suíte  
- Cálculo do valor total da hospedagem  
- Aplicação de desconto de 10% para reservas superiores a 10 dias  

## Estrutura do Projeto

```bash
SistemaHospedagem/
├── Pessoa.cs
├── Suite.cs
├── Reserva.cs
└── Program.cs
Tecnologias Utilizadas
C#

.NET 9

Visual Studio Code

Git e GitHub

Como executar
dotnet run

Aprendizados
Neste desafio, aprofundei meu entendimento em:

Criação e uso de classes e objetos

Encapsulamento e propriedades

Listas e estrutura de dados

Boas práticas com namespace e organização do projeto
