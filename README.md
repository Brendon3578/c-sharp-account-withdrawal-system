# Account Withdrawal System

Este projeto em C# .NET foi desenvolvido para explorar o tratamento de exceções, utilizando blocos `try-catch-finally` em operações de saque em uma conta bancária. O sistema simula um cenário de retiradas de valores de uma conta, verificando limites e saldo disponível, e lançando exceções personalizadas quando ocorrem erros.

## Descrição

O sistema permite ao usuário criar uma conta bancária e realizar múltiplos saques, verificando se o valor do saque excede o limite permitido ou se há saldo suficiente. Quando um erro ocorre durante a tentativa de saque, o sistema lança exceções personalizadas e trata essas exceções de forma adequada, exibindo mensagens de erro ao usuário e mantendo o sistema estável.

## Funcionalidades

- **Criação de Conta**: O sistema permite criar uma conta bancária com número, titular, saldo inicial e limite de saque.
- **Saque com Tratamento de Exceções**: O sistema verifica se o valor do saque é maior que o limite permitido ou maior que o saldo disponível e lança exceções específicas em cada caso.
- **Tratamento de Erros**: O sistema captura exceções personalizadas (`NotEnoughBalanceException` e `WithdrawException`) e exibe mensagens de erro informativas.
- **Bloco `finally`**: Após cada tentativa de saque, o sistema exibe o saldo atual, independentemente de ter ocorrido uma exceção.

## Pilares de POO Utilizados

Este projeto demonstra o uso dos seguintes pilares da Programação Orientada a Objetos:

1. **Herança**: As exceções personalizadas `NotEnoughBalanceException` e `WithdrawException` herdam da classe base `ApplicationException`, especializando o comportamento de exceções para o domínio da aplicação.
1. **Polimorfismo**: O uso de polimorfismo é evidenciado no tratamento de exceções, onde diferentes tipos de exceções são capturadas e tratadas de forma adequada.

## Estrutura do Código

- **Classe `Account`**: Representa uma conta bancária com número, titular, saldo e limite de saque. Contém métodos para depósito e saque, onde o saque pode lançar exceções se houver problemas.
- **Classe `WithdrawException`**: Exceção personalizada que é lançada quando ocorre um erro genérico relacionado a saques, como exceder o limite permitido.
- **Classe `NotEnoughBalanceException`**: Subclasse de `WithdrawException`, lançada quando o saldo da conta é insuficiente para o saque solicitado.

## Exemplo de Uso

O usuário pode criar uma conta bancária e tentar realizar múltiplos saques. Se o valor do saque exceder o limite permitido ou o saldo disponível, uma exceção será lançada, tratada e uma mensagem de erro será exibida. O sistema garante que, mesmo em caso de erro, o saldo da conta seja exibido corretamente após cada tentativa de saque.

## Tecnologias

- **C#**
- **.NET 8.0**

---

<h3 align="center">
    Feito com ☕ por <a href="https://github.com/Brendon3578"> Brendon Gomes</a>
</h3>
