namespace TaskManager.View
{
    partial class UcTask
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTask));
            this.PnlTblTaskElements = new System.Windows.Forms.TableLayoutPanel();
            this.LblStatus = new Telerik.WinControls.UI.RadLabel();
            this.Picture = new Telerik.WinControls.UI.RadPictureBox();
            this.LblDescription = new Telerik.WinControls.UI.RadLabel();
            this.DdlResponsible = new Telerik.WinControls.UI.RadDropDownList();
            this.LblPriority = new Telerik.WinControls.UI.RadLabel();
            this.PictureDelete = new Telerik.WinControls.UI.RadPictureBox();
            this.PnlTblTaskElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlResponsible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPriority)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTblTaskElements
            // 
            this.PnlTblTaskElements.ColumnCount = 7;
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.26582F));
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.73418F));
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.PnlTblTaskElements.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.PnlTblTaskElements.Controls.Add(this.LblStatus, 4, 0);
            this.PnlTblTaskElements.Controls.Add(this.Picture, 0, 0);
            this.PnlTblTaskElements.Controls.Add(this.LblDescription, 1, 0);
            this.PnlTblTaskElements.Controls.Add(this.DdlResponsible, 5, 0);
            this.PnlTblTaskElements.Controls.Add(this.LblPriority, 2, 0);
            this.PnlTblTaskElements.Controls.Add(this.PictureDelete, 6, 0);
            this.PnlTblTaskElements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlTblTaskElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblTaskElements.Location = new System.Drawing.Point(0, 0);
            this.PnlTblTaskElements.Name = "PnlTblTaskElements";
            this.PnlTblTaskElements.RowCount = 1;
            this.PnlTblTaskElements.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblTaskElements.Size = new System.Drawing.Size(580, 46);
            this.PnlTblTaskElements.TabIndex = 0;
            this.PnlTblTaskElements.Click += new System.EventHandler(this.PnlTblTaskElements_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Location = new System.Drawing.Point(295, 22);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(6, 22, 6, 6);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(37, 18);
            this.LblStatus.TabIndex = 3;
            this.LblStatus.Text = "Status";
            // 
            // Picture
            // 
            this.Picture.DefaultImage = ((System.Drawing.Image)(resources.GetObject("Picture.DefaultImage")));
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Image = ((System.Drawing.Image)(resources.GetObject("Picture.Image")));
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Margin = new System.Windows.Forms.Padding(0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(54, 46);
            this.Picture.TabIndex = 0;
            // 
            // LblDescription
            // 
            this.LblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDescription.Location = new System.Drawing.Point(60, 22);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(6, 22, 6, 6);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(63, 18);
            this.LblDescription.TabIndex = 1;
            this.LblDescription.Text = "Description";
            // 
            // DdlResponsible
            // 
            this.DdlResponsible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DdlResponsible.DropDownHeight = 239;
            this.DdlResponsible.ItemHeight = 27;
            this.DdlResponsible.Location = new System.Drawing.Point(333, 22);
            this.DdlResponsible.Margin = new System.Windows.Forms.Padding(6, 22, 6, 6);
            this.DdlResponsible.Name = "DdlResponsible";
            this.DdlResponsible.Size = new System.Drawing.Size(190, 20);
            this.DdlResponsible.TabIndex = 2;
            this.DdlResponsible.Text = "Unassigned";
            this.DdlResponsible.SelectedValueChanged += new System.EventHandler(this.DdlResponsible_SelectedValueChanged);
            // 
            // LblPriority
            // 
            this.LblPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblPriority.Location = new System.Drawing.Point(225, 22);
            this.LblPriority.Margin = new System.Windows.Forms.Padding(6, 22, 6, 6);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(26, 18);
            this.LblPriority.TabIndex = 4;
            this.LblPriority.Text = "Low";
            // 
            // PictureDelete
            // 
            this.PictureDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureDelete.Image = ((System.Drawing.Image)(resources.GetObject("PictureDelete.Image")));
            this.PictureDelete.Location = new System.Drawing.Point(529, 0);
            this.PictureDelete.Margin = new System.Windows.Forms.Padding(0);
            this.PictureDelete.Name = "PictureDelete";
            this.PictureDelete.Size = new System.Drawing.Size(51, 46);
            this.PictureDelete.TabIndex = 5;
            this.PictureDelete.Click += new System.EventHandler(this.PictureDelete_Click);
            // 
            // UcTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlTblTaskElements);
            this.Name = "UcTask";
            this.Size = new System.Drawing.Size(580, 46);
            this.Load += new System.EventHandler(this.UcTask_Load);
            this.PnlTblTaskElements.ResumeLayout(false);
            this.PnlTblTaskElements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DdlResponsible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblPriority)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlTblTaskElements;
        private Telerik.WinControls.UI.RadPictureBox Picture;
        private Telerik.WinControls.UI.RadLabel LblDescription;
        private Telerik.WinControls.UI.RadDropDownList DdlResponsible;
        private Telerik.WinControls.UI.RadLabel LblStatus;
        private Telerik.WinControls.UI.RadLabel LblPriority;
        private Telerik.WinControls.UI.RadPictureBox PictureDelete;
    }
}
