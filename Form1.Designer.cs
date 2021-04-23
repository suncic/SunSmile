
namespace SunSmile
{
    partial class f1
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
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(24, 31);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(183, 52);
            this.b1.TabIndex = 0;
            this.b1.Text = "Zakazivanje";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(24, 127);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(183, 51);
            this.b2.TabIndex = 1;
            this.b2.Text = "Kalendar";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(24, 223);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(183, 51);
            this.b3.TabIndex = 2;
            this.b3.Text = "Stomatolozi";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(24, 320);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(183, 51);
            this.b4.TabIndex = 3;
            this.b4.Text = "Tretmani";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // pnl1
            // 
            this.pnl1.Location = new System.Drawing.Point(367, 31);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(336, 339);
            this.pnl1.TabIndex = 4;
            // 
            // f1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "f1";
            this.Text = "SunSmile";
            this.Load += new System.EventHandler(this.f1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Panel pnl1;
    }
}

