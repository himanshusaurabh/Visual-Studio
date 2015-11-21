namespace MathQuiz
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
            this.timelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timelabel
            // 
            this.timelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelabel.Location = new System.Drawing.Point(132, 21);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(200, 30);
            this.timelabel.TabIndex = 0;
            this.timelabel.Text = "timelabel";
            this.timelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.timelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
    }
}

