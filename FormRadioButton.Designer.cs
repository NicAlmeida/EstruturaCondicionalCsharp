namespace ProjetoEstruturaCondicional
{
    partial class FormRadioButton
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
            this.btnEscollher = new System.Windows.Forms.Button();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbCsharp = new System.Windows.Forms.RadioButton();
            this.rbPHP = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEscollher
            // 
            this.btnEscollher.Location = new System.Drawing.Point(178, 225);
            this.btnEscollher.Name = "btnEscollher";
            this.btnEscollher.Size = new System.Drawing.Size(75, 23);
            this.btnEscollher.TabIndex = 20;
            this.btnEscollher.Text = "Escolher";
            this.btnEscollher.UseVisualStyleBackColor = true;
            this.btnEscollher.Click += new System.EventHandler(this.btnEscollher_Click);
            // 
            // txtResposta
            // 
            this.txtResposta.Location = new System.Drawing.Point(199, 91);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(100, 20);
            this.txtResposta.TabIndex = 19;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(107, 94);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(58, 13);
            this.lblResposta.TabIndex = 18;
            this.lblResposta.Text = "Resposta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Exemplo RadioButton";
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Location = new System.Drawing.Point(80, 158);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(48, 17);
            this.rbJava.TabIndex = 15;
            this.rbJava.TabStop = true;
            this.rbJava.Text = "Java";
            this.rbJava.UseVisualStyleBackColor = true;
            // 
            // rbCsharp
            // 
            this.rbCsharp.AutoSize = true;
            this.rbCsharp.Location = new System.Drawing.Point(189, 158);
            this.rbCsharp.Name = "rbCsharp";
            this.rbCsharp.Size = new System.Drawing.Size(39, 17);
            this.rbCsharp.TabIndex = 16;
            this.rbCsharp.TabStop = true;
            this.rbCsharp.Text = "C#";
            this.rbCsharp.UseVisualStyleBackColor = true;
            // 
            // rbPHP
            // 
            this.rbPHP.AutoSize = true;
            this.rbPHP.Location = new System.Drawing.Point(290, 158);
            this.rbPHP.Name = "rbPHP";
            this.rbPHP.Size = new System.Drawing.Size(47, 17);
            this.rbPHP.TabIndex = 17;
            this.rbPHP.TabStop = true;
            this.rbPHP.Text = "PHP";
            this.rbPHP.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Resposta: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // FormLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 303);
            this.Controls.Add(this.btnEscollher);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.rbPHP);
            this.Controls.Add(this.rbCsharp);
            this.Controls.Add(this.rbJava);
            this.Controls.Add(this.label1);
            this.Name = "FormLanguage";
            this.Text = "FormLanguage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEscollher;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbCsharp;
        private System.Windows.Forms.RadioButton rbPHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}