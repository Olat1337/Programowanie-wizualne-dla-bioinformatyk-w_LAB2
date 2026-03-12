namespace Viz_Lab2
{
    partial class Transport
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
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Rower";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 46);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(72, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Skuter";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 76);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Samochód";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 106);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(72, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Robot";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Transport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 147);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Transport";
            Text = "Transport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}