using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteABC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HideAllMenu();
        }
        void HideAllMenu()
        {
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = false;
            }
        }
        void RevealAllMenu()
        {
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = true;
            }
        }
        bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        //Database Memu start
        private void openExistingSQLiteDatabaseForTestingPurposeONLYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.DatabaseFile = f.FileName;
                lbDB.Text = config.DataSource;
                if (TestConnection())
                    RevealAllMenu();
                else
                    HideAllMenu();
            }
        }
        private void createNewSQLiteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.DatabaseFile = f.FileName;
                lbDB.Text = config.DataSource;
                if (TestConnection())
                    RevealAllMenu();
                else
                    HideAllMenu();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Database Memu end
        //DB info Memu start
        private void getTableStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetTableStatus f = new Forms.DBInfo.GetTableStatus();
            f.Show();
        }

        private void getTableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetTableList f = new Forms.DBInfo.GetTableList();
            f.Show();
        }

        private void getColumnStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //DB info Memu end
        //Query Memu Start
        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Select f = new Forms.Query.Select();
            f.Show();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void executeScalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Insert f = new Forms.Query.Insert();
            f.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lastInsertRowIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Query Memu end
        //Utilities Memu start
        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renameTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copyAllDataBetweenTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dropTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateTableStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void attachDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //Utilities Memu end





    }
}
