namespace ProAuto
{
    partial class AddService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddService));
            this.button2 = new System.Windows.Forms.Button();
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
            this.button2.Location = new System.Drawing.Point(453, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 50);
            this.button2.TabIndex = 24;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxMark
            // 
            this.textBoxMark.BackColor = System.Drawing.Color.Lavender;
            this.textBoxMark.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMark.Location = new System.Drawing.Point(362, 32);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(405, 50);
            this.textBoxMark.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 44);
            this.label2.TabIndex = 16;
            this.label2.Text = "Наименование:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(66, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxModel
            // 
            this.textBoxModel.BackColor = System.Drawing.Color.Lavender;
            this.textBoxModel.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxModel.Location = new System.Drawing.Point(362, 97);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(405, 50);
            this.textBoxModel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Цена:";
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(867, 293);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddService";
            this.Text = "Добавление сервиса";
            this.Load += new System.EventHandler(this.AddCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label1;
    }
}