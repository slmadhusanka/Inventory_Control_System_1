﻿namespace Inventory_Control_System
{
    partial class RptPendingRepairs
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
            this.CryViewerPending = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CryViewerPending
            // 
            this.CryViewerPending.ActiveViewIndex = -1;
            this.CryViewerPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CryViewerPending.Cursor = System.Windows.Forms.Cursors.Default;
            this.CryViewerPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CryViewerPending.Location = new System.Drawing.Point(0, 0);
            this.CryViewerPending.Name = "CryViewerPending";
            this.CryViewerPending.Size = new System.Drawing.Size(1370, 716);
            this.CryViewerPending.TabIndex = 0;
            // 
            // RptPendingRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 716);
            this.Controls.Add(this.CryViewerPending);
            this.Name = "RptPendingRepairs";
            this.Text = "Pending Repairs";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RptPendingRepairs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CryViewerPending;
    }
}