namespace adventureSummative
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
            this.optionButton1 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.optionButton2 = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.optionOutput1 = new System.Windows.Forms.Label();
            this.optionOutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionButton1
            // 
            this.optionButton1.Location = new System.Drawing.Point(143, 287);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(84, 45);
            this.optionButton1.TabIndex = 0;
            this.optionButton1.Text = "option1";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(100, 73);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 19);
            this.outputLabel.TabIndex = 1;
            // 
            // optionButton2
            // 
            this.optionButton2.Location = new System.Drawing.Point(143, 352);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(84, 45);
            this.optionButton2.TabIndex = 2;
            this.optionButton2.Text = "option2";
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Cascadia Code SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(303, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(204, 28);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "An Odd Adventure";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // optionOutput1
            // 
            this.optionOutput1.AutoSize = true;
            this.optionOutput1.Location = new System.Drawing.Point(253, 303);
            this.optionOutput1.Name = "optionOutput1";
            this.optionOutput1.Size = new System.Drawing.Size(78, 13);
            this.optionOutput1.TabIndex = 4;
            this.optionOutput1.Text = "option output 1";
            // 
            // optionOutput2
            // 
            this.optionOutput2.AutoSize = true;
            this.optionOutput2.Location = new System.Drawing.Point(253, 368);
            this.optionOutput2.Name = "optionOutput2";
            this.optionOutput2.Size = new System.Drawing.Size(78, 13);
            this.optionOutput2.TabIndex = 5;
            this.optionOutput2.Text = "option output 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionOutput2);
            this.Controls.Add(this.optionOutput1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.optionButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button optionButton1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button optionButton2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label optionOutput1;
        private System.Windows.Forms.Label optionOutput2;
    }
}

