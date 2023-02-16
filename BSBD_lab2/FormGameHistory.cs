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
    }
}
