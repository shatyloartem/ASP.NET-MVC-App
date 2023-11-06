namespace Graph
{
    partial class MultiplicationTableView
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
        private void InitializeComponent(MultiplicationTableController controller)
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.InputNum = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Black;
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(99, 10);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(32, 24);
            this.calculateButton.TabIndex = 33;
            this.calculateButton.Text = "OK";
            this.calculateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(controller.OnCalculateButtonClick);
            this.calculateButton.MouseEnter += new System.EventHandler(controller.OnCalculateButtonEnter);
            this.calculateButton.MouseLeave += new System.EventHandler(controller.OnCalculateButtonExit);
            // 
            // inputNum
            // 
            this.InputNum.BackColor = System.Drawing.Color.Black;
            this.InputNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.InputNum.Location = new System.Drawing.Point(12, 12);
            this.InputNum.Name = "InputNum";
            this.InputNum.Size = new System.Drawing.Size(81, 20);
            this.InputNum.TabIndex = 23;
            // 
            // outputLabel1
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(12, 44);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 24);
            this.outputLabel.TabIndex = 22;
            // 
            // multiplicationTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(141, 293);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.InputNum);
            this.Controls.Add(this.outputLabel);
            this.Name = "MultiplicationTableView";
            this.Text = "multiplicationTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox InputNum;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}