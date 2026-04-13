# 🔒 Cybersecurity Awareness Chatbot — Part 1

> **Module:** PROG6221 — Programming 2A  
> **Assessment:** Portfolio of Evidence (POE) — Part 1  
> **Institution:** The Independent Institute of Education (IIE)

---

## 📋 Project Overview

A C# console application that acts as a **Cybersecurity Awareness Assistant** for South African citizens. The chatbot provides interactive, educational responses on topics such as phishing, password safety, malware, online scams, and more.

---

## ✨ Features

| Feature | Description |
|---|---|
| 🔊 Voice Greeting | Plays a recorded WAV greeting when the app launches |
| 🎨 ASCII Art Logo | Displays a cybersecurity-themed ASCII art header |
| 👤 Personalised Interaction | Asks for the user's name and personalises all responses |
| 💬 Response System | Responds to cybersecurity topics and general queries |
| ✅ Input Validation | Handles empty inputs and unrecognised queries gracefully |
| 🎨 Enhanced Console UI | Colour-coded text, borders, typing effect, section dividers |
| 🏗️ Clean Code Structure | Separated into classes: `Program`, `ConsoleUI`, `ChatBot`, `AudioPlayer` |

---

## 🗂️ Project Structure

```
CybersecurityChatbot/
│
├── Program.cs                        ← Entry point
│
├── UI/
│   └── ConsoleUI.cs                  ← All console display, colours, typing effect, main loop
│
├── Chat/
│   └── ChatBot.cs                    ← Response logic, keyword matching, input validation
│
├── Audio/
│   └── AudioPlayer.cs                ← WAV greeting playback via System.Media
│
├── greeting.wav                      ← Recorded voice greeting (WAV format)
│
├── CybersecurityChatbot.csproj       ← Project file (.NET Framework 4.8)
│
├── .github/
│   └── workflows/
│       └── ci.yml                    ← GitHub Actions CI workflow
│
└── README.md                         ← This file
```

---

## 🚀 Setup & Running the Application

### Prerequisites
- **Visual Studio 2022** (Community or higher)
- **.NET Framework 4.8** (included with Visual Studio)
- **Windows OS** (required for `System.Media.SoundPlayer`)

### Steps

1. **Clone the repository**
   ```bash
   git clone https://github.com/YOUR_USERNAME/CybersecurityChatbot.git
   cd CybersecurityChatbot
   ```

2. **Open in Visual Studio**
   - Open `CybersecurityChatbot.sln` or `CybersecurityChatbot.csproj` in Visual Studio.

3. **Add your WAV greeting file**
   - Record a short WAV file (e.g. *"Hello! Welcome to the Cybersecurity Awareness Bot..."*).
   - Name it `greeting.wav` and place it in the root project folder.
   - In Visual Studio, right-click the file → **Properties** → set **Copy to Output Directory** to **Copy if newer**.

4. **Build and Run**
   - Press **F5** or click **Start** in Visual Studio.
   - Alternatively, use the terminal:
     ```bash
     dotnet build
     dotnet run
     ```

---

## 💬 Example Interactions

```
[YourName] › What is phishing?
[CyberBot] › 🎣 How to Spot Phishing Attacks:
              • Be suspicious of urgent emails asking you to 'act now'.
              • Check the sender's email address carefully for slight misspellings.
              ...

[YourName] › Tell me about password safety
[CyberBot] › 🔑 Password Safety Tips:
              • Use at least 12 characters mixing letters, numbers, and symbols.
              ...

[YourName] › exit
[CyberBot] › Goodbye! Stay safe online. 🔒
```

### Supported Topics
- `password` / `password safety`
- `phishing`
- `browsing` / `safe browsing`
- `malware`
- `two-factor` / `2fa`
- `social engineering`
- `privacy`
- `scam` / `scams`
- `how are you`
- `purpose` / `what is your purpose`
- `help` / `what can I ask you about`

---

## ✅ GitHub Actions CI — Successful Build

> **Screenshot of passing CI workflow:**

<img width="1292" height="603" alt="CI Workflow" src="https://github.com/user-attachments/assets/b9fb7d6c-b159-41ed-8510-765802193306" />


## 📝 Commit History (Minimum 6 Commits)

| # | Commit Message |
|---|---|
| 1 | `Initial commit: Set up project structure and namespace folders` |
| 2 | `Added AudioPlayer class with WAV greeting playback and error handling` |
| 3 | `Added ASCII art header and ConsoleUI with colour-coded output` |
| 4 | `Implemented ChatBot response system with keyword dictionary` |
| 5 | `Added input validation, default responses, and typing effect` |
| 6 | `Added GitHub Actions CI workflow and updated README` |

---

## 📚 References

Pieterse, H. 2021. The Cyber Threat Landscape in South Africa: A 10-Year Review. *The African Journal of Information and Communication*, 28(28). Available at: https://www.scielo.org.za/scielo.php?pid=S2077-72132021000200003&script=sci_arttext [Accessed 10 April 2026].
