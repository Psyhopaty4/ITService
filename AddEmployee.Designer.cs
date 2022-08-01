namespace ProAuto
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(457, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 50);
            this.button2.TabIndex = 28;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(95, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 44);
            this.label3.TabIndex = 25;
            this.label3.Text = "Пол:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.Lavender;
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(366, 39);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(405, 50);
            this.textBoxLastName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 44);
            this.label2.TabIndex = 23;
            this.label2.Text = "Фамилия:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(70, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 50);
            this.button1.TabIndex = 27;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BackColor = System.Drawing.Color.Lavender;
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFirstName.Location = new System.Drawing.Point(366, 104);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(405, 50);
            this.textBoxFirstName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 44);
            this.label1.TabIndex = 19;
            this.label1.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(95, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 44);
            this.label4.TabIndex = 29;
            this.label4.Text = "Должность:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxGender.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другой"});
            this.comboBoxGender.Location = new System.Drawing.Point(366, 168);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(405, 50);
            this.comboBoxGender.TabIndex = 30;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.BackColor = System.Drawing.Color.Lavender;
            this.comboBoxPosition.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Мужской",
            "Женский",
            "Другой"});
            this.comboBoxPosition.Location = new System.Drawing.Point(366, 241);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(405, 50);
            this.comboBoxPosition.TabIndex = 31;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 469);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.Text = "Добавление работника";
            this.Load += new System.EventHandler(this.AddSupplies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxPosition;
    }
}