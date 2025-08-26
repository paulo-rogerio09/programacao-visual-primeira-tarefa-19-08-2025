namespace conversao.Formularios
{
    partial class FormAlqParaHec
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
            this.label1 = new System.Windows.Forms.Label();
            this.alqTxt = new System.Windows.Forms.TextBox();
            this.hecTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.converterBtn = new System.Windows.Forms.Button();
            this.novobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONVERTER ALQUEIRE PARA HECTARE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alqTxt
            // 
            this.alqTxt.Location = new System.Drawing.Point(76, 161);
            this.alqTxt.Name = "alqTxt";
            this.alqTxt.Size = new System.Drawing.Size(100, 20);
            this.alqTxt.TabIndex = 2;
            // 
            // hecTxt
            // 
            this.hecTxt.Location = new System.Drawing.Point(76, 280);
            this.hecTxt.Name = "hecTxt";
            this.hecTxt.Size = new System.Drawing.Size(100, 20);
            this.hecTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "digite o valor de alqueire para hectare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "valor convertido para hectare";
            // 
            // converterBtn
            // 
            this.converterBtn.Location = new System.Drawing.Point(76, 218);
            this.converterBtn.Name = "converterBtn";
            this.converterBtn.Size = new System.Drawing.Size(75, 23);
            this.converterBtn.TabIndex = 6;
            this.converterBtn.Text = "converter";
            this.converterBtn.UseVisualStyleBackColor = true;
            this.converterBtn.Click += new System.EventHandler(this.converterBtn_Click);
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(283, 218);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 7;
            this.novobtn.Text = "novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // FormAlqParaHec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.converterBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hecTxt);
            this.Controls.Add(this.alqTxt);
            this.Controls.Add(this.label1);
            this.Name = "FormAlqParaHec";
            this.Text = "FormAlqParaHec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alqTxt;
        private System.Windows.Forms.TextBox hecTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button converterBtn;
        private System.Windows.Forms.Button novobtn;
    }
}