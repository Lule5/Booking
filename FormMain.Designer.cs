﻿namespace Booking {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.lblSelectCity = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.flpApartments = new System.Windows.Forms.FlowLayoutPanel();
            this.flpReservations = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lblSelectCity
            // 
            this.lblSelectCity.AutoSize = true;
            this.lblSelectCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSelectCity.Location = new System.Drawing.Point(22, 75);
            this.lblSelectCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectCity.Name = "lblSelectCity";
            this.lblSelectCity.Size = new System.Drawing.Size(98, 20);
            this.lblSelectCity.TabIndex = 0;
            this.lblSelectCity.Text = "Select a city:";
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.ItemHeight = 17;
            this.cbCity.Location = new System.Drawing.Point(119, 74);
            this.cbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(110, 25);
            this.cbCity.TabIndex = 1;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUser.Location = new System.Drawing.Point(23, 19);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 17);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User:";
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGuest.Location = new System.Drawing.Point(74, 19);
            this.lblGuest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(0, 17);
            this.lblGuest.TabIndex = 5;
            // 
            // flpApartments
            // 
            this.flpApartments.AutoScroll = true;
            this.flpApartments.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpApartments.Location = new System.Drawing.Point(557, 0);
            this.flpApartments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpApartments.Name = "flpApartments";
            this.flpApartments.Size = new System.Drawing.Size(561, 560);
            this.flpApartments.TabIndex = 6;
            // 
            // flpReservations
            // 
            this.flpReservations.Location = new System.Drawing.Point(26, 124);
            this.flpReservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpReservations.Name = "flpReservations";
            this.flpReservations.Size = new System.Drawing.Size(527, 436);
            this.flpReservations.TabIndex = 7;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 560);
            this.Controls.Add(this.flpReservations);
            this.Controls.Add(this.flpApartments);
            this.Controls.Add(this.lblGuest);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.lblSelectCity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Booking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCity;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.FlowLayoutPanel flpApartments;
        private System.Windows.Forms.FlowLayoutPanel flpReservations;
    }
}