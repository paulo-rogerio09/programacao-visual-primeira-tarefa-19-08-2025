namespace conversao.Formularios
{
    partial class FormHecEmKm
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
            this.hecTxt = new System.Windows.Forms.TextBox();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // novobtn
            // 
            this.novobtn.Location = new System.Drawing.Point(283, 203);
            this.novobtn.Name = "novobtn";
            this.novobtn.Size = new System.Drawing.Size(75, 23);
            this.novobtn.TabIndex = 21;
            this.novobtn.Text = "novo";
            this.novobtn.UseVisualStyleBackColor = true;
            this.novobtn.Click += new System.EventHandler(this.novobtn_Click);
            // 
            // converterBtn
            // 
            this.converterBtn.Location = new System.Drawing.Point(76, 203);
            this.converterBtn.Name = "converterBtn";
            this.converterBtn.Size = new System.Drawing.Size(75, 23);
            this.converterBtn.TabIndex = 20;
            this.converterBtn.Text = "converter";
            this.converterBtn.UseVisualStyleBackColor = true;
            this.converterBtn.Click += new System.EventHandler(this.converterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "valor convertido para km²";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "digite o valor de hectare para km²";
            // 
            // hecTxt
            // 
            this.hecTxt.Location = new System.Drawing.Point(66, 120);
            this.hecTxt.Name = "hecTxt";
            this.hecTxt.Size = new System.Drawing.Size(100, 20);
            this.hecTxt.TabIndex = 17;
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(66, 305);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(100, 20);
            this.kmTxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "CONVERTER  HECTARE PARA KM²";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormHecEmKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.novobtn);
            this.Controls.Add(this.converterBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hecTxt);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.label1);
            this.Name = "FormHecEmKm";
            this.Text = "FormHecEmKm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button novobtn;
        private System.Windows.Forms.Button converterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hecTxt;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.Label label1;
    }
}