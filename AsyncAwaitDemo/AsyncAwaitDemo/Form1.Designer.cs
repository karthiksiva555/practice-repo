namespace AsyncAwaitDemo
{
    partial class Form1
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
            this.btnCalculateSum = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculateSum
            // 
            this.btnCalculateSum.Location = new System.Drawing.Point(215, 178);
            this.btnCalculateSum.Name = "btnCalculateSum";
            this.btnCalculateSum.Size = new System.Drawing.Size(161, 41);
            this.btnCalculateSum.TabIndex = 0;
            this.btnCalculateSum.Text = "Calculate Sum";
            this.btnCalculateSum.UseVisualStyleBackColor = true;
            this.btnCalculateSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(41, 305);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 1;
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Location = new System.Drawing.Point(27, 67);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(158, 17);
            this.lblOperand1.TabIndex = 2;
            this.lblOperand1.Text = "Enter the Lower Range:";
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Location = new System.Drawing.Point(27, 121);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(162, 17);
            this.lblOperand2.TabIndex = 3;
            this.lblOperand2.Text = "Enter the Higher Range:";
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(215, 67);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(203, 22);
            this.txtOperand1.TabIndex = 4;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(215, 121);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(203, 22);
            this.txtOperand2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 358);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperand1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculateSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateSum;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
    }
}

