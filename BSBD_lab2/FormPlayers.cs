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
    public partial class FormPlayers : Form
    {
        public FormPlayers()
        {
            InitializeComponent();
        }

        private void игрокиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.игрокиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);

        }

        private void игрокиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.игрокиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);

        }

        private void игрокиBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.игрокиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);

        }

        private void FormPlayers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Игроки". При необходимости она может быть перемещена или удалена.
            this.игрокиTableAdapter.Fill(this.lab_1DataSet.Игроки);

        }

        private static FormPlayers f;
        public static FormPlayers fp
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPlayers();
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
