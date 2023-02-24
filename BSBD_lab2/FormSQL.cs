using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Data.Common;

namespace BSBD_lab2
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;
        public static FormSQL fsql
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Lab_1ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonPlayers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Игроки");
        }

        private void radioButtonMachines_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT [ID игры], [Выбор игрока], Результат FROM [История игр]");
        }

        private void radioButtonHistory_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT [ID игры], Аппараты.[ID аппарата]," +
                "Название, Результат FROM Аппараты, [История игр] " +
                "WHERE Аппараты.[ID аппарата] = [История игр].[ID аппарата]");
        }

        private void buttonF_Select_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxPlayer.Text))
            {
                MessageBox.Show("Введите ID игрока", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указано число в условии", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }

            string sqlSelect = "";
            if (radioButtonWins.Checked)
            {
                sqlSelect = @"SELECT ИГ.[ID игры], Дата, ИГ.[ID аппарата], ИГ.[Размер ставки], Результат
                              FROM   Игроки И, [История игр] ИГ 
                              WHERE  @player_id = И.[ID игрока] AND 
                                     И.[ID игрока] = ИГ.[ID игрока] AND
                                     (Результат LIKE '%Выигрыш%' OR Результат LIKE '%Win%')";
            }
            else
            {
                if (radioButtonMachine.Checked)
                {
                    sqlSelect = @"SELECT    ИГ.[ID аппарата], Sum(ИГ.[Размер ставки]) as Общий_выигрыш
                                  FROM		Игроки И, [История игр] ИГ, Аппараты А
                                  WHERE		И.[ID игрока] = ИГ.[ID игрока] AND
			                                @player_id = И.[ID игрока]
                                  GROUP BY	ИГ.[ID игрока], ИГ.[ID аппарата]";
                }
                else
                {
                    sqlSelect = @"  SELECT  Sum(ИГ.[Размер ставки])
                                    FROM    [История игр] ИГ 
                                    WHERE   @player_id = ИГ.[ID игрока]";
                }
            }

            if (checkBoxMore.Checked)
            {
                sqlSelect += " HAVING Sum(ИГ.[Размер ставки]) >@amount";
            }

            if (checkBoxOrder.Checked)
            {
                sqlSelect += " ORDER BY Sum(ИГ.[Размер ставки]) desc";
            }

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Lab_1ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@player_id", textBoxPlayer.Text);

            if (checkBoxMore.Checked)
            {
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value = Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Ставка в условии должна быть задана числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            }

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFSelect.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите номер необходимой продажи", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlSelect = "";

            if (radioButtonCorrelated.Checked)
            {
                sqlSelect = @"  SELECT Название
                                FROM Аппараты
                                WHERE @id_game IN
	                                (SELECT [ID игры]
	                                FROM [История игр]
	                                WHERE [ID аппарата] = Аппараты.[ID аппарата])";
            }
            else if (radioButtonNoCorrelated.Checked)
            {
                sqlSelect = @"  SELECT * 
                                from [История игр]
                                where [Размер ставки] > (select [Размер ставки] FROM [История игр]
                                WHERE @id_game = [История игр].[ID игры])";
            }
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.Lab_1ConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@id_game", SqlDbType.Int).Value = int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Номер продажи в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void InsertSlot()
        {
            if (String.IsNullOrEmpty(textBoxId_slot.Text) || (String.IsNullOrEmpty(textBoxName_slot.Text)))
            {
                MessageBox.Show("Обязательно введите код аппарата и его название", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_slot.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода аппарата!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double bet = 0;
            if (!String.IsNullOrEmpty(textBoxBet_slot.Text))
            {
                if (!double.TryParse(textBoxBet_slot.Text, out bet))
                {
                    MessageBox.Show("Некоректное значение цены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string sqlInsert = @"   INSERT INTO Аппараты (Название)
                                    VALUES (@Name)";

            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Lab_1ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", textBoxName_slot.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelectSlots_Click(this, EventArgs.Empty);
        }

        void UpdateSlot()
        {
            if (String.IsNullOrEmpty(textBoxId_slot.Text))
            {
                MessageBox.Show("Обязательно укажите код аппарата, для которого будете менять данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId_slot.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода аппарата!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double bet = 0;
            if (!String.IsNullOrEmpty(textBoxBet_slot.Text))
            {
                if (!double.TryParse(textBoxBet_slot.Text, out bet))
                {
                    MessageBox.Show("Некоректное значение цены!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            
            string sqlUpdate = "UPDATE Аппараты SET {0} " +
                               "WHERE Аппараты.[ID аппарата] = @Id_slot";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Lab_1ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxName_slot.Text))
                sqlValues += "Название=@Name,";
            if (!String.IsNullOrEmpty(textBoxBet_slot.Text))
                sqlValues += "[Размер ставки]=@Bet,";

            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(textBoxName_slot.Text))
                command.Parameters.AddWithValue("@Name", textBoxName_slot.Text);
            if (!String.IsNullOrEmpty(textBoxBet_slot.Text))
                command.Parameters.AddWithValue("@Bet", textBoxBet_slot.Text);
   
            command.Parameters.AddWithValue("@Id_slot", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelectSlots_Click(this, EventArgs.Empty);
        }

        void DeleteSlot()
        {
            if (String.IsNullOrEmpty(textBoxId_slot.Text))
            {
                MessageBox.Show("Обязательно укажите код аппарата, данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }

            int id;
            if (!int.TryParse(textBoxId_slot.Text, out id))
            {
                MessageBox.Show("Некоректное значение кода аппарата!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = @"DELETE FROM Аппараты WHERE Аппараты.[ID аппарата]=@Id_slot";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.Lab_1ConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Id_slot", id);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectSlots_Click(this, EventArgs.Empty);
        }

        private void buttonSelectSlots_Click(object sender, EventArgs e)
        {
            dataGridViewSlots.DataSource = FillDataGridView("SELECT * FROM Аппараты");
        }

        private void radioButtonInsert_Slot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonUpdate_Slot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDelete_Slot_CheckedChanged(object sender, EventArgs e)
        {
            panelSlot.Visible = !radioButtonDelete_Slot.Checked;
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert_Slot.Checked)
                InsertSlot();
            else if(radioButtonUpdate_Slot.Checked)
                UpdateSlot();
            else if (radioButtonDelete_Slot.Checked)
                DeleteSlot();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
