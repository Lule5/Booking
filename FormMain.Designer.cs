namespace Booking {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblSelectCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbApartments = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCity
            // 
            this.lblSelectCity.AutoSize = true;
            this.lblSelectCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectCity.Location = new System.Drawing.Point(30, 20);
            this.lblSelectCity.Name = "lblSelectCity";
            this.lblSelectCity.Size = new System.Drawing.Size(123, 25);
            this.lblSelectCity.TabIndex = 0;
            this.lblSelectCity.Text = "Select a city:";
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.ItemHeight = 22;
            this.cbCity.Location = new System.Drawing.Point(159, 20);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(145, 30);
            this.cbCity.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Booking.Properties.Resources.logo1;
            this.pbLogo.Location = new System.Drawing.Point(1194, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(142, 51);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lbApartments
            // 
            this.lbApartments.FormattingEnabled = true;
            this.lbApartments.ItemHeight = 16;
            this.lbApartments.Location = new System.Drawing.Point(35, 83);
            this.lbApartments.Name = "lbApartments";
            this.lbApartments.Size = new System.Drawing.Size(1263, 420);
            this.lbApartments.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 608);
            this.Controls.Add(this.lbApartments);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lblSelectCity);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ListBox lbApartments;
    }
}