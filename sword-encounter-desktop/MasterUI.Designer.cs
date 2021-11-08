namespace sword_encounter_desktop
{
    partial class MasterUI
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
            this.cartesianMasters = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartesianMasters
            // 
            this.cartesianMasters.Location = new System.Drawing.Point(97, 57);
            this.cartesianMasters.Name = "cartesianMasters";
            this.cartesianMasters.Size = new System.Drawing.Size(1097, 512);
            this.cartesianMasters.TabIndex = 6;
            this.cartesianMasters.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(620, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mestres";
            // 
            // MasterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1291, 599);
            this.Controls.Add(this.cartesianMasters);
            this.Controls.Add(this.label1);
            this.Name = "MasterUI";
            this.Text = "Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianMasters;
        private System.Windows.Forms.Label label1;
    }
}