﻿
namespace Remonter
{
    partial class NewCust
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IdCust = new System.Windows.Forms.TextBox();
            this.FioCust = new System.Windows.Forms.TextBox();
            this.ButEnt = new System.Windows.Forms.Button();
            this.TelCust = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер телефона";
            // 
            // IdCust
            // 
            this.IdCust.Location = new System.Drawing.Point(12, 29);
            this.IdCust.Name = "IdCust";
            this.IdCust.Size = new System.Drawing.Size(121, 22);
            this.IdCust.TabIndex = 0;
            this.IdCust.Tag = "0";
            // 
            // FioCust
            // 
            this.FioCust.Location = new System.Drawing.Point(12, 115);
            this.FioCust.Name = "FioCust";
            this.FioCust.Size = new System.Drawing.Size(121, 22);
            this.FioCust.TabIndex = 1;
            // 
            // ButEnt
            // 
            this.ButEnt.Location = new System.Drawing.Point(155, 95);
            this.ButEnt.Name = "ButEnt";
            this.ButEnt.Size = new System.Drawing.Size(121, 53);
            this.ButEnt.TabIndex = 3;
            this.ButEnt.Text = "Проверить и ввести";
            this.ButEnt.UseVisualStyleBackColor = true;
            this.ButEnt.Click += new System.EventHandler(this.ButEnt_Click);
            // 
            // TelCust
            // 
            this.TelCust.Location = new System.Drawing.Point(12, 218);
            this.TelCust.Name = "TelCust";
            this.TelCust.Size = new System.Drawing.Size(121, 22);
            this.TelCust.TabIndex = 2;
            // 
            // NewCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.TelCust);
            this.Controls.Add(this.ButEnt);
            this.Controls.Add(this.FioCust);
            this.Controls.Add(this.IdCust);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewCust";
            this.Text = "NewCust";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IdCust;
        private System.Windows.Forms.TextBox FioCust;
        private System.Windows.Forms.Button ButEnt;
        private System.Windows.Forms.MaskedTextBox TelCust;
    }
}