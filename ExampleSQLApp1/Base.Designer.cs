using System.ComponentModel;

namespace ExampleSQLApp1
{
    partial class Base
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(Base));
			txtPhoneNumber = new TextBox();
			btnDial = new Button();
			closeButton = new Label();
			panel1 = new Panel();
			btnHelp = new Button();
			btn_Logout = new Button();
			btn_Status = new Button();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			btn_Disconnect = new Button();
			btnViewLogs = new Button();
			btnManageUsers = new Button();
			panel1.SuspendLayout();
			((ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// txtPhoneNumber
			// 
			txtPhoneNumber.Location = new Point(44, 170);
			txtPhoneNumber.Name = "txtPhoneNumber";
			txtPhoneNumber.Size = new Size(280, 23);
			txtPhoneNumber.TabIndex = 0;
			txtPhoneNumber.Enter += txtPhoneNumber_Enter;
			txtPhoneNumber.Leave += txtPhoneNumber_Leave;
			// 
			// btnDial
			// 
			btnDial.BackColor = Color.SandyBrown;
			btnDial.BackgroundImageLayout = ImageLayout.Center;
			btnDial.Cursor = Cursors.Hand;
			btnDial.FlatAppearance.BorderColor = Color.Black;
			btnDial.FlatStyle = FlatStyle.Flat;
			btnDial.Font = new Font("Times New Roman", 20.25F);
			btnDial.ForeColor = Color.White;
			btnDial.Location = new Point(44, 239);
			btnDial.Name = "btnDial";
			btnDial.Size = new Size(133, 48);
			btnDial.TabIndex = 1;
			btnDial.Text = "Вызов";
			btnDial.UseVisualStyleBackColor = false;
			btnDial.Click += btnDial_Click;
			// 
			// closeButton
			// 
			closeButton.AutoSize = true;
			closeButton.BackColor = Color.Red;
			closeButton.Cursor = Cursors.Hand;
			closeButton.Font = new Font("Segoe UI", 18F);
			closeButton.ForeColor = Color.White;
			closeButton.Location = new Point(812, 0);
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
			panel1.Location = new Point(0, -1);
			panel1.Name = "panel1";
			panel1.Size = new Size(840, 100);
			panel1.TabIndex = 4;
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
			btnHelp.Click += btnHelp_Click;
			// 
			// btn_Logout
			// 
			btn_Logout.BackColor = Color.SandyBrown;
			btn_Logout.Cursor = Cursors.Hand;
			btn_Logout.FlatStyle = FlatStyle.Flat;
			btn_Logout.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btn_Logout.Location = new Point(660, 68);
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
			btn_Status.Click += btn_Status_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Comic Sans MS", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
			label1.ForeColor = Color.Gold;
			label1.Location = new Point(291, 20);
			label1.Name = "label1";
			label1.Size = new Size(255, 60);
			label1.TabIndex = 5;
			label1.Text = "Мини-АТС";
			label1.Click += label1_Click;
			label1.MouseMove += label1_MouseMove;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
			pictureBox1.Image = Properties.Resources.font;
			pictureBox1.Location = new Point(405, 170);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(400, 400);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// btn_Disconnect
			// 
			btn_Disconnect.BackColor = Color.SandyBrown;
			btn_Disconnect.BackgroundImageLayout = ImageLayout.Center;
			btn_Disconnect.Cursor = Cursors.Hand;
			btn_Disconnect.FlatAppearance.BorderColor = Color.Black;
			btn_Disconnect.FlatStyle = FlatStyle.Flat;
			btn_Disconnect.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
			btn_Disconnect.ForeColor = Color.White;
			btn_Disconnect.Location = new Point(183, 239);
			btn_Disconnect.Name = "btn_Disconnect";
			btn_Disconnect.Size = new Size(141, 48);
			btn_Disconnect.TabIndex = 6;
			btn_Disconnect.Text = "Завершить";
			btn_Disconnect.UseVisualStyleBackColor = false;
			btn_Disconnect.Click += btn_Disconnect_Click;
			// 
			// btnViewLogs
			// 
			btnViewLogs.BackColor = Color.DarkOrange;
			btnViewLogs.BackgroundImageLayout = ImageLayout.Center;
			btnViewLogs.Cursor = Cursors.Hand;
			btnViewLogs.FlatStyle = FlatStyle.Flat;
			btnViewLogs.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnViewLogs.Location = new Point(44, 320);
			btnViewLogs.Name = "btnViewLogs";
			btnViewLogs.Size = new Size(280, 36);
			btnViewLogs.TabIndex = 9;
			btnViewLogs.Text = "Посмотреть действия пользователей";
			btnViewLogs.UseVisualStyleBackColor = false;
			btnViewLogs.Click += btnViewLogs_Click;
			// 
			// btnManageUsers
			// 
			btnManageUsers.BackColor = Color.DarkOrange;
			btnManageUsers.BackgroundImageLayout = ImageLayout.Center;
			btnManageUsers.Cursor = Cursors.Hand;
			btnManageUsers.FlatStyle = FlatStyle.Flat;
			btnManageUsers.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
			btnManageUsers.Location = new Point(44, 387);
			btnManageUsers.Name = "btnManageUsers";
			btnManageUsers.Size = new Size(280, 36);
			btnManageUsers.TabIndex = 10;
			btnManageUsers.Text = "Просмотр пользователей";
			btnManageUsers.UseVisualStyleBackColor = false;
			btnManageUsers.Click += btnManageUsers_Click;
			// 
			// Base
			// 
			BackColor = Color.BurlyWood;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			ClientSize = new Size(840, 650);
			Controls.Add(btnManageUsers);
			Controls.Add(btnViewLogs);
			Controls.Add(btn_Disconnect);
			Controls.Add(pictureBox1);
			Controls.Add(btnDial);
			Controls.Add(txtPhoneNumber);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Base";
			StartPosition = FormStartPosition.CenterScreen;
			Load += Base_Load;
			KeyPress += Base_KeyPress;
			MouseDown += Base_MouseDown;
			MouseMove += Base_MouseMove;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		private TextBox txtPhoneNumber;
        private Button btnDial;
        private Label closeButton;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btn_Status;
        private Button btn_Logout;
        private Button btn_Disconnect;
        private Button btnViewLogs;
        private Button btnHelp;
		private Button btnManageUsers;
	}
}
