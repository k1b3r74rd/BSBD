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
    public partial class FormPlayersNGameHistory : Form
    {
        public FormPlayersNGameHistory()
        {
            InitializeComponent();
        }

        private void игрокиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.игрокиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lab_1DataSet);

        }

        private void FormPlayersNGameHistory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.История_игр". При необходимости она может быть перемещена или удалена.
            this.история_игрTableAdapter.Fill(this.lab_1DataSet.История_игр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lab_1DataSet.Игроки". При необходимости она может быть перемещена или удалена.
            this.игрокиTableAdapter.Fill(this.lab_1DataSet.Игроки);

        }


        private static FormPlayersNGameHistory f;
        public static FormPlayersNGameHistory fpngh
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPlayersNGameHistory();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void PlayerHistorySave_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.история_игрBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.lab_1DataSet);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)игрокиBindingSource.Current)["ID игрока"].ToString() != "")
            {
                id = (int)(((DataRowView)игрокиBindingSource.Current)["ID игрока"]);
            }
            id = FormPlayers.fp.ShowSelectForm(id);

            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)игрокиBindingSource.Current)["ID игрока"] = id;
                игрокиBindingSource.EndEdit();
            }
        }
    }
}
