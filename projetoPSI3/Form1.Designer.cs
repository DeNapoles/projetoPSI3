namespace projetoPSI3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Titulo1 = new System.Windows.Forms.Label();
            this.btnjogo1 = new System.Windows.Forms.Button();
            this.btnjogo2 = new System.Windows.Forms.Button();
            this.btnjogo3 = new System.Windows.Forms.Button();
            this.btnequipa1 = new System.Windows.Forms.Button();
            this.btnequipa2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo1
            // 
            this.Titulo1.AutoSize = true;
            this.Titulo1.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Titulo1.Location = new System.Drawing.Point(266, 9);
            this.Titulo1.Name = "Titulo1";
            this.Titulo1.Size = new System.Drawing.Size(238, 40);
            this.Titulo1.TabIndex = 0;
            this.Titulo1.Text = "Casa de apostas";
            // 
            // btnjogo1
            // 
            this.btnjogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogo1.Location = new System.Drawing.Point(12, 104);
            this.btnjogo1.Name = "btnjogo1";
            this.btnjogo1.Size = new System.Drawing.Size(760, 37);
            this.btnjogo1.TabIndex = 1;
            this.btnjogo1.Text = "Primeiro Jogo";
            this.btnjogo1.UseVisualStyleBackColor = true;
            // 
            // btnjogo2
            // 
            this.btnjogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogo2.Location = new System.Drawing.Point(12, 417);
            this.btnjogo2.Name = "btnjogo2";
            this.btnjogo2.Size = new System.Drawing.Size(760, 37);
            this.btnjogo2.TabIndex = 2;
            this.btnjogo2.Text = "Segundo Jogo";
            this.btnjogo2.UseVisualStyleBackColor = true;
            // 
            // btnjogo3
            // 
            this.btnjogo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjogo3.Location = new System.Drawing.Point(12, 533);
            this.btnjogo3.Name = "btnjogo3";
            this.btnjogo3.Size = new System.Drawing.Size(760, 37);
            this.btnjogo3.TabIndex = 3;
            this.btnjogo3.Text = "Terceiro Jogo";
            this.btnjogo3.UseVisualStyleBackColor = true;
            // 
            // btnequipa1
            // 
            this.btnequipa1.Image = ((System.Drawing.Image)(resources.GetObject("btnequipa1.Image")));
            this.btnequipa1.Location = new System.Drawing.Point(137, 147);
            this.btnequipa1.Name = "btnequipa1";
            this.btnequipa1.Size = new System.Drawing.Size(182, 182);
            this.btnequipa1.TabIndex = 4;
            this.btnequipa1.UseVisualStyleBackColor = true;
            // 
            // btnequipa2
            // 
            this.btnequipa2.Image = ((System.Drawing.Image)(resources.GetObject("btnequipa2.Image")));
            this.btnequipa2.Location = new System.Drawing.Point(457, 147);
            this.btnequipa2.Name = "btnequipa2";
            this.btnequipa2.Size = new System.Drawing.Size(182, 182);
            this.btnequipa2.TabIndex = 5;
            this.btnequipa2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "VS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 715);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnequipa2);
            this.Controls.Add(this.btnequipa1);
            this.Controls.Add(this.btnjogo3);
            this.Controls.Add(this.btnjogo2);
            this.Controls.Add(this.btnjogo1);
            this.Controls.Add(this.Titulo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo1;
        private System.Windows.Forms.Button btnjogo1;
        private System.Windows.Forms.Button btnjogo2;
        private System.Windows.Forms.Button btnjogo3;
        private System.Windows.Forms.Button btnequipa1;
        private System.Windows.Forms.Button btnequipa2;
        private System.Windows.Forms.Label label1;
    }
}

