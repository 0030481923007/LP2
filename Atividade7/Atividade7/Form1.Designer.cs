namespace Atividade7
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
            this.btnExercicio1 = new System.Windows.Forms.Button();
            this.btnExericio2 = new System.Windows.Forms.Button();
            this.btnExericio3 = new System.Windows.Forms.Button();
            this.btnExericio4 = new System.Windows.Forms.Button();
            this.btnExericio5 = new System.Windows.Forms.Button();
            this.btnExericio6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExercicio1
            // 
            this.btnExercicio1.Location = new System.Drawing.Point(37, 46);
            this.btnExercicio1.Name = "btnExercicio1";
            this.btnExercicio1.Size = new System.Drawing.Size(137, 75);
            this.btnExercicio1.TabIndex = 0;
            this.btnExercicio1.Text = "Ler 20 números e inverter";
            this.btnExercicio1.UseVisualStyleBackColor = true;
            this.btnExercicio1.Click += new System.EventHandler(this.btnExercicio1_Click);
            // 
            // btnExericio2
            // 
            this.btnExericio2.Location = new System.Drawing.Point(37, 169);
            this.btnExericio2.Name = "btnExericio2";
            this.btnExericio2.Size = new System.Drawing.Size(137, 78);
            this.btnExericio2.TabIndex = 1;
            this.btnExericio2.Text = "Ler 20 números inverter usando REVERSE";
            this.btnExericio2.UseVisualStyleBackColor = true;
            this.btnExericio2.Click += new System.EventHandler(this.btnExericio2_Click);
            // 
            // btnExericio3
            // 
            this.btnExericio3.Location = new System.Drawing.Point(258, 46);
            this.btnExericio3.Name = "btnExericio3";
            this.btnExericio3.Size = new System.Drawing.Size(132, 75);
            this.btnExericio3.TabIndex = 2;
            this.btnExericio3.Text = "Armazém";
            this.btnExericio3.UseVisualStyleBackColor = true;
            this.btnExericio3.Click += new System.EventHandler(this.btnExericio3_Click);
            // 
            // btnExericio4
            // 
            this.btnExericio4.Location = new System.Drawing.Point(258, 169);
            this.btnExericio4.Name = "btnExericio4";
            this.btnExericio4.Size = new System.Drawing.Size(132, 78);
            this.btnExericio4.TabIndex = 3;
            this.btnExericio4.Text = "Alunos com String";
            this.btnExericio4.UseVisualStyleBackColor = true;
            this.btnExericio4.Click += new System.EventHandler(this.btnExericio4_Click);
            // 
            // btnExericio5
            // 
            this.btnExericio5.Location = new System.Drawing.Point(469, 46);
            this.btnExericio5.Name = "btnExericio5";
            this.btnExericio5.Size = new System.Drawing.Size(142, 75);
            this.btnExericio5.TabIndex = 4;
            this.btnExericio5.Text = "Alunos com Array List";
            this.btnExericio5.UseVisualStyleBackColor = true;
            this.btnExericio5.Click += new System.EventHandler(this.btnExericio5_Click);
            // 
            // btnExericio6
            // 
            this.btnExericio6.Location = new System.Drawing.Point(469, 169);
            this.btnExericio6.Name = "btnExericio6";
            this.btnExericio6.Size = new System.Drawing.Size(142, 78);
            this.btnExericio6.TabIndex = 5;
            this.btnExericio6.Text = "Média Nota Alunos";
            this.btnExericio6.UseVisualStyleBackColor = true;
            this.btnExericio6.Click += new System.EventHandler(this.btnExericio6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 300);
            this.Controls.Add(this.btnExericio6);
            this.Controls.Add(this.btnExericio5);
            this.Controls.Add(this.btnExericio4);
            this.Controls.Add(this.btnExericio3);
            this.Controls.Add(this.btnExericio2);
            this.Controls.Add(this.btnExercicio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExercicio1;
        private System.Windows.Forms.Button btnExericio2;
        private System.Windows.Forms.Button btnExericio3;
        private System.Windows.Forms.Button btnExericio4;
        private System.Windows.Forms.Button btnExericio5;
        private System.Windows.Forms.Button btnExericio6;
    }
}

