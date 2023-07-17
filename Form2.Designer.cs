
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DescriçãoDoFilmeAqui = new System.Windows.Forms.Label();
            this.TituloDoFilme = new System.Windows.Forms.Label();
            this.BotaoDoFilmeOuSerieAssistir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 454);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotaoDoFilmeOuSerieAssistir);
            this.Controls.Add(this.TituloDoFilme);
            this.Controls.Add(this.DescriçãoDoFilmeAqui);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DescriçãoDoFilmeAqui;
        private System.Windows.Forms.Label TituloDoFilme;
        private System.Windows.Forms.Button BotaoDoFilmeOuSerieAssistir;
    }
}