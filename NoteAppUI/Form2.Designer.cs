namespace NoteAppUI
{
    partial class Form2
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Autor = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.linkLabel_Mail = new System.Windows.Forms.LinkLabel();
            this.label_GitHub = new System.Windows.Forms.Label();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.label_copiriait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Title.Location = new System.Drawing.Point(12, 28);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(171, 42);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "NoteApp";
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Version.Location = new System.Drawing.Point(14, 84);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(79, 25);
            this.label_Version.TabIndex = 2;
            this.label_Version.Text = "V. 1.0.0";
            // 
            // label_Autor
            // 
            this.label_Autor.AutoSize = true;
            this.label_Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Autor.Location = new System.Drawing.Point(14, 131);
            this.label_Autor.Name = "label_Autor";
            this.label_Autor.Size = new System.Drawing.Size(376, 25);
            this.label_Autor.TabIndex = 3;
            this.label_Autor.Text = "Автор: Устинов Владислав Алексеевич";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_mail.Location = new System.Drawing.Point(15, 174);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(295, 20);
            this.label_mail.TabIndex = 4;
            this.label_mail.Text = "e-mail почта для обратной связи :";
            // 
            // linkLabel_Mail
            // 
            this.linkLabel_Mail.AutoSize = true;
            this.linkLabel_Mail.Location = new System.Drawing.Point(316, 178);
            this.linkLabel_Mail.Name = "linkLabel_Mail";
            this.linkLabel_Mail.Size = new System.Drawing.Size(156, 16);
            this.linkLabel_Mail.TabIndex = 7;
            this.linkLabel_Mail.TabStop = true;
            this.linkLabel_Mail.Text = "vladislav140203@mail.ru";
            // 
            // label_GitHub
            // 
            this.label_GitHub.AutoSize = true;
            this.label_GitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_GitHub.Location = new System.Drawing.Point(15, 216);
            this.label_GitHub.Name = "label_GitHub";
            this.label_GitHub.Size = new System.Drawing.Size(111, 20);
            this.label_GitHub.TabIndex = 8;
            this.label_GitHub.Text = "Мой GitHub :";
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.AutoSize = true;
            this.linkLabel_GitHub.Location = new System.Drawing.Point(132, 220);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(267, 16);
            this.linkLabel_GitHub.TabIndex = 9;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "https://github.com/Vlad-Ust-123/NoteApp.git";
            // 
            // label_copiriait
            // 
            this.label_copiriait.AutoSize = true;
            this.label_copiriait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_copiriait.Location = new System.Drawing.Point(15, 348);
            this.label_copiriait.Name = "label_copiriait";
            this.label_copiriait.Size = new System.Drawing.Size(240, 20);
            this.label_copiriait.TabIndex = 10;
            this.label_copiriait.Text = "2024 Устинов Владислав ® ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.label_copiriait);
            this.Controls.Add(this.linkLabel_GitHub);
            this.Controls.Add(this.label_GitHub);
            this.Controls.Add(this.linkLabel_Mail);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_Autor);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.label_Title);
            this.Name = "Form2";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_Autor;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.LinkLabel linkLabel_Mail;
        private System.Windows.Forms.Label label_GitHub;
        private System.Windows.Forms.LinkLabel linkLabel_GitHub;
        private System.Windows.Forms.Label label_copiriait;
    }
}