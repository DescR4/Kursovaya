namespace ExampleSQLApp1
{
	partial class Fake
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fake));
			btnDial = new Button();
			txtPhoneNumber = new TextBox();
			closeButton = new Label();
			panel1 = new Panel();
			btnHelp = new Button();
			btn_Logout = new Button();
			btn_Status = new Button();
			label1 = new Label();
			btn_Disconnect = new Button();
			pictureBox1 = new PictureBox();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// btnDial
			// 
			btnDial.BackColor = Color.SandyBrown;
			btnDial.BackgroundImageLayout = ImageLayout.Center;
			btnDial.FlatAppearance.BorderColor = Color.Black;
			btnDial.FlatStyle = FlatStyle.Flat;
			btnDial.Font = new Font("Times New Roman", 20.25F);
			btnDial.ForeColor = Color.White;
			btnDial.Location = new Point(45, 234);
			btnDial.Name = "btnDial";
			btnDial.Size = new Size(133, 48);
			btnDial.TabIndex = 11;
			btnDial.Text = "Вызов";
			btnDial.UseVisualStyleBackColor = false;
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.Location = new Point(45, 165);
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.Size = new Size(280, 23);
			txtPhoneNumber.TabIndex = 10;
			txtPhoneNumber.Enter += txtPhoneNumber_Enter;
			txtPhoneNumber.Leave += txtPhoneNumber_Leave;
			// 
			// closeButton
			// 
			closeButton.AutoSize = true;
			closeButton.BackColor = Color.Red;
			closeButton.Cursor = Cursors.Hand;
			closeButton.Font = new Font("Segoe UI", 18F);
			closeButton.ForeColor = Color.White;
			closeButton.Location = new Point(814, -3);
			closeButton.Name = "closeButton";
			closeButton.Size = new Size(28, 32);
			closeButton.TabIndex = 2;
			closeButton.Tag = "closeButton";
			closeButton.Text = "X";
			closeButton.Click += closeButton_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkOrange;
			panel1.Controls.Add(btnHelp);
			panel1.Controls.Add(btn_Logout);
			panel1.Controls.Add(btn_Status);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(closeButton);
			panel1.Location = new Point(-1, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(842, 100);
			panel1.TabIndex = 12;
			panel1.MouseDown += panel1_MouseDown;
			panel1.MouseMove += panel1_MouseMove;
			// 
			// btnHelp
			// 
			btnHelp.BackColor = Color.SandyBrown;
			btnHelp.FlatStyle = FlatStyle.Flat;
			btnHelp.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnHelp.Location = new Point(92, 0);
			btnHelp.Name = "btnHelp";
			btnHelp.Size = new Size(193, 32);
			btnHelp.TabIndex = 8;
			btnHelp.Text = "Справка";
			btnHelp.UseVisualStyleBackColor = false;
			// 
			// btn_Logout
			// 
			btn_Logout.BackColor = Color.SandyBrown;
			btn_Logout.FlatStyle = FlatStyle.Flat;
			btn_Logout.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btn_Logout.Location = new Point(662, 68);
			btn_Logout.Name = "btn_Logout";
			btn_Logout.Size = new Size(180, 32);
			btn_Logout.TabIndex = 7;
			btn_Logout.Text = "Выход из аккаунта";
			btn_Logout.UseVisualStyleBackColor = false;
			btn_Logout.Click += btn_Logout_Click;
			// 
			// btn_Status
			// 
			btn_Status.BackColor = Color.SandyBrown;
			btn_Status.Cursor = Cursors.Hand;
			btn_Status.FlatStyle = FlatStyle.Flat;
			btn_Status.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btn_Status.Location = new Point(0, 0);
			btn_Status.Name = "btn_Status";
			btn_Status.Size = new Size(93, 32);
			btn_Status.TabIndex = 6;
			btn_Status.Text = "Статус";
			btn_Status.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Comic Sans MS", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.ForeColor = Color.Gold;
			label1.Location = new Point(291, 25);
			label1.Name = "label1";
			label1.Size = new Size(255, 60);
			label1.TabIndex = 5;
			label1.Text = "Мини-АТС";
			label1.MouseDown += label1_MouseDown;
			label1.MouseMove += label1_MouseMove;
			// 
			// btn_Disconnect
			// 
			btn_Disconnect.BackColor = Color.SandyBrown;
			btn_Disconnect.BackgroundImageLayout = ImageLayout.Center;
			btn_Disconnect.FlatAppearance.BorderColor = Color.Black;
			btn_Disconnect.FlatStyle = FlatStyle.Flat;
			btn_Disconnect.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Disconnect.ForeColor = Color.White;
			btn_Disconnect.Location = new Point(184, 234);
			btn_Disconnect.Name = "btn_Disconnect";
			btn_Disconnect.Size = new Size(141, 48);
			btn_Disconnect.TabIndex = 14;
			btn_Disconnect.Text = "Завершить";
			btn_Disconnect.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(389, 165);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(439, 368);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 13;
			pictureBox1.TabStop = false;
			// 
			// Fake
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.BurlyWood;
			ClientSize = new Size(840, 650);
			Controls.Add(btnDial);
			Controls.Add(txtPhoneNumber);
			Controls.Add(panel1);
			Controls.Add(btn_Disconnect);
			Controls.Add(pictureBox1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Fake";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Fake";
			MouseDown += Fake_MouseDown;
			MouseMove += Fake_MouseMove;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDial;
		private TextBox txtPhoneNumber;
		private Label closeButton;
		private Panel panel1;
		private Button btnHelp;
		private Button btn_Logout;
		private Button btn_Status;
		private Label label1;
		private Button btn_Disconnect;
		private PictureBox pictureBox1;
	}
}