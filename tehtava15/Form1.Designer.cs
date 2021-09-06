namespace tehtava15
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aika_label1 = new System.Windows.Forms.Label();
            this.kaynista_button1 = new System.Windows.Forms.Button();
            this.pysayta_button1 = new System.Windows.Forms.Button();
            this.uudeleen_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // aika_label1
            // 
            this.aika_label1.AutoSize = true;
            this.aika_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aika_label1.Location = new System.Drawing.Point(40, 22);
            this.aika_label1.Name = "aika_label1";
            this.aika_label1.Size = new System.Drawing.Size(603, 108);
            this.aika_label1.TabIndex = 0;
            this.aika_label1.Text = "00:00:00.000";
            // 
            // kaynista_button1
            // 
            this.kaynista_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaynista_button1.Location = new System.Drawing.Point(58, 134);
            this.kaynista_button1.Name = "kaynista_button1";
            this.kaynista_button1.Size = new System.Drawing.Size(148, 45);
            this.kaynista_button1.TabIndex = 1;
            this.kaynista_button1.Text = "Start";
            this.kaynista_button1.UseVisualStyleBackColor = true;
            this.kaynista_button1.Click += new System.EventHandler(this.kaynista_button1_Click);
            // 
            // pysayta_button1
            // 
            this.pysayta_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pysayta_button1.Location = new System.Drawing.Point(266, 133);
            this.pysayta_button1.Name = "pysayta_button1";
            this.pysayta_button1.Size = new System.Drawing.Size(141, 45);
            this.pysayta_button1.TabIndex = 2;
            this.pysayta_button1.Text = "Stop";
            this.pysayta_button1.UseVisualStyleBackColor = true;
            this.pysayta_button1.Click += new System.EventHandler(this.pysayta_button1_Click);
            // 
            // uudeleen_button1
            // 
            this.uudeleen_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uudeleen_button1.Location = new System.Drawing.Point(463, 133);
            this.uudeleen_button1.Name = "uudeleen_button1";
            this.uudeleen_button1.Size = new System.Drawing.Size(147, 45);
            this.uudeleen_button1.TabIndex = 3;
            this.uudeleen_button1.Text = "Reset";
            this.uudeleen_button1.UseVisualStyleBackColor = true;
            this.uudeleen_button1.Click += new System.EventHandler(this.uudeleen_button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 225);
            this.Controls.Add(this.uudeleen_button1);
            this.Controls.Add(this.pysayta_button1);
            this.Controls.Add(this.kaynista_button1);
            this.Controls.Add(this.aika_label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label aika_label1;
        private System.Windows.Forms.Button kaynista_button1;
        private System.Windows.Forms.Button pysayta_button1;
        private System.Windows.Forms.Button uudeleen_button1;
    }
}

