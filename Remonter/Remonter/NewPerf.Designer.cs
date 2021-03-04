
namespace Remonter
{
    partial class NewPerf
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
            this.IdPerf = new System.Windows.Forms.Label();
            this.FioPerf = new System.Windows.Forms.Label();
            this.ButEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО сотрудника";
            // 
            // IdPerf
            // 
            this.IdPerf.AutoSize = true;
            this.IdPerf.Location = new System.Drawing.Point(43, 75);
            this.IdPerf.Name = "IdPerf";
            this.IdPerf.Size = new System.Drawing.Size(0, 17);
            this.IdPerf.TabIndex = 2;
            // 
            // FioPerf
            // 
            this.FioPerf.AutoSize = true;
            this.FioPerf.Location = new System.Drawing.Point(46, 170);
            this.FioPerf.Name = "FioPerf";
            this.FioPerf.Size = new System.Drawing.Size(0, 17);
            this.FioPerf.TabIndex = 3;
            // 
            // ButEnt
            // 
            this.ButEnt.Location = new System.Drawing.Point(43, 294);
            this.ButEnt.Name = "ButEnt";
            this.ButEnt.Size = new System.Drawing.Size(75, 23);
            this.ButEnt.TabIndex = 4;
            this.ButEnt.UseVisualStyleBackColor = true;
            // 
            // NewPerf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.ButEnt);
            this.Controls.Add(this.FioPerf);
            this.Controls.Add(this.IdPerf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewPerf";
            this.Text = "NewPerf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IdPerf;
        private System.Windows.Forms.Label FioPerf;
        private System.Windows.Forms.Button ButEnt;
    }
}