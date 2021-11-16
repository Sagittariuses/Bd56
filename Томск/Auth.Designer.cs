
namespace Томск
{
    partial class Aunthorization
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.LoginTb = new System.Windows.Forms.MaskedTextBox();
            this.PasswordTb = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(40, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(208, 176);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(96, 31);
            this.EnterBtn.TabIndex = 6;
            this.EnterBtn.Text = "Войти";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // LoginTb
            // 
            this.LoginTb.Location = new System.Drawing.Point(180, 74);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LoginTb.Size = new System.Drawing.Size(202, 26);
            this.LoginTb.TabIndex = 7;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(180, 122);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.Size = new System.Drawing.Size(202, 26);
            this.PasswordTb.TabIndex = 8;
            // 
            // Aunthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 266);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.LoginTb);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Aunthorization";
            this.Text = "Авторизация - \"Простирушки\"";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.MaskedTextBox LoginTb;
        private System.Windows.Forms.MaskedTextBox PasswordTb;
    }
}

