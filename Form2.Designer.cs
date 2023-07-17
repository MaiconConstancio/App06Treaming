
namespace App06Treaming
{
    partial class Form2
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
            this.DescriçãoDoFilmeAqui = new System.Windows.Forms.Label();
            this.TituloDoFilme = new System.Windows.Forms.Label();
            this.BotaoDoFilmeOuSerieAssistir = new System.Windows.Forms.Button();
            this.ImagemDeFundo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemDeFundo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriçãoDoFilmeAqui
            // 
            this.DescriçãoDoFilmeAqui.AutoSize = true;
            this.DescriçãoDoFilmeAqui.Location = new System.Drawing.Point(51, 311);
            this.DescriçãoDoFilmeAqui.Name = "DescriçãoDoFilmeAqui";
            this.DescriçãoDoFilmeAqui.Size = new System.Drawing.Size(107, 13);
            this.DescriçãoDoFilmeAqui.TabIndex = 2;
            this.DescriçãoDoFilmeAqui.Text = "Descrição longa aqui";
            // 
            // TituloDoFilme
            // 
            this.TituloDoFilme.AutoSize = true;
            this.TituloDoFilme.Location = new System.Drawing.Point(51, 226);
            this.TituloDoFilme.Name = "TituloDoFilme";
            this.TituloDoFilme.Size = new System.Drawing.Size(107, 13);
            this.TituloDoFilme.TabIndex = 3;
            this.TituloDoFilme.Text = "Descrição longa aqui";
            // 
            // BotaoDoFilmeOuSerieAssistir
            // 
            this.BotaoDoFilmeOuSerieAssistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoDoFilmeOuSerieAssistir.Location = new System.Drawing.Point(54, 273);
            this.BotaoDoFilmeOuSerieAssistir.Name = "BotaoDoFilmeOuSerieAssistir";
            this.BotaoDoFilmeOuSerieAssistir.Size = new System.Drawing.Size(75, 25);
            this.BotaoDoFilmeOuSerieAssistir.TabIndex = 4;
            this.BotaoDoFilmeOuSerieAssistir.Text = "Assistir";
            this.BotaoDoFilmeOuSerieAssistir.UseVisualStyleBackColor = true;
            // 
            // ImagemDeFundo
            // 
            this.ImagemDeFundo.Image = global::App06Treaming.Properties.Resources.fundomulan;
            this.ImagemDeFundo.Location = new System.Drawing.Point(-3, -2);
            this.ImagemDeFundo.Name = "ImagemDeFundo";
            this.ImagemDeFundo.Size = new System.Drawing.Size(806, 454);
            this.ImagemDeFundo.TabIndex = 0;
            this.ImagemDeFundo.TabStop = false;
            this.ImagemDeFundo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BotaoDoFilmeOuSerieAssistir);
            this.panel1.Controls.Add(this.TituloDoFilme);
            this.panel1.Controls.Add(this.DescriçãoDoFilmeAqui);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 599);
            this.panel1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ImagemDeFundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImagemDeFundo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImagemDeFundo;
        private System.Windows.Forms.Label DescriçãoDoFilmeAqui;
        private System.Windows.Forms.Label TituloDoFilme;
        private System.Windows.Forms.Button BotaoDoFilmeOuSerieAssistir;
        private System.Windows.Forms.Panel panel1;
    }
}