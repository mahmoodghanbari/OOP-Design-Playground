# OOP Design Playground

A clean, extensible object-oriented architecture showcasing real-world design techniques.

---

## 🚀 Overview

**OOP Design Playground** is a practical object-oriented laboratory built in **C#**.

It demonstrates clean architecture principles using:

- **Abstraction**
- **Interfaces**
- **Polymorphism**
- **Dependency Injection**
- **Separation of Concerns**
- **Extensible modular design**

This project simulates a real-world mini system including:

- **Payment processors** (ZarinPal, SEP — extensible)
- **Notification services** (Email, SMS)
- **Logging service**
- **Checkout workflow**

The goal is to show how even a small project can be written with enterprise-level design quality.

---

## 🧱 Architecture Breakdown

### ✔ Core Principles Used

- **Abstraction** – Base classes defining behavioral contracts  
- **Interfaces** – Decoupled components with swappable implementations  
- **Polymorphism** – Runtime switching of payment gateways & notifiers  
- **Dependency Injection** – Services injected cleanly via constructor  
- **Separation of Concerns** – Payment, notification, logging isolated  
- **Extensibility** – Add new services (e.g., Telegram, Stripe) without changing core logic  

---

## 🛠 How to Run

```bash
dotnet run --project ./src/OOPPlayground/OOPPlayground
```

---

## 📄 License

MIT — free to use, modify, learn from, or integrate into your own projects

