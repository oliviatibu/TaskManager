namespace TaskManager
{
    partial class UcTaskManager
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
            TaskManager.Presenter.PresenterTask presenterTask1 = new TaskManager.Presenter.PresenterTask();
            TaskManager.Model.ModelTask modelTask1 = new TaskManager.Model.ModelTask();
            this.PnlTblMain = new System.Windows.Forms.TableLayoutPanel();
            this.SplitMain = new System.Windows.Forms.SplitContainer();
            this.PnlTblSideMenu = new System.Windows.Forms.TableLayoutPanel();
            this.PnlSeparator = new Telerik.WinControls.UI.RadPanel();
            this.PnlTblMenu = new System.Windows.Forms.TableLayoutPanel();
            this.PnlAddTaskActiveRight = new System.Windows.Forms.Panel();
            this.BtnAddTask = new Telerik.WinControls.UI.RadButton();
            this.BtnKanbanBoard = new Telerik.WinControls.UI.RadButton();
            this.PnlKanbanActiveUp = new System.Windows.Forms.Panel();
            this.PnlKanbanActiveRight = new System.Windows.Forms.Panel();
            this.PnlAddTaskActiveUp = new System.Windows.Forms.Panel();
            this.Locations = new TaskManager.UcLocations();
            this.PnlKanban = new System.Windows.Forms.Panel();
            this.UcKanbanBoard = new TaskManager.UcKanbanBoard();
            this.PnlTblUserActivity = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLogin = new Telerik.WinControls.UI.RadButton();
            this.LblUsername = new Telerik.WinControls.UI.RadLabel();
            this.LblErrorMessages = new Telerik.WinControls.UI.RadLabel();
            this.Separator = new Telerik.WinControls.UI.RadPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PnlTblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMain)).BeginInit();
            this.SplitMain.Panel1.SuspendLayout();
            this.SplitMain.Panel2.SuspendLayout();
            this.SplitMain.SuspendLayout();
            this.PnlTblSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PnlSeparator)).BeginInit();
            this.PnlTblMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnKanbanBoard)).BeginInit();
            this.PnlKanban.SuspendLayout();
            this.PnlTblUserActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblErrorMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTblMain
            // 
            this.PnlTblMain.ColumnCount = 3;
            this.PnlTblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.PnlTblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.PnlTblMain.Controls.Add(this.SplitMain, 1, 4);
            this.PnlTblMain.Controls.Add(this.PnlTblUserActivity, 1, 1);
            this.PnlTblMain.Controls.Add(this.Separator, 1, 3);
            this.PnlTblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblMain.Location = new System.Drawing.Point(0, 0);
            this.PnlTblMain.Margin = new System.Windows.Forms.Padding(2);
            this.PnlTblMain.Name = "PnlTblMain";
            this.PnlTblMain.RowCount = 6;
            this.PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.PnlTblMain.Size = new System.Drawing.Size(978, 523);
            this.PnlTblMain.TabIndex = 0;
            // 
            // SplitMain
            // 
            this.SplitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitMain.Location = new System.Drawing.Point(7, 32);
            this.SplitMain.Margin = new System.Windows.Forms.Padding(0);
            this.SplitMain.Name = "SplitMain";
            // 
            // SplitMain.Panel1
            // 
            this.SplitMain.Panel1.Controls.Add(this.PnlTblSideMenu);
            this.SplitMain.Panel1MinSize = 10;
            // 
            // SplitMain.Panel2
            // 
            this.SplitMain.Panel2.Controls.Add(this.PnlKanban);
            this.SplitMain.Size = new System.Drawing.Size(964, 485);
            this.SplitMain.SplitterDistance = 113;
            this.SplitMain.TabIndex = 4;
            // 
            // PnlTblSideMenu
            // 
            this.PnlTblSideMenu.ColumnCount = 2;
            this.PnlTblSideMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblSideMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PnlTblSideMenu.Controls.Add(this.PnlSeparator, 1, 0);
            this.PnlTblSideMenu.Controls.Add(this.PnlTblMenu, 0, 1);
            this.PnlTblSideMenu.Controls.Add(this.Locations, 0, 0);
            this.PnlTblSideMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblSideMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlTblSideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTblSideMenu.Name = "PnlTblSideMenu";
            this.PnlTblSideMenu.RowCount = 2;
            this.PnlTblSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PnlTblSideMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblSideMenu.Size = new System.Drawing.Size(113, 485);
            this.PnlTblSideMenu.TabIndex = 0;
            // 
            // PnlSeparator
            // 
            this.PnlSeparator.BackColor = System.Drawing.Color.Black;
            this.PnlSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSeparator.Location = new System.Drawing.Point(111, 0);
            this.PnlSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.PnlSeparator.Name = "PnlSeparator";
            this.PnlTblSideMenu.SetRowSpan(this.PnlSeparator, 2);
            this.PnlSeparator.Size = new System.Drawing.Size(2, 485);
            this.PnlSeparator.TabIndex = 3;
            // 
            // PnlTblMenu
            // 
            this.PnlTblMenu.ColumnCount = 4;
            this.PnlTblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.PnlTblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.PnlTblMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.PnlTblMenu.Controls.Add(this.PnlAddTaskActiveRight, 2, 4);
            this.PnlTblMenu.Controls.Add(this.BtnAddTask, 1, 5);
            this.PnlTblMenu.Controls.Add(this.BtnKanbanBoard, 1, 2);
            this.PnlTblMenu.Controls.Add(this.PnlKanbanActiveUp, 1, 1);
            this.PnlTblMenu.Controls.Add(this.PnlKanbanActiveRight, 2, 1);
            this.PnlTblMenu.Controls.Add(this.PnlAddTaskActiveUp, 1, 4);
            this.PnlTblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblMenu.Location = new System.Drawing.Point(0, 68);
            this.PnlTblMenu.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTblMenu.Name = "PnlTblMenu";
            this.PnlTblMenu.RowCount = 10;
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PnlTblMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.PnlTblMenu.Size = new System.Drawing.Size(111, 417);
            this.PnlTblMenu.TabIndex = 7;
            // 
            // PnlAddTaskActiveRight
            // 
            this.PnlAddTaskActiveRight.Location = new System.Drawing.Point(97, 129);
            this.PnlAddTaskActiveRight.Margin = new System.Windows.Forms.Padding(0);
            this.PnlAddTaskActiveRight.Name = "PnlAddTaskActiveRight";
            this.PnlTblMenu.SetRowSpan(this.PnlAddTaskActiveRight, 2);
            this.PnlAddTaskActiveRight.Size = new System.Drawing.Size(5, 79);
            this.PnlAddTaskActiveRight.TabIndex = 4;
            // 
            // BtnAddTask
            // 
            this.BtnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddTask.Location = new System.Drawing.Point(10, 134);
            this.BtnAddTask.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAddTask.Name = "BtnAddTask";
            this.BtnAddTask.Size = new System.Drawing.Size(87, 74);
            this.BtnAddTask.TabIndex = 2;
            this.BtnAddTask.Text = "Add Task";
            this.BtnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // BtnKanbanBoard
            // 
            this.BtnKanbanBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKanbanBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnKanbanBoard.Location = new System.Drawing.Point(10, 25);
            this.BtnKanbanBoard.Margin = new System.Windows.Forms.Padding(0);
            this.BtnKanbanBoard.Name = "BtnKanbanBoard";
            this.BtnKanbanBoard.Size = new System.Drawing.Size(87, 74);
            this.BtnKanbanBoard.TabIndex = 0;
            this.BtnKanbanBoard.Text = "Kanban board";
            this.BtnKanbanBoard.Click += new System.EventHandler(this.BtnKanbanBoard_Click);
            // 
            // PnlKanbanActiveUp
            // 
            this.PnlKanbanActiveUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlKanbanActiveUp.Location = new System.Drawing.Point(20, 20);
            this.PnlKanbanActiveUp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlKanbanActiveUp.Name = "PnlKanbanActiveUp";
            this.PnlKanbanActiveUp.Size = new System.Drawing.Size(77, 5);
            this.PnlKanbanActiveUp.TabIndex = 5;
            // 
            // PnlKanbanActiveRight
            // 
            this.PnlKanbanActiveRight.Location = new System.Drawing.Point(97, 20);
            this.PnlKanbanActiveRight.Margin = new System.Windows.Forms.Padding(0);
            this.PnlKanbanActiveRight.Name = "PnlKanbanActiveRight";
            this.PnlTblMenu.SetRowSpan(this.PnlKanbanActiveRight, 2);
            this.PnlKanbanActiveRight.Size = new System.Drawing.Size(5, 79);
            this.PnlKanbanActiveRight.TabIndex = 3;
            // 
            // PnlAddTaskActiveUp
            // 
            this.PnlAddTaskActiveUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlAddTaskActiveUp.Location = new System.Drawing.Point(20, 129);
            this.PnlAddTaskActiveUp.Margin = new System.Windows.Forms.Padding(0);
            this.PnlAddTaskActiveUp.Name = "PnlAddTaskActiveUp";
            this.PnlAddTaskActiveUp.Size = new System.Drawing.Size(77, 5);
            this.PnlAddTaskActiveUp.TabIndex = 6;
            // 
            // Locations
            // 
            this.Locations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Locations.Location = new System.Drawing.Point(2, 2);
            this.Locations.LocationChanged = null;
            this.Locations.Margin = new System.Windows.Forms.Padding(2);
            this.Locations.Name = "Locations";
            presenterTask1.Model = modelTask1;
            presenterTask1.View = null;
            presenterTask1.ViewKanbanBoard = null;
            presenterTask1.ViewTask = null;
            presenterTask1.ViewTaskManager = null;
            this.Locations.Presenter = presenterTask1;
            this.Locations.Size = new System.Drawing.Size(107, 64);
            this.Locations.TabIndex = 8;
            // 
            // PnlKanban
            // 
            this.PnlKanban.AutoSize = true;
            this.PnlKanban.Controls.Add(this.UcKanbanBoard);
            this.PnlKanban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlKanban.Location = new System.Drawing.Point(0, 0);
            this.PnlKanban.Margin = new System.Windows.Forms.Padding(2);
            this.PnlKanban.Name = "PnlKanban";
            this.PnlKanban.Size = new System.Drawing.Size(847, 485);
            this.PnlKanban.TabIndex = 1;
            // 
            // UcKanbanBoard
            // 
            this.UcKanbanBoard.BackColor = System.Drawing.Color.White;
            this.UcKanbanBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcKanbanBoard.Location = new System.Drawing.Point(0, 0);
            this.UcKanbanBoard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UcKanbanBoard.Name = "UcKanbanBoard";
            this.UcKanbanBoard.PresenterTask = null;
            this.UcKanbanBoard.Size = new System.Drawing.Size(847, 485);
            this.UcKanbanBoard.TabIndex = 0;
            // 
            // PnlTblUserActivity
            // 
            this.PnlTblUserActivity.ColumnCount = 5;
            this.PnlTblUserActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblUserActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.PnlTblUserActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.PnlTblUserActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.PnlTblUserActivity.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PnlTblUserActivity.Controls.Add(this.BtnLogin, 3, 0);
            this.PnlTblUserActivity.Controls.Add(this.LblUsername, 1, 0);
            this.PnlTblUserActivity.Controls.Add(this.LblErrorMessages, 0, 0);
            this.PnlTblUserActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlTblUserActivity.Location = new System.Drawing.Point(7, 6);
            this.PnlTblUserActivity.Margin = new System.Windows.Forms.Padding(0);
            this.PnlTblUserActivity.Name = "PnlTblUserActivity";
            this.PnlTblUserActivity.RowCount = 1;
            this.PnlTblUserActivity.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PnlTblUserActivity.Size = new System.Drawing.Size(964, 20);
            this.PnlTblUserActivity.TabIndex = 7;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Location = new System.Drawing.Point(864, 0);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(80, 20);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblUsername
            // 
            this.LblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblUsername.Location = new System.Drawing.Point(782, 3);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(74, 14);
            this.LblUsername.TabIndex = 7;
            this.LblUsername.Text = "Username";
            // 
            // LblErrorMessages
            // 
            this.LblErrorMessages.Dock = System.Windows.Forms.DockStyle.Left;
            this.LblErrorMessages.ForeColor = System.Drawing.Color.Black;
            this.LblErrorMessages.Location = new System.Drawing.Point(3, 3);
            this.LblErrorMessages.Name = "LblErrorMessages";
            this.LblErrorMessages.Size = new System.Drawing.Size(2, 14);
            this.LblErrorMessages.TabIndex = 8;
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Black;
            this.Separator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Separator.Location = new System.Drawing.Point(7, 31);
            this.Separator.Margin = new System.Windows.Forms.Padding(0);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(964, 1);
            this.Separator.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(32, 86);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 3);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // UcTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlTblMain);
            this.Location = new System.Drawing.Point(3, 3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcTaskManager";
            this.Size = new System.Drawing.Size(978, 523);
            this.Load += new System.EventHandler(this.UcTaskManager_Load);
            this.PnlTblMain.ResumeLayout(false);
            this.SplitMain.Panel1.ResumeLayout(false);
            this.SplitMain.Panel2.ResumeLayout(false);
            this.SplitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMain)).EndInit();
            this.SplitMain.ResumeLayout(false);
            this.PnlTblSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PnlSeparator)).EndInit();
            this.PnlTblMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnKanbanBoard)).EndInit();
            this.PnlKanban.ResumeLayout(false);
            this.PnlTblUserActivity.ResumeLayout(false);
            this.PnlTblUserActivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblErrorMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Separator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PnlTblMain;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer SplitMain;
        private UcKanbanBoard UcKanbanBoard;
        private System.Windows.Forms.Panel PnlKanban;
        private Telerik.WinControls.UI.RadButton BtnLogin;
        private System.Windows.Forms.TableLayoutPanel PnlTblUserActivity;
        private Telerik.WinControls.UI.RadPanel Separator;
        private System.Windows.Forms.TableLayoutPanel PnlTblSideMenu;
        private System.Windows.Forms.TableLayoutPanel PnlTblMenu;
        private Telerik.WinControls.UI.RadButton BtnAddTask;
        private Telerik.WinControls.UI.RadButton BtnKanbanBoard;
        private Telerik.WinControls.UI.RadLabel LblUsername;
        private Telerik.WinControls.UI.RadLabel LblErrorMessages;
        private Telerik.WinControls.UI.RadPanel PnlSeparator;
        private UcLocations Locations;
        private System.Windows.Forms.Panel PnlAddTaskActiveRight;
        private System.Windows.Forms.Panel PnlKanbanActiveRight;
        private System.Windows.Forms.Panel PnlKanbanActiveUp;
        private System.Windows.Forms.Panel PnlAddTaskActiveUp;
    }
}
