namespace KelimeBulma
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtWord = new TextBox();
            btnEnter = new Button();
            lblWord = new Label();
            label2 = new Label();
            lstHistory = new ListBox();
            lblKeywords = new Label();
            pictureBox1 = new PictureBox();
            lblHeart = new Label();
            btnRest = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtWord
            // 
            txtWord.BorderStyle = BorderStyle.FixedSingle;
            txtWord.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtWord.Location = new Point(15, 243);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(263, 35);
            txtWord.TabIndex = 0;
            // 
            // btnEnter
            // 
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnter.Location = new Point(284, 243);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(121, 35);
            btnEnter.TabIndex = 1;
            btnEnter.Text = "Gönder";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWord.Location = new Point(141, 111);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(78, 46);
            lblWord.TabIndex = 4;
            lblWord.Text = "null";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 121);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 5;
            label2.Text = "Kelimen : ";
            // 
            // lstHistory
            // 
            lstHistory.BorderStyle = BorderStyle.FixedSingle;
            lstHistory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 30;
            lstHistory.Location = new Point(15, 286);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(390, 152);
            lstHistory.TabIndex = 6;
            // 
            // lblKeywords
            // 
            lblKeywords.AutoSize = true;
            lblKeywords.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKeywords.ForeColor = Color.Firebrick;
            lblKeywords.Location = new Point(12, 12);
            lblKeywords.Name = "lblKeywords";
            lblKeywords.Size = new Size(63, 37);
            lblKeywords.TabIndex = 7;
            lblKeywords.Text = "null";
            lblKeywords.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.heart_attack;
            pictureBox1.Location = new Point(414, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblHeart
            // 
            lblHeart.AutoSize = true;
            lblHeart.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeart.Location = new Point(366, 9);
            lblHeart.Name = "lblHeart";
            lblHeart.Size = new Size(39, 32);
            lblHeart.TabIndex = 9;
            lblHeart.Text = "9x";
            // 
            // btnRest
            // 
            btnRest.BackgroundImage = Properties.Resources.refresh;
            btnRest.BackgroundImageLayout = ImageLayout.Zoom;
            btnRest.Cursor = Cursors.Hand;
            btnRest.FlatStyle = FlatStyle.Flat;
            btnRest.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRest.Location = new Point(411, 243);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(35, 35);
            btnRest.TabIndex = 10;
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(459, 450);
            Controls.Add(pictureBox1);
            Controls.Add(lblHeart);
            Controls.Add(btnRest);
            Controls.Add(lblKeywords);
            Controls.Add(lstHistory);
            Controls.Add(label2);
            Controls.Add(lblWord);
            Controls.Add(btnEnter);
            Controls.Add(txtWord);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Kelime Bulma Oyunu";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWord;
        private Button btnEnter;
        private Label lblWord;
        private Label label2;
        private ListBox lstHistory;
        private Label lblKeywords;
        private PictureBox pictureBox1;
        private Label lblHeart;
        private Button btnRest;
    }
}