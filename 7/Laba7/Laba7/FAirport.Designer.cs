namespace Laba7
{
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
            this.BAddAIrplane = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.listPlanes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BAddAIrplane
            // 
            this.BAddAIrplane.Location = new System.Drawing.Point(12, 12);
            this.BAddAIrplane.Name = "BAddAIrplane";
            this.BAddAIrplane.Size = new System.Drawing.Size(75, 23);
            this.BAddAIrplane.TabIndex = 0;
            this.BAddAIrplane.Text = "Add airplane";
            this.BAddAIrplane.UseVisualStyleBackColor = true;
            this.BAddAIrplane.Click += new System.EventHandler(this.BAddAIrplane_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.Location = new System.Drawing.Point(93, 12);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(75, 23);
            this.BRefresh.TabIndex = 1;
            this.BRefresh.Text = "Refresh";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.BRefresh_Click);
            // 
            // listPlanes
            // 
            this.listPlanes.FormattingEnabled = true;
            this.listPlanes.HorizontalScrollbar = true;
            this.listPlanes.Location = new System.Drawing.Point(12, 42);
            this.listPlanes.Name = "listPlanes";
            this.listPlanes.Size = new System.Drawing.Size(498, 355);
            this.listPlanes.Sorted = true;
            this.listPlanes.TabIndex = 2;
            // 
            // FAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 444);
            this.Controls.Add(this.listPlanes);
            this.Controls.Add(this.BRefresh);
            this.Controls.Add(this.BAddAIrplane);
            this.Name = "FAirport";
            this.Text = "Airport";
            this.Load += new System.EventHandler(this.Airport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAddAIrplane;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.ListBox listPlanes;
    }
}

