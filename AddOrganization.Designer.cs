namespace ProAuto
{
    partial class AddOrganization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrganization));
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(476, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 50);
            this.button2.TabIndex = 43;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.Lavender;
            this.textBoxYear.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYear.Location = new System.Drawing.Point(262, 164);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(545, 50);
            this.textBoxYear.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(105, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 44);
            this.label3.TabIndex = 37;
            this.label3.Text = "КПП:";
            // 
            // textBoxMark
            // 
            this.textBoxMark.BackColor = System.Drawing.Color.Lavender;
            this.textBoxMark.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMark.Location = new System.Drawing.Point(262, 34);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(545, 50);
            this.textBoxMark.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 44);
            this.label2.TabIndex = 34;
            this.label2.Text = "Адрес:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(89, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.Color.Lavender;
            this.textBoxModel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(262, 99);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(545, 50);
            this.textBoxModel.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 44);
            this.label1.TabIndex = 30;
            this.label1.Text = "ИНН:";
            // 
            // AddOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 382);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrganization";
            this.Text = "Добавление компании";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label1;
    }
}