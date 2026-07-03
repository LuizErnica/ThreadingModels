# Threading Models (.NET)

> A practical study of the main threading models available in .NET, demonstrating different approaches to concurrency, parallelism, and asynchronous programming in C#.

## 📚 About the Project

This repository contains practical examples of the primary concurrency models available in the .NET platform.

Its purpose is to compare different approaches, showing when each one should be used, along with their advantages, limitations, and impact on modern application development.

This project is intended for educational purposes and serves as a learning resource for developers who want to better understand threads, tasks, and asynchronous programming.

---

## 🚀 Technologies

- .NET
- C#
- Task Parallel Library (TPL)
- async / await
- Thread
- ThreadPool
- Parallel Library

---

## 📂 Threading Models Covered

The project includes examples using:

- ✅ Thread
- ✅ ThreadPool
- ✅ Task
- ✅ async / await
- ✅ Parallel.For
- ✅ Parallel.ForEach
- ✅ PLINQ (when applicable)
- ✅ CancellationToken
- ✅ Wait / WaitAll / WhenAll
- ✅ ContinueWith
- ✅ Thread synchronization

*(The list may expand as new examples are added.)*

---

## 🎯 Objectives

- Understand the difference between concurrency and parallelism
- Learn when to create a Thread manually
- Use the ThreadPool correctly
- Work with the Task Parallel Library
- Apply modern asynchronous programming
- Compare the performance of different approaches
- Understand multithreading best practices

---

## ▶️ Running the Project

Clone the repository:

```bash
git clone https://github.com/LuizErnica/ThreadingModels.git
```

Navigate to the project folder:

```bash
cd ThreadingModels
```

Run the application:

```bash
dotnet run
```

Or open the solution in Visual Studio and run the desired project.

---

## 📖 Concepts Covered

- Processes vs. Threads
- Thread Scheduling
- Context Switching
- ThreadPool
- Task Scheduler
- CPU-bound vs. I/O-bound operations
- Deadlocks
- Race Conditions
- Synchronization
- Locks
- Cancellation
- Asynchronous Programming

---

## 📊 General Comparison

| Model | Recommended | Typical Scenario |
|---------|-------------|------------------|
| Thread | Specific cases | Full control over thread execution |
| ThreadPool | Yes | Short-lived, repetitive tasks |
| Task | Yes | Modern concurrent programming |
| async/await | Yes | I/O-bound operations |
| Parallel.For | Yes | CPU-intensive parallel processing |
| PLINQ | Yes | Parallel LINQ queries |

---

## 🎓 Target Audience

This project is intended for:

- C# students
- .NET developers
- Technical interview preparation
- Concurrency and multithreading studies
- Learning the Task Parallel Library

---

## 📁 Project Structure

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

*(The structure may change as the project evolves.)*

---

## 💡 Learning Outcomes

Through these examples, you will learn:

- The differences between synchronous and asynchronous execution
- Efficient CPU resource utilization
- Performance gains from parallel processing
- The overhead of manually creating threads
- The benefits of the Task Parallel Library

---

## 📚 References

- Microsoft Learn — Task Parallel Library
- Microsoft Learn — async / await
- C# Documentation
- .NET Documentation

---

## 👨‍💻 Author

**Luiz Henrique Érnica**

GitHub: https://github.com/LuizErnica

---

## 📄 License

This project was created for educational and learning purposes.
