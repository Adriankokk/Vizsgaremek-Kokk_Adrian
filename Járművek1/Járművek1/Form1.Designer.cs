using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Járművek1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lbleredmeny = new Label();
            txtev = new TextBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(145, 496);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(145, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "btnBeolvas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(145, 194);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "btnRendez";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(145, 276);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "btLegregebbi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(145, 341);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "btnLegujabb";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(145, 409);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "btnKeres";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lbleredmeny
            // 
            lbleredmeny.AutoSize = true;
            lbleredmeny.Location = new Point(394, 496);
            lbleredmeny.Name = "lbleredmeny";
            lbleredmeny.Size = new Size(73, 15);
            lbleredmeny.TabIndex = 6;
            lbleredmeny.Text = "lblEredmeny";
            // 
            // txtev
            // 
            txtev.Location = new Point(394, 123);
            txtev.Name = "txtev";
            txtev.Size = new Size(100, 23);
            txtev.TabIndex = 7;
            txtev.Text = "txtEv";
            // 
            // Form1
            // 
            ClientSize = new Size(1265, 650);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(lbleredmeny);
            Controls.Add(txtev);
            Name = "Form1";
            Text = "Járművek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lbleredmeny;
        private TextBox txtev;
    }
}
