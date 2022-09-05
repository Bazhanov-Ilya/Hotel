
namespace Hotel
{
    partial class FormLogIn
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogIn_btn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.Forgot_pass = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ViewPass = new System.Windows.Forms.PictureBox();
            this.Close_btn = new System.Windows.Forms.PictureBox();
            this.Minimize_Btn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 620);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Olympus";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.ViewPass);
            this.groupBox1.Controls.Add(this.LogIn_btn);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUserName);
            this.groupBox1.Controls.Add(this.Forgot_pass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(163, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login First";
            // 
            // LogIn_btn
            // 
            this.LogIn_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogIn_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.LogIn_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogIn_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.LogIn_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.LogIn_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(77)))), ((int)(((byte)(255)))));
            this.LogIn_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn_btn.ForeColor = System.Drawing.Color.White;
            this.LogIn_btn.Location = new System.Drawing.Point(155, 252);
            this.LogIn_btn.Name = "LogIn_btn";
            this.LogIn_btn.Size = new System.Drawing.Size(130, 37);
            this.LogIn_btn.TabIndex = 3;
            this.LogIn_btn.Text = "Log In";
            this.LogIn_btn.UseVisualStyleBackColor = false;
            this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(66, 166);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(283, 22);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUserName.Location = new System.Drawing.Point(66, 96);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(311, 22);
            this.textBoxUserName.TabIndex = 1;
            // 
            // Forgot_pass
            // 
            this.Forgot_pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Forgot_pass.AutoSize = true;
            this.Forgot_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forgot_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Forgot_pass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.Forgot_pass.Location = new System.Drawing.Point(152, 222);
            this.Forgot_pass.Name = "Forgot_pass";
            this.Forgot_pass.Size = new System.Drawing.Size(133, 16);
            this.Forgot_pass.TabIndex = 0;
            this.Forgot_pass.Text = "Forgot Password?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(63, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(719, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 455);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.label4.Location = new System.Drawing.Point(957, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hotel Menegement";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(204)))), ((int)(((byte)(73)))));
            this.label5.Location = new System.Drawing.Point(1026, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Hotel.Properties.Resources.cli;
            this.pictureBox1.Location = new System.Drawing.Point(856, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ViewPass
            // 
            this.ViewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewPass.Image = global::Hotel.Properties.Resources.pngegg;
            this.ViewPass.Location = new System.Drawing.Point(356, 166);
            this.ViewPass.Name = "ViewPass";
            this.ViewPass.Size = new System.Drawing.Size(21, 21);
            this.ViewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewPass.TabIndex = 4;
            this.ViewPass.TabStop = false;
            this.ViewPass.Click += new System.EventHandler(this.ViewPass_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.Image = global::Hotel.Properties.Resources.User_Interface_Close_Window_icon;
            this.Close_btn.Location = new System.Drawing.Point(1322, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(35, 35);
            this.Close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_btn.TabIndex = 0;
            this.Close_btn.TabStop = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseHover += new System.EventHandler(this.Close_btn_MouseHover);
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Btn.Image = global::Hotel.Properties.Resources.Programming_Minimize_Window_icon;
            this.Minimize_Btn.Location = new System.Drawing.Point(1271, 12);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(35, 35);
            this.Minimize_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize_Btn.TabIndex = 0;
            this.Minimize_Btn.TabStop = false;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            this.Minimize_Btn.MouseHover += new System.EventHandler(this.Minimize_Btn_MouseHover);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 720);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Minimize_Btn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel_Management_System | LogIn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Minimize_Btn;
        private System.Windows.Forms.PictureBox Close_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Forgot_pass;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.PictureBox ViewPass;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

