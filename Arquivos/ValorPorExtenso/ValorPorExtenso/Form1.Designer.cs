namespace ValorPorExtenso
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExtenso = new System.Windows.Forms.Button();
            this.txtExtenso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(31, 44);
            this.txtValor.Name = "txtValor";
            this.txtValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtValor.Size = new System.Drawing.Size(408, 22);
            this.txtValor.TabIndex = 0;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o valor em  Reais";
            // 
            // btnExtenso
            // 
            this.btnExtenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtenso.Location = new System.Drawing.Point(31, 70);
            this.btnExtenso.Name = "btnExtenso";
            this.btnExtenso.Size = new System.Drawing.Size(150, 35);
            this.btnExtenso.TabIndex = 2;
            this.btnExtenso.Text = "Valor Por Extenso";
            this.btnExtenso.UseVisualStyleBackColor = true;
            this.btnExtenso.Click += new System.EventHandler(this.btnExtenso_Click);
            // 
            // txtExtenso
            // 
            this.txtExtenso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtenso.Location = new System.Drawing.Point(31, 111);
            this.txtExtenso.Multiline = true;
            this.txtExtenso.Name = "txtExtenso";
            this.txtExtenso.Size = new System.Drawing.Size(408, 203);
            this.txtExtenso.TabIndex = 3;
            this.txtExtenso.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(463, 333);
            this.Controls.Add(this.txtExtenso);
            this.Controls.Add(this.btnExtenso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Valores por Extenso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExtenso;
        private System.Windows.Forms.TextBox txtExtenso;
    }
}

