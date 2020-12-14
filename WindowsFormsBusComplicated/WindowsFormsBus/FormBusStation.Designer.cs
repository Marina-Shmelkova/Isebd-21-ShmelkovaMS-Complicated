﻿namespace WindowsFormsBus
{
    partial class FormBusStation
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
            this.pictureBoxBusStation = new System.Windows.Forms.PictureBox();
            this.buttonDeleteBusStation = new System.Windows.Forms.Button();
            this.listBoxBusStation = new System.Windows.Forms.ListBox();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonStack = new System.Windows.Forms.Button();
            this.labelCompare = new System.Windows.Forms.Label();
            this.maskedTextBoxCompare = new System.Windows.Forms.MaskedTextBox();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.groupBoxStation = new System.Windows.Forms.GroupBox();
            this.OutPutBus = new System.Windows.Forms.Button();
            this.maskedTextBoxBus = new System.Windows.Forms.MaskedTextBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.buttonAddBusStation = new System.Windows.Forms.Button();
            this.labelStation = new System.Windows.Forms.Label();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однуПарковкуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПарковкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однуПарковкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПарковкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialogBus = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogBus = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusStation)).BeginInit();
            this.groupBoxStation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBusStation
            // 
            this.pictureBoxBusStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxBusStation.Location = new System.Drawing.Point(0, 24);
            this.pictureBoxBusStation.Name = "pictureBoxBusStation";
            this.pictureBoxBusStation.Size = new System.Drawing.Size(553, 426);
            this.pictureBoxBusStation.TabIndex = 1;
            this.pictureBoxBusStation.TabStop = false;
            // 
            // buttonDeleteBusStation
            // 
            this.buttonDeleteBusStation.Location = new System.Drawing.Point(634, 102);
            this.buttonDeleteBusStation.Name = "buttonDeleteBusStation";
            this.buttonDeleteBusStation.Size = new System.Drawing.Size(122, 23);
            this.buttonDeleteBusStation.TabIndex = 22;
            this.buttonDeleteBusStation.Text = "Удалить парковку";
            this.buttonDeleteBusStation.UseVisualStyleBackColor = true;
            this.buttonDeleteBusStation.Click += new System.EventHandler(this.buttonDelBusStation_Click);
            // 
            // listBoxBusStation
            // 
            this.listBoxBusStation.FormattingEnabled = true;
            this.listBoxBusStation.Location = new System.Drawing.Point(634, 40);
            this.listBoxBusStation.Name = "listBoxBusStation";
            this.listBoxBusStation.Size = new System.Drawing.Size(122, 56);
            this.listBoxBusStation.TabIndex = 21;
            this.listBoxBusStation.Click += new System.EventHandler(this.listBoxBusStation_SelectedIndexChanged);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(720, 14);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(39, 20);
            this.textBoxNewLevelName.TabIndex = 20;
            // 
            // buttonStack
            // 
            this.buttonStack.Location = new System.Drawing.Point(634, 334);
            this.buttonStack.Name = "buttonStack";
            this.buttonStack.Size = new System.Drawing.Size(125, 29);
            this.buttonStack.TabIndex = 19;
            this.buttonStack.Text = "Стек";
            this.buttonStack.UseVisualStyleBackColor = true;
            this.buttonStack.Click += new System.EventHandler(this.buttonStack_Click);
            // 
            // labelCompare
            // 
            this.labelCompare.AutoSize = true;
            this.labelCompare.Location = new System.Drawing.Point(595, 370);
            this.labelCompare.Name = "labelCompare";
            this.labelCompare.Size = new System.Drawing.Size(167, 13);
            this.labelCompare.TabIndex = 18;
            this.labelCompare.Text = "Количество заполненных мест:";
            // 
            // maskedTextBoxCompare
            // 
            this.maskedTextBoxCompare.Location = new System.Drawing.Point(631, 386);
            this.maskedTextBoxCompare.Name = "maskedTextBoxCompare";
            this.maskedTextBoxCompare.Size = new System.Drawing.Size(125, 20);
            this.maskedTextBoxCompare.TabIndex = 17;
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(631, 408);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(125, 28);
            this.buttonCompare.TabIndex = 16;
            this.buttonCompare.Text = "Сравнить";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
            // 
            // groupBoxStation
            // 
            this.groupBoxStation.Controls.Add(this.OutPutBus);
            this.groupBoxStation.Controls.Add(this.maskedTextBoxBus);
            this.groupBoxStation.Controls.Add(this.labelBus);
            this.groupBoxStation.Location = new System.Drawing.Point(634, 219);
            this.groupBoxStation.Name = "groupBoxStation";
            this.groupBoxStation.Size = new System.Drawing.Size(125, 109);
            this.groupBoxStation.TabIndex = 15;
            this.groupBoxStation.TabStop = false;
            this.groupBoxStation.Text = "Забрать транспортное средство";
            // 
            // OutPutBus
            // 
            this.OutPutBus.Location = new System.Drawing.Point(9, 79);
            this.OutPutBus.Name = "OutPutBus";
            this.OutPutBus.Size = new System.Drawing.Size(75, 23);
            this.OutPutBus.TabIndex = 2;
            this.OutPutBus.Text = "Забрать";
            this.OutPutBus.UseVisualStyleBackColor = true;
            this.OutPutBus.Click += new System.EventHandler(this.buttonTakeBus_Click);
            // 
            // maskedTextBoxBus
            // 
            this.maskedTextBoxBus.Location = new System.Drawing.Point(51, 53);
            this.maskedTextBoxBus.Name = "maskedTextBoxBus";
            this.maskedTextBoxBus.Size = new System.Drawing.Size(48, 20);
            this.maskedTextBoxBus.TabIndex = 1;
            // 
            // labelBus
            // 
            this.labelBus.AutoSize = true;
            this.labelBus.Location = new System.Drawing.Point(6, 53);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(39, 13);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Место";
            // 
            // buttonAddBusStation
            // 
            this.buttonAddBusStation.Location = new System.Drawing.Point(592, 12);
            this.buttonAddBusStation.Name = "buttonAddBusStation";
            this.buttonAddBusStation.Size = new System.Drawing.Size(122, 23);
            this.buttonAddBusStation.TabIndex = 23;
            this.buttonAddBusStation.Text = "Добавить парковку";
            this.buttonAddBusStation.UseVisualStyleBackColor = true;
            this.buttonAddBusStation.Click += new System.EventHandler(this.buttonAddBusStation_Click);
            // 
            // labelStation
            // 
            this.labelStation.AutoSize = true;
            this.labelStation.Location = new System.Drawing.Point(682, 0);
            this.labelStation.Name = "labelStation";
            this.labelStation.Size = new System.Drawing.Size(57, 13);
            this.labelStation.TabIndex = 24;
            this.labelStation.Text = "Парковки";
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Location = new System.Drawing.Point(634, 152);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(122, 26);
            this.buttonAddBus.TabIndex = 25;
            this.buttonAddBus.Text = "Добавить ТС";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.однуПарковкуToolStripMenuItem1,
            this.всеПарковкиToolStripMenuItem1});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // однуПарковкуToolStripMenuItem1
            // 
            this.однуПарковкуToolStripMenuItem1.Name = "однуПарковкуToolStripMenuItem1";
            this.однуПарковкуToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.однуПарковкуToolStripMenuItem1.Text = "Текущую парковку";
            this.однуПарковкуToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьОднуПарковкуToolStripMenuItem1_Click);
            // 
            // всеПарковкиToolStripMenuItem1
            // 
            this.всеПарковкиToolStripMenuItem1.Name = "всеПарковкиToolStripMenuItem1";
            this.всеПарковкиToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.всеПарковкиToolStripMenuItem1.Text = "Все парковки";
            this.всеПарковкиToolStripMenuItem1.Click += new System.EventHandler(this.сохранитьВсеПарковкиToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.однуПарковкуToolStripMenuItem,
            this.всеПарковкиToolStripMenuItem});
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // однуПарковкуToolStripMenuItem
            // 
            this.однуПарковкуToolStripMenuItem.Name = "однуПарковкуToolStripMenuItem";
            this.однуПарковкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.однуПарковкуToolStripMenuItem.Text = "Одну парковку";
            this.однуПарковкуToolStripMenuItem.Click += new System.EventHandler(this.загрузитьОднуПарковкуToolStripMenuItem_Click);
            // 
            // всеПарковкиToolStripMenuItem
            // 
            this.всеПарковкиToolStripMenuItem.Name = "всеПарковкиToolStripMenuItem";
            this.всеПарковкиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всеПарковкиToolStripMenuItem.Text = "Все парковки";
            this.всеПарковкиToolStripMenuItem.Click += new System.EventHandler(this.загрузитьВсеПарковкиToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStripBus";
            // 
            // saveFileDialogBus
            // 
            this.saveFileDialogBus.Filter = "txt file | *.txt";
            // 
            // openFileDialogBus
            // 
            this.openFileDialogBus.FileName = "openFileDialogBus";
            this.openFileDialogBus.Filter = "txt file | *.txt";
            // 
            // FormBusStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddBus);
            this.Controls.Add(this.labelStation);
            this.Controls.Add(this.buttonAddBusStation);
            this.Controls.Add(this.buttonDeleteBusStation);
            this.Controls.Add(this.listBoxBusStation);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonStack);
            this.Controls.Add(this.labelCompare);
            this.Controls.Add(this.maskedTextBoxCompare);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.groupBoxStation);
            this.Controls.Add(this.pictureBoxBusStation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBusStation";
            this.Text = "FormBusStation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusStation)).EndInit();
            this.groupBoxStation.ResumeLayout(false);
            this.groupBoxStation.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBusStation;
        private System.Windows.Forms.Button buttonDeleteBusStation;
        private System.Windows.Forms.ListBox listBoxBusStation;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonStack;
        private System.Windows.Forms.Label labelCompare;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCompare;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.GroupBox groupBoxStation;
        private System.Windows.Forms.Button OutPutBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxBus;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Button buttonAddBusStation;
        private System.Windows.Forms.Label labelStation;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBus;
        private System.Windows.Forms.OpenFileDialog openFileDialogBus;
        private System.Windows.Forms.ToolStripMenuItem однуПарковкуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem всеПарковкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem однуПарковкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПарковкиToolStripMenuItem;
    }
}