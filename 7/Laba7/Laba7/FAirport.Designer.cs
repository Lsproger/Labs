

namespace Laba7
{
   // using System.ComponentModel.DataAnnotations;
    partial class FAirport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAirport));
            this.BAddAIrplane = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.listPlanes = new System.Windows.Forms.ListBox();
            this.BTShowList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_Company = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_Type = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_NumbOfPlaces = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_Carrying = new System.Windows.Forms.ToolStripMenuItem();
            this.Search_ComboSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort_FirstPilot = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort_SecPilot = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort_LastTO = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.авиакомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типуСамолётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествуМестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.грузоподъёмностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.несколькоКритериевToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.фИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.командираToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пилотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаПоследнегоТОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.hideToolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TBDateTime = new System.Windows.Forms.ToolStripTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.RightToolStripPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BAddAIrplane
            // 
            this.BAddAIrplane.Location = new System.Drawing.Point(12, 27);
            this.BAddAIrplane.Name = "BAddAIrplane";
            this.BAddAIrplane.Size = new System.Drawing.Size(75, 23);
            this.BAddAIrplane.TabIndex = 0;
            this.BAddAIrplane.Text = "Add airplane";
            this.BAddAIrplane.UseVisualStyleBackColor = true;
            this.BAddAIrplane.Click += new System.EventHandler(this.BAddAIrplane_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.Location = new System.Drawing.Point(93, 27);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(75, 23);
            this.BRefresh.TabIndex = 1;
            this.BRefresh.Text = "Refresh";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // listPlanes
            // 
            this.listPlanes.BackColor = System.Drawing.Color.Azure;
            this.listPlanes.FormattingEnabled = true;
            this.listPlanes.HorizontalScrollbar = true;
            this.listPlanes.Location = new System.Drawing.Point(12, 56);
            this.listPlanes.Name = "listPlanes";
            this.listPlanes.Size = new System.Drawing.Size(403, 355);
            this.listPlanes.Sorted = true;
            this.listPlanes.TabIndex = 2;
            this.listPlanes.Visible = false;
            // 
            // BTShowList
            // 
            this.BTShowList.Location = new System.Drawing.Point(174, 27);
            this.BTShowList.Name = "BTShowList";
            this.BTShowList.Size = new System.Drawing.Size(75, 23);
            this.BTShowList.TabIndex = 3;
            this.BTShowList.Text = "Show list";
            this.BTShowList.UseVisualStyleBackColor = true;
            this.BTShowList.Click += new System.EventHandler(this.BTShowList_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаПоToolStripMenuItem,
            this.Menu_Save,
            this.About,
            this.hideToolbarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search_Company,
            this.Search_Type,
            this.Search_NumbOfPlaces,
            this.Search_Carrying,
            this.Search_ComboSearch});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.поискToolStripMenuItem.Text = "Поиск по";
            // 
            // Search_Company
            // 
            this.Search_Company.Name = "Search_Company";
            this.Search_Company.Size = new System.Drawing.Size(194, 22);
            this.Search_Company.Text = "Авиакомпании";
            // 
            // Search_Type
            // 
            this.Search_Type.Name = "Search_Type";
            this.Search_Type.Size = new System.Drawing.Size(194, 22);
            this.Search_Type.Text = "По типу самолоёта";
            // 
            // Search_NumbOfPlaces
            // 
            this.Search_NumbOfPlaces.Name = "Search_NumbOfPlaces";
            this.Search_NumbOfPlaces.Size = new System.Drawing.Size(194, 22);
            this.Search_NumbOfPlaces.Text = "Количеству мест";
            // 
            // Search_Carrying
            // 
            this.Search_Carrying.Name = "Search_Carrying";
            this.Search_Carrying.Size = new System.Drawing.Size(194, 22);
            this.Search_Carrying.Text = "Грузоподъёмности";
            // 
            // Search_ComboSearch
            // 
            this.Search_ComboSearch.Name = "Search_ComboSearch";
            this.Search_ComboSearch.Size = new System.Drawing.Size(194, 22);
            this.Search_ComboSearch.Text = "Несколько критериев";
            this.Search_ComboSearch.Click += new System.EventHandler(this.Search_ComboSearch_Click_1);
            // 
            // сортировкаПоToolStripMenuItem
            // 
            this.сортировкаПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фамилииToolStripMenuItem,
            this.Sort_LastTO});
            this.сортировкаПоToolStripMenuItem.Name = "сортировкаПоToolStripMenuItem";
            this.сортировкаПоToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.сортировкаПоToolStripMenuItem.Text = "Сортировка по";
            // 
            // фамилииToolStripMenuItem
            // 
            this.фамилииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sort_FirstPilot,
            this.Sort_SecPilot});
            this.фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            this.фамилииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фамилииToolStripMenuItem.Text = "ФИО";
            // 
            // Sort_FirstPilot
            // 
            this.Sort_FirstPilot.Name = "Sort_FirstPilot";
            this.Sort_FirstPilot.Size = new System.Drawing.Size(136, 22);
            this.Sort_FirstPilot.Text = "Командира";
            // 
            // Sort_SecPilot
            // 
            this.Sort_SecPilot.Name = "Sort_SecPilot";
            this.Sort_SecPilot.Size = new System.Drawing.Size(136, 22);
            this.Sort_SecPilot.Text = "Пилота";
            // 
            // Sort_LastTO
            // 
            this.Sort_LastTO.Name = "Sort_LastTO";
            this.Sort_LastTO.Size = new System.Drawing.Size(180, 22);
            this.Sort_LastTO.Text = "Дата последнео ТО";
            // 
            // Menu_Save
            // 
            this.Menu_Save.Name = "Menu_Save";
            this.Menu_Save.Size = new System.Drawing.Size(77, 20);
            this.Menu_Save.Text = "Сохранить";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(94, 20);
            this.About.Text = "О программе";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator2,
            this.toolStripDropDownButton2,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator5,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.pBar,
            this.TBDateTime});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(104, 191);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авиакомпанииToolStripMenuItem,
            this.типуСамолётаToolStripMenuItem,
            this.количествуМестToolStripMenuItem,
            this.грузоподъёмностиToolStripMenuItem,
            this.несколькоКритериевToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(102, 19);
            this.toolStripDropDownButton1.Text = "Поиск по";
            // 
            // авиакомпанииToolStripMenuItem
            // 
            this.авиакомпанииToolStripMenuItem.Name = "авиакомпанииToolStripMenuItem";
            this.авиакомпанииToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.авиакомпанииToolStripMenuItem.Text = "Авиакомпании";
            // 
            // типуСамолётаToolStripMenuItem
            // 
            this.типуСамолётаToolStripMenuItem.Name = "типуСамолётаToolStripMenuItem";
            this.типуСамолётаToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.типуСамолётаToolStripMenuItem.Text = "Типу самолёта";
            // 
            // количествуМестToolStripMenuItem
            // 
            this.количествуМестToolStripMenuItem.Name = "количествуМестToolStripMenuItem";
            this.количествуМестToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.количествуМестToolStripMenuItem.Text = "Количеству мест";
            // 
            // грузоподъёмностиToolStripMenuItem
            // 
            this.грузоподъёмностиToolStripMenuItem.Name = "грузоподъёмностиToolStripMenuItem";
            this.грузоподъёмностиToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.грузоподъёмностиToolStripMenuItem.Text = "Грузоподъёмности";
            // 
            // несколькоКритериевToolStripMenuItem
            // 
            this.несколькоКритериевToolStripMenuItem.Name = "несколькоКритериевToolStripMenuItem";
            this.несколькоКритериевToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.несколькоКритериевToolStripMenuItem.Text = "Несколько критериев";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(102, 6);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИОToolStripMenuItem,
            this.датаПоследнегоТОToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(102, 19);
            this.toolStripDropDownButton2.Text = "Сортировка по";
            // 
            // фИОToolStripMenuItem
            // 
            this.фИОToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.командираToolStripMenuItem,
            this.пилотаToolStripMenuItem});
            this.фИОToolStripMenuItem.Name = "фИОToolStripMenuItem";
            this.фИОToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.фИОToolStripMenuItem.Text = "ФИО";
            // 
            // командираToolStripMenuItem
            // 
            this.командираToolStripMenuItem.Name = "командираToolStripMenuItem";
            this.командираToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.командираToolStripMenuItem.Text = "Командира";
            // 
            // пилотаToolStripMenuItem
            // 
            this.пилотаToolStripMenuItem.Name = "пилотаToolStripMenuItem";
            this.пилотаToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.пилотаToolStripMenuItem.Text = "Пилота";
            // 
            // датаПоследнегоТОToolStripMenuItem
            // 
            this.датаПоследнегоТОToolStripMenuItem.Name = "датаПоследнегоТОToolStripMenuItem";
            this.датаПоследнегоТОToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.датаПоследнегоТОToolStripMenuItem.Text = "Дата последнего ТО";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(102, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(102, 19);
            this.toolStripButton1.Text = "Сохранить";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(102, 6);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(102, 19);
            this.toolStripButton2.Text = "О программе";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(102, 6);
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.SystemColors.Highlight;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(100, 15);
            this.pBar.ToolTipText = "Ход выполнения";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Aquamarine;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BTShowList);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.listPlanes);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BRefresh);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.BAddAIrplane);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(418, 420);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.Size = new System.Drawing.Size(522, 444);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(102, 19);
            this.toolStripButton3.Text = "Hide";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(102, 6);
            // 
            // hideToolbarToolStripMenuItem
            // 
            this.hideToolbarToolStripMenuItem.Name = "hideToolbarToolStripMenuItem";
            this.hideToolbarToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.hideToolbarToolStripMenuItem.Text = "toolbar";
            this.hideToolbarToolStripMenuItem.Click += new System.EventHandler(this.hideToolbarToolStripMenuItem_Click);
            // 
            // TBDateTime
            // 
            this.TBDateTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBDateTime.Name = "TBDateTime";
            this.TBDateTime.ReadOnly = true;
            this.TBDateTime.Size = new System.Drawing.Size(100, 22);
            this.TBDateTime.Click += new System.EventHandler(this.TBDateTime_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show using LINQ to XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(522, 444);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FAirport";
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.Airport_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.RightToolStripPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAddAIrplane;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.ListBox listPlanes;
        private System.Windows.Forms.Button BTShowList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Search_Type;
        private System.Windows.Forms.ToolStripMenuItem Search_NumbOfPlaces;
        private System.Windows.Forms.ToolStripMenuItem Search_Carrying;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Sort_FirstPilot;
        private System.Windows.Forms.ToolStripMenuItem Sort_SecPilot;
        private System.Windows.Forms.ToolStripMenuItem Sort_LastTO;
        private System.Windows.Forms.ToolStripMenuItem Menu_Save;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Search_ComboSearch;
        private System.Windows.Forms.ToolStripMenuItem Search_Company;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripProgressBar pBar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem авиакомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типуСамолётаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествуМестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem несколькоКритериевToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаПоследнегоТОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem командираToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пилотаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem грузоподъёмностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem hideToolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TBDateTime;
        private System.Windows.Forms.Button button1;
    }
}

