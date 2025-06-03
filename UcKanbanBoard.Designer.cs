namespace TaskManager
{
    partial class UcKanbanBoard
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
            this.PnlTblMainList = new System.Windows.Forms.TableLayoutPanel();
            this.LblToDoList = new Telerik.WinControls.UI.RadLabel();
            this.PnlToDoList = new System.Windows.Forms.Panel();
            this.PnlTblTasks = new System.Windows.Forms.TableLayoutPanel();
            this.PnlTblMainList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblToDoList)).BeginInit();
            this.PnlToDoList.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTblMainList
            // 
            this.PnlTblMainList.AutoScroll = true;
            this.PnlTblMainList.ColumnCount = 1;
            this.PnlTblMainList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblMainList.Controls.Add(this.LblToDoList, 0, 0);
            this.PnlTblMainList.Controls.Add(this.PnlToDoList, 0, 1);
            this.PnlTblMainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblMainList.Location = new System.Drawing.Point(0, 0);
            this.PnlTblMainList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlTblMainList.Name = "PnlTblMainList";
            this.PnlTblMainList.RowCount = 2;
            this.PnlTblMainList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.PnlTblMainList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblMainList.Size = new System.Drawing.Size(788, 415);
            this.PnlTblMainList.TabIndex = 0;
            // 
            // LblToDoList
            // 
            this.LblToDoList.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblToDoList.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToDoList.Location = new System.Drawing.Point(9, 9);
            this.LblToDoList.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.LblToDoList.Name = "LblToDoList";
            this.LblToDoList.Size = new System.Drawing.Size(82, 34);
            this.LblToDoList.TabIndex = 0;
            this.LblToDoList.Text = "To-Do";
            // 
            // PnlToDoList
            // 
            this.PnlToDoList.AutoScroll = true;
            this.PnlToDoList.Controls.Add(this.PnlTblTasks);
            this.PnlToDoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlToDoList.Location = new System.Drawing.Point(3, 65);
            this.PnlToDoList.Name = "PnlToDoList";
            this.PnlToDoList.Size = new System.Drawing.Size(782, 347);
            this.PnlToDoList.TabIndex = 1;
            // 
            // PnlTblTasks
            // 
            this.PnlTblTasks.AutoSize = true;
            this.PnlTblTasks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlTblTasks.ColumnCount = 1;
            this.PnlTblTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTblTasks.Location = new System.Drawing.Point(0, 0);
            this.PnlTblTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnlTblTasks.Name = "PnlTblTasks";
            this.PnlTblTasks.RowCount = 3;
            this.PnlTblTasks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlTblTasks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlTblTasks.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlTblTasks.Size = new System.Drawing.Size(782, 0);
            this.PnlTblTasks.TabIndex = 0;
            // 
            // UcKanbanBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlTblMainList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcKanbanBoard";
            this.Size = new System.Drawing.Size(788, 415);
            this.Load += new System.EventHandler(this.UcKanbanBoard_Load);
            this.PnlTblMainList.ResumeLayout(false);
            this.PnlTblMainList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LblToDoList)).EndInit();
            this.PnlToDoList.ResumeLayout(false);
            this.PnlToDoList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlTblMainList;
        private Telerik.WinControls.UI.RadLabel LblToDoList;
        private System.Windows.Forms.TableLayoutPanel PnlTblTasks;
        private System.Windows.Forms.Panel PnlToDoList;
    }
}
