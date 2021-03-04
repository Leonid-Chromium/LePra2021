
namespace Remonter
{
    partial class MainMenu
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
            this.BNOrder = new System.Windows.Forms.Button();
            this.BNC = new System.Windows.Forms.Button();
            this.BNPerformer = new System.Windows.Forms.Button();
            this.BNPerf = new System.Windows.Forms.Button();
            this.BOOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BNOrder
            // 
            this.BNOrder.Location = new System.Drawing.Point(93, 80);
            this.BNOrder.Name = "BNOrder";
            this.BNOrder.Size = new System.Drawing.Size(148, 23);
            this.BNOrder.TabIndex = 1;
            this.BNOrder.Text = "Новый заказ";
            this.BNOrder.UseVisualStyleBackColor = true;
            this.BNOrder.Click += new System.EventHandler(this.BNOrder_Click);
            // 
            // BNC
            // 
            this.BNC.Location = new System.Drawing.Point(93, 51);
            this.BNC.Name = "BNC";
            this.BNC.Size = new System.Drawing.Size(148, 23);
            this.BNC.TabIndex = 0;
            this.BNC.Text = "Новый клиент";
            this.BNC.UseVisualStyleBackColor = true;
            this.BNC.Click += new System.EventHandler(this.BNC_Click);
            // 
            // BNPerformer
            // 
            this.BNPerformer.Location = new System.Drawing.Point(93, 264);
            this.BNPerformer.Name = "BNPerformer";
            this.BNPerformer.Size = new System.Drawing.Size(148, 23);
            this.BNPerformer.TabIndex = 3;
            this.BNPerformer.Text = "Новый работник";
            this.BNPerformer.UseVisualStyleBackColor = true;
            this.BNPerformer.Click += new System.EventHandler(this.BNPerformer_Click);
            // 
            // BNPerf
            // 
            this.BNPerf.Location = new System.Drawing.Point(93, 293);
            this.BNPerf.Name = "BNPerf";
            this.BNPerf.Size = new System.Drawing.Size(148, 23);
            this.BNPerf.TabIndex = 4;
            this.BNPerf.Text = "Новая поломка";
            this.BNPerf.UseVisualStyleBackColor = true;
            // 
            // BOOrder
            // 
            this.BOOrder.Location = new System.Drawing.Point(93, 156);
            this.BOOrder.Name = "BOOrder";
            this.BOOrder.Size = new System.Drawing.Size(148, 47);
            this.BOOrder.TabIndex = 2;
            this.BOOrder.Text = "Изменения по заказу";
            this.BOOrder.UseVisualStyleBackColor = true;
            this.BOOrder.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 450);
            this.Controls.Add(this.BOOrder);
            this.Controls.Add(this.BNPerf);
            this.Controls.Add(this.BNPerformer);
            this.Controls.Add(this.BNC);
            this.Controls.Add(this.BNOrder);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BNOrder;
        private System.Windows.Forms.Button BNC;
        private System.Windows.Forms.Button BNPerformer;
        private System.Windows.Forms.Button BNPerf;
        private System.Windows.Forms.Button BOOrder;
    }
}