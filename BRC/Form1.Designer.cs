namespace BRC
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
            Bullet_Amount = new TextBox();
            ShowBulletAomunt = new Label();
            RedBullet = new Label();
            textBox1 = new TextBox();
            GrayBullet = new Label();
            textBox2 = new TextBox();
            RedBullet_button = new Button();
            GrayBullet_button = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            Reset = new Button();
            SetRed = new Button();
            SetGray = new Button();
            GrayOut = new Button();
            RedOut = new Button();
            label1 = new Label();
            label2 = new Label();
            RedChance = new Label();
            GrayChance = new Label();
            SaveList = new ListBox();
            SuspendLayout();
            // 
            // Bullet_Amount
            // 
            Bullet_Amount.Location = new Point(12, 47);
            Bullet_Amount.Name = "Bullet_Amount";
            Bullet_Amount.Size = new Size(100, 23);
            Bullet_Amount.TabIndex = 0;
            // 
            // ShowBulletAomunt
            // 
            ShowBulletAomunt.AutoSize = true;
            ShowBulletAomunt.Location = new Point(12, 29);
            ShowBulletAomunt.Name = "ShowBulletAomunt";
            ShowBulletAomunt.Size = new Size(55, 15);
            ShowBulletAomunt.TabIndex = 1;
            ShowBulletAomunt.Text = "子彈數量";
            ShowBulletAomunt.Click += label1_Click;
            // 
            // RedBullet
            // 
            RedBullet.AutoSize = true;
            RedBullet.Location = new Point(12, 86);
            RedBullet.Name = "RedBullet";
            RedBullet.Size = new Size(55, 15);
            RedBullet.TabIndex = 3;
            RedBullet.Text = "實彈數量";
            RedBullet.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // GrayBullet
            // 
            GrayBullet.AutoSize = true;
            GrayBullet.Location = new Point(12, 130);
            GrayBullet.Name = "GrayBullet";
            GrayBullet.Size = new Size(55, 15);
            GrayBullet.TabIndex = 5;
            GrayBullet.Text = "空彈數量";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // RedBullet_button
            // 
            RedBullet_button.ForeColor = Color.IndianRed;
            RedBullet_button.Location = new Point(137, 104);
            RedBullet_button.Name = "RedBullet_button";
            RedBullet_button.Size = new Size(75, 23);
            RedBullet_button.TabIndex = 6;
            RedBullet_button.Text = "實彈";
            RedBullet_button.UseVisualStyleBackColor = true;
            RedBullet_button.Click += RedBullet_button_Click;
            // 
            // GrayBullet_button
            // 
            GrayBullet_button.Location = new Point(137, 148);
            GrayBullet_button.Name = "GrayBullet_button";
            GrayBullet_button.Size = new Size(75, 23);
            GrayBullet_button.TabIndex = 7;
            GrayBullet_button.Text = "空彈";
            GrayBullet_button.UseVisualStyleBackColor = true;
            GrayBullet_button.Click += GrayBullet_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(306, 229);
            button1.Name = "button1";
            button1.Size = new Size(36, 87);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 229);
            button2.Name = "button2";
            button2.Size = new Size(36, 87);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(222, 229);
            button3.Name = "button3";
            button3.Size = new Size(36, 87);
            button3.TabIndex = 11;
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(180, 229);
            button4.Name = "button4";
            button4.Size = new Size(36, 87);
            button4.TabIndex = 10;
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(138, 229);
            button5.Name = "button5";
            button5.Size = new Size(36, 87);
            button5.TabIndex = 15;
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(96, 229);
            button6.Name = "button6";
            button6.Size = new Size(36, 87);
            button6.TabIndex = 14;
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(54, 229);
            button7.Name = "button7";
            button7.Size = new Size(36, 87);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 229);
            button8.Name = "button8";
            button8.Size = new Size(36, 87);
            button8.TabIndex = 12;
            button8.UseVisualStyleBackColor = true;
            button8.Visible = false;
            button8.Click += button8_Click;
            // 
            // Reset
            // 
            Reset.Location = new Point(240, 126);
            Reset.Name = "Reset";
            Reset.Size = new Size(75, 45);
            Reset.TabIndex = 16;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += Reset_Click;
            // 
            // SetRed
            // 
            SetRed.ForeColor = Color.IndianRed;
            SetRed.Location = new Point(15, 415);
            SetRed.Name = "SetRed";
            SetRed.Size = new Size(75, 23);
            SetRed.TabIndex = 17;
            SetRed.Text = "實彈";
            SetRed.UseVisualStyleBackColor = true;
            SetRed.Visible = false;
            SetRed.Click += SetRed_Click;
            // 
            // SetGray
            // 
            SetGray.Location = new Point(99, 415);
            SetGray.Name = "SetGray";
            SetGray.Size = new Size(75, 23);
            SetGray.TabIndex = 18;
            SetGray.Text = "空彈";
            SetGray.UseVisualStyleBackColor = true;
            SetGray.Visible = false;
            SetGray.Click += SetGray_Click;
            // 
            // GrayOut
            // 
            GrayOut.Location = new Point(357, 261);
            GrayOut.Name = "GrayOut";
            GrayOut.Size = new Size(75, 23);
            GrayOut.TabIndex = 20;
            GrayOut.Text = "空彈";
            GrayOut.UseVisualStyleBackColor = true;
            GrayOut.Click += GrayOut_Click;
            // 
            // RedOut
            // 
            RedOut.ForeColor = Color.IndianRed;
            RedOut.Location = new Point(357, 229);
            RedOut.Name = "RedOut";
            RedOut.Size = new Size(75, 23);
            RedOut.TabIndex = 19;
            RedOut.Text = "實彈";
            RedOut.UseVisualStyleBackColor = true;
            RedOut.Click += RedOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 302);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 21;
            label1.Text = "空包機率";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 287);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 22;
            label2.Text = "實彈機率";
            // 
            // RedChance
            // 
            RedChance.AutoSize = true;
            RedChance.Location = new Point(418, 287);
            RedChance.Name = "RedChance";
            RedChance.Size = new Size(0, 15);
            RedChance.TabIndex = 23;
            // 
            // GrayChance
            // 
            GrayChance.AutoSize = true;
            GrayChance.Location = new Point(418, 301);
            GrayChance.Name = "GrayChance";
            GrayChance.Size = new Size(0, 15);
            GrayChance.TabIndex = 24;
            // 
            // SaveList
            // 
            SaveList.FormattingEnabled = true;
            SaveList.ItemHeight = 15;
            SaveList.Location = new Point(624, 10);
            SaveList.Name = "SaveList";
            SaveList.Size = new Size(164, 274);
            SaveList.TabIndex = 25;
            SaveList.SelectedIndexChanged += SaveList_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaveList);
            Controls.Add(GrayChance);
            Controls.Add(RedChance);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GrayOut);
            Controls.Add(RedOut);
            Controls.Add(SetGray);
            Controls.Add(SetRed);
            Controls.Add(Reset);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(GrayBullet_button);
            Controls.Add(RedBullet_button);
            Controls.Add(GrayBullet);
            Controls.Add(textBox2);
            Controls.Add(RedBullet);
            Controls.Add(textBox1);
            Controls.Add(ShowBulletAomunt);
            Controls.Add(Bullet_Amount);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Bullet_Amount;
        private Label ShowBulletAomunt;
        private Label RedBullet;
        private TextBox textBox1;
        private Label GrayBullet;
        private TextBox textBox2;
        private Button RedBullet_button;
        private Button GrayBullet_button;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button Reset;
        private Button SetRed;
        private Button SetGray;
        private Button GrayOut;
        private Button RedOut;
        private Label label1;
        private Label label2;
        private Label RedChance;
        private Label GrayChance;
        private ListBox SaveList;
    }
}
