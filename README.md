# Trabalho Avaliativo: Um algoritmo, diferentes linguagens

**Unidade Curricular:** Algoritmos e Programação
**Professor:** Alexandre de Oliveira

## Integrantes

- Rian Oliveira dos Santos — RA: 126221443020
- Wellington Costa Oliveira — RA: 1242022422

## Sobre o projeto

O mesmo algoritmo de geração de confrontos de futebol foi implementado em Java, C# e Rust. Cada programa começa com quatro times, mostra os jogos de ida e volta e de turno único e, em seguida, adiciona o Tombense e recalcula os totais. O projeto original está em [WeellCts/Trabalho-Algoritmos](https://github.com/WeellCts/Trabalho-Algoritmos).

## Estrutura

```text
.
├── java/
│   └── src/App.java
├── csharp/
│   ├── csharp.csproj
│   └── Program.cs
├── rust/
│   ├── Cargo.toml
│   └── src/main.rs
├── .vscode/settings.json
├── .gitignore
├── README.md
└── RELATORIO.md
```

Arquivos gerados na compilação (`java/bin`, `csharp/bin`, `csharp/obj` e `rust/target`) são ignorados pelo Git.

## Pré-requisitos

- JDK 21 ou superior
- .NET SDK 10
- Rust e Cargo (edição 2024)

## Como executar

Execute os comandos na raiz do repositório.

### Java

```bash
mkdir -p java/bin
javac -encoding UTF-8 -d java/bin java/src/App.java
java -cp java/bin App
```

### C#

```bash
dotnet run --project csharp/csharp.csproj
```

### Rust

```bash
cargo run --manifest-path rust/Cargo.toml
```

## Resultados esperados

| Quantidade de times | Ida e volta | Turno único |
|---:|---:|---:|
| 4 | 12 jogos | 6 jogos |
| 5 | 20 jogos | 10 jogos |

O relatório teórico e o registro da dupla estão em [RELATORIO.md](RELATORIO.md).
