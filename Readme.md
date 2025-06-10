# OOP

Este projeto é um exemplo de aplicação de Programação Orientada a Objetos (POO) em C#. Ele demonstra como estruturar um sistema que utiliza regras de negócio dinâmicas, roteamento de comandos e reflexão para manipulação de objetos em tempo de execução.

## Estrutura do Projeto

- **OOP.sln**: Solução do Visual Studio.
- **OOP/**: Diretório principal do projeto C#.
  - Program.cs: Ponto de entrada da aplicação.
  - `Regra1.cs`, `Regra2.cs`: Implementações das regras de negócio.
  - `Roteador.cs`: Responsável por instanciar dinamicamente as classes de regras.
  - `App.config`: Configuração da aplicação.
  - AssemblyInfo.cs: Informações do assembly.

## Funcionamento

Ao executar o programa, o usuário é solicitado a digitar o nome de uma regra de negócio (`Regra1` ou `Regra2`). O sistema utiliza o `Roteador.GetObject` para criar dinamicamente uma instância da classe correspondente à regra informada. Em seguida, as propriedades do objeto criado são exibidas no console.

O loop principal permite ao usuário acionar diferentes regras até digitar `FECHAR`, encerrando a aplicação.

## Principais Características

- **Reflexão e Tipagem Dinâmica**: O uso de `dynamic` e reflexão permite manipular objetos de diferentes tipos em tempo de execução.
- **Extensibilidade**: Novas regras de negócio podem ser adicionadas facilmente, bastando criar uma nova classe e atualizar o roteador.
- **Interação via Console**: Interface simples para testes e demonstração dos conceitos de POO.

## Exemplo de Uso

```
Digite a regra de negócios que você quer acionar: Regra1 ou Regra2. Para encerrar a aplicação digite 'FECHAR'
> Regra1
// Exibe propriedades e valores da classe Regra1

> Regra2
// Exibe propriedades e valores da classe Regra2

> FECHAR
// Encerra a aplicação
```

## Arquivos Relevantes

- Program.cs: `OOP.Program`
- Roteador.cs: `OOP.Roteador`
- Regra1.cs: `OOP.Regra1`
- Regra2.cs: `OOP.Regra2`

---

Este projeto é ideal para estudos de conceitos básicos e intermediários de orientação a objetos, reflexão e design extensível em C#.