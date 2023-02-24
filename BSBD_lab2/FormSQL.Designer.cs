namespace BSBD_lab2
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPagePrimer = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonHistory = new System.Windows.Forms.RadioButton();
            this.radioButtonMachines = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayers = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFSelect = new System.Windows.Forms.GroupBox();
            this.buttonF_Select = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonMachine = new System.Windows.Forms.RadioButton();
            this.radioButtonWins = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_NO = new System.Windows.Forms.RadioButton();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.tabPageSubQuery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubQuery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonInsert_Slot = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate_Slot = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete_Slot = new System.Windows.Forms.RadioButton();
            this.labelIDSlot = new System.Windows.Forms.Label();
            this.textBoxId_slot = new System.Windows.Forms.TextBox();
            this.panelSlot = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName_slot = new System.Windows.Forms.TextBox();
            this.textBoxBet_slot = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.buttonSelectSlots = new System.Windows.Forms.Button();
            this.dataGridViewSlots = new System.Windows.Forms.DataGridView();
            this.tabControlSQL.SuspendLayout();
            this.tabPagePrimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).BeginInit();
            this.groupBoxFSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubQuery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.panelSlot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPagePrimer);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubQuery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(612, 413);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPagePrimer
            // 
            this.tabPagePrimer.Controls.Add(this.dataGridViewSelect);
            this.tabPagePrimer.Controls.Add(this.groupBoxSelect);
            this.tabPagePrimer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrimer.Name = "tabPagePrimer";
            this.tabPagePrimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrimer.Size = new System.Drawing.Size(604, 387);
            this.tabPagePrimer.TabIndex = 0;
            this.tabPagePrimer.Text = "Примеры запросов";
            this.tabPagePrimer.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 97);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(598, 287);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonHistory);
            this.groupBoxSelect.Controls.Add(this.radioButtonMachines);
            this.groupBoxSelect.Controls.Add(this.radioButtonPlayers);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(598, 94);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonHistory
            // 
            this.radioButtonHistory.AutoSize = true;
            this.radioButtonHistory.Location = new System.Drawing.Point(403, 42);
            this.radioButtonHistory.Name = "radioButtonHistory";
            this.radioButtonHistory.Size = new System.Drawing.Size(57, 17);
            this.radioButtonHistory.TabIndex = 2;
            this.radioButtonHistory.TabStop = true;
            this.radioButtonHistory.Text = "History";
            this.radioButtonHistory.UseVisualStyleBackColor = true;
            this.radioButtonHistory.CheckedChanged += new System.EventHandler(this.radioButtonHistory_CheckedChanged);
            // 
            // radioButtonMachines
            // 
            this.radioButtonMachines.AutoSize = true;
            this.radioButtonMachines.Location = new System.Drawing.Point(212, 42);
            this.radioButtonMachines.Name = "radioButtonMachines";
            this.radioButtonMachines.Size = new System.Drawing.Size(71, 17);
            this.radioButtonMachines.TabIndex = 1;
            this.radioButtonMachines.TabStop = true;
            this.radioButtonMachines.Text = "Machines";
            this.radioButtonMachines.UseVisualStyleBackColor = true;
            this.radioButtonMachines.CheckedChanged += new System.EventHandler(this.radioButtonMachines_CheckedChanged);
            // 
            // radioButtonPlayers
            // 
            this.radioButtonPlayers.AutoSize = true;
            this.radioButtonPlayers.Location = new System.Drawing.Point(48, 42);
            this.radioButtonPlayers.Name = "radioButtonPlayers";
            this.radioButtonPlayers.Size = new System.Drawing.Size(59, 17);
            this.radioButtonPlayers.TabIndex = 0;
            this.radioButtonPlayers.TabStop = true;
            this.radioButtonPlayers.Text = "Players";
            this.radioButtonPlayers.UseVisualStyleBackColor = true;
            this.radioButtonPlayers.CheckedChanged += new System.EventHandler(this.radioButtonPlayers_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewFSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxFSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(604, 387);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Полная запись SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFSelect
            // 
            this.dataGridViewFSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFSelect.Location = new System.Drawing.Point(3, 146);
            this.dataGridViewFSelect.Name = "dataGridViewFSelect";
            this.dataGridViewFSelect.Size = new System.Drawing.Size(598, 238);
            this.dataGridViewFSelect.TabIndex = 1;
            // 
            // groupBoxFSelect
            // 
            this.groupBoxFSelect.Controls.Add(this.buttonF_Select);
            this.groupBoxFSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFSelect.Controls.Add(this.textBoxPlayer);
            this.groupBoxFSelect.Controls.Add(this.labelPlayer);
            this.groupBoxFSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFSelect.Name = "groupBoxFSelect";
            this.groupBoxFSelect.Size = new System.Drawing.Size(598, 143);
            this.groupBoxFSelect.TabIndex = 0;
            this.groupBoxFSelect.TabStop = false;
            this.groupBoxFSelect.Text = "groupBox1";
            // 
            // buttonF_Select
            // 
            this.buttonF_Select.Location = new System.Drawing.Point(259, 105);
            this.buttonF_Select.Name = "buttonF_Select";
            this.buttonF_Select.Size = new System.Drawing.Size(75, 23);
            this.buttonF_Select.TabIndex = 6;
            this.buttonF_Select.Text = "Посчитать";
            this.buttonF_Select.UseVisualStyleBackColor = true;
            this.buttonF_Select.Click += new System.EventHandler(this.buttonF_Select_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(9, 86);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(198, 17);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Сортировать по убыванию ставки";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(156, 60);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(131, 20);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(9, 60);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(141, 17);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать ставки более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonMachine);
            this.groupBoxDet.Controls.Add(this.radioButtonWins);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_NO);
            this.groupBoxDet.Location = new System.Drawing.Point(367, 19);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(225, 109);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация движения денег";
            // 
            // radioButtonMachine
            // 
            this.radioButtonMachine.AutoSize = true;
            this.radioButtonMachine.Location = new System.Drawing.Point(16, 53);
            this.radioButtonMachine.Name = "radioButtonMachine";
            this.radioButtonMachine.Size = new System.Drawing.Size(97, 17);
            this.radioButtonMachine.TabIndex = 2;
            this.radioButtonMachine.TabStop = true;
            this.radioButtonMachine.Text = "По аппаратам";
            this.radioButtonMachine.UseVisualStyleBackColor = true;
            // 
            // radioButtonWins
            // 
            this.radioButtonWins.AutoSize = true;
            this.radioButtonWins.Location = new System.Drawing.Point(16, 28);
            this.radioButtonWins.Name = "radioButtonWins";
            this.radioButtonWins.Size = new System.Drawing.Size(118, 17);
            this.radioButtonWins.TabIndex = 1;
            this.radioButtonWins.TabStop = true;
            this.radioButtonWins.Text = "Только выигрыши";
            this.radioButtonWins.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_NO
            // 
            this.radioButtonDet_NO.AutoSize = true;
            this.radioButtonDet_NO.Location = new System.Drawing.Point(16, 76);
            this.radioButtonDet_NO.Name = "radioButtonDet_NO";
            this.radioButtonDet_NO.Size = new System.Drawing.Size(96, 17);
            this.radioButtonDet_NO.TabIndex = 0;
            this.radioButtonDet_NO.TabStop = true;
            this.radioButtonDet_NO.Text = "Общая сумма";
            this.radioButtonDet_NO.UseVisualStyleBackColor = true;
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Location = new System.Drawing.Point(156, 28);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(131, 20);
            this.textBoxPlayer.TabIndex = 1;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(100, 31);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(50, 13);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Player ID";
            // 
            // tabPageSubQuery
            // 
            this.tabPageSubQuery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubQuery.Controls.Add(this.groupBoxSubQuery);
            this.tabPageSubQuery.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubQuery.Name = "tabPageSubQuery";
            this.tabPageSubQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubQuery.Size = new System.Drawing.Size(604, 387);
            this.tabPageSubQuery.TabIndex = 2;
            this.tabPageSubQuery.Text = "Примеры подзапросов";
            this.tabPageSubQuery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 131);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.Size = new System.Drawing.Size(598, 253);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubQuery
            // 
            this.groupBoxSubQuery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubQuery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubQuery.Controls.Add(this.label1);
            this.groupBoxSubQuery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubQuery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubQuery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubQuery.Name = "groupBoxSubQuery";
            this.groupBoxSubQuery.Size = new System.Drawing.Size(598, 128);
            this.groupBoxSubQuery.TabIndex = 0;
            this.groupBoxSubQuery.TabStop = false;
            this.groupBoxSubQuery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(221, 99);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(147, 23);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить запрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(249, 67);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(132, 20);
            this.textBoxNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID игры";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(322, 28);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(170, 17);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный запрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(120, 28);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(157, 17);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный запрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewSlots);
            this.tabPageDML.Controls.Add(this.panelSlot);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(604, 387);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.textBoxId_slot);
            this.groupBoxDML.Controls.Add(this.labelIDSlot);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete_Slot);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate_Slot);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert_Slot);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(598, 118);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // radioButtonInsert_Slot
            // 
            this.radioButtonInsert_Slot.AutoSize = true;
            this.radioButtonInsert_Slot.Location = new System.Drawing.Point(22, 19);
            this.radioButtonInsert_Slot.Name = "radioButtonInsert_Slot";
            this.radioButtonInsert_Slot.Size = new System.Drawing.Size(180, 17);
            this.radioButtonInsert_Slot.TabIndex = 0;
            this.radioButtonInsert_Slot.TabStop = true;
            this.radioButtonInsert_Slot.Text = "Добавить данные по аппарату";
            this.radioButtonInsert_Slot.UseVisualStyleBackColor = true;
            this.radioButtonInsert_Slot.CheckedChanged += new System.EventHandler(this.radioButtonInsert_Slot_CheckedChanged);
            // 
            // radioButtonUpdate_Slot
            // 
            this.radioButtonUpdate_Slot.AutoSize = true;
            this.radioButtonUpdate_Slot.Location = new System.Drawing.Point(232, 19);
            this.radioButtonUpdate_Slot.Name = "radioButtonUpdate_Slot";
            this.radioButtonUpdate_Slot.Size = new System.Drawing.Size(259, 17);
            this.radioButtonUpdate_Slot.TabIndex = 1;
            this.radioButtonUpdate_Slot.TabStop = true;
            this.radioButtonUpdate_Slot.Text = "Изменить данные по аппарату с заданным ID";
            this.radioButtonUpdate_Slot.UseVisualStyleBackColor = true;
            this.radioButtonUpdate_Slot.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_Slot_CheckedChanged);
            // 
            // radioButtonDelete_Slot
            // 
            this.radioButtonDelete_Slot.AutoSize = true;
            this.radioButtonDelete_Slot.Location = new System.Drawing.Point(232, 42);
            this.radioButtonDelete_Slot.Name = "radioButtonDelete_Slot";
            this.radioButtonDelete_Slot.Size = new System.Drawing.Size(251, 17);
            this.radioButtonDelete_Slot.TabIndex = 2;
            this.radioButtonDelete_Slot.TabStop = true;
            this.radioButtonDelete_Slot.Text = "Удалить данные по аппарату с заданным ID";
            this.radioButtonDelete_Slot.UseVisualStyleBackColor = true;
            this.radioButtonDelete_Slot.CheckedChanged += new System.EventHandler(this.radioButtonDelete_Slot_CheckedChanged);
            // 
            // labelIDSlot
            // 
            this.labelIDSlot.AutoSize = true;
            this.labelIDSlot.Location = new System.Drawing.Point(19, 79);
            this.labelIDSlot.Name = "labelIDSlot";
            this.labelIDSlot.Size = new System.Drawing.Size(68, 13);
            this.labelIDSlot.TabIndex = 3;
            this.labelIDSlot.Text = "ID аппарата";
            // 
            // textBoxId_slot
            // 
            this.textBoxId_slot.Location = new System.Drawing.Point(93, 76);
            this.textBoxId_slot.Name = "textBoxId_slot";
            this.textBoxId_slot.Size = new System.Drawing.Size(100, 20);
            this.textBoxId_slot.TabIndex = 4;
            // 
            // panelSlot
            // 
            this.panelSlot.Controls.Add(this.buttonSelectSlots);
            this.panelSlot.Controls.Add(this.textBoxBet_slot);
            this.panelSlot.Controls.Add(this.textBoxName_slot);
            this.panelSlot.Controls.Add(this.label3);
            this.panelSlot.Controls.Add(this.label2);
            this.panelSlot.Location = new System.Drawing.Point(3, 127);
            this.panelSlot.Name = "panelSlot";
            this.panelSlot.Size = new System.Drawing.Size(598, 92);
            this.panelSlot.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название аппарата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Размер ставки";
            // 
            // textBoxName_slot
            // 
            this.textBoxName_slot.Location = new System.Drawing.Point(145, 13);
            this.textBoxName_slot.Name = "textBoxName_slot";
            this.textBoxName_slot.Size = new System.Drawing.Size(100, 20);
            this.textBoxName_slot.TabIndex = 2;
            // 
            // textBoxBet_slot
            // 
            this.textBoxBet_slot.Location = new System.Drawing.Point(145, 45);
            this.textBoxBet_slot.Name = "textBoxBet_slot";
            this.textBoxBet_slot.Size = new System.Drawing.Size(100, 20);
            this.textBoxBet_slot.TabIndex = 3;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(262, 79);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(172, 23);
            this.buttonExecuteDML.TabIndex = 5;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // buttonSelectSlots
            // 
            this.buttonSelectSlots.Location = new System.Drawing.Point(363, 66);
            this.buttonSelectSlots.Name = "buttonSelectSlots";
            this.buttonSelectSlots.Size = new System.Drawing.Size(172, 23);
            this.buttonSelectSlots.TabIndex = 4;
            this.buttonSelectSlots.Text = "Показать список аппаратов";
            this.buttonSelectSlots.UseVisualStyleBackColor = true;
            this.buttonSelectSlots.Click += new System.EventHandler(this.buttonSelectSlots_Click);
            // 
            // dataGridViewSlots
            // 
            this.dataGridViewSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSlots.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewSlots.Location = new System.Drawing.Point(3, 225);
            this.dataGridViewSlots.Name = "dataGridViewSlots";
            this.dataGridViewSlots.Size = new System.Drawing.Size(598, 159);
            this.dataGridViewSlots.TabIndex = 2;
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 413);
            this.Controls.Add(this.tabControlSQL);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPagePrimer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFSelect)).EndInit();
            this.groupBoxFSelect.ResumeLayout(false);
            this.groupBoxFSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubQuery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubQuery.ResumeLayout(false);
            this.groupBoxSubQuery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelSlot.ResumeLayout(false);
            this.panelSlot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSlots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPagePrimer;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonHistory;
        private System.Windows.Forms.RadioButton radioButtonMachines;
        private System.Windows.Forms.RadioButton radioButtonPlayers;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.GroupBox groupBoxFSelect;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonWins;
        private System.Windows.Forms.RadioButton radioButtonDet_NO;
        private System.Windows.Forms.TextBox textBoxPlayer;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.DataGridView dataGridViewFSelect;
        private System.Windows.Forms.Button buttonF_Select;
        private System.Windows.Forms.RadioButton radioButtonMachine;
        private System.Windows.Forms.TabPage tabPageSubQuery;
        private System.Windows.Forms.GroupBox groupBoxSubQuery;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.RadioButton radioButtonDelete_Slot;
        private System.Windows.Forms.RadioButton radioButtonUpdate_Slot;
        private System.Windows.Forms.RadioButton radioButtonInsert_Slot;
        private System.Windows.Forms.Panel panelSlot;
        private System.Windows.Forms.TextBox textBoxId_slot;
        private System.Windows.Forms.Label labelIDSlot;
        private System.Windows.Forms.DataGridView dataGridViewSlots;
        private System.Windows.Forms.Button buttonSelectSlots;
        private System.Windows.Forms.TextBox textBoxBet_slot;
        private System.Windows.Forms.TextBox textBoxName_slot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExecuteDML;
    }
}