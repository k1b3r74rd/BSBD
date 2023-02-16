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
    public partial class FormGamesList : Form
    {
        public FormGamesList()
        {
            InitializeComponent();
        }

        private void аппаратыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.аппаратыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);

        }

        private void FormGamesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Аппараты". При необходимости она может быть перемещена или удалена.
            this.аппаратыTableAdapter.Fill(this.lab_1DataSet.Аппараты);

        }

        private static FormGamesList f;
        public static FormGamesList fgl
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormGamesList();
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
