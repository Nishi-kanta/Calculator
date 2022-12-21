namespace calculator_performance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.substractbutton = new System.Windows.Forms.Button();
            this.divisionbutton = new System.Windows.Forms.Button();
            this.multibutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIRST NUMBER:-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SECOND NUMBER:-";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(290, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 25);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBox2.Location = new System.Drawing.Point(290, 175);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(273, 21);
            this.textBox2.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.DeepPink;
            this.addButton.Location = new System.Drawing.Point(43, 294);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 43);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADDITION";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // substractbutton
            // 
            this.substractbutton.BackColor = System.Drawing.Color.Turquoise;
            this.substractbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.substractbutton.ForeColor = System.Drawing.Color.Fuchsia;
            this.substractbutton.Location = new System.Drawing.Point(235, 294);
            this.substractbutton.Name = "substractbutton";
            this.substractbutton.Size = new System.Drawing.Size(148, 43);
            this.substractbutton.TabIndex = 5;
            this.substractbutton.Text = "SUBSTRACTION";
            this.substractbutton.UseVisualStyleBackColor = false;
            this.substractbutton.Click += new System.EventHandler(this.substractbutton_Click);
            // 
            // divisionbutton
            // 
            this.divisionbutton.BackColor = System.Drawing.Color.DarkBlue;
            this.divisionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisionbutton.ForeColor = System.Drawing.Color.Yellow;
            this.divisionbutton.Location = new System.Drawing.Point(676, 294);
            this.divisionbutton.Name = "divisionbutton";
            this.divisionbutton.Size = new System.Drawing.Size(188, 43);
            this.divisionbutton.TabIndex = 6;
            this.divisionbutton.Text = "DIVISION";
            this.divisionbutton.UseVisualStyleBackColor = false;
            this.divisionbutton.Click += new System.EventHandler(this.divisionbutton_Click);
            // 
            // multibutton
            // 
            this.multibutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.multibutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multibutton.ForeColor = System.Drawing.Color.DarkOrange;
            this.multibutton.Location = new System.Drawing.Point(426, 294);
            this.multibutton.Name = "multibutton";
            this.multibutton.Size = new System.Drawing.Size(205, 43);
            this.multibutton.TabIndex = 7;
            this.multibutton.Text = "MULTIPLICATION";
            this.multibutton.UseVisualStyleBackColor = false;
            this.multibutton.Click += new System.EventHandler(this.multibutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(419, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "-: MY  CALCULATOR:-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Fuchsia;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(723, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.multibutton);
            this.Controls.Add(this.divisionbutton);
            this.Controls.Add(this.substractbutton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CALCULATOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button substractbutton;
        private System.Windows.Forms.Button divisionbutton;
        private System.Windows.Forms.Button multibutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

