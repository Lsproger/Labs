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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._add = new System.Windows.Forms.Button();
            this._name = new System.Windows.Forms.TextBox();
            this._experience = new System.Windows.Forms.TextBox();
            this._age = new System.Windows.Forms.TextBox();
            this._post = new System.Windows.Forms.ComboBox();
            this._close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стаж работы";
            // 
            // _add
            // 
            this._add.Location = new System.Drawing.Point(10, 120);
            this._add.Name = "_add";
            this._add.Size = new System.Drawing.Size(116, 23);
            this._add.TabIndex = 5;
            this._add.Text = "Готово(следующий)";
            this._add.UseVisualStyleBackColor = true;
            this._add.Click += new System.EventHandler(this._add_Click);
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(109, 10);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(243, 20);
            this._name.TabIndex = 1;
            // 
            // _experience
            // 
            this._experience.Location = new System.Drawing.Point(109, 90);
            this._experience.Name = "_experience";
            this._experience.Size = new System.Drawing.Size(100, 20);
            this._experience.TabIndex = 4;
            // 
            // _age
            // 
            this._age.Location = new System.Drawing.Point(109, 67);
            this._age.Name = "_age";
            this._age.Size = new System.Drawing.Size(100, 20);
            this._age.TabIndex = 3;
            // 
            // _post
            // 
            this._post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._post.FormattingEnabled = true;
            this._post.Location = new System.Drawing.Point(109, 37);
            this._post.MaxDropDownItems = 2;
            this._post.Name = "_post";
            this._post.Size = new System.Drawing.Size(161, 21);
            this._post.TabIndex = 2;
            // 
            // _close
            // 
            this._close.Location = new System.Drawing.Point(133, 120);
            this._close.Name = "_close";
            this._close.Size = new System.Drawing.Size(75, 23);
            this._close.TabIndex = 9;
            this._close.Text = "Закрыть";
            this._close.UseVisualStyleBackColor = true;
            this._close.Click += new System.EventHandler(this._close_Click);
            // 
            // FAddCrewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 168);
            this.Controls.Add(this._close);
            this.Controls.Add(this._post);
            this.Controls.Add(this._age);
            this.Controls.Add(this._experience);
            this.Controls.Add(this._name);
            this.Controls.Add(this._add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FAddCrewMember";
            this.Text = "AddCrewMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _add;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.TextBox _experience;
        private System.Windows.Forms.TextBox _age;
        private System.Windows.Forms.ComboBox _post;
        private System.Windows.Forms.Button _close;
    }
}