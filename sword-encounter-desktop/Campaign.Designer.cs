namespace sword_encounter_desktop
{
    partial class Campaign
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
            this.buttonUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUsuarios
            // 
            this.buttonUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.buttonUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.buttonUsuarios.Location = new System.Drawing.Point(12, 12);
            this.buttonUsuarios.Name = "buttonUsuarios";
            this.buttonUsuarios.Size = new System.Drawing.Size(112, 36);
            this.buttonUsuarios.TabIndex = 1;
            this.buttonUsuarios.Text = "button1";
            this.buttonUsuarios.UseVisualStyleBackColor = false;
            // 
            // Campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsuarios);
            this.Name = "Campaign";
            this.Text = "Campaign";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUsuarios;
    }
}