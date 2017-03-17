namespace Laba7
{
    partial class FAddAirplane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddAirplane));
            this.TBAirplaneID = new System.Windows.Forms.TextBox();
            this.LBLAirplaneType = new System.Windows.Forms.Label();
            this.LBLAirplaneID = new System.Windows.Forms.Label();
            this.RBPassenger = new System.Windows.Forms.RadioButton();
            this.RBTransporter = new System.Windows.Forms.RadioButton();
            this.RBMilitary = new System.Windows.Forms.RadioButton();
            this.LBLAirplaneModel = new System.Windows.Forms.Label();
            this.TBAirplaneModel = new System.Windows.Forms.TextBox();
            this.LBLNumberOfPlaces = new System.Windows.Forms.Label();
            this.CBNumberOfPlaces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBYearOfIssue = new System.Windows.Forms.TrackBar();
            this.LYIssue = new System.Windows.Forms.Label();
            this.LBLCarrying = new System.Windows.Forms.Label();
            this.TBCarrying = new System.Windows.Forms.TextBox();
            this.LBLLastService = new System.Windows.Forms.Label();
            this.LSmonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.GoToCreateCrewForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBNumberOfMembers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBYearOfIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // TBAirplaneID
            // 
            this.TBAirplaneID.BackColor = System.Drawing.Color.DeepPink;
            this.TBAirplaneID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBAirplaneID.Location = new System.Drawing.Point(110, 10);
            this.TBAirplaneID.Name = "TBAirplaneID";
            this.TBAirplaneID.ReadOnly = true;
            this.TBAirplaneID.Size = new System.Drawing.Size(100, 20);
            this.TBAirplaneID.TabIndex = 1;
            // 
            // LBLAirplaneType
            // 
            this.LBLAirplaneType.AutoSize = true;
            this.LBLAirplaneType.BackColor = System.Drawing.Color.HotPink;
            this.LBLAirplaneType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLAirplaneType.Location = new System.Drawing.Point(11, 43);
            this.LBLAirplaneType.Name = "LBLAirplaneType";
            this.LBLAirplaneType.Size = new System.Drawing.Size(73, 15);
            this.LBLAirplaneType.TabIndex = 2;
            this.LBLAirplaneType.Text = "Airplane type:";
            // 
            // LBLAirplaneID
            // 
            this.LBLAirplaneID.AutoSize = true;
            this.LBLAirplaneID.BackColor = System.Drawing.Color.HotPink;
            this.LBLAirplaneID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLAirplaneID.Location = new System.Drawing.Point(11, 13);
            this.LBLAirplaneID.Name = "LBLAirplaneID";
            this.LBLAirplaneID.Size = new System.Drawing.Size(64, 15);
            this.LBLAirplaneID.TabIndex = 3;
            this.LBLAirplaneID.Text = "Airplane ID:";
            // 
            // RBPassenger
            // 
            this.RBPassenger.AutoSize = true;
            this.RBPassenger.BackColor = System.Drawing.Color.HotPink;
            this.RBPassenger.Location = new System.Drawing.Point(11, 61);
            this.RBPassenger.Name = "RBPassenger";
            this.RBPassenger.Size = new System.Drawing.Size(75, 17);
            this.RBPassenger.TabIndex = 4;
            this.RBPassenger.TabStop = true;
            this.RBPassenger.Text = "Passenger";
            this.RBPassenger.UseVisualStyleBackColor = false;
            // 
            // RBTransporter
            // 
            this.RBTransporter.AutoSize = true;
            this.RBTransporter.BackColor = System.Drawing.Color.HotPink;
            this.RBTransporter.Location = new System.Drawing.Point(94, 61);
            this.RBTransporter.Name = "RBTransporter";
            this.RBTransporter.Size = new System.Drawing.Size(79, 17);
            this.RBTransporter.TabIndex = 5;
            this.RBTransporter.TabStop = true;
            this.RBTransporter.Text = "Transporter";
            this.RBTransporter.UseVisualStyleBackColor = false;
            // 
            // RBMilitary
            // 
            this.RBMilitary.AutoSize = true;
            this.RBMilitary.BackColor = System.Drawing.Color.HotPink;
            this.RBMilitary.Location = new System.Drawing.Point(179, 61);
            this.RBMilitary.Name = "RBMilitary";
            this.RBMilitary.Size = new System.Drawing.Size(57, 17);
            this.RBMilitary.TabIndex = 6;
            this.RBMilitary.TabStop = true;
            this.RBMilitary.Text = "Military";
            this.RBMilitary.UseVisualStyleBackColor = false;
            // 
            // LBLAirplaneModel
            // 
            this.LBLAirplaneModel.AutoSize = true;
            this.LBLAirplaneModel.BackColor = System.Drawing.Color.HotPink;
            this.LBLAirplaneModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLAirplaneModel.Location = new System.Drawing.Point(12, 91);
            this.LBLAirplaneModel.Name = "LBLAirplaneModel";
            this.LBLAirplaneModel.Size = new System.Drawing.Size(81, 15);
            this.LBLAirplaneModel.TabIndex = 7;
            this.LBLAirplaneModel.Text = "Airplane model:";
            // 
            // TBAirplaneModel
            // 
            this.TBAirplaneModel.BackColor = System.Drawing.Color.LightPink;
            this.TBAirplaneModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBAirplaneModel.Location = new System.Drawing.Point(109, 88);
            this.TBAirplaneModel.Name = "TBAirplaneModel";
            this.TBAirplaneModel.Size = new System.Drawing.Size(164, 20);
            this.TBAirplaneModel.TabIndex = 8;
            // 
            // LBLNumberOfPlaces
            // 
            this.LBLNumberOfPlaces.AutoSize = true;
            this.LBLNumberOfPlaces.BackColor = System.Drawing.Color.HotPink;
            this.LBLNumberOfPlaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLNumberOfPlaces.Location = new System.Drawing.Point(12, 123);
            this.LBLNumberOfPlaces.Name = "LBLNumberOfPlaces";
            this.LBLNumberOfPlaces.Size = new System.Drawing.Size(92, 15);
            this.LBLNumberOfPlaces.TabIndex = 9;
            this.LBLNumberOfPlaces.Text = "Number of places";
            // 
            // CBNumberOfPlaces
            // 
            this.CBNumberOfPlaces.BackColor = System.Drawing.Color.LightPink;
            this.CBNumberOfPlaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBNumberOfPlaces.FormattingEnabled = true;
            this.CBNumberOfPlaces.Location = new System.Drawing.Point(109, 123);
            this.CBNumberOfPlaces.Name = "CBNumberOfPlaces";
            this.CBNumberOfPlaces.Size = new System.Drawing.Size(164, 21);
            this.CBNumberOfPlaces.TabIndex = 10;
            this.CBNumberOfPlaces.SelectedIndexChanged += new System.EventHandler(this.CBNumberOfPlaces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Year of Issue";
            // 
            // TBYearOfIssue
            // 
            this.TBYearOfIssue.BackColor = System.Drawing.Color.LightPink;
            this.TBYearOfIssue.Location = new System.Drawing.Point(109, 156);
            this.TBYearOfIssue.Maximum = 2020;
            this.TBYearOfIssue.Minimum = 1950;
            this.TBYearOfIssue.Name = "TBYearOfIssue";
            this.TBYearOfIssue.Size = new System.Drawing.Size(121, 45);
            this.TBYearOfIssue.TabIndex = 12;
            this.TBYearOfIssue.TickFrequency = 5;
            this.TBYearOfIssue.Value = 1950;
            this.TBYearOfIssue.Scroll += new System.EventHandler(this.TBYearOfIssue_Scroll);
            // 
            // LYIssue
            // 
            this.LYIssue.BackColor = System.Drawing.Color.HotPink;
            this.LYIssue.Location = new System.Drawing.Point(233, 156);
            this.LYIssue.Name = "LYIssue";
            this.LYIssue.Size = new System.Drawing.Size(40, 29);
            this.LYIssue.TabIndex = 13;
            this.LYIssue.Text = "1950";
            this.LYIssue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LYIssue.Click += new System.EventHandler(this.label2_Click);
            // 
            // LBLCarrying
            // 
            this.LBLCarrying.AutoSize = true;
            this.LBLCarrying.BackColor = System.Drawing.Color.HotPink;
            this.LBLCarrying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLCarrying.Location = new System.Drawing.Point(12, 188);
            this.LBLCarrying.Name = "LBLCarrying";
            this.LBLCarrying.Size = new System.Drawing.Size(65, 15);
            this.LBLCarrying.TabIndex = 14;
            this.LBLCarrying.Text = "Carrying, kg";
            // 
            // TBCarrying
            // 
            this.TBCarrying.BackColor = System.Drawing.Color.LightPink;
            this.TBCarrying.Location = new System.Drawing.Point(109, 188);
            this.TBCarrying.MaxLength = 6;
            this.TBCarrying.Name = "TBCarrying";
            this.TBCarrying.Size = new System.Drawing.Size(164, 20);
            this.TBCarrying.TabIndex = 15;
           // this.TBCarrying.TextChanged += new System.EventHandler(this.TBCarrying_TextChanged);
            // 
            // LBLLastService
            // 
            this.LBLLastService.AutoSize = true;
            this.LBLLastService.BackColor = System.Drawing.Color.HotPink;
            this.LBLLastService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLLastService.Location = new System.Drawing.Point(11, 222);
            this.LBLLastService.Name = "LBLLastService";
            this.LBLLastService.Size = new System.Drawing.Size(69, 15);
            this.LBLLastService.TabIndex = 16;
            this.LBLLastService.Text = "Last service:";
            // 
            // LSmonthCalendar
            // 
            this.LSmonthCalendar.BackColor = System.Drawing.Color.LightPink;
            this.LSmonthCalendar.Location = new System.Drawing.Point(109, 222);
            this.LSmonthCalendar.Name = "LSmonthCalendar";
            this.LSmonthCalendar.TabIndex = 17;
            // 
            // GoToCreateCrewForm
            // 
            this.GoToCreateCrewForm.BackColor = System.Drawing.Color.HotPink;
            this.GoToCreateCrewForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoToCreateCrewForm.Location = new System.Drawing.Point(14, 424);
            this.GoToCreateCrewForm.Name = "GoToCreateCrewForm";
            this.GoToCreateCrewForm.Size = new System.Drawing.Size(259, 27);
            this.GoToCreateCrewForm.TabIndex = 18;
            this.GoToCreateCrewForm.Text = "Next step (Adding crew members)";
            this.GoToCreateCrewForm.UseVisualStyleBackColor = false;
            this.GoToCreateCrewForm.Click += new System.EventHandler(this.GoToCreateCrewForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(13, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Number of members of crew:";
            // 
            // TBNumberOfMembers
            // 
            this.TBNumberOfMembers.BackColor = System.Drawing.Color.LightPink;
            this.TBNumberOfMembers.Location = new System.Drawing.Point(161, 397);
            this.TBNumberOfMembers.MaxLength = 2;
            this.TBNumberOfMembers.Name = "TBNumberOfMembers";
            this.TBNumberOfMembers.Size = new System.Drawing.Size(100, 20);
            this.TBNumberOfMembers.TabIndex = 20;
            // 
            // FAddAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 454);
            this.Controls.Add(this.TBNumberOfMembers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GoToCreateCrewForm);
            this.Controls.Add(this.LSmonthCalendar);
            this.Controls.Add(this.LBLLastService);
            this.Controls.Add(this.TBCarrying);
            this.Controls.Add(this.LBLCarrying);
            this.Controls.Add(this.LYIssue);
            this.Controls.Add(this.TBYearOfIssue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBNumberOfPlaces);
            this.Controls.Add(this.LBLNumberOfPlaces);
            this.Controls.Add(this.TBAirplaneModel);
            this.Controls.Add(this.LBLAirplaneModel);
            this.Controls.Add(this.RBMilitary);
            this.Controls.Add(this.RBTransporter);
            this.Controls.Add(this.RBPassenger);
            this.Controls.Add(this.LBLAirplaneID);
            this.Controls.Add(this.LBLAirplaneType);
            this.Controls.Add(this.TBAirplaneID);
            this.Name = "FAddAirplane";
            this.Text = "AddAirplane";
            this.Load += new System.EventHandler(this.AddAirplane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBYearOfIssue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBAirplaneID;
        private System.Windows.Forms.Label LBLAirplaneType;
        private System.Windows.Forms.Label LBLAirplaneID;
        private System.Windows.Forms.RadioButton RBPassenger;
        private System.Windows.Forms.RadioButton RBTransporter;
        private System.Windows.Forms.RadioButton RBMilitary;
        private System.Windows.Forms.Label LBLAirplaneModel;
        private System.Windows.Forms.TextBox TBAirplaneModel;
        private System.Windows.Forms.Label LBLNumberOfPlaces;
        private System.Windows.Forms.ComboBox CBNumberOfPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TBYearOfIssue;
        private System.Windows.Forms.Label LYIssue;
        private System.Windows.Forms.Label LBLCarrying;
        private System.Windows.Forms.TextBox TBCarrying;
        private System.Windows.Forms.Label LBLLastService;
        private System.Windows.Forms.MonthCalendar LSmonthCalendar;
        private System.Windows.Forms.Button GoToCreateCrewForm;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TBNumberOfMembers;
    }
}