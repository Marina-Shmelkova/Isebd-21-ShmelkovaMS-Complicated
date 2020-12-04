﻿namespace WindowsFormsBus
{
    partial class FormBus
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
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.comboCountDoors = new System.Windows.Forms.ComboBox();
            this.groupBoxDoors = new System.Windows.Forms.GroupBox();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.buttonCreateTrolleybus = new System.Windows.Forms.Button();
            this.checkBoxRound = new System.Windows.Forms.CheckBox();
            this.checkBoxRectangle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.groupBoxDoors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBus.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(13, 13);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(103, 23);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Создать автобус";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreateBus_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = global::WindowsFormsBus.Properties.Resources.стрелка_вверх;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(733, 342);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = global::WindowsFormsBus.Properties.Resources.стрелка_право;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(758, 372);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = global::WindowsFormsBus.Properties.Resources.стрелка_низ;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(733, 408);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = global::WindowsFormsBus.Properties.Resources.стрелка_лево;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(707, 372);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // comboCountDoors
            // 
            this.comboCountDoors.FormattingEnabled = true;
            this.comboCountDoors.Location = new System.Drawing.Point(6, 87);
            this.comboCountDoors.Name = "comboCountDoors";
            this.comboCountDoors.Size = new System.Drawing.Size(121, 21);
            this.comboCountDoors.TabIndex = 6;
            this.comboCountDoors.Text = "Количество дверей";
            // 
            // groupBoxDoors
            // 
            this.groupBoxDoors.Controls.Add(this.checkBoxTriangle);
            this.groupBoxDoors.Controls.Add(this.checkBoxRound);
            this.groupBoxDoors.Controls.Add(this.comboCountDoors);
            this.groupBoxDoors.Controls.Add(this.checkBoxRectangle);
            this.groupBoxDoors.Location = new System.Drawing.Point(582, 14);
            this.groupBoxDoors.Name = "groupBoxDoors";
            this.groupBoxDoors.Size = new System.Drawing.Size(155, 110);
            this.groupBoxDoors.TabIndex = 9;
            this.groupBoxDoors.TabStop = false;
            this.groupBoxDoors.Text = "Форма дверей";
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Location = new System.Drawing.Point(6, 64);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(93, 17);
            this.checkBoxTriangle.TabIndex = 2;
            this.checkBoxTriangle.Text = "Треугольные";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTrolleybus
            // 
            this.buttonCreateTrolleybus.Location = new System.Drawing.Point(582, 130);
            this.buttonCreateTrolleybus.Name = "buttonCreateTrolleybus";
            this.buttonCreateTrolleybus.Size = new System.Drawing.Size(150, 23);
            this.buttonCreateTrolleybus.TabIndex = 6;
            this.buttonCreateTrolleybus.Text = "Создать троллейбус";
            this.buttonCreateTrolleybus.UseVisualStyleBackColor = true;
            this.buttonCreateTrolleybus.Click += new System.EventHandler(this.buttonCreateTrolleybus_Click);
            // 
            // checkBoxRound
            // 
            this.checkBoxRound.AutoSize = true;
            this.checkBoxRound.Location = new System.Drawing.Point(6, 41);
            this.checkBoxRound.Name = "checkBoxRound";
            this.checkBoxRound.Size = new System.Drawing.Size(99, 17);
            this.checkBoxRound.TabIndex = 1;
            this.checkBoxRound.Text = "Закругленные";
            this.checkBoxRound.UseVisualStyleBackColor = true;
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.AutoSize = true;
            this.checkBoxRectangle.Location = new System.Drawing.Point(6, 19);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.Size = new System.Drawing.Size(88, 17);
            this.checkBoxRectangle.TabIndex = 0;
            this.checkBoxRectangle.Text = "Квадратные";
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxDoors);
            this.Controls.Add(this.buttonCreateTrolleybus);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.pictureBoxBus);
            this.Name = "FormBus";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.groupBoxDoors.ResumeLayout(false);
            this.groupBoxDoors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.ComboBox comboCountDoors;
        private System.Windows.Forms.GroupBox groupBoxDoors;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.Button buttonCreateTrolleybus;
        private System.Windows.Forms.CheckBox checkBoxRound;
        private System.Windows.Forms.CheckBox checkBoxRectangle;
    }
}

