namespace Viz_Lab2
{
    partial class Pay
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            btnFinalizuj = new Button();
            lblDoZaplaty = new Label();
            SuspendLayout();
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(12, 12);
            rb1.Name = "rb1";
            rb1.Size = new Size(223, 24);
            rb1.TabIndex = 0;
            rb1.TabStop = true;
            rb1.Text = "Blik / Apple Pay / Google Pay";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(12, 42);
            rb2.Name = "rb2";
            rb2.Size = new Size(129, 24);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "Karta płatnicza";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(12, 72);
            rb3.Name = "rb3";
            rb3.Size = new Size(131, 24);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "Portfel (in App)";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(12, 102);
            rb4.Name = "rb4";
            rb4.Size = new Size(89, 24);
            rb4.TabIndex = 3;
            rb4.TabStop = true;
            rb4.Text = "Gotówka";
            rb4.UseVisualStyleBackColor = true;
            // 
            // btnFinalizuj
            // 
            btnFinalizuj.Location = new Point(178, 97);
            btnFinalizuj.Name = "btnFinalizuj";
            btnFinalizuj.Size = new Size(94, 29);
            btnFinalizuj.TabIndex = 4;
            btnFinalizuj.Text = "Zapłać";
            btnFinalizuj.UseVisualStyleBackColor = true;
            btnFinalizuj.Click += btnFinalizuj_Click;
            // 
            // lblDoZaplaty
            // 
            lblDoZaplaty.AutoSize = true;
            lblDoZaplaty.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDoZaplaty.Location = new Point(197, 72);
            lblDoZaplaty.Name = "lblDoZaplaty";
            lblDoZaplaty.Size = new Size(56, 20);
            lblDoZaplaty.TabIndex = 5;
            lblDoZaplaty.Text = "0.00 zł";
            lblDoZaplaty.Click += lblDoZaplaty_Click;
            // 
            // Pay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 147);
            Controls.Add(lblDoZaplaty);
            Controls.Add(btnFinalizuj);
            Controls.Add(rb4);
            Controls.Add(rb3);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Name = "Pay";
            Text = "Płatność";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Button btnFinalizuj;
        private System.Windows.Forms.Label lblDoZaplaty;
    }
}