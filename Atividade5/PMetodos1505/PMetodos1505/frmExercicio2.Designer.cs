namespace PMetodos1505
{
    partial class frmExercicio2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnInsere1 = new System.Windows.Forms.Button();
            this.btnInsere2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palavra 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palavra2";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra1.Location = new System.Drawing.Point(250, 54);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 26);
            this.txtPalavra1.TabIndex = 2;
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalavra2.Location = new System.Drawing.Point(250, 103);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 26);
            this.txtPalavra2.TabIndex = 3;
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(12, 196);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(131, 70);
            this.btnComparar.TabIndex = 4;
            this.btnComparar.Text = "Testa se são iguais";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnInsere1
            // 
            this.btnInsere1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsere1.Location = new System.Drawing.Point(156, 196);
            this.btnInsere1.Name = "btnInsere1";
            this.btnInsere1.Size = new System.Drawing.Size(121, 70);
            this.btnInsere1.TabIndex = 5;
            this.btnInsere1.Text = "Insere Palavra 1 na Palavra 2";
            this.btnInsere1.UseVisualStyleBackColor = true;
            this.btnInsere1.Click += new System.EventHandler(this.btnInsere1_Click);
            // 
            // btnInsere2
            // 
            this.btnInsere2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsere2.Location = new System.Drawing.Point(293, 196);
            this.btnInsere2.Name = "btnInsere2";
            this.btnInsere2.Size = new System.Drawing.Size(121, 70);
            this.btnInsere2.TabIndex = 6;
            this.btnInsere2.Text = "Insere ** na Palavra 1";
            this.btnInsere2.UseVisualStyleBackColor = true;
            this.btnInsere2.Click += new System.EventHandler(this.btnInsere2_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 286);
            this.Controls.Add(this.btnInsere2);
            this.Controls.Add(this.btnInsere1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnInsere1;
        private System.Windows.Forms.Button btnInsere2;
    }
}