

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAirport));
            this.BAddAIrplane = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.planeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.X_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.airplanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airportDataSet = new Laba7.AirportDataSet();
            this.airplanesTableAdapter = new Laba7.AirportDataSetTableAdapters.AirplanesTableAdapter();
            this._saveChanges = new System.Windows.Forms.Button();
            this._sortAP = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add crewer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planeIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.placesDataGridViewTextBoxColumn,
            this.issueDataGridViewTextBoxColumn,
            this.picDataGridViewImageColumn,
            this.X_Delete});
            this.dataGridView1.DataSource = this.airplanesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(688, 450);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // planeIdDataGridViewTextBoxColumn
            // 
            this.planeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaneId";
            this.planeIdDataGridViewTextBoxColumn.HeaderText = "PlaneId";
            this.planeIdDataGridViewTextBoxColumn.Name = "planeIdDataGridViewTextBoxColumn";
            this.planeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // placesDataGridViewTextBoxColumn
            // 
            this.placesDataGridViewTextBoxColumn.DataPropertyName = "Places";
            this.placesDataGridViewTextBoxColumn.HeaderText = "Places";
            this.placesDataGridViewTextBoxColumn.Name = "placesDataGridViewTextBoxColumn";
            // 
            // issueDataGridViewTextBoxColumn
            // 
            this.issueDataGridViewTextBoxColumn.DataPropertyName = "Issue";
            this.issueDataGridViewTextBoxColumn.HeaderText = "Issue";
            this.issueDataGridViewTextBoxColumn.Name = "issueDataGridViewTextBoxColumn";
            // 
            // picDataGridViewImageColumn
            // 
            this.picDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.picDataGridViewImageColumn.DataPropertyName = "Pic";
            this.picDataGridViewImageColumn.HeaderText = "Pic";
            this.picDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.picDataGridViewImageColumn.Name = "picDataGridViewImageColumn";
            // 
            // X_Delete
            // 
            this.X_Delete.DataPropertyName = "X";
            this.X_Delete.HeaderText = "";
            this.X_Delete.Name = "X_Delete";
            this.X_Delete.Text = "X";
            this.X_Delete.UseColumnTextForButtonValue = true;
            this.X_Delete.Width = 30;
            // 
            // airplanesBindingSource
            // 
            this.airplanesBindingSource.DataMember = "Airplanes";
            this.airplanesBindingSource.DataSource = this.airportDataSetBindingSource;
            // 
            // airportDataSetBindingSource
            // 
            this.airportDataSetBindingSource.DataSource = this.airportDataSet;
            this.airportDataSetBindingSource.Position = 0;
            // 
            // airportDataSet
            // 
            this.airportDataSet.DataSetName = "AirportDataSet";
            this.airportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airplanesTableAdapter
            // 
            this.airplanesTableAdapter.ClearBeforeFill = true;
            // 
            // _saveChanges
            // 
            this._saveChanges.Location = new System.Drawing.Point(267, 27);
            this._saveChanges.Name = "_saveChanges";
            this._saveChanges.Size = new System.Drawing.Size(100, 23);
            this._saveChanges.TabIndex = 5;
            this._saveChanges.Text = "Save changes";
            this._saveChanges.UseVisualStyleBackColor = true;
            this._saveChanges.Click += new System.EventHandler(this._saveChanges_Click);
            // 
            // _sortAP
            // 
            this._sortAP.Location = new System.Drawing.Point(94, 27);
            this._sortAP.Name = "_sortAP";
            this._sortAP.Size = new System.Drawing.Size(75, 23);
            this._sortAP.TabIndex = 6;
            this._sortAP.Text = "Show crews";
            this._sortAP.UseVisualStyleBackColor = true;
            this._sortAP.Click += new System.EventHandler(this._sortAP_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "vverh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(707, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "vniz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this._sortAP);
            this.Controls.Add(this._saveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BAddAIrplane);
            this.Name = "FAirport";
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.Airport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airplanesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAddAIrplane;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource airportDataSetBindingSource;
        private AirportDataSet airportDataSet;
        private System.Windows.Forms.BindingSource airplanesBindingSource;
        private AirportDataSetTableAdapters.AirplanesTableAdapter airplanesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn picDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn X_Delete;
        private System.Windows.Forms.Button _saveChanges;
        private System.Windows.Forms.Button _sortAP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

