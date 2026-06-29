using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace CybersecurityChatbotPart2
{
    public partial class frmChatbot : Form
    {
        private string userName = "";
        private string favouriteTopic = "";
        private string currentTopic = "";

        private readonly Random random = new Random();

        // Delegate
        private delegate string ChatResponseDelegate(string userInput);
        private readonly ChatResponseDelegate responseProcessor;

        // Keyword Responses
        private readonly Dictionary<string, List<string>> keywordResponses;

        // Sentiment Responses
        private readonly Dictionary<string, string> sentimentResponses;

        public frmChatbot()
        {
            InitializeComponent();

            keywordResponses = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
            {
                {
                    "password",
                    new List<string>
                    {
                        "Use strong and unique passwords for every account.",
                        "A strong password should contain uppercase letters, lowercase letters, numbers, and symbols.",
                        "Never share your passwords with anyone online."
                    }
                },

                {
                    "phishing",
                    new List<string>
                    {
                        "Be careful of emails asking for personal information.",
                        "Always check suspicious links before clicking them.",
                        "Phishing scams often pretend to be banks or trusted companies."
                    }
                },

                {
                    "privacy",
                    new List<string>
                    {
                        "Review your social media privacy settings regularly.",
                        "Avoid posting sensitive personal information online.",
                        "Enable two-factor authentication to improve privacy."
                    }
                },

                {
                    "scam",
                    new List<string>
                    {
                        "If something sounds too good to be true, it probably is.",
                        "Never share banking details with unknown people.",
                        "Always verify suspicious messages before responding."
                    }
                },

                {
                    "safe browsing",
                    new List<string>
                    {
                        "Only visit websites that use HTTPS.",
                        "Avoid downloading files from unknown websites.",
                        "Keep your browser and antivirus updated."
                    }
                }
            };

            sentimentResponses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "worried", "It’s understandable to feel worried. Let me help you stay safer online." },
                { "curious", "Curiosity is good. Learning cybersecurity helps protect your information." },
                { "frustrated", "Cybersecurity can feel confusing sometimes, but I’ll help simplify it." },
                { "confused", "No problem, I’ll explain things more clearly." }
            };

            responseProcessor = GenerateResponse;

            SetupForm();
            LoadLogo();
            LoadAsciiArt();
            PlayVoiceGreeting();

            AddBotMessage("Hello! Welcome to the Cybersecurity Awareness Chatbot.");
            AddBotMessage("What is your name?");
        }

        // =========================
        // FORM SETUP
        // =========================
        private void SetupForm()
        {
            this.Text = "Cybersecurity Awareness Chatbot";
            this.StartPosition = FormStartPosition.CenterScreen;

            rtbChat.ReadOnly = true;
            rtbChat.BackColor = Color.Black;
            rtbChat.ForeColor = Color.Lime;
            rtbChat.Font = new Font("Consolas", 10);

            txtUserInput.Font = new Font("Segoe UI", 12);

            // Placeholder
            txtUserInput.Text = "Type your message here...";
            txtUserInput.ForeColor = Color.Gray;

            txtUserInput.Enter += RemovePlaceholder;
            txtUserInput.Leave += SetPlaceholder;

            // Send Button
            btnSend.Text = "Send";
            btnSend.BackColor = Color.Cyan;
            btnSend.ForeColor = Color.Black;
            btnSend.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Clear Button
            btnClear.Text = "Clear Chat";
            btnClear.BackColor = Color.Orange;
            btnClear.ForeColor = Color.Black;
            btnClear.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Exit Button
            btnExit.Text = "Exit";
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = Color.White;
            btnExit.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Events
            btnSend.Click += BtnSend_Click;
            btnClear.Click += BtnClear_Click;
            btnExit.Click += BtnExit_Click;

            txtUserInput.KeyDown += TxtUserInput_KeyDown;
        }

        // =========================
        // LOAD LOGO
        // =========================
        private void LoadLogo()
        {
            try
            {
                string imagePath = Path.Combine(Application.StartupPath, "Resources", "botlogo.jpg");

                if (File.Exists(imagePath))
                {
                    picLogo.Image = Image.FromFile(imagePath);
                }
                else
                {
                    AddBotMessage("Logo file not found.");
                }
            }
            catch (Exception ex)
            {
                AddBotMessage("Error loading logo: " + ex.Message);
            }
        }

        // =========================
        // ASCII ART
        // =========================
        private void LoadAsciiArt()
        {
            try
            {
                if (File.Exists("ASCIIArt.txt"))
                {
                    lblAscii.Text = File.ReadAllText("ASCIIArt.txt");
                }
                else
                {
                    lblAscii.Text = "CYBERSECURITY CHATBOT";
                }

                lblAscii.Font = new Font("Consolas", 7);
                lblAscii.ForeColor = Color.LightGreen;
            }
            catch
            {
                lblAscii.Text = "CYBERSECURITY CHATBOT";
            }
        }

        // =========================
        // VOICE GREETING
        // =========================
        private void PlayVoiceGreeting()
        {
            try
            {
                if (File.Exists("Welcome.wav"))
                {
                    SoundPlayer player = new SoundPlayer("Welcome.wav");
                    player.Play();
                }
                else if (File.Exists(@"Resources\Welcome.wav"))
                {
                    SoundPlayer player = new SoundPlayer(@"Resources\Welcome.wav");
                    player.Play();
                }
            }
            catch
            {
                AddBotMessage("Voice greeting could not be played.");
            }
        }

        // =========================
        // SEND BUTTON
        // =========================
        private void BtnSend_Click(object sender, EventArgs e)
        {
            ProcessUserInput();
        }

        // =========================
        // ENTER KEY
        // =========================
        private void TxtUserInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessUserInput();
                e.SuppressKeyPress = true;
            }
        }

        // =========================
        // PROCESS INPUT
        // =========================
        private void ProcessUserInput()
        {
            string input = txtUserInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(input) ||
                input == "Type your message here...")
            {
                AddBotMessage("Please type something before pressing Send.");
                return;
            }

            AddUserMessage(input);

            txtUserInput.Clear();

            string response = responseProcessor(input);

            AddBotMessage(response);
        }

        // =========================
        // GENERATE RESPONSE
        // =========================
        private string GenerateResponse(string input)
        {
            string lowerInput = input.ToLower();

            // Save Username
            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = input;

                return $"Nice to meet you, {userName}! Ask me about passwords, phishing, scams, privacy, or safe browsing.";
            }

            // Exit
            if (lowerInput == "exit")
            {
                Application.Exit();
            }

            // Sentiment Detection
            string sentimentMessage = DetectSentiment(lowerInput);

            // Basic Questions
            if (lowerInput.Contains("how are you"))
            {
                return $"I’m doing well, {userName}. Ready to help you stay safe online.";
            }

            if (lowerInput.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity awareness.";
            }

            if (lowerInput.Contains("what can i ask"))
            {
                return "You can ask me about password safety, phishing, scams, privacy, and safe browsing.";
            }

            // Memory Feature
            if (lowerInput.Contains("interested in"))
            {
                foreach (string topic in keywordResponses.Keys)
                {
                    if (lowerInput.Contains(topic))
                    {
                        favouriteTopic = topic;
                        currentTopic = topic;

                        return $"Great! I’ll remember that you are interested in {topic}.";
                    }
                }
            }

            // Memory Recall
            if (lowerInput.Contains("what do you remember"))
            {
                if (!string.IsNullOrWhiteSpace(favouriteTopic))
                {
                    return $"I remember that your favourite topic is {favouriteTopic}.";
                }

                return "I don’t remember a favourite topic yet.";
            }

            // Conversation Flow
            if (lowerInput.Contains("tell me more") ||
                lowerInput.Contains("another tip") ||
                lowerInput.Contains("explain more"))
            {
                if (!string.IsNullOrWhiteSpace(currentTopic))
                {
                    return GetRandomResponse(currentTopic);
                }

                return "Please ask about a cybersecurity topic first.";
            }

            // Keyword Recognition
            foreach (string topic in keywordResponses.Keys)
            {
                if (lowerInput.Contains(topic))
                {
                    currentTopic = topic;

                    string response = GetRandomResponse(topic);

                    if (!string.IsNullOrWhiteSpace(sentimentMessage))
                    {
                        return sentimentMessage + Environment.NewLine + response;
                    }

                    return response;
                }
            }

            // Greeting
            if (lowerInput.Contains("hello") || lowerInput.Contains("hi"))
            {
                return $"Hello, {userName}! How can I help you today?";
            }

            // Unknown Input
            return "I’m not sure I understand. Can you try rephrasing?";
        }

        // =========================
        // SENTIMENT DETECTION
        // =========================
        private string DetectSentiment(string input)
        {
            foreach (KeyValuePair<string, string> sentiment in sentimentResponses)
            {
                if (input.Contains(sentiment.Key))
                {
                    return sentiment.Value;
                }
            }

            return "";
        }

        // =========================
        // RANDOM RESPONSES
        // =========================
        private string GetRandomResponse(string topic)
        {
            if (keywordResponses.ContainsKey(topic))
            {
                List<string> responses = keywordResponses[topic];

                int index = random.Next(responses.Count);

                return responses[index];
            }

            return "I do not have information on that topic yet.";
        }

        // =========================
        // USER MESSAGE
        // =========================
        private void AddUserMessage(string message)
        {
            string time = DateTime.Now.ToString("HH:mm");

            rtbChat.SelectionColor = Color.Cyan;
            rtbChat.AppendText($"[{time}] You: {message}{Environment.NewLine}");

            rtbChat.ScrollToCaret();
        }

        // =========================
        // BOT MESSAGE
        // =========================
        private void AddBotMessage(string message)
        {
            string time = DateTime.Now.ToString("HH:mm");

            rtbChat.SelectionColor = Color.Lime;
            rtbChat.AppendText($"[{time}] Bot: {message}{Environment.NewLine}{Environment.NewLine}");

            rtbChat.ScrollToCaret();
        }

        // =========================
        // CLEAR CHAT
        // =========================
        private void BtnClear_Click(object sender, EventArgs e)
        {
            rtbChat.Clear();

            AddBotMessage("Chat cleared successfully.");
        }

        // =========================
        // EXIT BUTTON
        // =========================
        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thank you for using the Cybersecurity Awareness Chatbot. Stay safe online!",
                "Goodbye",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Application.Exit();
        }

        // =========================
        // PLACEHOLDER METHODS
        // =========================
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtUserInput.Text == "Type your message here...")
            {
                txtUserInput.Text = "";
                txtUserInput.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserInput.Text))
            {
                txtUserInput.Text = "Type your message here...";
                txtUserInput.ForeColor = Color.Gray;
            }
        }
    }
}