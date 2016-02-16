using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mngrs;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class Form1 : Form
    {
        List<DataTable> db1 = new List<DataTable>();
        string databaseName = "database", ThisText;
        string filePath;

        public Form1()
        {
            InitializeComponent();
            ThisText = this.Text;
        }

        private void Reload()
        {
            changeEnable(true);
            if (cb1.SelectedIndex < 0 | cb1.Items.Count < 0)
            {
                cb1.Items.Clear();
                foreach (var item in db1)
                {
                    cb1.Items.Add(item.TableName);
                }
                cb1.SelectedIndex = cb1.Items.Count - 1; 
            }
            try
            {
                dgv1.DataSource = db1[cb1.SelectedIndex];
            }
            catch (ArgumentOutOfRangeException)
            {
                changeEnable(false);
                btnAddtable.Enabled = true;
                cb1.Enabled = true;
            }
        }

        #region "btns&txts&cbs"
        private void btnColAdd_Click(object sender, EventArgs e)
        {
            db1[cb1.SelectedIndex].Columns.Add(txtColAdd.Text);
            txtColAdd.Text = "";
            Reload();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (!cb1.Items.Contains(cb1.Text))
            {
                cb1.Items.Add(cb1.Text);
                db1.Add(new DataTable(cb1.Text));
                Reload();
            }
            else
            {
                dgv1.DataSource = db1[cb1.SelectedIndex];
            }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv1.DataSource = db1[cb1.SelectedIndex];
        }

        private void cb1_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAddtable;
        }

        private void txtColAdd_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnColAdd;
        }
        #endregion

        #region "tsmis"
        private void tsmiRecente_MouseEnter(object sender, EventArgs e)
        {
            UtilitiesMngr.Load_Recent(ref recenteToolStripMenuItem, tsmiRecentItem_Click, "No recent Files...");
        }

        private void tsmiRecentItem_Click(object sender, EventArgs e)
        {
            OpenFile((sender as ToolStripMenuItem).Name);
        }

        private void tsmiCriar_Click(object sender, EventArgs e)
        {
            db1 = new List<DataTable>();
            Reload();
        }

        private void tsmiAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Db File|*.db" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    OpenFile(ofd.FileName);
                }
            }
        }

        private void tsmiSalvarComo_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "All Files|*.db" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    DataMngr.TablesToFile(db1, sfd.FileName);
                    changeFormText(sfd.FileName);
                }
            }
        }

        private void tsmiSalvar_Click(object sender, EventArgs e)
        {
            if (Text == "Database Editor")
            {
                tsmiSalvarComo_Click(sender, e);
            }
            else
            {
                DataMngr.TablesToFile(db1, filePath);
            }
        }

        private void OpenFile(string path)
        {
            DataMngr.fileToTables(out db1, path);
            changeFormText(path);
            cb1.Items.Clear();
            foreach (var item in db1)
            {
                cb1.Items.Add(item.TableName);
            }
            Reload();
            cb1.SelectedIndex = 0;
            dgv1.DataSource = db1[cb1.SelectedIndex];
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 abb = new AboutBox1();
            abb.ShowDialog();
        }

        private void tsmiNewColumn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region "utilities"
        private void changeFormText(string path)
        {
            filePath = path;
            databaseName = DirMngr.fngen(path);
            this.Text = ThisText + " - " + databaseName;
            UtilitiesMngr.AddToRecent(databaseName, filePath);
        }

        private void changeEnable(bool enable)
        {
            List<Control> controls = new List<Control>();

            controls.Add(txtColAdd);
            controls.Add(btnAddtable);
            controls.Add(btnColAdd);
            controls.Add(cb1);
            controls.Add(dgv1);

            foreach (var item in controls)
            {
                if (item.Enabled != enable)
                {
                    item.Enabled = enable;
                }
            }
        } 
        #endregion
    }
}