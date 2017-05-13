namespace Laba7
{
    partial class Cre
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airportDataSet1 = new Laba7.AirportDataSet1();
            this.crewmembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crewmembersTableAdapter = new Laba7.AirportDataSet1TableAdapters.CrewmembersTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewmembersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.planeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.crewmembersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(549, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // airportDataSet1
            // 
            this.airportDataSet1.DataSetName = "AirportDataSet1";
            this.airportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // crewmembersBindingSource
            // 
            this.crewmembersBindingSource.DataMember = "Crewmembers";
            this.crewmembersBindingSource.DataSource = this.airportDataSet1;
            // 
            // crewmembersTableAdapter
            // 
            this.crewmembersTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "Experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "Experience";
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            // 
            // planeidDataGridViewTextBoxColumn
            // 
            this.planeidDataGridViewTextBoxColumn.DataPropertyName = "Planeid";
            this.planeidDataGridViewTextBoxColumn.HeaderText = "Planeid";
            this.planeidDataGridViewTextBoxColumn.Name = "planeidDataGridViewTextBoxColumn";
            // 
            // Cre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 315);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cre";
            this.Text = "Cre";
            this.Load += new System.EventHandler(this.Cre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crewmembersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AirportDataSet1 airportDataSet1;
        private System.Windows.Forms.BindingSource crewmembersBindingSource;
        private AirportDataSet1TableAdapters.CrewmembersTableAdapter crewmembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeidDataGridViewTextBoxColumn;
    }
}