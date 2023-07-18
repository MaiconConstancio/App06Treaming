
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
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.TituloDoFilme = new System.Windows.Forms.Label();
            this.DescriçãoDoFilmeAqui = new System.Windows.Forms.Label();
            this.BotaoDoFilmeOuSerieAssistir = new Guna.UI2.WinForms.Guna2Button();
            this.wvVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // imgFundo
            // 
            this.imgFundo.Location = new System.Drawing.Point(-4, -4);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(809, 606);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFundo.TabIndex = 9;
            this.imgFundo.TabStop = false;
            // 
            // TituloDoFilme
            // 
            this.TituloDoFilme.AutoSize = true;
            this.TituloDoFilme.Location = new System.Drawing.Point(44, 232);
            this.TituloDoFilme.Name = "TituloDoFilme";
            this.TituloDoFilme.Size = new System.Drawing.Size(107, 13);
            this.TituloDoFilme.TabIndex = 11;
            this.TituloDoFilme.Text = "Descrição longa aqui";
            // 
            // DescriçãoDoFilmeAqui
            // 
            this.DescriçãoDoFilmeAqui.AutoSize = true;
            this.DescriçãoDoFilmeAqui.Location = new System.Drawing.Point(44, 323);
            this.DescriçãoDoFilmeAqui.MaximumSize = new System.Drawing.Size(700, 0);
            this.DescriçãoDoFilmeAqui.Name = "DescriçãoDoFilmeAqui";
            this.DescriçãoDoFilmeAqui.Size = new System.Drawing.Size(107, 13);
            this.DescriçãoDoFilmeAqui.TabIndex = 10;
            this.DescriçãoDoFilmeAqui.Text = "Descrição longa aqui";
            // 
            // BotaoDoFilmeOuSerieAssistir
            // 
            this.BotaoDoFilmeOuSerieAssistir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BotaoDoFilmeOuSerieAssistir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BotaoDoFilmeOuSerieAssistir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BotaoDoFilmeOuSerieAssistir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BotaoDoFilmeOuSerieAssistir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BotaoDoFilmeOuSerieAssistir.ForeColor = System.Drawing.Color.White;
            this.BotaoDoFilmeOuSerieAssistir.Location = new System.Drawing.Point(47, 269);
            this.BotaoDoFilmeOuSerieAssistir.Name = "BotaoDoFilmeOuSerieAssistir";
            this.BotaoDoFilmeOuSerieAssistir.Size = new System.Drawing.Size(180, 45);
            this.BotaoDoFilmeOuSerieAssistir.TabIndex = 13;
            this.BotaoDoFilmeOuSerieAssistir.Text = "Assistir";
            this.BotaoDoFilmeOuSerieAssistir.Click += new System.EventHandler(this.BotaoDoFilmeOuSerieAssistir_Click);
            // 
            // wvVideo
            // 
            this.wvVideo.AllowExternalDrop = true;
            this.wvVideo.CreationProperties = null;
            this.wvVideo.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVideo.Location = new System.Drawing.Point(-4, -4);
            this.wvVideo.Name = "wvVideo";
            this.wvVideo.Size = new System.Drawing.Size(809, 606);
            this.wvVideo.TabIndex = 14;
            this.wvVideo.Visible = false;
            this.wvVideo.ZoomFactor = 1D;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.wvVideo);
            this.Controls.Add(this.BotaoDoFilmeOuSerieAssistir);
            this.Controls.Add(this.TituloDoFilme);
            this.Controls.Add(this.DescriçãoDoFilmeAqui);
            this.Controls.Add(this.imgFundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.Label TituloDoFilme;
        private System.Windows.Forms.Label DescriçãoDoFilmeAqui;
        private Guna.UI2.WinForms.Guna2Button BotaoDoFilmeOuSerieAssistir;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVideo;
    }
}