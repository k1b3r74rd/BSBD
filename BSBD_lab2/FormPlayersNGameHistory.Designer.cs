namespace BSBD_lab2
{
    partial class FormPlayersNGameHistory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_игрокаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label балансLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayersNGameHistory));
            System.Windows.Forms.Label iD_ФИОLabel;
            this.lab_1DataSet = new BSBD_lab2.Lab_1DataSet();
            this.игрокиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.игрокиTableAdapter = new BSBD_lab2.Lab_1DataSetTableAdapters.ИгрокиTableAdapter();
            this.tableAdapterManager = new BSBD_lab2.Lab_1DataSetTableAdapters.TableAdapterManager();
            this.история_игрTableAdapter = new BSBD_lab2.Lab_1DataSetTableAdapters.История_игрTableAdapter();
            this.игрокиBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.игрокиBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_игрокаTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.балансTextBox = new System.Windows.Forms.TextBox();
            this.PlayerGameHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.PlayerHistorybindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.история_игрBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayerHistorySave = new System.Windows.Forms.ToolStripButton();
            this.история_игрDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPlayer = new System.Windows.Forms.Button();
            this.iD_ФИОLabel1 = new System.Windows.Forms.Label();
            iD_игрокаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            балансLabel = new System.Windows.Forms.Label();
            iD_ФИОLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lab_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокиBindingNavigator)).BeginInit();
            this.игрокиBindingNavigator.SuspendLayout();
            this.PlayerGameHistoryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHistorybindingNavigator)).BeginInit();
            this.PlayerHistorybindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.история_игрBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_игрDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_игрокаLabel
            // 
            iD_игрокаLabel.AutoSize = true;
            iD_игрокаLabel.Location = new System.Drawing.Point(12, 39);
            iD_игрокаLabel.Name = "iD_игрокаLabel";
            iD_игрокаLabel.Size = new System.Drawing.Size(59, 13);
            iD_игрокаLabel.TabIndex = 1;
            iD_игрокаLabel.Text = "ID игрока:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(12, 65);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(37, 13);
            фИОLabel.TabIndex = 3;
            фИОLabel.Text = "ФИО:";
            // 
            // балансLabel
            // 
            балансLabel.AutoSize = true;
            балансLabel.Location = new System.Drawing.Point(12, 91);
            балансLabel.Name = "балансLabel";
            балансLabel.Size = new System.Drawing.Size(47, 13);
            балансLabel.TabIndex = 5;
            балансLabel.Text = "Баланс:";
            // 
            // lab_1DataSet
            // 
            this.lab_1DataSet.DataSetName = "Lab_1DataSet";
            this.lab_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // игрокиBindingSource
            // 
            this.игрокиBindingSource.DataMember = "Игроки";
            this.игрокиBindingSource.DataSource = this.lab_1DataSet;
            // 
            // игрокиTableAdapter
            // 
            this.игрокиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BSBD_lab2.Lab_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АппаратыTableAdapter = null;
            this.tableAdapterManager.ИгрокиTableAdapter = this.игрокиTableAdapter;
            this.tableAdapterManager.История_игрTableAdapter = this.история_игрTableAdapter;
            // 
            // история_игрTableAdapter
            // 
            this.история_игрTableAdapter.ClearBeforeFill = true;
            // 
            // игрокиBindingNavigator
            // 
            this.игрокиBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.игрокиBindingNavigator.BindingSource = this.игрокиBindingSource;
            this.игрокиBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.игрокиBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.игрокиBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.игрокиBindingNavigatorSaveItem});
            this.игрокиBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.игрокиBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.игрокиBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.игрокиBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.игрокиBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.игрокиBindingNavigator.Name = "игрокиBindingNavigator";
            this.игрокиBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.игрокиBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.игрокиBindingNavigator.TabIndex = 0;
            this.игрокиBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // игрокиBindingNavigatorSaveItem
            // 
            this.игрокиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.игрокиBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("игрокиBindingNavigatorSaveItem.Image")));
            this.игрокиBindingNavigatorSaveItem.Name = "игрокиBindingNavigatorSaveItem";
            this.игрокиBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.игрокиBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.игрокиBindingNavigatorSaveItem.Click += new System.EventHandler(this.игрокиBindingNavigatorSaveItem_Click);
            // 
            // iD_игрокаTextBox
            // 
            this.iD_игрокаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокиBindingSource, "ID игрока", true));
            this.iD_игрокаTextBox.Location = new System.Drawing.Point(77, 36);
            this.iD_игрокаTextBox.Name = "iD_игрокаTextBox";
            this.iD_игрокаTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_игрокаTextBox.TabIndex = 2;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокиBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(77, 62);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(100, 20);
            this.фИОTextBox.TabIndex = 4;
            // 
            // балансTextBox
            // 
            this.балансTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокиBindingSource, "Баланс", true));
            this.балансTextBox.Location = new System.Drawing.Point(77, 88);
            this.балансTextBox.Name = "балансTextBox";
            this.балансTextBox.Size = new System.Drawing.Size(100, 20);
            this.балансTextBox.TabIndex = 6;
            // 
            // PlayerGameHistoryGroupBox
            // 
            this.PlayerGameHistoryGroupBox.Controls.Add(this.PlayerHistorybindingNavigator);
            this.PlayerGameHistoryGroupBox.Controls.Add(this.история_игрDataGridView);
            this.PlayerGameHistoryGroupBox.Location = new System.Drawing.Point(12, 114);
            this.PlayerGameHistoryGroupBox.Name = "PlayerGameHistoryGroupBox";
            this.PlayerGameHistoryGroupBox.Size = new System.Drawing.Size(776, 424);
            this.PlayerGameHistoryGroupBox.TabIndex = 7;
            this.PlayerGameHistoryGroupBox.TabStop = false;
            this.PlayerGameHistoryGroupBox.Text = "История игрока";
            // 
            // PlayerHistorybindingNavigator
            // 
            this.PlayerHistorybindingNavigator.AddNewItem = this.toolStripButton1;
            this.PlayerHistorybindingNavigator.BindingSource = this.история_игрBindingSource;
            this.PlayerHistorybindingNavigator.CountItem = this.toolStripLabel1;
            this.PlayerHistorybindingNavigator.DeleteItem = this.toolStripButton2;
            this.PlayerHistorybindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.PlayerHistorySave});
            this.PlayerHistorybindingNavigator.Location = new System.Drawing.Point(3, 16);
            this.PlayerHistorybindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.PlayerHistorybindingNavigator.MoveLastItem = this.toolStripButton6;
            this.PlayerHistorybindingNavigator.MoveNextItem = this.toolStripButton5;
            this.PlayerHistorybindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.PlayerHistorybindingNavigator.Name = "PlayerHistorybindingNavigator";
            this.PlayerHistorybindingNavigator.PositionItem = this.toolStripTextBox1;
            this.PlayerHistorybindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.PlayerHistorybindingNavigator.TabIndex = 1;
            this.PlayerHistorybindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // история_игрBindingSource
            // 
            this.история_игрBindingSource.DataMember = "FK_ID_игрока";
            this.история_игрBindingSource.DataSource = this.игрокиBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(43, 22);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // PlayerHistorySave
            // 
            this.PlayerHistorySave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayerHistorySave.Image = ((System.Drawing.Image)(resources.GetObject("PlayerHistorySave.Image")));
            this.PlayerHistorySave.Name = "PlayerHistorySave";
            this.PlayerHistorySave.Size = new System.Drawing.Size(23, 22);
            this.PlayerHistorySave.Text = "Сохранить данные";
            this.PlayerHistorySave.Click += new System.EventHandler(this.PlayerHistorySave_Click);
            // 
            // история_игрDataGridView
            // 
            this.история_игрDataGridView.AutoGenerateColumns = false;
            this.история_игрDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.история_игрDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.история_игрDataGridView.DataSource = this.история_игрBindingSource;
            this.история_игрDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.история_игрDataGridView.Location = new System.Drawing.Point(3, 44);
            this.история_игрDataGridView.Name = "история_игрDataGridView";
            this.история_игрDataGridView.Size = new System.Drawing.Size(770, 377);
            this.история_игрDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID игры";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID игры";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID игрока";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID игрока";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ID аппарата";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID аппарата";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Размер ставки";
            this.dataGridViewTextBoxColumn5.HeaderText = "Размер ставки";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Выбор игрока";
            this.dataGridViewTextBoxColumn6.HeaderText = "Выбор игрока";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Результат";
            this.dataGridViewTextBoxColumn7.HeaderText = "Результат";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // buttonPlayer
            // 
            this.buttonPlayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlayer.Location = new System.Drawing.Point(222, 36);
            this.buttonPlayer.Name = "buttonPlayer";
            this.buttonPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayer.TabIndex = 8;
            this.buttonPlayer.Text = "Игрок";
            this.buttonPlayer.UseVisualStyleBackColor = true;
            this.buttonPlayer.Click += new System.EventHandler(this.buttonPlayer_Click);
            // 
            // iD_ФИОLabel
            // 
            iD_ФИОLabel.AutoSize = true;
            iD_ФИОLabel.Location = new System.Drawing.Point(219, 91);
            iD_ФИОLabel.Name = "iD_ФИОLabel";
            iD_ФИОLabel.Size = new System.Drawing.Size(54, 13);
            iD_ФИОLabel.TabIndex = 9;
            iD_ФИОLabel.Text = "ID+ФИО:";
            // 
            // iD_ФИОLabel1
            // 
            this.iD_ФИОLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.игрокиBindingSource, "ID+ФИО", true));
            this.iD_ФИОLabel1.Location = new System.Drawing.Point(279, 91);
            this.iD_ФИОLabel1.Name = "iD_ФИОLabel1";
            this.iD_ФИОLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_ФИОLabel1.TabIndex = 10;
            this.iD_ФИОLabel1.Text = "label1";
            // 
            // FormPlayersNGameHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 558);
            this.Controls.Add(iD_ФИОLabel);
            this.Controls.Add(this.iD_ФИОLabel1);
            this.Controls.Add(this.buttonPlayer);
            this.Controls.Add(this.PlayerGameHistoryGroupBox);
            this.Controls.Add(iD_игрокаLabel);
            this.Controls.Add(this.iD_игрокаTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(балансLabel);
            this.Controls.Add(this.балансTextBox);
            this.Controls.Add(this.игрокиBindingNavigator);
            this.Name = "FormPlayersNGameHistory";
            this.Text = "Игроки и История игр";
            this.Load += new System.EventHandler(this.FormPlayersNGameHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.игрокиBindingNavigator)).EndInit();
            this.игрокиBindingNavigator.ResumeLayout(false);
            this.игрокиBindingNavigator.PerformLayout();
            this.PlayerGameHistoryGroupBox.ResumeLayout(false);
            this.PlayerGameHistoryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHistorybindingNavigator)).EndInit();
            this.PlayerHistorybindingNavigator.ResumeLayout(false);
            this.PlayerHistorybindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.история_игрBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.история_игрDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab_1DataSet lab_1DataSet;
        private System.Windows.Forms.BindingSource игрокиBindingSource;
        private Lab_1DataSetTableAdapters.ИгрокиTableAdapter игрокиTableAdapter;
        private Lab_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator игрокиBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton игрокиBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_игрокаTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox балансTextBox;
        private System.Windows.Forms.GroupBox PlayerGameHistoryGroupBox;
        private Lab_1DataSetTableAdapters.История_игрTableAdapter история_игрTableAdapter;
        private System.Windows.Forms.BindingSource история_игрBindingSource;
        private System.Windows.Forms.BindingNavigator PlayerHistorybindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton PlayerHistorySave;
        private System.Windows.Forms.DataGridView история_игрDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button buttonPlayer;
        private System.Windows.Forms.Label iD_ФИОLabel1;
    }
}