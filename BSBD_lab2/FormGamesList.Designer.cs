namespace BSBD_lab2
{
    partial class FormGamesList
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
            System.Windows.Forms.Label iD_аппаратаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label размер_ставкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGamesList));
            this.lab_1DataSet = new BSBD_lab2.Lab_1DataSet();
            this.аппаратыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.аппаратыTableAdapter = new BSBD_lab2.Lab_1DataSetTableAdapters.АппаратыTableAdapter();
            this.tableAdapterManager = new BSBD_lab2.Lab_1DataSetTableAdapters.TableAdapterManager();
            this.аппаратыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.аппаратыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_аппаратаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.размер_ставкиTextBox = new System.Windows.Forms.TextBox();
            iD_аппаратаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            размер_ставкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lab_1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аппаратыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.аппаратыBindingNavigator)).BeginInit();
            this.аппаратыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_аппаратаLabel
            // 
            iD_аппаратаLabel.AutoSize = true;
            iD_аппаратаLabel.Location = new System.Drawing.Point(90, 72);
            iD_аппаратаLabel.Name = "iD_аппаратаLabel";
            iD_аппаратаLabel.Size = new System.Drawing.Size(71, 13);
            iD_аппаратаLabel.TabIndex = 1;
            iD_аппаратаLabel.Text = "ID аппарата:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(90, 98);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(60, 13);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // размер_ставкиLabel
            // 
            размер_ставкиLabel.AutoSize = true;
            размер_ставкиLabel.Location = new System.Drawing.Point(90, 124);
            размер_ставкиLabel.Name = "размер_ставкиLabel";
            размер_ставкиLabel.Size = new System.Drawing.Size(87, 13);
            размер_ставкиLabel.TabIndex = 5;
            размер_ставкиLabel.Text = "Размер ставки:";
            // 
            // lab_1DataSet
            // 
            this.lab_1DataSet.DataSetName = "Lab_1DataSet";
            this.lab_1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // аппаратыBindingSource
            // 
            this.аппаратыBindingSource.DataMember = "Аппараты";
            this.аппаратыBindingSource.DataSource = this.lab_1DataSet;
            // 
            // аппаратыTableAdapter
            // 
            this.аппаратыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = BSBD_lab2.Lab_1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АппаратыTableAdapter = this.аппаратыTableAdapter;
            this.tableAdapterManager.ИгрокиTableAdapter = null;
            this.tableAdapterManager.История_игрTableAdapter = null;
            // 
            // аппаратыBindingNavigator
            // 
            this.аппаратыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.аппаратыBindingNavigator.BindingSource = this.аппаратыBindingSource;
            this.аппаратыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.аппаратыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.аппаратыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.аппаратыBindingNavigatorSaveItem});
            this.аппаратыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.аппаратыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.аппаратыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.аппаратыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.аппаратыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.аппаратыBindingNavigator.Name = "аппаратыBindingNavigator";
            this.аппаратыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.аппаратыBindingNavigator.Size = new System.Drawing.Size(377, 25);
            this.аппаратыBindingNavigator.TabIndex = 0;
            this.аппаратыBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveNextItem.MergeIndex = 1;
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
            // аппаратыBindingNavigatorSaveItem
            // 
            this.аппаратыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.аппаратыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("аппаратыBindingNavigatorSaveItem.Image")));
            this.аппаратыBindingNavigatorSaveItem.Name = "аппаратыBindingNavigatorSaveItem";
            this.аппаратыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.аппаратыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.аппаратыBindingNavigatorSaveItem.Click += new System.EventHandler(this.аппаратыBindingNavigatorSaveItem_Click);
            // 
            // iD_аппаратаTextBox
            // 
            this.iD_аппаратаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аппаратыBindingSource, "ID аппарата", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "+1", "N0"));
            this.iD_аппаратаTextBox.Location = new System.Drawing.Point(183, 69);
            this.iD_аппаратаTextBox.Name = "iD_аппаратаTextBox";
            this.iD_аппаратаTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_аппаратаTextBox.TabIndex = 2;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аппаратыBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(183, 95);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(100, 20);
            this.названиеTextBox.TabIndex = 4;
            // 
            // размер_ставкиTextBox
            // 
            this.размер_ставкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.аппаратыBindingSource, "Размер ставки", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.размер_ставкиTextBox.Location = new System.Drawing.Point(183, 121);
            this.размер_ставкиTextBox.Name = "размер_ставкиTextBox";
            this.размер_ставкиTextBox.Size = new System.Drawing.Size(100, 20);
            this.размер_ставкиTextBox.TabIndex = 6;
            // 
            // FormGamesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 199);
            this.Controls.Add(iD_аппаратаLabel);
            this.Controls.Add(this.iD_аппаратаTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(размер_ставкиLabel);
            this.Controls.Add(this.размер_ставкиTextBox);
            this.Controls.Add(this.аппаратыBindingNavigator);
            this.Name = "FormGamesList";
            this.Text = "Список аппаратов";
            this.Load += new System.EventHandler(this.FormGamesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lab_1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аппаратыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.аппаратыBindingNavigator)).EndInit();
            this.аппаратыBindingNavigator.ResumeLayout(false);
            this.аппаратыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lab_1DataSet lab_1DataSet;
        private System.Windows.Forms.BindingSource аппаратыBindingSource;
        private Lab_1DataSetTableAdapters.АппаратыTableAdapter аппаратыTableAdapter;
        private Lab_1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator аппаратыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton аппаратыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_аппаратаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox размер_ставкиTextBox;
    }
}