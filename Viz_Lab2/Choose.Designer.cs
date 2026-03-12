namespace Viz_Lab2
{
    partial class Choose
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
            ListViewItem listViewItem1 = new ListViewItem("Chleb");
            ListViewItem listViewItem2 = new ListViewItem("Mleko");
            ListViewItem listViewItem3 = new ListViewItem("Jabłka");
            ListViewItem listViewItem4 = new ListViewItem("Mięso");
            ListViewItem listViewItem5 = new ListViewItem("Jajka (x10)");
            ListViewItem listViewItem6 = new ListViewItem("Chipsy");
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listViewItem1.Tag = "10";
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(224, 138);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(12, 156);
            button1.Name = "button1";
            button1.Size = new Size(118, 58);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(118, 156);
            button2.Name = "button2";
            button2.Size = new Size(118, 58);
            button2.TabIndex = 2;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Choose
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 320);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Choose";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
    }
}