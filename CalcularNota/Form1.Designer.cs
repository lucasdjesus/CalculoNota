namespace CalcularNota
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
            this.LblMensagem = new System.Windows.Forms.Label();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.Btnok = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMensagem
            // 
            this.LblMensagem.AutoSize = true;
            this.LblMensagem.Location = new System.Drawing.Point(87, 181);
            this.LblMensagem.Name = "LblMensagem";
            this.LblMensagem.Size = new System.Drawing.Size(59, 13);
            this.LblMensagem.TabIndex = 0;
            this.LblMensagem.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(152, 181);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(100, 20);
            this.txtMensagem.TabIndex = 1;
            // 
            // Btnok
            // 
            this.Btnok.Location = new System.Drawing.Point(168, 207);
            this.Btnok.Name = "Btnok";
            this.Btnok.Size = new System.Drawing.Size(75, 23);
            this.Btnok.TabIndex = 2;
            this.Btnok.Text = "Ok";
            this.Btnok.UseVisualStyleBackColor = true;
            this.Btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(249, 207);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(67, 23);
            this.Sair.TabIndex = 3;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 329);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Btnok);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.LblMensagem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMensagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button Btnok;
        private System.Windows.Forms.Button Sair;
    }
}

