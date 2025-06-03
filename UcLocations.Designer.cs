namespace TaskManager
{
    partial class UcLocations
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlTblLocation = new System.Windows.Forms.TableLayoutPanel();
            this.LblLocations = new Telerik.WinControls.UI.RadLabel();
            this.DdlLocations = new Telerik.WinControls.UI.RadDropDownList();
            this.PnlTblLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTblLocation
            // 
            this.PnlTblLocation.ColumnCount = 1;
            this.PnlTblLocation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblLocation.Controls.Add(this.LblLocations, 0, 0);
            this.PnlTblLocation.Controls.Add(this.DdlLocations, 0, 1);
            this.PnlTblLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblLocation.Location = new System.Drawing.Point(0, 0);
            this.PnlTblLocation.Name = "PnlTblLocation";
            this.PnlTblLocation.RowCount = 2;
            this.PnlTblLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.PnlTblLocation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblLocation.Size = new System.Drawing.Size(201, 64);
            this.PnlTblLocation.TabIndex = 0;
            // 
            // LblLocations
            // 
            this.LblLocations.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblLocations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLocations.Location = new System.Drawing.Point(9, 9);
            this.LblLocations.Margin = new System.Windows.Forms.Padding(9);
            this.LblLocations.Name = "LblLocations";
            this.LblLocations.Size = new System.Drawing.Size(71, 22);
            this.LblLocations.TabIndex = 1;
            this.LblLocations.Text = "Locations";
            this.LblLocations.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // DdlLocations
            // 
            this.DdlLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DdlLocations.Location = new System.Drawing.Point(3, 43);
            this.DdlLocations.Name = "DdlLocations";
            this.DdlLocations.Size = new System.Drawing.Size(195, 18);
            this.DdlLocations.TabIndex = 2;
            this.DdlLocations.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.DdlLocations_SelectedIndexChanged);
            // 
            // UcLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlTblLocation);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcLocations";
            this.Size = new System.Drawing.Size(201, 64);
            this.Load += new System.EventHandler(this.UcLocations_Load);
            this.PnlTblLocation.ResumeLayout(false);
            this.PnlTblLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlLocations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlTblLocation;
        private Telerik.WinControls.UI.RadLabel LblLocations;
        private Telerik.WinControls.UI.RadDropDownList DdlLocations;
    }
}
