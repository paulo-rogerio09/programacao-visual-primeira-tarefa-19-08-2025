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
            this.metpquiTxt = new System.Windows.Forms.Button();
            this.quipmet = new System.Windows.Forms.Button();
            this.horpminTxt = new System.Windows.Forms.Button();
            this.minphor = new System.Windows.Forms.Button();
            this.hecpkm = new System.Windows.Forms.Button();
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
            // metpquiTxt
            // 
            this.metpquiTxt.Location = new System.Drawing.Point(49, 160);
            this.metpquiTxt.Name = "metpquiTxt";
            this.metpquiTxt.Size = new System.Drawing.Size(176, 23);
            this.metpquiTxt.TabIndex = 3;
            this.metpquiTxt.Text = "Converter Metros em Quilomeros";
            this.metpquiTxt.UseVisualStyleBackColor = true;
            this.metpquiTxt.Click += new System.EventHandler(this.metpquiTxt_Click);
            // 
            // quipmet
            // 
            this.quipmet.Location = new System.Drawing.Point(475, 160);
            this.quipmet.Name = "quipmet";
            this.quipmet.Size = new System.Drawing.Size(174, 23);
            this.quipmet.TabIndex = 4;
            this.quipmet.Text = "Converter Quilometres em Metros";
            this.quipmet.UseVisualStyleBackColor = true;
            this.quipmet.Click += new System.EventHandler(this.quipmet_Click);
            // 
            // horpminTxt
            // 
            this.horpminTxt.Location = new System.Drawing.Point(58, 239);
            this.horpminTxt.Name = "horpminTxt";
            this.horpminTxt.Size = new System.Drawing.Size(156, 23);
            this.horpminTxt.TabIndex = 5;
            this.horpminTxt.Text = "Converter Horas em Minutos";
            this.horpminTxt.UseVisualStyleBackColor = true;
            this.horpminTxt.Click += new System.EventHandler(this.horpminTxt_Click);
            // 
            // minphor
            // 
            this.minphor.Location = new System.Drawing.Point(477, 239);
            this.minphor.Name = "minphor";
            this.minphor.Size = new System.Drawing.Size(172, 23);
            this.minphor.TabIndex = 6;
            this.minphor.Text = "Converter Minutos em Horas";
            this.minphor.UseVisualStyleBackColor = true;
            this.minphor.Click += new System.EventHandler(this.minphor_Click);
            // 
            // hecpkm
            // 
            this.hecpkm.Location = new System.Drawing.Point(284, 310);
            this.hecpkm.Name = "hecpkm";
            this.hecpkm.Size = new System.Drawing.Size(152, 23);
            this.hecpkm.TabIndex = 7;
            this.hecpkm.Text = "Converter Hectares em Km²";
            this.hecpkm.UseVisualStyleBackColor = true;
            this.hecpkm.Click += new System.EventHandler(this.hecpkm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hecpkm);
            this.Controls.Add(this.minphor);
            this.Controls.Add(this.horpminTxt);
            this.Controls.Add(this.quipmet);
            this.Controls.Add(this.metpquiTxt);
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
        private System.Windows.Forms.Button metpquiTxt;
        private System.Windows.Forms.Button quipmet;
        private System.Windows.Forms.Button horpminTxt;
        private System.Windows.Forms.Button minphor;
        private System.Windows.Forms.Button hecpkm;
    }
}

