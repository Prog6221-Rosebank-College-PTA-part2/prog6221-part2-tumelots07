🛡️ Cybersecurity Awareness Chatbot (VB.NET Windows Forms)
👨‍💻 Developer

Student Project — PROG6221 POE Part 3

📌 Project Overview

This project is a Cybersecurity Awareness Chatbot built using VB.NET Windows Forms and MySQL.

It is designed to educate users about cybersecurity while also providing:

Task management
Reminders
Interactive quiz game
Activity tracking
Basic NLP simulation
🚀 Features
💬 Chatbot (NLP Simulation)
Detects user intent using keyword matching
Responds to cybersecurity-related questions
Supports greetings, phishing, passwords, privacy, and more
📋 Task Assistant (MySQL Database)
Add cybersecurity tasks
View all tasks in a grid
Mark tasks as completed
Delete tasks
Stores all data in MySQL database
⏰ Reminder System
Users can set reminders for tasks
Automatic reminder checks on startup
🧠 Cybersecurity Quiz Game
12+ multiple-choice questions
Instant feedback per question
Final score with performance message
📊 Activity Log
Tracks user and system actions
Logs tasks, quiz activity, and chatbot interactions
Displays recent actions for review
🎵 UI Enhancements
Welcome sound plays on startup
ASCII art displayed on launch
🛠️ Technologies Used
VB.NET Windows Forms
MySQL Database
ADO.NET (MySQL Connector)
Basic NLP (string matching simulation)
🧪 How to Run the Project
Open the solution in Visual Studio
Ensure MySQL server is running
Update connection string in DatabaseHelper.vb
Run the application
📂 Database Setup

Create a database:

CREATE DATABASE CybersecurityChatbotDB;

Table:

CREATE TABLE Tasks (
    TaskID INT AUTO_INCREMENT PRIMARY KEY,
    Title VARCHAR(255),
    Description TEXT,
    ReminderDate DATE,
    IsCompleted BOOLEAN
);
🎯 Key Learning Outcomes
Windows Forms GUI development
Database integration with MySQL
Event-driven programming
Basic NLP simulation techniques
Software design and modular programming
📌 Author Notes

This system demonstrates integration of multiple software components into a single educational cybersecurity tool.
