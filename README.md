# DIO - Trilha .NET - Desenvolvimento Guiado por Testes com C#
www.dio.me

## Desafio de projeto
Para este desafio, foi necessário criar uma aplicação usando a técnica TDD (Test Driven Development, ou Desenvolvimento Guiado por Testes).

## Premissas
Foi criada uma biblioteca de Calculadora, com quatro operações: somar, subtrair, multiplicar e dividir, além de ser possível recuperar o histórico das últimas três operações.

As regras de negócio são as seguintes:
- Tanto os parâmetros quanto os retornos devem apenas ser números inteiros
- Cada uma operação, com exceção do histórico, recebe dois parâmetros
- O histórico sempre retorna as últimas 3 operações (se existirem)

## Solução
Os testes foram feitos utilizando o framework xUnit. Buscou-se manter as boas práticas, tanto em relação ao projeto .NET quanto ao GIT.
