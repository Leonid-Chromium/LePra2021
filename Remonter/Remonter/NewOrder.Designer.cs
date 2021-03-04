
namespace Remonter
{
    partial class NewOrder
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
            this.id_o = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_c = new System.Windows.Forms.TextBox();
            this.ButEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заказа";
            // 
            // id_o
            // 
            this.id_o.Location = new System.Drawing.Point(16, 33);
            this.id_o.Name = "id_o";
            this.id_o.Size = new System.Drawing.Size(100, 22);
            this.id_o.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер заказчика";
            // 
            // id_c
            // 
            this.id_c.Location = new System.Drawing.Point(16, 106);
            this.id_c.Name = "id_c";
            this.id_c.Size = new System.Drawing.Size(100, 22);
            this.id_c.TabIndex = 3;
            // 
            // ButEnt
            // 
            this.ButEnt.Location = new System.Drawing.Point(16, 151);
            this.ButEnt.Name = "ButEnt";
            this.ButEnt.Size = new System.Drawing.Size(120, 47);
            this.ButEnt.TabIndex = 4;
            this.ButEnt.Text = "Проверить и ввести";
            this.ButEnt.UseVisualStyleBackColor = true;
            this.ButEnt.Click += new System.EventHandler(this.ButEnt_Click);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.ButEnt);
            this.Controls.Add(this.id_c);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_o);
            this.Controls.Add(this.label1);
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_o;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_c;
        private System.Windows.Forms.Button ButEnt;
    }
}