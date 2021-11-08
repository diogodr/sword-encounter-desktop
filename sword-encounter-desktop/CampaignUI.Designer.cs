namespace sword_encounter_desktop
{
    partial class CampaignUI
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
            this.cartesianCampaigns = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartesianCampaigns
            // 
            this.cartesianCampaigns.Location = new System.Drawing.Point(42, 71);
            this.cartesianCampaigns.Name = "cartesianCampaigns";
            this.cartesianCampaigns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cartesianCampaigns.Size = new System.Drawing.Size(1100, 512);
            this.cartesianCampaigns.TabIndex = 5;
            this.cartesianCampaigns.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(550, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Campanhas";
            // 
            // CampaignUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1181, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianCampaigns);
            this.Name = "CampaignUI";
            this.Text = "Campaign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianCampaigns;
        private System.Windows.Forms.Label label1;
    }
}