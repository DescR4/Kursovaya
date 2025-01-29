namespace ExampleSQLApp1
{
    partial class LoginForm
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
			panel1 = new Panel();
			guestButton = new Button();
			buttonLogin = new Button();
			passfield = new TextBox();
			pictureBox2 = new PictureBox();
			loginField = new TextBox();
			pictureBox1 = new PictureBox();
			panel2 = new Panel();
			closeButton = new Label();
			label1 = new Label();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.BurlyWood;
			panel1.Controls.Add(guestButton);
			panel1.Controls.Add(buttonLogin);
			panel1.Controls.Add(passfield);
			panel1.Controls.Add(pictureBox2);
			panel1.Controls.Add(loginField);
			panel1.Controls.Add(pictureBox1);
			panel1.Controls.Add(panel2);
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(408, 414);
			panel1.TabIndex = 0;
			panel1.MouseDown += panel1_MouseDown;
			panel1.MouseMove += panel1_MouseMove;
			// 
			// guestButton
			// 
			guestButton.BackColor = Color.Wheat;
			guestButton.BackgroundImageLayout = ImageLayout.Center;
			guestButton.Cursor = Cursors.Hand;
			guestButton.FlatAppearance.BorderColor = Color.Black;
			guestButton.FlatStyle = FlatStyle.Flat;
			guestButton.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
			guestButton.ForeColor = SystemColors.ControlLightLight;
			guestButton.Location = new Point(114, 356);
			guestButton.Name = "guestButton";
			guestButton.Size = new Size(234, 46);
			guestButton.TabIndex = 7;
			guestButton.Text = "Войти без авторизации";
			guestButton.UseVisualStyleBackColor = false;
			guestButton.Click += guestButton_Click;
			// 
			// buttonLogin
			// 
			buttonLogin.BackColor = Color.SandyBrown;
			buttonLogin.FlatAppearance.BorderColor = Color.Black;
			buttonLogin.FlatAppearance.MouseDownBackColor = Color.PeachPuff;
			buttonLogin.FlatAppearance.MouseOverBackColor = Color.Chocolate;
			buttonLogin.FlatStyle = FlatStyle.Flat;
			buttonLogin.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			buttonLogin.ForeColor = Color.White;
			buttonLogin.Location = new Point(132, 296);
			buttonLogin.Name = "buttonLogin";
			buttonLogin.Size = new Size(202, 54);
			buttonLogin.TabIndex = 6;
			buttonLogin.Text = "Войти";
			buttonLogin.UseVisualStyleBackColor = false;
			buttonLogin.Click += button1_Click;
			// 
			// passfield
			// 
			passfield.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			passfield.Location = new Point(132, 219);
			passfield.Name = "passfield";
			passfield.PasswordChar = '*';
			passfield.Size = new Size(202, 48);
			passfield.TabIndex = 5;
			passfield.UseSystemPasswordChar = true;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = Properties.Resources._lock;
			pictureBox2.InitialImage = Properties.Resources.user;
			pictureBox2.Location = new Point(62, 219);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(64, 64);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 4;
			pictureBox2.TabStop = false;
			// 
			// loginField
			// 
			loginField.Font = new Font("Times New Roman", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
			loginField.Location = new Point(132, 131);
			loginField.Multiline = true;
			loginField.Name = "loginField";
			loginField.Size = new Size(202, 64);
			loginField.TabIndex = 3;
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = ImageLayout.None;
			pictureBox1.Image = Properties.Resources.user;
			pictureBox1.InitialImage = Properties.Resources.user;
			pictureBox1.Location = new Point(62, 131);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(64, 64);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkOrange;
			panel2.Controls.Add(closeButton);
			panel2.Controls.Add(label1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(408, 100);
			panel2.TabIndex = 1;
			// 
			// closeButton
			// 
			closeButton.AutoSize = true;
			closeButton.BackColor = Color.Red;
			closeButton.Cursor = Cursors.Hand;
			closeButton.Font = new Font("Segoe UI", 18F);
			closeButton.ForeColor = Color.White;
			closeButton.Location = new Point(379, 0);
			closeButton.Name = "closeButton";
			closeButton.Size = new Size(28, 32);
			closeButton.TabIndex = 1;
			closeButton.Tag = "closeButton";
			closeButton.Text = "X";
			closeButton.Click += label2_Click;
			closeButton.MouseEnter += closeButton_MouseEnter;
			closeButton.MouseLeave += closeButton_MouseLeave;
			// 
			// label1
			// 
			label1.Dock = DockStyle.Fill;
			label1.Font = new Font("Comic Sans MS", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.ForeColor = Color.Gold;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(408, 100);
			label1.TabIndex = 0;
			label1.Text = "Авторизация";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.MouseMove += label1_MouseMove;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(407, 414);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "LoginForm";
			Text = "LoginForm";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label closeButton;
        private PictureBox pictureBox1;
        private TextBox passfield;
        private PictureBox pictureBox2;
        private TextBox loginField;
        private Button buttonLogin;
        private Button guestButton;
    }
}