namespace TelegramBotDemo
{
    partial class Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnStart = new Button();
            txtToken = new TextBox();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            dgReports = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtMessage = new TextBox();
            btnSend = new Button();
            txtFilePath = new TextBox();
            btnSelectFile = new Button();
            btnVideo = new Button();
            btnPhoto = new Button();
            groupBox2 = new GroupBox();
            btnSendVideo = new Button();
            btnSendPhoto = new Button();
            btnSendText = new Button();
            txtChannel = new TextBox();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgReports).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStart);
            groupBox1.Controls.Add(txtToken);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(776, 69);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Token";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(0, 22);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(134, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtToken
            // 
            txtToken.Location = new Point(140, 25);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(630, 26);
            txtToken.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 603);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Red;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 20);
            lblStatus.Text = "Offline";
            // 
            // dgReports
            // 
            dgReports.AllowUserToAddRows = false;
            dgReports.AllowUserToDeleteRows = false;
            dgReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReports.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgReports.Location = new Point(12, 69);
            dgReports.Name = "dgReports";
            dgReports.ReadOnly = true;
            dgReports.RowHeadersWidth = 51;
            dgReports.Size = new Size(776, 239);
            dgReports.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ChatId";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "UserName";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Command";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "MessageId";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Date";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(112, 311);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(676, 94);
            txtMessage.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 372);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 33);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(270, 414);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(518, 26);
            txtFilePath.TabIndex = 5;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(212, 411);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(52, 29);
            btnSelectFile.TabIndex = 6;
            btnSelectFile.Text = "...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // btnVideo
            // 
            btnVideo.Location = new Point(12, 414);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(94, 29);
            btnVideo.TabIndex = 7;
            btnVideo.Text = "Video";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnPhoto
            // 
            btnPhoto.Location = new Point(112, 412);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(94, 29);
            btnPhoto.TabIndex = 8;
            btnPhoto.Text = "Photo";
            btnPhoto.UseVisualStyleBackColor = true;
            btnPhoto.Click += btnPhoto_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSendVideo);
            groupBox2.Controls.Add(btnSendPhoto);
            groupBox2.Controls.Add(btnSendText);
            groupBox2.Controls.Add(txtChannel);
            groupBox2.Location = new Point(12, 449);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 73);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Channal";
            // 
            // btnSendVideo
            // 
            btnSendVideo.Location = new Point(89, 16);
            btnSendVideo.Name = "btnSendVideo";
            btnSendVideo.Size = new Size(153, 29);
            btnSendVideo.TabIndex = 12;
            btnSendVideo.Text = "Send Video";
            btnSendVideo.UseVisualStyleBackColor = true;
            btnSendVideo.Click += btnSendVideo_Click;
            // 
            // btnSendPhoto
            // 
            btnSendPhoto.Location = new Point(248, 16);
            btnSendPhoto.Name = "btnSendPhoto";
            btnSendPhoto.Size = new Size(134, 29);
            btnSendPhoto.TabIndex = 11;
            btnSendPhoto.Text = "Send Photo";
            btnSendPhoto.UseVisualStyleBackColor = true;
            btnSendPhoto.Click += btnSendPhoto_Click;
            // 
            // btnSendText
            // 
            btnSendText.Location = new Point(388, 16);
            btnSendText.Name = "btnSendText";
            btnSendText.Size = new Size(149, 29);
            btnSendText.TabIndex = 10;
            btnSendText.Text = "Send Text";
            btnSendText.UseVisualStyleBackColor = true;
            btnSendText.Click += btnSendText_Click;
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(543, 16);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(227, 26);
            txtChannel.TabIndex = 0;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 629);
            Controls.Add(groupBox2);
            Controls.Add(btnPhoto);
            Controls.Add(btnVideo);
            Controls.Add(btnSelectFile);
            Controls.Add(txtFilePath);
            Controls.Add(btnSend);
            Controls.Add(txtMessage);
            Controls.Add(dgReports);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form";
            RightToLeftLayout = true;
            Text = "Form";
            FormClosing += Form_FormClosing;
            Load += Form_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgReports).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtToken;
        private Button btnStart;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private DataGridView dgReports;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtMessage;
        private Button btnSend;
        private TextBox txtFilePath;
        private Button btnSelectFile;
        private Button btnVideo;
        private Button btnPhoto;
        private GroupBox groupBox2;
        private TextBox txtChannel;
        private Button btnSendVideo;
        private Button btnSendPhoto;
        private Button btnSendText;
    }
}
