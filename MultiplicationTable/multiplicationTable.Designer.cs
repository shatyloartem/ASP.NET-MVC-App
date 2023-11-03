namespace Graph
{
    partial class multiplicationTable
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
            this.OKButton = new System.Windows.Forms.Button();
            this.inputNum = new System.Windows.Forms.TextBox();
            this.outputLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.Black;
            this.OKButton.ForeColor = System.Drawing.Color.White;
            this.OKButton.Location = new System.Drawing.Point(99, 10);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(32, 24);
            this.OKButton.TabIndex = 33;
            this.OKButton.Text = "OK";
            this.OKButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // inputNum
            // 
            this.inputNum.BackColor = System.Drawing.Color.Black;
            this.inputNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.inputNum.Location = new System.Drawing.Point(12, 12);
            this.inputNum.Name = "inputNum";
            this.inputNum.Size = new System.Drawing.Size(81, 20);
            this.inputNum.TabIndex = 23;
            // 
            // outputLabel1
            // 
            this.outputLabel1.AutoSize = true;
            this.outputLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel1.ForeColor = System.Drawing.Color.White;
            this.outputLabel1.Location = new System.Drawing.Point(12, 44);
            this.outputLabel1.Name = "outputLabel1";
            this.outputLabel1.Size = new System.Drawing.Size(0, 24);
            this.outputLabel1.TabIndex = 22;
            // 
            // multiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(141, 293);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.inputNum);
            this.Controls.Add(this.outputLabel1);
            this.Name = "multiplicationTable";
            this.Text = "multiplicationTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox inputNum;
        private System.Windows.Forms.Label outputLabel1;
    }
}