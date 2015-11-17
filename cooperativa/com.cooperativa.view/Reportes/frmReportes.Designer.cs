namespace com.cooperativa.view.Reportes
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            this.crvGenerico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvGenerico
            // 
            this.crvGenerico.ActiveViewIndex = -1;
            this.crvGenerico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvGenerico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvGenerico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvGenerico.Location = new System.Drawing.Point(0, 0);
            this.crvGenerico.Name = "crvGenerico";
            this.crvGenerico.Size = new System.Drawing.Size(822, 413);
            this.crvGenerico.TabIndex = 0;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 413);
            this.Controls.Add(this.crvGenerico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvGenerico;








    }
}