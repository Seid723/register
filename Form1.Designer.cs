namespace c__proyekti
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 0, 192);
            button1.Location = new Point(574, 531);
            button1.Name = "button1";
            button1.Size = new Size(378, 60);
            button1.TabIndex = 0;
            button1.Text = "Sign up";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(574, 255);
            label1.Name = "label1";
            label1.Size = new Size(200, 31);
            label1.TabIndex = 1;
            label1.Text = "Username or Email";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gray;
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(574, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 36);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(574, 371);
            label2.Name = "label2";
            label2.Size = new Size(106, 31);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 57);
            label3.Name = "label3";
            label3.Size = new Size(310, 81);
            label3.TabIndex = 5;
            label3.Text = "Saiducino";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(607, 168);
            label4.Name = "label4";
            label4.Size = new Size(280, 31);
            label4.TabIndex = 6;
            label4.Text = "Sign Up To Your Account";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.Gray;
            maskedTextBox1.Location = new Point(574, 415);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.PasswordChar = '*';
            maskedTextBox1.Size = new Size(378, 27);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(299, 239);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(947, 239);
            button3.Name = "button3";
            button3.Size = new Size(340, 302);
            button3.TabIndex = 9;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1566, 775);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Registration";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private Button button2;
        private Button button3;
    }
}
