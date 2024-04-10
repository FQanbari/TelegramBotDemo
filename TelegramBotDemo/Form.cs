using Newtonsoft.Json.Bson;
using System.IO;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Color = System.Drawing.Color;

namespace TelegramBotDemo
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static string _token = "";
        private Thread _botThread;
        private TelegramBotClient _botClient;
        private ReplyKeyboardMarkup _mainreplyKeyboardMarkup;

        public Form()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            _token = txtToken.Text;
            _botThread = new Thread(new ThreadStart(runBot));
            _botThread.Start();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            KeyboardButton[][] keyboardButtons =
            {
                [new ($"About me \U00002764"), new ("button 1")],
                [new ("button 3")]
            };

            _mainreplyKeyboardMarkup = new ReplyKeyboardMarkup(keyboardButtons);

        }

        void runBot()
        {
            _botClient = new TelegramBotClient(_token);

            this.Invoke(new Action(() =>
            {
                lblStatus.Text = "Online";
                lblStatus.ForeColor = Color.Green;
            }));

            int offset = 0;
            while (true)
            {
                Update[] updates = _botClient.GetUpdatesAsync(offset).Result;

                foreach (var update in updates)
                {
                    offset = update.Id + 1;
                    if (update.Message == null || string.IsNullOrWhiteSpace(update.Message.Text)) continue;

                    string command = update.Message.Text.ToLower();
                    var from = update.Message.From;
                    var chatId = update.Message.Chat.Id;

                    if (command.Contains("/start"))
                    {
                        StringBuilder reply = new ();
                        reply.AppendLine($"{from.FirstName} wlecome to my bot!");
                        _botClient.SendTextMessageAsync(chatId, reply.ToString(), replyMarkup: _mainreplyKeyboardMarkup);
                    }
                    else if (command.Contains("but 1"))
                    {
                        StringBuilder reply = new ();
                        reply.AppendLine($"which one?");

                        KeyboardButton[][] subkeyboardButtons =
                            {
                                [new ($"sub button 1 \U00002764"), new ("sub button 1")],
                                [new ("sub button 3"),new("/return")]
                            };
                        var subKeyboardMarkup = new ReplyKeyboardMarkup(subkeyboardButtons);

                        InlineKeyboardButton inlineKeyboardButton = new("t");
                        inlineKeyboardButton.Url = "www.google.com";
                        
                        InlineKeyboardMarkup inlineKeyboardMarkup = new (inlineKeyboardButton);
                        _botClient.SendTextMessageAsync(chatId, reply.ToString(), replyMarkup: inlineKeyboardMarkup);

                    }
                    else if (command.Contains("/return"))
                    {
                        _botClient.SendTextMessageAsync(chatId, "return", replyMarkup: _mainreplyKeyboardMarkup);
                    }

                    dgReports.Invoke(new Action(() =>
                    {
                        dgReports.Rows.Add(chatId, from.Username, command, update.Message.MessageId, update.Message.Date.ToString("yyyy/MM/dd"));
                    }));
                }
            }
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _botThread.Abort();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (dgReports.CurrentRow != null)
            {
                long chatId = long.Parse(dgReports.CurrentRow.Cells[0].Value.ToString());
                _botClient.SendTextMessageAsync(chatId, txtMessage.Text);
                txtMessage.Text = "";
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            if (dgReports.CurrentRow != null && !string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                long chatId = long.Parse(dgReports.CurrentRow.Cells[0].Value.ToString());
                using (FileStream imageFile = System.IO.File.Open(txtFilePath.Text, FileMode.Open))
                {
                    _botClient.SendPhotoAsync(chatId, InputFile.FromStream(imageFile), caption: txtMessage.Text);
                }

            }
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            if (dgReports.CurrentRow != null && !string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                long chatId = long.Parse(dgReports.CurrentRow.Cells[0].Value.ToString());
                using (FileStream imageFile = System.IO.File.Open(txtFilePath.Text, FileMode.Open))
                {
                    _botClient.SendVideoAsync(chatId, InputFile.FromStream(imageFile), caption: txtMessage.Text);
                }

            }
        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            _botClient.SendTextMessageAsync(txtChannel.Text, txtMessage.Text);
        }

        private void btnSendPhoto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                using (FileStream imageFile = System.IO.File.Open(txtFilePath.Text, FileMode.Open))
                {
                    _botClient.SendPhotoAsync(txtChannel.Text, InputFile.FromStream(imageFile), caption: txtMessage.Text);
                }

            }
        }

        private void btnSendVideo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFilePath.Text))
            {
                using (FileStream imageFile = System.IO.File.Open(txtFilePath.Text, FileMode.Open))
                {
                    _botClient.SendVideoAsync(txtChannel.Text, InputFile.FromStream(imageFile), caption: txtMessage.Text);
                }

            }
        }
    }
}

