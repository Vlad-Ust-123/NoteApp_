namespace NoteAppUI
{
    partial class FormNoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNoteApp));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerModified = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerCreated = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.создатьНовуюЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьТекущуюЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущуюЗаметкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.fileToolStripMenuItem.Text = "Программа";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовуюЗаметкуToolStripMenuItem,
            this.редактироватьТекущуюЗаметкуToolStripMenuItem,
            this.удалитьТекущуюЗаметкуToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.editToolStripMenuItem.Text = "Редактировать";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Показать категории :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(163, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 81);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 564);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox);
            this.groupBox1.Controls.Add(this.dateTimePickerModified);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerCreated);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Header);
            this.groupBox1.Location = new System.Drawing.Point(413, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(775, 683);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(25, 126);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(740, 549);
            this.richTextBox.TabIndex = 7;
            this.richTextBox.Text = "";
            // 
            // dateTimePickerModified
            // 
            this.dateTimePickerModified.Enabled = false;
            this.dateTimePickerModified.Location = new System.Drawing.Point(393, 81);
            this.dateTimePickerModified.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerModified.Name = "dateTimePickerModified";
            this.dateTimePickerModified.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerModified.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Обновлен :";
            // 
            // dateTimePickerCreated
            // 
            this.dateTimePickerCreated.Enabled = false;
            this.dateTimePickerCreated.Location = new System.Drawing.Point(105, 81);
            this.dateTimePickerCreated.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerCreated.Name = "dateTimePickerCreated";
            this.dateTimePickerCreated.Size = new System.Drawing.Size(189, 22);
            this.dateTimePickerCreated.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Создан :";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(101, 55);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(92, 16);
            this.labelCategory.TabIndex = 2;
            this.labelCategory.Text = "labelCategory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория :";
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header.Location = new System.Drawing.Point(20, 16);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(229, 29);
            this.Header.TabIndex = 0;
            this.Header.Text = "Название заметки";
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(20, 649);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 49);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = ((System.Drawing.Image)(resources.GetObject("buttonEdit.Image")));
            this.buttonEdit.Location = new System.Drawing.Point(163, 649);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(59, 49);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(310, 649);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(58, 49);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // создатьНовуюЗаметкуToolStripMenuItem
            // 
            this.создатьНовуюЗаметкуToolStripMenuItem.Name = "создатьНовуюЗаметкуToolStripMenuItem";
            this.создатьНовуюЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.создатьНовуюЗаметкуToolStripMenuItem.Text = "Создать новую заметку";
            this.создатьНовуюЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.создатьНовуюЗаметкуToolStripMenuItem_Click);
            // 
            // редактироватьТекущуюЗаметкуToolStripMenuItem
            // 
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Name = "редактироватьТекущуюЗаметкуToolStripMenuItem";
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Text = "Редактировать текущую заметку";
            this.редактироватьТекущуюЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.редактироватьТекущуюЗаметкуToolStripMenuItem_Click);
            // 
            // удалитьТекущуюЗаметкуToolStripMenuItem
            // 
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Name = "удалитьТекущуюЗаметкуToolStripMenuItem";
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Text = "Удалить текущую заметку";
            this.удалитьТекущуюЗаметкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьТекущуюЗаметкуToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F14)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // FormNoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 713);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNoteApp";
            this.Text = "NoteApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.FormNoteApp_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.DateTimePicker dateTimePickerModified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreated;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовуюЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьТекущуюЗаметкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущуюЗаметкуToolStripMenuItem;
    }
}

