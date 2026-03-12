namespace Viz_Lab2
{
    partial class Zamów_jedzenie
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
            listView1 = new ListView();
            lblSuma = new Label();
            btnOpenChoose = new Button();
            btnOpenTransport = new Button();
            btnOpenPay = new Button();
            lblTransportStatus = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(227, 259);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSuma.Location = new Point(260, 10);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(93, 23);
            lblSuma.TabIndex = 1;
            lblSuma.Text = "Suma: 0 zł";
            // 
            // btnOpenChoose
            // 
            btnOpenChoose.Location = new Point(260, 85);
            btnOpenChoose.Name = "btnOpenChoose";
            btnOpenChoose.Size = new Size(150, 41);
            btnOpenChoose.TabIndex = 2;
            btnOpenChoose.Text = "Wybierz produkt";
            btnOpenChoose.UseVisualStyleBackColor = true;
            btnOpenChoose.Click += button1_Click;
            // 
            // btnOpenTransport
            // 
            btnOpenTransport.Location = new Point(260, 146);
            btnOpenTransport.Name = "btnOpenTransport";
            btnOpenTransport.Size = new Size(150, 41);
            btnOpenTransport.TabIndex = 3;
            btnOpenTransport.Text = "Transport";
            btnOpenTransport.UseVisualStyleBackColor = true;
            btnOpenTransport.Click += button2_Click;
            // 
            // btnOpenPay
            // 
            btnOpenPay.Location = new Point(260, 213);
            btnOpenPay.Name = "btnOpenPay";
            btnOpenPay.Size = new Size(150, 41);
            btnOpenPay.TabIndex = 4;
            btnOpenPay.Text = "Zapłać";
            btnOpenPay.UseVisualStyleBackColor = true;
            btnOpenPay.Click += btnOpenPay_Click;
            // 
            // lblTransportStatus
            // 
            lblTransportStatus.AutoSize = true;
            lblTransportStatus.Location = new Point(260, 31);
            lblTransportStatus.Name = "lblTransportStatus";
            lblTransportStatus.Size = new Size(96, 20);
            lblTransportStatus.TabIndex = 5;
            lblTransportStatus.Text = "Transport: ---";
            // 
            // Zamów_jedzenie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 285);
            Controls.Add(lblTransportStatus);
            Controls.Add(btnOpenPay);
            Controls.Add(btnOpenTransport);
            Controls.Add(btnOpenChoose);
            Controls.Add(lblSuma);
            Controls.Add(listView1);
            Name = "Zamów_jedzenie";
            Text = "Koszyk zamówień";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Button btnOpenChoose;
        private System.Windows.Forms.Button btnOpenTransport;
        private System.Windows.Forms.Button btnOpenPay;
        private System.Windows.Forms.Label lblTransportStatus;
    }
}