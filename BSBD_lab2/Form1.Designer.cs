namespace BSBD_lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.about_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАппаратовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокИгроковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.игрокиИсторияИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.справочникToolStripMenuItem,
            this.базыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_toolStripMenuItem,
            this.close_toolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // about_toolStripMenuItem
            // 
            this.about_toolStripMenuItem.Name = "about_toolStripMenuItem";
            this.about_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.about_toolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.about_toolStripMenuItem.Text = "О программе";
            this.about_toolStripMenuItem.Click += new System.EventHandler(this.about_toolStripMenuItem_Click);
            // 
            // close_toolStripMenuItem
            // 
            this.close_toolStripMenuItem.Name = "close_toolStripMenuItem";
            this.close_toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.close_toolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.close_toolStripMenuItem.Text = "Выход";
            this.close_toolStripMenuItem.Click += new System.EventHandler(this.close_toolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокАппаратовToolStripMenuItem,
            this.списокИгроковToolStripMenuItem,
            this.историяИгрToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // списокАппаратовToolStripMenuItem
            // 
            this.списокАппаратовToolStripMenuItem.Name = "списокАппаратовToolStripMenuItem";
            this.списокАппаратовToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.списокАппаратовToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.списокАппаратовToolStripMenuItem.Text = "Список аппаратов";
            this.списокАппаратовToolStripMenuItem.Click += new System.EventHandler(this.списокАппаратовToolStripMenuItem_Click);
            // 
            // списокИгроковToolStripMenuItem
            // 
            this.списокИгроковToolStripMenuItem.Name = "списокИгроковToolStripMenuItem";
            this.списокИгроковToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.списокИгроковToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.списокИгроковToolStripMenuItem.Text = "Список игроков";
            this.списокИгроковToolStripMenuItem.Click += new System.EventHandler(this.списокИгроковToolStripMenuItem_Click);
            // 
            // историяИгрToolStripMenuItem
            // 
            this.историяИгрToolStripMenuItem.Name = "историяИгрToolStripMenuItem";
            this.историяИгрToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.историяИгрToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.историяИгрToolStripMenuItem.Text = "История игр";
            this.историяИгрToolStripMenuItem.Click += new System.EventHandler(this.историяИгрToolStripMenuItem_Click);
            // 
            // базыToolStripMenuItem
            // 
            this.базыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игрокиИсторияИгрToolStripMenuItem});
            this.базыToolStripMenuItem.Name = "базыToolStripMenuItem";
            this.базыToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.базыToolStripMenuItem.Text = "Базы";
            // 
            // игрокиИсторияИгрToolStripMenuItem
            // 
            this.игрокиИсторияИгрToolStripMenuItem.Name = "игрокиИсторияИгрToolStripMenuItem";
            this.игрокиИсторияИгрToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.игрокиИсторияИгрToolStripMenuItem.Text = "Игроки + История игр";
            this.игрокиИсторияИгрToolStripMenuItem.Click += new System.EventHandler(this.игрокиИсторияИгрToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem about_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem close_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокАппаратовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокИгроковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяИгрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem игрокиИсторияИгрToolStripMenuItem;
    }
}

