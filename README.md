# 🛡️ Cybersecurity Awareness Chatbot (Part 3)

## PROG6221 Portfolio of Evidence

**Student:** Tumelo Mohuba  
**Module:** PROG6221 – Programming 2A 
**Institution:** Rosebank International (The IIE)  
**Language:** VB.NET Windows Forms  
**Database:** MySQL

---

# 📖 Project Overview

The Cybersecurity Awareness Chatbot is a Windows Forms desktop application developed using VB.NET. The purpose of the application is to educate users about cybersecurity while providing intelligent task management and reminder functionality.

The chatbot allows users to ask cybersecurity-related questions, receive educational advice, manage cybersecurity tasks, complete quizzes, and interact naturally through simple Natural Language Processing (NLP).

This project extends the previous versions by introducing conversation memory, sentiment analysis, improved intent recognition, smart task creation, and context-aware responses.

---

# ✨ Features

## Cybersecurity Awareness

- Password security advice
- Phishing awareness
- Privacy protection tips
- Two-Factor Authentication (2FA) guidance

---

## Task Management

- Add cybersecurity tasks
- Delete tasks
- Mark tasks as completed
- View all tasks
- Store tasks permanently in MySQL

---

## Smart Reminder System

The chatbot automatically recognises reminder phrases such as:

- Tomorrow
- Next week
- Next month
- In 3 days
- In 7 days

Example:

```
Remind me tomorrow to update my password.
```

The chatbot automatically creates and stores the task.

---

## Conversation Memory

The chatbot remembers:

- User's name
- Favourite cybersecurity topic

Example:

```
User:
I like phishing.

Later...

User:
What do you remember about me?

Bot:
I remember that you're interested in phishing.
```

---

## Context Awareness

The chatbot remembers the current discussion.

Example:

```
User:
Tell me about passwords.

User:
Tell me more.
```

The chatbot continues discussing passwords instead of changing topics.

---

## Sentiment Analysis

The chatbot recognises simple emotional states including:

- Positive
- Negative
- Confused

It adapts its responses accordingly.

---

## Cybersecurity Quiz

A built-in quiz allows users to test their cybersecurity knowledge.

---

## Activity Log

Every important interaction is recorded, including:

- User questions
- Tasks created
- Quiz activity
- Reminder notifications
- Chatbot responses

---

## Welcome Experience

When the application starts it:

- Plays a welcome sound
- Displays ASCII Art
- Greets the user
- Requests the user's name

---

# 💻 Technologies Used

- VB.NET (.NET Framework)
- Windows Forms
- MySQL
- MySQL Connector/NET
- Visual Studio 2022
- Git
- GitHub

---

# 📂 Project Structure

```
CybersecurityChatbotPart3
│
├── Form1.vb
├── Form1.Designer.vb
├── DatabaseHelper.vb
├── ActivityLog.vb
├── QuizForm.vb
├── Resources
│   ├── ASCIIArt.txt
│   └── Welcome.wav
├── App.config
```

---

# 🗄️ Database

Database Name

```
CybersecurityChatbotDB
```

Tasks Table

| Column | Description |
|----------|-------------|
| TaskID | Primary Key |
| Title | Task title |
| Description | Task description |
| ReminderDate | Reminder date |
| IsCompleted | Completion status |

---

# ▶️ How to Run

## Requirements

- Visual Studio 2022
- .NET Framework
- MySQL Server
- MySQL Connector/NET

---

## Steps

1. Clone the repository.

```
git clone https://github.com/Prog6221-Rosebank-College-PTA-part2/prog6221-part2-tumelots07.git
```

2. Open the solution in Visual Studio.

3. Restore NuGet packages.

4. Create the MySQL database.

5. Update the connection string inside:

```
DatabaseHelper.vb
```

and

```
Form1.vb
```

if necessary.

6. Run the application.

---

# 🎥 Demonstration Video

YouTube (Unlisted)

```(https://youtu.be/V4xbcwgZLVE)
```

---

# 📌 Future Improvements

- Voice recognition
- AI-powered responses
- Email notifications
- User accounts
- Cloud database integration
- Mobile application

---

# 📚 References

Microsoft. (2025). *VB.NET Documentation*. https://learn.microsoft.com/

Oracle. (2025). *MySQL Documentation*. https://dev.mysql.com/doc/

The IIE. (2025). *PROG6221 Learning Material*. https://mystudies.iie.edu.za/

OpenAI. (2026). *ChatGPT (GPT-5.5)*. https://chatgpt.com/

---

# 👨‍💻 Author

**Tshiamo Tumelo Simango**

PROG6221 Portfolio of Evidence

Cybersecurity Awareness Chatbot Part 3

2026
