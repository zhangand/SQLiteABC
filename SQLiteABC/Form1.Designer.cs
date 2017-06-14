namespace SQLiteABC
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewSQLiteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTableStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getColumnStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastInsertRowIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllDataBetweenTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTableStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.dBInfoToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem,
            this.createNewSQLiteDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem
            // 
            this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem.Name = "openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem";
            this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem.Size = new System.Drawing.Size(468, 24);
            this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem.Text = "Open Existing SQLite Database (For Testing Purpose ONLY)";
            this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem.Click += new System.EventHandler(this.openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem_Click);
            // 
            // createNewSQLiteDatabaseToolStripMenuItem
            // 
            this.createNewSQLiteDatabaseToolStripMenuItem.Name = "createNewSQLiteDatabaseToolStripMenuItem";
            this.createNewSQLiteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(468, 24);
            this.createNewSQLiteDatabaseToolStripMenuItem.Text = "Create New SQLite Database";
            this.createNewSQLiteDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createNewSQLiteDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(468, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dBInfoToolStripMenuItem
            // 
            this.dBInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getTableStatusToolStripMenuItem,
            this.getTableListToolStripMenuItem,
            this.getColumnStatusToolStripMenuItem,
            this.showDatabaseToolStripMenuItem});
            this.dBInfoToolStripMenuItem.Name = "dBInfoToolStripMenuItem";
            this.dBInfoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dBInfoToolStripMenuItem.Text = "DB info";
            // 
            // getTableStatusToolStripMenuItem
            // 
            this.getTableStatusToolStripMenuItem.Name = "getTableStatusToolStripMenuItem";
            this.getTableStatusToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.getTableStatusToolStripMenuItem.Text = "GetTableStatus";
            this.getTableStatusToolStripMenuItem.Click += new System.EventHandler(this.getTableStatusToolStripMenuItem_Click);
            // 
            // getTableListToolStripMenuItem
            // 
            this.getTableListToolStripMenuItem.Name = "getTableListToolStripMenuItem";
            this.getTableListToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.getTableListToolStripMenuItem.Text = "GetTableList";
            this.getTableListToolStripMenuItem.Click += new System.EventHandler(this.getTableListToolStripMenuItem_Click);
            // 
            // getColumnStatusToolStripMenuItem
            // 
            this.getColumnStatusToolStripMenuItem.Name = "getColumnStatusToolStripMenuItem";
            this.getColumnStatusToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.getColumnStatusToolStripMenuItem.Text = "GetColumnStatus";
            this.getColumnStatusToolStripMenuItem.Click += new System.EventHandler(this.getColumnStatusToolStripMenuItem_Click);
            // 
            // showDatabaseToolStripMenuItem
            // 
            this.showDatabaseToolStripMenuItem.Name = "showDatabaseToolStripMenuItem";
            this.showDatabaseToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.showDatabaseToolStripMenuItem.Text = "ShowDatabase";
            this.showDatabaseToolStripMenuItem.Click += new System.EventHandler(this.showDatabaseToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.executeScalarToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.lastInsertRowIDToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // executeScalarToolStripMenuItem
            // 
            this.executeScalarToolStripMenuItem.Name = "executeScalarToolStripMenuItem";
            this.executeScalarToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.executeScalarToolStripMenuItem.Text = "ExecuteScalar";
            this.executeScalarToolStripMenuItem.Click += new System.EventHandler(this.executeScalarToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // lastInsertRowIDToolStripMenuItem
            // 
            this.lastInsertRowIDToolStripMenuItem.Name = "lastInsertRowIDToolStripMenuItem";
            this.lastInsertRowIDToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.lastInsertRowIDToolStripMenuItem.Text = "LastInsertRowID";
            this.lastInsertRowIDToolStripMenuItem.Click += new System.EventHandler(this.lastInsertRowIDToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTableToolStripMenuItem,
            this.renameTableToolStripMenuItem,
            this.copyAllDataBetweenTablesToolStripMenuItem,
            this.dropTableToolStripMenuItem,
            this.updateTableStructureToolStripMenuItem,
            this.attachDatabaseToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.createTableToolStripMenuItem.Text = "CreateTable";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // renameTableToolStripMenuItem
            // 
            this.renameTableToolStripMenuItem.Name = "renameTableToolStripMenuItem";
            this.renameTableToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.renameTableToolStripMenuItem.Text = "RenameTable";
            this.renameTableToolStripMenuItem.Click += new System.EventHandler(this.renameTableToolStripMenuItem_Click);
            // 
            // copyAllDataBetweenTablesToolStripMenuItem
            // 
            this.copyAllDataBetweenTablesToolStripMenuItem.Name = "copyAllDataBetweenTablesToolStripMenuItem";
            this.copyAllDataBetweenTablesToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.copyAllDataBetweenTablesToolStripMenuItem.Text = "CopyAllDataBetweenTables";
            this.copyAllDataBetweenTablesToolStripMenuItem.Click += new System.EventHandler(this.copyAllDataBetweenTablesToolStripMenuItem_Click);
            // 
            // dropTableToolStripMenuItem
            // 
            this.dropTableToolStripMenuItem.Name = "dropTableToolStripMenuItem";
            this.dropTableToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.dropTableToolStripMenuItem.Text = "DropTable";
            this.dropTableToolStripMenuItem.Click += new System.EventHandler(this.dropTableToolStripMenuItem_Click);
            // 
            // updateTableStructureToolStripMenuItem
            // 
            this.updateTableStructureToolStripMenuItem.Name = "updateTableStructureToolStripMenuItem";
            this.updateTableStructureToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.updateTableStructureToolStripMenuItem.Text = "UpdateTableStructure";
            this.updateTableStructureToolStripMenuItem.Click += new System.EventHandler(this.updateTableStructureToolStripMenuItem_Click);
            // 
            // attachDatabaseToolStripMenuItem
            // 
            this.attachDatabaseToolStripMenuItem.Name = "attachDatabaseToolStripMenuItem";
            this.attachDatabaseToolStripMenuItem.Size = new System.Drawing.Size(262, 24);
            this.attachDatabaseToolStripMenuItem.Text = "AttachDatabase";
            this.attachDatabaseToolStripMenuItem.Click += new System.EventHandler(this.attachDatabaseToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 233);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(682, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbDB
            // 
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 255);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SQLite Helper Test App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewSQLiteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTableStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getColumnStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastInsertRowIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllDataBetweenTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTableStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachDatabaseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbDB;
    }
}

