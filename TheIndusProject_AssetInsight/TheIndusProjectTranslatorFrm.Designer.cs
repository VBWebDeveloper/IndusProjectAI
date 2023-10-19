namespace TheIndusProject.AssetInsight
{
    partial class TheIndusProjectTranslatorFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheIndusProjectTranslatorFrm));
            this.label1 = new System.Windows.Forms.Label();
            this._comboFrom = new System.Windows.Forms.ComboBox();
            this._comboTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this._editSourceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._editTarget = new System.Windows.Forms.TextBox();
            this._btnTranslate = new System.Windows.Forms.Button();
            this._lblStatus = new System.Windows.Forms.Label();
            this._lnkReverse = new System.Windows.Forms.LinkLabel();
            this._btnSpeak = new System.Windows.Forms.Button();
            this._webBrowserCtrl = new System.Windows.Forms.WebBrowser();
            this._lnkSourceEnglish = new System.Windows.Forms.LinkLabel();
            this._lnkTargetEnglish = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Dialect:";
            // 
            // _comboFrom
            // 
            this._comboFrom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._comboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboFrom.FormattingEnabled = true;
            this._comboFrom.Location = new System.Drawing.Point(9, 30);
            this._comboFrom.MaxDropDownItems = 20;
            this._comboFrom.Name = "_comboFrom";
            this._comboFrom.Size = new System.Drawing.Size(181, 21);
            this._comboFrom.Sorted = true;
            this._comboFrom.TabIndex = 1;
            // 
            // _comboTo
            // 
            this._comboTo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._comboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboTo.FormattingEnabled = true;
            this._comboTo.Location = new System.Drawing.Point(215, 30);
            this._comboTo.MaxDropDownItems = 20;
            this._comboTo.Name = "_comboTo";
            this._comboTo.Size = new System.Drawing.Size(181, 21);
            this._comboTo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(215, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Dialect:";
            // 
            // _editSourceText
            // 
            this._editSourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editSourceText.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._editSourceText.Location = new System.Drawing.Point(12, 74);
            this._editSourceText.Multiline = true;
            this._editSourceText.Name = "_editSourceText";
            this._editSourceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editSourceText.Size = new System.Drawing.Size(588, 60);
            this._editSourceText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Source text:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(9, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Translated text:";
            // 
            // _editTarget
            // 
            this._editTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._editTarget.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._editTarget.Location = new System.Drawing.Point(9, 154);
            this._editTarget.Multiline = true;
            this._editTarget.Name = "_editTarget";
            this._editTarget.ReadOnly = true;
            this._editTarget.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._editTarget.Size = new System.Drawing.Size(588, 60);
            this._editTarget.TabIndex = 10;
            // 
            // _btnTranslate
            // 
            this._btnTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnTranslate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._btnTranslate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnTranslate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnTranslate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this._btnTranslate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnTranslate.ForeColor = System.Drawing.Color.Red;
            this._btnTranslate.Location = new System.Drawing.Point(416, 222);
            this._btnTranslate.Name = "_btnTranslate";
            this._btnTranslate.Size = new System.Drawing.Size(87, 23);
            this._btnTranslate.TabIndex = 13;
            this._btnTranslate.Text = "Translate";
            this._btnTranslate.UseVisualStyleBackColor = false;
            this._btnTranslate.Click += new System.EventHandler(this._btnTranslate_Click);
            // 
            // _lblStatus
            // 
            this._lblStatus.AutoSize = true;
            this._lblStatus.ForeColor = System.Drawing.Color.DarkOrange;
            this._lblStatus.Location = new System.Drawing.Point(7, 226);
            this._lblStatus.Name = "_lblStatus";
            this._lblStatus.Size = new System.Drawing.Size(16, 13);
            this._lblStatus.TabIndex = 11;
            this._lblStatus.Text = "   ";
            // 
            // _lnkReverse
            // 
            this._lnkReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lnkReverse.AutoSize = true;
            this._lnkReverse.LinkColor = System.Drawing.Color.Pink;
            this._lnkReverse.Location = new System.Drawing.Point(546, 58);
            this._lnkReverse.Name = "_lnkReverse";
            this._lnkReverse.Size = new System.Drawing.Size(54, 13);
            this._lnkReverse.TabIndex = 7;
            this._lnkReverse.TabStop = true;
            this._lnkReverse.Text = "Reverse";
            this._lnkReverse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkReverse_LinkClicked);
            // 
            // _btnSpeak
            // 
            this._btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSpeak.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this._btnSpeak.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSpeak.ForeColor = System.Drawing.Color.Red;
            this._btnSpeak.Location = new System.Drawing.Point(509, 222);
            this._btnSpeak.Name = "_btnSpeak";
            this._btnSpeak.Size = new System.Drawing.Size(87, 23);
            this._btnSpeak.TabIndex = 14;
            this._btnSpeak.Text = "Speak";
            this._btnSpeak.UseVisualStyleBackColor = false;
            this._btnSpeak.Click += new System.EventHandler(this._btnSpeak_Click);
            // 
            // _webBrowserCtrl
            // 
            this._webBrowserCtrl.IsWebBrowserContextMenuEnabled = false;
            this._webBrowserCtrl.Location = new System.Drawing.Point(126, 224);
            this._webBrowserCtrl.Name = "_webBrowserCtrl";
            this._webBrowserCtrl.Size = new System.Drawing.Size(79, 20);
            this._webBrowserCtrl.TabIndex = 12;
            this._webBrowserCtrl.Visible = false;
            this._webBrowserCtrl.WebBrowserShortcutsEnabled = false;
            // 
            // _lnkSourceEnglish
            // 
            this._lnkSourceEnglish.AutoSize = true;
            this._lnkSourceEnglish.LinkColor = System.Drawing.Color.Pink;
            this._lnkSourceEnglish.Location = new System.Drawing.Point(149, 14);
            this._lnkSourceEnglish.Name = "_lnkSourceEnglish";
            this._lnkSourceEnglish.Size = new System.Drawing.Size(35, 13);
            this._lnkSourceEnglish.TabIndex = 2;
            this._lnkSourceEnglish.TabStop = true;
            this._lnkSourceEnglish.Text = "Hindi";
            this._lnkSourceEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkSourceEnglish_LinkClicked);
            // 
            // _lnkTargetEnglish
            // 
            this._lnkTargetEnglish.AutoSize = true;
            this._lnkTargetEnglish.LinkColor = System.Drawing.Color.Pink;
            this._lnkTargetEnglish.Location = new System.Drawing.Point(355, 14);
            this._lnkTargetEnglish.Name = "_lnkTargetEnglish";
            this._lnkTargetEnglish.Size = new System.Drawing.Size(45, 13);
            this._lnkTargetEnglish.TabIndex = 5;
            this._lnkTargetEnglish.TabStop = true;
            this._lnkTargetEnglish.Text = "Telugu";
            this._lnkTargetEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._lnkTargetEnglish_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(439, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 39);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(399, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 42);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(539, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 39);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(474, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 39);
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(568, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 39);
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // TheIndusProjectTranslatorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(607, 251);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this._lnkTargetEnglish);
            this.Controls.Add(this._lnkSourceEnglish);
            this.Controls.Add(this._webBrowserCtrl);
            this.Controls.Add(this._btnSpeak);
            this.Controls.Add(this._lnkReverse);
            this.Controls.Add(this._lblStatus);
            this.Controls.Add(this._btnTranslate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._editTarget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._editSourceText);
            this.Controls.Add(this._comboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._comboFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1192, 300);
            this.MinimumSize = new System.Drawing.Size(417, 290);
            this.Name = "TheIndusProjectTranslatorFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Indus Project Translator";
            this.Load += new System.EventHandler(this.TheIndusProjectTranslatorFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _comboFrom;
        private System.Windows.Forms.ComboBox _comboTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _editSourceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _editTarget;
        private System.Windows.Forms.Button _btnTranslate;
        private System.Windows.Forms.Label _lblStatus;
        private System.Windows.Forms.LinkLabel _lnkReverse;
        private System.Windows.Forms.Button _btnSpeak;
        private System.Windows.Forms.WebBrowser _webBrowserCtrl;
        private System.Windows.Forms.LinkLabel _lnkSourceEnglish;
        private System.Windows.Forms.LinkLabel _lnkTargetEnglish;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}