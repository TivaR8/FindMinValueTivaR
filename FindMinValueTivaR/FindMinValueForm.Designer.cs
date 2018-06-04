namespace FindMinValueTivaR
{
    partial class FindMinValueForm
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
            this.lstNumberSet = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMinValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstNumberSet
            // 
            this.lstNumberSet.FormattingEnabled = true;
            this.lstNumberSet.Location = new System.Drawing.Point(43, 55);
            this.lstNumberSet.Name = "lstNumberSet";
            this.lstNumberSet.Size = new System.Drawing.Size(178, 147);
            this.lstNumberSet.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(97, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblMinValue
            // 
            this.lblMinValue.AutoSize = true;
            this.lblMinValue.Location = new System.Drawing.Point(44, 222);
            this.lblMinValue.Name = "lblMinValue";
            this.lblMinValue.Size = new System.Drawing.Size(111, 13);
            this.lblMinValue.TabIndex = 2;
            this.lblMinValue.Text = "The minimum value is:";
            // 
            // FindMinValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 263);
            this.Controls.Add(this.lblMinValue);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lstNumberSet);
            this.Name = "FindMinValueForm";
            this.Text = "Find Min Value By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumberSet;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMinValue;
    }
}

