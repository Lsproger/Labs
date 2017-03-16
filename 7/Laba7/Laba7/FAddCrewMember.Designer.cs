namespace Laba7
{
    partial class FAddCrewMember
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
            this.AddingCrewTable = new System.Windows.Forms.TableLayoutPanel();
            this.LBLFirstname = new System.Windows.Forms.Label();
            this.LBLSurname = new System.Windows.Forms.Label();
            this.LBLPatronymic = new System.Windows.Forms.Label();
            this.LBLAge = new System.Windows.Forms.Label();
            this.LBLPost = new System.Windows.Forms.Label();
            this.LBLExperience = new System.Windows.Forms.Label();
            this.BSaveCrew = new System.Windows.Forms.Button();
            this.Bcheck = new System.Windows.Forms.Button();
            this.AddingCrewTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddingCrewTable
            // 
            this.AddingCrewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddingCrewTable.AutoScroll = true;
            this.AddingCrewTable.ColumnCount = 6;
            this.AddingCrewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddingCrewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddingCrewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddingCrewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddingCrewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddingCrewTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.AddingCrewTable.Controls.Add(this.LBLFirstname, 0, 0);
            this.AddingCrewTable.Controls.Add(this.LBLSurname, 1, 0);
            this.AddingCrewTable.Controls.Add(this.LBLPatronymic, 2, 0);
            this.AddingCrewTable.Controls.Add(this.LBLAge, 3, 0);
            this.AddingCrewTable.Controls.Add(this.LBLPost, 4, 0);
            this.AddingCrewTable.Controls.Add(this.LBLExperience, 5, 0);
            this.AddingCrewTable.Location = new System.Drawing.Point(12, 32);
            this.AddingCrewTable.Name = "AddingCrewTable";
            this.AddingCrewTable.RowCount = 2;
            this.AddingCrewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.AddingCrewTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.AddingCrewTable.Size = new System.Drawing.Size(682, 226);
            this.AddingCrewTable.TabIndex = 0;
            // 
            // LBLFirstname
            // 
            this.LBLFirstname.AutoSize = true;
            this.LBLFirstname.Location = new System.Drawing.Point(3, 0);
            this.LBLFirstname.Name = "LBLFirstname";
            this.LBLFirstname.Size = new System.Drawing.Size(52, 13);
            this.LBLFirstname.TabIndex = 0;
            this.LBLFirstname.Text = "Firstname";
            // 
            // LBLSurname
            // 
            this.LBLSurname.AutoSize = true;
            this.LBLSurname.Location = new System.Drawing.Point(103, 0);
            this.LBLSurname.Name = "LBLSurname";
            this.LBLSurname.Size = new System.Drawing.Size(49, 13);
            this.LBLSurname.TabIndex = 1;
            this.LBLSurname.Text = "Surname";
            // 
            // LBLPatronymic
            // 
            this.LBLPatronymic.AutoSize = true;
            this.LBLPatronymic.Location = new System.Drawing.Point(203, 0);
            this.LBLPatronymic.Name = "LBLPatronymic";
            this.LBLPatronymic.Size = new System.Drawing.Size(59, 13);
            this.LBLPatronymic.TabIndex = 2;
            this.LBLPatronymic.Text = "Patronymic";
            // 
            // LBLAge
            // 
            this.LBLAge.AutoSize = true;
            this.LBLAge.Location = new System.Drawing.Point(303, 0);
            this.LBLAge.Name = "LBLAge";
            this.LBLAge.Size = new System.Drawing.Size(26, 13);
            this.LBLAge.TabIndex = 3;
            this.LBLAge.Text = "Age";
            // 
            // LBLPost
            // 
            this.LBLPost.AutoSize = true;
            this.LBLPost.Location = new System.Drawing.Point(353, 0);
            this.LBLPost.Name = "LBLPost";
            this.LBLPost.Size = new System.Drawing.Size(28, 13);
            this.LBLPost.TabIndex = 4;
            this.LBLPost.Text = "Post";
            // 
            // LBLExperience
            // 
            this.LBLExperience.AutoSize = true;
            this.LBLExperience.Location = new System.Drawing.Point(453, 0);
            this.LBLExperience.Name = "LBLExperience";
            this.LBLExperience.Size = new System.Drawing.Size(60, 13);
            this.LBLExperience.TabIndex = 5;
            this.LBLExperience.Text = "Experience";
            // 
            // BSaveCrew
            // 
            this.BSaveCrew.Location = new System.Drawing.Point(13, 3);
            this.BSaveCrew.Name = "BSaveCrew";
            this.BSaveCrew.Size = new System.Drawing.Size(75, 23);
            this.BSaveCrew.TabIndex = 1;
            this.BSaveCrew.Text = "Save";
            this.BSaveCrew.UseVisualStyleBackColor = true;
            this.BSaveCrew.Click += new System.EventHandler(this.BSaveCrew_Click);
            // 
            // Bcheck
            // 
            this.Bcheck.Location = new System.Drawing.Point(118, 3);
            this.Bcheck.Name = "Bcheck";
            this.Bcheck.Size = new System.Drawing.Size(75, 23);
            this.Bcheck.TabIndex = 2;
            this.Bcheck.Text = "check";
            this.Bcheck.UseVisualStyleBackColor = true;
            // 
            // FAddCrewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 261);
            this.Controls.Add(this.Bcheck);
            this.Controls.Add(this.BSaveCrew);
            this.Controls.Add(this.AddingCrewTable);
            this.Name = "FAddCrewMember";
            this.Text = "AddCrewMember";
            this.Load += new System.EventHandler(this.FAddCrewMember_Load_1);
            this.AddingCrewTable.ResumeLayout(false);
            this.AddingCrewTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel AddingCrewTable;
        private System.Windows.Forms.Label LBLFirstname;
        private System.Windows.Forms.Label LBLSurname;
        private System.Windows.Forms.Label LBLPatronymic;
        private System.Windows.Forms.Label LBLAge;
        private System.Windows.Forms.Label LBLPost;
        private System.Windows.Forms.Label LBLExperience;
        private System.Windows.Forms.Button BSaveCrew;
        private System.Windows.Forms.Button Bcheck;
    }
}