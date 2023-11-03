﻿namespace Graph
{
    partial class AgeCategoriesView
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
        private void InitializeComponent(AgeCategoriesController controller)
        {
            this.InputAge = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputAge
            // 
            this.InputAge.BackColor = System.Drawing.Color.Black;
            this.InputAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputAge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InputAge.Location = new System.Drawing.Point(12, 12);
            this.InputAge.Name = "inputAge";
            this.InputAge.Size = new System.Drawing.Size(60, 20);
            this.InputAge.TabIndex = 11;
            // 
            // outputLabel1
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 46);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 24);
            this.outputLabel.TabIndex = 23;
            // 
            // OKButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(83, 9);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(32, 24);
            this.calculateButton.TabIndex = 34;
            this.calculateButton.Text = "OK";
            this.calculateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(controller.OnCalculateButtonClicked);
            this.calculateButton.MouseEnter += new System.EventHandler(controller.OnCalculateButtonMouseEnter);
            this.calculateButton.MouseLeave += new System.EventHandler(controller.OnCalculateButtonMouseExit);
            // 
            // ageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(129, 88);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.InputAge);
            this.Name = "AgeCategoriesView";
            this.Text = "ageCategories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox InputAge { get; private set; }
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}