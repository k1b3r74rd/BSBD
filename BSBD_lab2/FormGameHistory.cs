using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSBD_lab2
{
    public partial class FormGameHistory : Form
    {
        public FormGameHistory()
        {
            InitializeComponent();
        }

        private void история_игрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.история_игрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);

        }

        private void FormGameHistory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.История_игр". При необходимости она может быть перемещена или удалена.
            this.история_игрTableAdapter.Fill(this.lab_1DataSet.История_игр);

        }

        private static FormGameHistory f;
        public static FormGameHistory fgh
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormGameHistory();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
        string GetSelectedFieldName()
        {
            return история_игрDataGridView.Columns[история_игрDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int indexPos;
            try
            {
                indexPos = история_игрBindingSource.Find(GetSelectedFieldName(), toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

            if (indexPos > -1)
            {
                история_игрBindingSource.Position = indexPos;
            }
            else
            {
                MessageBox.Show("Таких игр нет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                история_игрBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        история_игрBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
                }
            }
            else
            {
                история_игрBindingSource.Filter = "";
            }

            if (история_игрBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                история_игрBindingSource.Filter = "";
                checkBoxFind.Checked = false;

            }
        }
    }
}
