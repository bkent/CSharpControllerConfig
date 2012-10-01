namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ApplyButton = new System.Windows.Forms.Button();
            this.NewIP = new System.Windows.Forms.TextBox();
            this.NewSN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewGW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DefaultIP = new System.Windows.Forms.TextBox();
            this.DefaultSN = new System.Windows.Forms.TextBox();
            this.DefaultGW = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RebButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(12, 202);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // NewIP
            // 
            this.NewIP.Location = new System.Drawing.Point(104, 122);
            this.NewIP.Name = "NewIP";
            this.NewIP.Size = new System.Drawing.Size(168, 20);
            this.NewIP.TabIndex = 1;
            // 
            // NewSN
            // 
            this.NewSN.Location = new System.Drawing.Point(104, 148);
            this.NewSN.Name = "NewSN";
            this.NewSN.Size = new System.Drawing.Size(168, 20);
            this.NewSN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Settings";
            // 
            // NewGW
            // 
            this.NewGW.Location = new System.Drawing.Point(104, 176);
            this.NewGW.Name = "NewGW";
            this.NewGW.Size = new System.Drawing.Size(168, 20);
            this.NewGW.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "New Subnet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "New Gateway";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "IP Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subnet Mask";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Default Gateway";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(197, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DefaultIP
            // 
            this.DefaultIP.Location = new System.Drawing.Point(104, 22);
            this.DefaultIP.Name = "DefaultIP";
            this.DefaultIP.Size = new System.Drawing.Size(168, 20);
            this.DefaultIP.TabIndex = 16;
            // 
            // DefaultSN
            // 
            this.DefaultSN.Location = new System.Drawing.Point(104, 45);
            this.DefaultSN.Name = "DefaultSN";
            this.DefaultSN.Size = new System.Drawing.Size(168, 20);
            this.DefaultSN.TabIndex = 17;
            // 
            // DefaultGW
            // 
            this.DefaultGW.Location = new System.Drawing.Point(104, 70);
            this.DefaultGW.Name = "DefaultGW";
            this.DefaultGW.Size = new System.Drawing.Size(168, 20);
            this.DefaultGW.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "New Settings";
            // 
            // RebButton
            // 
            this.RebButton.Location = new System.Drawing.Point(104, 202);
            this.RebButton.Name = "RebButton";
            this.RebButton.Size = new System.Drawing.Size(75, 23);
            this.RebButton.TabIndex = 20;
            this.RebButton.Text = "Reboot";
            this.RebButton.UseVisualStyleBackColor = true;
            this.RebButton.Click += new System.EventHandler(this.RebButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 230);
            this.Controls.Add(this.RebButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DefaultGW);
            this.Controls.Add(this.DefaultSN);
            this.Controls.Add(this.DefaultIP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewGW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewSN);
            this.Controls.Add(this.NewIP);
            this.Controls.Add(this.ApplyButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CSharpCConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.TextBox NewIP;
        private System.Windows.Forms.TextBox NewSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewGW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox DefaultIP;
        private System.Windows.Forms.TextBox DefaultSN;
        private System.Windows.Forms.TextBox DefaultGW;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RebButton;
    }
}

