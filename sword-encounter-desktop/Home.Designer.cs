namespace sword_encounter_desktop
{
    partial class Home
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
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.buttonMestres = new System.Windows.Forms.Button();
            this.buttonJogadores = new System.Windows.Forms.Button();
            this.buttonFichas = new System.Windows.Forms.Button();
            this.buttonCampanhas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.buttonUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonUsuarios.Location = new System.Drawing.Point(26, 37);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(112, 36);
            this.buttonUsuarios.TabIndex = 0;
            this.buttonUsuarios.Text = "Usuários";
            this.buttonUsuarios.UseVisualStyleBackColor = false;
            // 
            // buttonMestres
            // 
            this.buttonMestres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.buttonMestres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMestres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonMestres.Location = new System.Drawing.Point(26, 94);
            this.buttonMestres.Name = "buttonMestres";
            this.buttonMestres.Size = new System.Drawing.Size(112, 36);
            this.buttonMestres.TabIndex = 1;
            this.buttonMestres.Text = "Mestres";
            this.buttonMestres.UseVisualStyleBackColor = false;
            // 
            // buttonJogadores
            // 
            this.buttonJogadores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.buttonJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJogadores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonJogadores.Location = new System.Drawing.Point(26, 148);
            this.buttonJogadores.Name = "buttonJogadores";
            this.buttonJogadores.Size = new System.Drawing.Size(112, 36);
            this.buttonJogadores.TabIndex = 2;
            this.buttonJogadores.Text = "Jogadores";
            this.buttonJogadores.UseVisualStyleBackColor = false;
            // 
            // buttonFichas
            // 
            this.buttonFichas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.buttonFichas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFichas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonFichas.Location = new System.Drawing.Point(26, 202);
            this.buttonFichas.Name = "buttonFichas";
            this.buttonFichas.Size = new System.Drawing.Size(112, 36);
            this.buttonFichas.TabIndex = 3;
            this.buttonFichas.Text = "Fichas";
            this.buttonFichas.UseVisualStyleBackColor = false;
            // 
            // buttonCampanhas
            // 
            this.buttonCampanhas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.buttonCampanhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCampanhas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonCampanhas.Location = new System.Drawing.Point(26, 259);
            this.buttonCampanhas.Name = "buttonCampanhas";
            this.buttonCampanhas.Size = new System.Drawing.Size(112, 36);
            this.buttonCampanhas.TabIndex = 4;
            this.buttonCampanhas.Text = "Campanhas";
            this.buttonCampanhas.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCampanhas);
            this.Controls.Add(this.buttonFichas);
            this.Controls.Add(this.buttonJogadores);
            this.Controls.Add(this.buttonMestres);
            this.Controls.Add(this.buttonUsuarios);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsuarios;
        private System.Windows.Forms.Button buttonMestres;
        private System.Windows.Forms.Button buttonJogadores;
        private System.Windows.Forms.Button buttonFichas;
        private System.Windows.Forms.Button buttonCampanhas;
    }
}

