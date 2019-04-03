namespace Vel2j.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.vehiclesList = new System.Windows.Forms.ListView();
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLocW = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColorP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colColorS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRespawn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripList.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesList
            // 
            this.vehiclesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colType,
            this.colLocX,
            this.colLocY,
            this.colLocZ,
            this.colLocW,
            this.colColorP,
            this.colColorS,
            this.colRespawn});
            this.vehiclesList.ContextMenuStrip = this.contextMenuStripList;
            this.vehiclesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehiclesList.FullRowSelect = true;
            this.vehiclesList.GridLines = true;
            this.vehiclesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.vehiclesList.Location = new System.Drawing.Point(0, 0);
            this.vehiclesList.MultiSelect = false;
            this.vehiclesList.Name = "vehiclesList";
            this.vehiclesList.Size = new System.Drawing.Size(681, 451);
            this.vehiclesList.TabIndex = 0;
            this.vehiclesList.UseCompatibleStateImageBehavior = false;
            this.vehiclesList.View = System.Windows.Forms.View.Details;
            // 
            // colType
            // 
            this.colType.Text = "Type";
            this.colType.Width = 175;
            // 
            // colLocX
            // 
            this.colLocX.Text = "X";
            this.colLocX.Width = 65;
            // 
            // colLocY
            // 
            this.colLocY.Text = "Y";
            this.colLocY.Width = 65;
            // 
            // colLocZ
            // 
            this.colLocZ.Text = "Z";
            this.colLocZ.Width = 65;
            // 
            // colLocW
            // 
            this.colLocW.Text = "Angle";
            this.colLocW.Width = 65;
            // 
            // colColorP
            // 
            this.colColorP.Text = "Color 1";
            this.colColorP.Width = 70;
            // 
            // colColorS
            // 
            this.colColorS.Text = "Color 2";
            this.colColorS.Width = 70;
            // 
            // colRespawn
            // 
            this.colRespawn.Text = "Respawn Time";
            this.colRespawn.Width = 85;
            // 
            // contextMenuStripList
            // 
            this.contextMenuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.importToolStripMenuItem});
            this.contextMenuStripList.Name = "contextMenuStripList";
            this.contextMenuStripList.Size = new System.Drawing.Size(160, 170);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Enabled = false;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(156, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.ImportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(681, 451);
            this.Controls.Add(this.vehiclesList);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vel2j";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView vehiclesList;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colLocX;
        private System.Windows.Forms.ColumnHeader colLocY;
        private System.Windows.Forms.ColumnHeader colLocZ;
        private System.Windows.Forms.ColumnHeader colLocW;
        private System.Windows.Forms.ColumnHeader colColorP;
        private System.Windows.Forms.ColumnHeader colColorS;
        private System.Windows.Forms.ColumnHeader colRespawn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripList;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

