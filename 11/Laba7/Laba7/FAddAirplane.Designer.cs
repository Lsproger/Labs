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
            this.LBLAirplaneType = new System.Windows.Forms.Label();
            this.RBPassenger = new System.Windows.Forms.RadioButton();
            this.RBTransporter = new System.Windows.Forms.RadioButton();
            this.RBMilitary = new System.Windows.Forms.RadioButton();
            this.LBLAirplaneModel = new System.Windows.Forms.Label();
            this._model = new System.Windows.Forms.TextBox();
            this.LBLNumberOfPlaces = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBYearOfIssue = new System.Windows.Forms.TrackBar();
            this._issue = new System.Windows.Forms.Label();
            this.GoToCreateCrewForm = new System.Windows.Forms.Button();
            this.AttachPhoto = new System.Windows.Forms.Button();
            this._pathIm = new System.Windows.Forms.TextBox();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this._preview = new System.Windows.Forms.PictureBox();
            this._calend = new System.Windows.Forms.MonthCalendar();
            this._places = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TBYearOfIssue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._preview)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLAirplaneType
            // 
            this.LBLAirplaneType.AutoSize = true;
            this.LBLAirplaneType.BackColor = System.Drawing.Color.HotPink;
            this.LBLAirplaneType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLAirplaneType.Location = new System.Drawing.Point(386, 18);
            this.LBLAirplaneType.Name = "LBLAirplaneType";
            this.LBLAirplaneType.Size = new System.Drawing.Size(73, 15);
            this.LBLAirplaneType.TabIndex = 2;
            this.LBLAirplaneType.Text = "Airplane type:";
            // 
            // RBPassenger
            // 
            this.RBPassenger.AutoSize = true;
            this.RBPassenger.BackColor = System.Drawing.Color.HotPink;
            this.RBPassenger.Location = new System.Drawing.Point(385, 41);
            this.RBPassenger.Name = "RBPassenger";
            this.RBPassenger.Size = new System.Drawing.Size(99, 17);
            this.RBPassenger.TabIndex = 4;
            this.RBPassenger.TabStop = true;
            this.RBPassenger.Text = "пассажирский";
            this.RBPassenger.UseVisualStyleBackColor = false;
            // 
            // RBTransporter
            // 
            this.RBTransporter.AutoSize = true;
            this.RBTransporter.BackColor = System.Drawing.Color.HotPink;
            this.RBTransporter.Location = new System.Drawing.Point(490, 41);
            this.RBTransporter.Name = "RBTransporter";
            this.RBTransporter.Size = new System.Drawing.Size(71, 17);
            this.RBTransporter.TabIndex = 5;
            this.RBTransporter.TabStop = true;
            this.RBTransporter.Text = "грузовой";
            this.RBTransporter.UseVisualStyleBackColor = false;
            // 
            // RBMilitary
            // 
            this.RBMilitary.AutoSize = true;
            this.RBMilitary.BackColor = System.Drawing.Color.HotPink;
            this.RBMilitary.Location = new System.Drawing.Point(576, 41);
            this.RBMilitary.Name = "RBMilitary";
            this.RBMilitary.Size = new System.Drawing.Size(69, 17);
            this.RBMilitary.TabIndex = 6;
            this.RBMilitary.TabStop = true;
            this.RBMilitary.Text = "военный";
            this.RBMilitary.UseVisualStyleBackColor = false;
            // 
            // LBLAirplaneModel
            // 
            this.LBLAirplaneModel.AutoSize = true;
            this.LBLAirplaneModel.BackColor = System.Drawing.Color.HotPink;
            this.LBLAirplaneModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLAirplaneModel.Location = new System.Drawing.Point(386, 71);
            this.LBLAirplaneModel.Name = "LBLAirplaneModel";
            this.LBLAirplaneModel.Size = new System.Drawing.Size(81, 15);
            this.LBLAirplaneModel.TabIndex = 7;
            this.LBLAirplaneModel.Text = "Airplane model:";
            // 
            // _model
            // 
            this._model.BackColor = System.Drawing.Color.LightPink;
            this._model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._model.Location = new System.Drawing.Point(483, 68);
            this._model.Name = "_model";
            this._model.Size = new System.Drawing.Size(164, 20);
            this._model.TabIndex = 8;
            // 
            // LBLNumberOfPlaces
            // 
            this.LBLNumberOfPlaces.AutoSize = true;
            this.LBLNumberOfPlaces.BackColor = System.Drawing.Color.HotPink;
            this.LBLNumberOfPlaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLNumberOfPlaces.Location = new System.Drawing.Point(386, 103);
            this.LBLNumberOfPlaces.Name = "LBLNumberOfPlaces";
            this.LBLNumberOfPlaces.Size = new System.Drawing.Size(92, 15);
            this.LBLNumberOfPlaces.TabIndex = 9;
            this.LBLNumberOfPlaces.Text = "Number of places";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(386, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Year of Issue";
            // 
            // TBYearOfIssue
            // 
            this.TBYearOfIssue.BackColor = System.Drawing.Color.LightPink;
            this.TBYearOfIssue.Location = new System.Drawing.Point(41, 18);
            this.TBYearOfIssue.Maximum = 2017;
            this.TBYearOfIssue.Minimum = 1950;
            this.TBYearOfIssue.Name = "TBYearOfIssue";
            this.TBYearOfIssue.Size = new System.Drawing.Size(121, 45);
            this.TBYearOfIssue.TabIndex = 12;
            this.TBYearOfIssue.TickFrequency = 5;
            this.TBYearOfIssue.Value = 1950;
            this.TBYearOfIssue.Scroll += new System.EventHandler(this.TBYearOfIssue_Scroll);
            // 
            // _issue
            // 
            this._issue.BackColor = System.Drawing.Color.HotPink;
            this._issue.Location = new System.Drawing.Point(165, 18);
            this._issue.Name = "_issue";
            this._issue.Size = new System.Drawing.Size(40, 29);
            this._issue.TabIndex = 13;
            this._issue.Text = "1950";
            this._issue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoToCreateCrewForm
            // 
            this.GoToCreateCrewForm.BackColor = System.Drawing.Color.HotPink;
            this.GoToCreateCrewForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoToCreateCrewForm.Location = new System.Drawing.Point(386, 373);
            this.GoToCreateCrewForm.Name = "GoToCreateCrewForm";
            this.GoToCreateCrewForm.Size = new System.Drawing.Size(259, 27);
            this.GoToCreateCrewForm.TabIndex = 18;
            this.GoToCreateCrewForm.Text = "Next step (Adding crew members)";
            this.GoToCreateCrewForm.UseVisualStyleBackColor = false;
            this.GoToCreateCrewForm.Click += new System.EventHandler(this.GoToCreateCrewForm_Click);
            // 
            // AttachPhoto
            // 
            this.AttachPhoto.Location = new System.Drawing.Point(386, 310);
            this.AttachPhoto.Name = "AttachPhoto";
            this.AttachPhoto.Size = new System.Drawing.Size(147, 23);
            this.AttachPhoto.TabIndex = 19;
            this.AttachPhoto.Text = "Добавить фотографию";
            this.AttachPhoto.UseVisualStyleBackColor = true;
            this.AttachPhoto.Click += new System.EventHandler(this.AttachPhoto_Click);
            // 
            // _pathIm
            // 
            this._pathIm.Location = new System.Drawing.Point(386, 347);
            this._pathIm.Name = "_pathIm";
            this._pathIm.ReadOnly = true;
            this._pathIm.Size = new System.Drawing.Size(259, 20);
            this._pathIm.TabIndex = 20;
            // 
            // dlg
            // 
            this.dlg.FileName = "dlg";
            // 
            // _preview
            // 
            this._preview.Location = new System.Drawing.Point(212, 288);
            this._preview.Name = "_preview";
            this._preview.Size = new System.Drawing.Size(170, 110);
            this._preview.TabIndex = 23;
            this._preview.TabStop = false;
            // 
            // _calend
            // 
            this._calend.Location = new System.Drawing.Point(483, 136);
            this._calend.Name = "_calend";
            this._calend.TabIndex = 24;
            // 
            // _places
            // 
            this._places.BackColor = System.Drawing.Color.LightPink;
            this._places.Location = new System.Drawing.Point(483, 100);
            this._places.Name = "_places";
            this._places.Size = new System.Drawing.Size(164, 20);
            this._places.TabIndex = 25;
            // 
            // FAddAirplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(670, 454);
            this.Controls.Add(this._places);
            this.Controls.Add(this._calend);
            this.Controls.Add(this._preview);
            this.Controls.Add(this._pathIm);
            this.Controls.Add(this.AttachPhoto);
            this.Controls.Add(this.GoToCreateCrewForm);
            this.Controls.Add(this._issue);
            this.Controls.Add(this.TBYearOfIssue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLNumberOfPlaces);
            this.Controls.Add(this._model);
            this.Controls.Add(this.LBLAirplaneModel);
            this.Controls.Add(this.RBMilitary);
            this.Controls.Add(this.RBTransporter);
            this.Controls.Add(this.RBPassenger);
            this.Controls.Add(this.LBLAirplaneType);
            this.Name = "FAddAirplane";
            this.Text = "AddAirplane";
            this.Load += new System.EventHandler(this.AddAirplane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBYearOfIssue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LBLAirplaneType;
        private System.Windows.Forms.RadioButton RBPassenger;
        private System.Windows.Forms.RadioButton RBTransporter;
        private System.Windows.Forms.RadioButton RBMilitary;
        private System.Windows.Forms.Label LBLAirplaneModel;
        private System.Windows.Forms.TextBox _model;
        private System.Windows.Forms.Label LBLNumberOfPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar TBYearOfIssue;
        private System.Windows.Forms.Label _issue;
        private System.Windows.Forms.Button GoToCreateCrewForm;
        private System.Windows.Forms.Button AttachPhoto;
        private System.Windows.Forms.TextBox _pathIm;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.PictureBox _preview;
        private System.Windows.Forms.MonthCalendar _calend;
        private System.Windows.Forms.TextBox _places;
    }
}