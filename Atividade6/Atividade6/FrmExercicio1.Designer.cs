namespace Atividade6
{
    partial class FrmExercicio1
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
            this.rchTexto = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnRepetR = new System.Windows.Forms.Button();
            this.btnRepetPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTexto
            // 
            this.rchTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTexto.Location = new System.Drawing.Point(65, 12);
            this.rchTexto.Name = "rchTexto";
            this.rchTexto.Size = new System.Drawing.Size(348, 145);
            this.rchTexto.TabIndex = 0;
            this.rchTexto.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(23, 172);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(125, 61);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Espaços em Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRepetR
            // 
            this.btnRepetR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepetR.Location = new System.Drawing.Point(185, 172);
            this.btnRepetR.Name = "btnRepetR";
            this.btnRepetR.Size = new System.Drawing.Size(125, 61);
            this.btnRepetR.TabIndex = 2;
            this.btnRepetR.Text = "Repete Letra \'R\'";
            this.btnRepetR.UseVisualStyleBackColor = true;
            this.btnRepetR.Click += new System.EventHandler(this.btnRepetR_Click);
            // 
            // btnRepetPar
            // 
            this.btnRepetPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepetPar.Location = new System.Drawing.Point(340, 172);
            this.btnRepetPar.Name = "btnRepetPar";
            this.btnRepetPar.Size = new System.Drawing.Size(125, 61);
            this.btnRepetPar.TabIndex = 3;
            this.btnRepetPar.Text = "Par de Letras";
            this.btnRepetPar.UseVisualStyleBackColor = true;
            this.btnRepetPar.Click += new System.EventHandler(this.btnRepetPar_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 294);
            this.Controls.Add(this.btnRepetPar);
            this.Controls.Add(this.btnRepetR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchTexto);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTexto;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnRepetR;
        private System.Windows.Forms.Button btnRepetPar;
    }
}