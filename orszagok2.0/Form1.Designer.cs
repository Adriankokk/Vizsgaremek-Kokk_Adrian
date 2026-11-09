namespace orszagok2._0
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
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtFovaros = new System.Windows.Forms.TextBox();
            this.txtKereses = new System.Windows.Forms.TextBox();
            this.txtLakossag = new System.Windows.Forms.TextBox();
            this.dgvOrszagok = new System.Windows.Forms.DataGridView();
            this.btnHozzaadas = new System.Windows.Forms.Button();
            this.btnBeolvasas = new System.Windows.Forms.Button();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnRendezes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrszagok)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(124, 73);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 0;
            this.txtOrszag.Text = "Ország";
            // 
            // txtFovaros
            // 
            this.txtFovaros.Location = new System.Drawing.Point(124, 132);
            this.txtFovaros.Name = "txtFovaros";
            this.txtFovaros.Size = new System.Drawing.Size(100, 20);
            this.txtFovaros.TabIndex = 1;
            this.txtFovaros.Text = "Főváros";
            // 
            // txtKereses
            // 
            this.txtKereses.Location = new System.Drawing.Point(124, 233);
            this.txtKereses.Name = "txtKereses";
            this.txtKereses.Size = new System.Drawing.Size(100, 20);
            this.txtKereses.TabIndex = 2;
            this.txtKereses.Text = "Keresés";
            // 
            // txtLakossag
            // 
            this.txtLakossag.Location = new System.Drawing.Point(124, 184);
            this.txtLakossag.Name = "txtLakossag";
            this.txtLakossag.Size = new System.Drawing.Size(100, 20);
            this.txtLakossag.TabIndex = 3;
            this.txtLakossag.Text = "Lakosság";
            // 
            // dgvOrszagok
            // 
            this.dgvOrszagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrszagok.Location = new System.Drawing.Point(124, 295);
            this.dgvOrszagok.Name = "dgvOrszagok";
            this.dgvOrszagok.Size = new System.Drawing.Size(155, 74);
            this.dgvOrszagok.TabIndex = 4;
            // 
            // btnHozzaadas
            // 
            this.btnHozzaadas.Location = new System.Drawing.Point(474, 71);
            this.btnHozzaadas.Name = "btnHozzaadas";
            this.btnHozzaadas.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaadas.TabIndex = 5;
            this.btnHozzaadas.Text = "Hozzáadás";
            this.btnHozzaadas.UseVisualStyleBackColor = true;
            // 
            // btnBeolvasas
            // 
            this.btnBeolvasas.Location = new System.Drawing.Point(474, 132);
            this.btnBeolvasas.Name = "btnBeolvasas";
            this.btnBeolvasas.Size = new System.Drawing.Size(75, 23);
            this.btnBeolvasas.TabIndex = 6;
            this.btnBeolvasas.Text = "Beolvasás";
            this.btnBeolvasas.UseVisualStyleBackColor = true;
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(474, 184);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(75, 23);
            this.btnKereses.TabIndex = 7;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            // 
            // btnRendezes
            // 
            this.btnRendezes.Location = new System.Drawing.Point(474, 233);
            this.btnRendezes.Name = "btnRendezes";
            this.btnRendezes.Size = new System.Drawing.Size(75, 23);
            this.btnRendezes.TabIndex = 8;
            this.btnRendezes.Text = "Rendezés";
            this.btnRendezes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 630);
            this.Controls.Add(this.btnRendezes);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnBeolvasas);
            this.Controls.Add(this.btnHozzaadas);
            this.Controls.Add(this.txtLakossag);
            this.Controls.Add(this.txtKereses);
            this.Controls.Add(this.txtFovaros);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.dgvOrszagok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrszagok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtFovaros;
        private System.Windows.Forms.TextBox txtKereses;
        private System.Windows.Forms.TextBox txtLakossag;
        private System.Windows.Forms.DataGridView dgvOrszagok;
        private System.Windows.Forms.Button btnHozzaadas;
        private System.Windows.Forms.Button btnBeolvasas;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnRendezes;
    }
}

