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
            this.extraButton = new System.Windows.Forms.Button();
            this.extraOutput = new System.Windows.Forms.Label();
            this.background3 = new System.Windows.Forms.PictureBox();
            this.background2 = new System.Windows.Forms.PictureBox();
            this.background1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).BeginInit();
            this.SuspendLayout();
            // 
            // optionButton1
            // 
            this.optionButton1.Location = new System.Drawing.Point(143, 271);
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(84, 45);
            this.optionButton1.TabIndex = 0;
            this.optionButton1.Text = "Start";
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(21, 59);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(351, 19);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "Press start if you would like to play!";
            // 
            // optionButton2
            // 
            this.optionButton2.Location = new System.Drawing.Point(143, 336);
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(84, 45);
            this.optionButton2.TabIndex = 2;
            this.optionButton2.Text = "Don\'t Start";
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
            // 
            // optionOutput1
            // 
            this.optionOutput1.AutoSize = true;
            this.optionOutput1.Location = new System.Drawing.Point(253, 287);
            this.optionOutput1.Name = "optionOutput1";
            this.optionOutput1.Size = new System.Drawing.Size(0, 13);
            this.optionOutput1.TabIndex = 4;
            this.optionOutput1.Click += new System.EventHandler(this.optionOutput1_Click);
            // 
            // optionOutput2
            // 
            this.optionOutput2.AutoSize = true;
            this.optionOutput2.Location = new System.Drawing.Point(253, 352);
            this.optionOutput2.Name = "optionOutput2";
            this.optionOutput2.Size = new System.Drawing.Size(0, 13);
            this.optionOutput2.TabIndex = 5;
            this.optionOutput2.Click += new System.EventHandler(this.optionOutput2_Click);
            // 
            // extraButton
            // 
            this.extraButton.Location = new System.Drawing.Point(143, 393);
            this.extraButton.Name = "extraButton";
            this.extraButton.Size = new System.Drawing.Size(84, 45);
            this.extraButton.TabIndex = 6;
            this.extraButton.UseVisualStyleBackColor = true;
            this.extraButton.Click += new System.EventHandler(this.extraButton_Click);
            // 
            // extraOutput
            // 
            this.extraOutput.AutoSize = true;
            this.extraOutput.Location = new System.Drawing.Point(253, 409);
            this.extraOutput.Name = "extraOutput";
            this.extraOutput.Size = new System.Drawing.Size(0, 13);
            this.extraOutput.TabIndex = 7;
            this.extraOutput.Click += new System.EventHandler(this.extraOutput_Click);
            // 
            // background3
            // 
            this.background3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.background3.Location = new System.Drawing.Point(127, 261);
            this.background3.Name = "background3";
            this.background3.Size = new System.Drawing.Size(396, 188);
            this.background3.TabIndex = 8;
            this.background3.TabStop = false;
            this.background3.Click += new System.EventHandler(this.background3_Click);
            // 
            // background2
            // 
            this.background2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.background2.Location = new System.Drawing.Point(12, 50);
            this.background2.Name = "background2";
            this.background2.Size = new System.Drawing.Size(776, 188);
            this.background2.TabIndex = 9;
            this.background2.TabStop = false;
            // 
            // background1
            // 
            this.background1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.background1.Location = new System.Drawing.Point(290, 2);
            this.background1.Name = "background1";
            this.background1.Size = new System.Drawing.Size(233, 42);
            this.background1.TabIndex = 10;
            this.background1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.optionButton1);
            this.Controls.Add(this.optionOutput1);
            this.Controls.Add(this.optionOutput2);
            this.Controls.Add(this.extraOutput);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.background1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.background2);
            this.Controls.Add(this.extraButton);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.background3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.background3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background1)).EndInit();
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
        private System.Windows.Forms.Button extraButton;
        private System.Windows.Forms.Label extraOutput;
        private System.Windows.Forms.PictureBox background3;
        private System.Windows.Forms.PictureBox background2;
        private System.Windows.Forms.PictureBox background1;
    }
}

