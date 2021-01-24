namespace PixelAssignment
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
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.White;
            this.picBox1.Location = new System.Drawing.Point(-48, -48);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(899, 493);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            this.picBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox1_Paint);
            this.picBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseDown);
            this.picBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseMove);
            this.picBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(344, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(249, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Move Your Mouse Around\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(801, 390);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
    }
}

