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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void about_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            // "О программе"
            MessageBox.Show("Программа предназначена для заполнения базы данных казино " +
                            "\n \n(C) ТУСУР, КИБЭВС, Золотарев Максим, группа 711-2, 2023", "О программе",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void close_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            // "Выход"
            Close();
        }

        private void списокАппаратовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // "Список аппаратов"
            FormGamesList.fgl.ShowForm();
        }

        private void списокИгроковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlayers.fp.ShowForm();
        }

        private void историяИгрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGameHistory.fgh.ShowForm();
        }
    }
}
