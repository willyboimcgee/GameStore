﻿namespace GameStoreAdminApp
{
    partial class frmGamePreowned
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
            this.label5 = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Discount %";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Location = new System.Drawing.Point(97, 147);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(96, 20);
            this.nudDiscount.TabIndex = 49;
            // 
            // frmGamePreowned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(352, 176);
            this.Controls.Add(this.nudDiscount);
            this.Controls.Add(this.label5);
            this.Name = "frmGamePreowned";
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.nudDiscount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudDiscount;
    }
}
