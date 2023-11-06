namespace Graph
{
    partial class CalculatorView
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
        private void InitializeComponent(CalculatorController controller)
        {
            this.outputLabel = new System.Windows.Forms.Label();
            this.plusButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputLabel.ForeColor = System.Drawing.Color.White;
            this.outputLabel.Location = new System.Drawing.Point(211, 15);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 16);
            this.outputLabel.TabIndex = 0;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Black;
            this.plusButton.ForeColor = System.Drawing.Color.White;
            this.plusButton.Location = new System.Drawing.Point(13, 49);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(61, 23);
            this.plusButton.TabIndex = 4;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(controller.OnPlusButtonClick);
            this.plusButton.MouseEnter += new System.EventHandler(controller.OnPlusButtonMouseEnter);
            this.plusButton.MouseLeave += new System.EventHandler(controller.OnPlusButtonMouseExit);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.Color.Black;
            this.divisionButton.ForeColor = System.Drawing.Color.White;
            this.divisionButton.Location = new System.Drawing.Point(214, 49);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(61, 23);
            this.divisionButton.TabIndex = 7;
            this.divisionButton.Text = "/";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(controller.OnDivisionButtonClick);
            this.divisionButton.MouseEnter += new System.EventHandler(controller.OnDivisionButtonMouseEnter);
            this.divisionButton.MouseLeave += new System.EventHandler(controller.OnDivisionButtonMouseExit);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Black;
            this.multiplyButton.ForeColor = System.Drawing.Color.White;
            this.multiplyButton.Location = new System.Drawing.Point(144, 49);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(61, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(controller.OnMultiplyButtonClick);
            this.multiplyButton.MouseEnter += new System.EventHandler(controller.OnMultiplyButtonMouseEnter);
            this.multiplyButton.MouseLeave += new System.EventHandler(controller.OnMultiplyButtonMouseExit);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.Color.Black;
            this.subtractButton.ForeColor = System.Drawing.Color.White;
            this.subtractButton.Location = new System.Drawing.Point(80, 49);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(61, 23);
            this.subtractButton.TabIndex = 9;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(controller.OnSubtractionButtonClick);
            this.subtractButton.MouseEnter += new System.EventHandler(controller.OnSubtractionButtonMouseEnter);
            this.subtractButton.MouseLeave += new System.EventHandler(controller.OnSubtractionButtonMouseExit);
            // 
            // input2
            // 
            this.Input2.BackColor = System.Drawing.Color.Black;
            this.Input2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Input2.Location = new System.Drawing.Point(111, 13);
            this.Input2.Name = "input2";
            this.Input2.Size = new System.Drawing.Size(81, 20);
            this.Input2.TabIndex = 10;
            // 
            // input1
            // 
            this.Input1.BackColor = System.Drawing.Color.Black;
            this.Input1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Input1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Input1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Input1.Location = new System.Drawing.Point(12, 13);
            this.Input1.Name = "input1";
            this.Input1.Size = new System.Drawing.Size(81, 20);
            this.Input1.TabIndex = 11;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(288, 87);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.outputLabel);
            this.Name = "CalculatorView";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button subtractButton;
        public System.Windows.Forms.TextBox Input2;
        public System.Windows.Forms.TextBox Input1;
    }
}