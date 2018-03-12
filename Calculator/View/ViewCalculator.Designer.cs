﻿namespace Calculator.View
{
    partial class ViewCalculator
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
            this.btnChosenPath = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblChosenPath = new System.Windows.Forms.Label();
            this.lblCanceled = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChosenPath
            // 
            this.btnChosenPath.Location = new System.Drawing.Point(12, 13);
            this.btnChosenPath.Name = "btnChosenPath";
            this.btnChosenPath.Size = new System.Drawing.Size(75, 23);
            this.btnChosenPath.TabIndex = 0;
            this.btnChosenPath.Text = "Load";
            this.btnChosenPath.UseVisualStyleBackColor = true;
            this.btnChosenPath.Click += new System.EventHandler(this.ChosePath);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 98);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(359, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblChosenPath
            // 
            this.lblChosenPath.AutoSize = true;
            this.lblChosenPath.Location = new System.Drawing.Point(115, 18);
            this.lblChosenPath.Name = "lblChosenPath";
            this.lblChosenPath.Size = new System.Drawing.Size(0, 13);
            this.lblChosenPath.TabIndex = 3;
            // 
            // lblCanceled
            // 
            this.lblCanceled.AutoSize = true;
            this.lblCanceled.Location = new System.Drawing.Point(115, 47);
            this.lblCanceled.Name = "lblCanceled";
            this.lblCanceled.Size = new System.Drawing.Size(35, 13);
            this.lblCanceled.TabIndex = 4;
            this.lblCanceled.Text = "label2";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(10, 81);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(140, 13);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.Text = "The progress of current task";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "label4";
            // 
            // ViewCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblCanceled);
            this.Controls.Add(this.lblChosenPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChosenPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChosenPath;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblChosenPath;
        private System.Windows.Forms.Label lblCanceled;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblResult;
    }
}