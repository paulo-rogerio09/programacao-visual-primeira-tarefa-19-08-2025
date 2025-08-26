namespace conversao.Formularios
{
    partial class FormMetrosEmQuilometros
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
            this.novobtn = new System.Windows.Forms.Button();
            this.converterBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metrosTxt = new System.Windows.Forms.TextBox();
            this.quilometrosTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(283, 203);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 28;
            this.novobtn.Text = "novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // converterBtn
            // 
            this.converterBtn.Location = new System.Drawing.Point(76, 203);
            this.converterBtn.Name = "converterBtn";
            this.converterBtn.Size = new System.Drawing.Size(75, 23);
            this.converterBtn.TabIndex = 27;
            this.converterBtn.Text = "converter";
            this.converterBtn.UseVisualStyleBackColor = true;
            this.converterBtn.Click += new System.EventHandler(this.converterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "valor convertido em quilometros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "digite o valor em metros para quilometros";
            // 
            // metrosTxt
            // 
            this.metrosTxt.Location = new System.Drawing.Point(66, 120);
            this.metrosTxt.Name = "metrosTxt";
            this.metrosTxt.Size = new System.Drawing.Size(100, 20);
            this.metrosTxt.TabIndex = 24;
            // 
            // quilometrosTxt
            // 
            this.quilometrosTxt.Location = new System.Drawing.Point(66, 305);
            this.quilometrosTxt.Name = "quilometrosTxt";
            this.quilometrosTxt.Size = new System.Drawing.Size(100, 20);
            this.quilometrosTxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "CONVERTER  METROS EM QUILOMETROS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMetrosEmQuilometros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.converterBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metrosTxt);
            this.Controls.Add(this.quilometrosTxt);
            this.Controls.Add(this.label1);
            this.Name = "FormMetrosEmQuilometros";
            this.Text = "FormMetrosEmQuilometros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Button converterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metrosTxt;
        private System.Windows.Forms.TextBox quilometrosTxt;
        private System.Windows.Forms.Label label1;
    }
}