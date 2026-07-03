# Threading Models (.NET)

> Estudo prático dos principais modelos de criação e gerenciamento de threads no .NET, demonstrando diferentes abordagens para execução concorrente, paralelismo e programação assíncrona em C#.

## 📚 Sobre o Projeto

Este repositório reúne exemplos práticos dos principais modelos de concorrência disponíveis na plataforma .NET.

O objetivo é comparar as diferentes abordagens, demonstrando quando utilizar cada uma delas, suas vantagens, limitações e impacto na escrita de aplicações modernas.

O projeto possui caráter educacional e serve como material de estudo para desenvolvedores que desejam compreender melhor o funcionamento de threads, tarefas e programação assíncrona.

---

## 🚀 Tecnologias

- .NET
- C#
- Task Parallel Library (TPL)
- async / await
- Thread
- ThreadPool
- Parallel Library

---

## 📂 Modelos Demonstrados

O projeto aborda exemplos utilizando:

- ✅ Thread
- ✅ ThreadPool
- ✅ Task
- ✅ async / await
- ✅ Parallel.For
- ✅ Parallel.ForEach
- ✅ PLINQ (quando aplicável)
- ✅ CancellationToken
- ✅ Wait / WaitAll / WhenAll
- ✅ ContinueWith
- ✅ Sincronização entre threads

*(A lista pode ser expandida conforme novos exemplos forem adicionados.)*

---

## 🎯 Objetivos

- Entender a diferença entre concorrência e paralelismo
- Aprender quando criar uma Thread manualmente
- Utilizar o ThreadPool corretamente
- Trabalhar com a Task Parallel Library
- Utilizar programação assíncrona moderna
- Comparar desempenho entre diferentes abordagens
- Compreender boas práticas de multithreading

---

## ▶️ Executando o Projeto

Clone o repositório:

```bash
git clone https://github.com/LuizErnica/ThreadingModels.git
```

Entre na pasta:

```bash
cd ThreadingModels
```

Execute:

```bash
dotnet run
```

Ou abra a solução no Visual Studio e execute o projeto desejado.

---

## 📖 Conceitos Abordados

- Processos x Threads
- Thread Scheduling
- Context Switching
- ThreadPool
- Task Scheduler
- CPU-bound x I/O-bound
- Deadlocks
- Race Conditions
- Synchronization
- Locks
- Cancellation
- Async Programming

---

## 📊 Comparação Geral

| Modelo | Recomendado | Cenário |
|---------|-------------|----------|
| Thread | Casos específicos | Controle total da thread |
| ThreadPool | Sim | Tarefas rápidas e repetitivas |
| Task | Sim | Programação moderna |
| async/await | Sim | Operações de I/O |
| Parallel.For | Sim | Processamento paralelo |
| PLINQ | Sim | Consultas paralelas |

---

## 🎓 Público-alvo

Este projeto é indicado para:

- Estudantes de C#
- Desenvolvedores .NET
- Preparação para entrevistas técnicas
- Estudos sobre concorrência
- Aprendizado da Task Parallel Library

---

## 📁 Estrutura

```text
ThreadingModels
│
├── Thread/
├── ThreadPool/
├── Task/
├── AsyncAwait/
├── Parallel/
├── PLINQ/
└── README.md
```

*(A estrutura pode variar conforme a evolução do projeto.)*

---

## 💡 Aprendizados

Durante os exemplos é possível observar:

- Diferenças entre execução síncrona e assíncrona
- Utilização eficiente dos recursos da CPU
- Ganhos de desempenho em operações paralelas
- Custos da criação manual de threads
- Benefícios da Task Parallel Library

---

## 📚 Referências

- Microsoft Learn — Task Parallel Library
- Microsoft Learn — async / await
- C# Documentation
- .NET Documentation

---

## 👨‍💻 Autor

**Luiz Henrique Érnica**

GitHub: https://github.com/LuizErnica

---

## 📄 Licença

Este projeto foi desenvolvido para fins de estudo e aprendizado.
