namespace conversao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btHecParaAlqu = new System.Windows.Forms.Button();
            this.btAlquParaHec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btHecParaAlqu
            // 
            this.btHecParaAlqu.Location = new System.Drawing.Point(69, 83);
            this.btHecParaAlqu.Name = "btHecParaAlqu";
            this.btHecParaAlqu.Size = new System.Drawing.Size(136, 23);
            this.btHecParaAlqu.TabIndex = 1;
            this.btHecParaAlqu.Text = "Converter Hec Para Alqu";
            this.btHecParaAlqu.UseVisualStyleBackColor = true;
            this.btHecParaAlqu.Click += new System.EventHandler(this.btHecParaAlqu_Click);
            // 
            // btAlquParaHec
            // 
            this.btAlquParaHec.Location = new System.Drawing.Point(494, 83);
            this.btAlquParaHec.Name = "btAlquParaHec";
            this.btAlquParaHec.Size = new System.Drawing.Size(146, 23);
            this.btAlquParaHec.TabIndex = 2;
            this.btAlquParaHec.Text = "converter Alqu Para Hec";
            this.btAlquParaHec.UseVisualStyleBackColor = true;
            this.btAlquParaHec.Click += new System.EventHandler(this.btAlquParaHec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAlquParaHec);
            this.Controls.Add(this.btHecParaAlqu);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHecParaAlqu;
        private System.Windows.Forms.Button btAlquParaHec;
    }
}

