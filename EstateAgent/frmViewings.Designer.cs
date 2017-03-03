namespace EstateAgent
{
    partial class frmViewings
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
            this.ViewingsCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnAddViewing = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemoveViewing = new System.Windows.Forms.Button();
            this.btnViewingDetails = new System.Windows.Forms.Button();
            this.lstViewings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBoxProperties = new System.Windows.Forms.ListBox();
            this.btnShowAllViewings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridProperties = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewingsCalendar
            // 
            this.ViewingsCalendar.Location = new System.Drawing.Point(431, 53);
            this.ViewingsCalendar.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.ViewingsCalendar.MaxSelectionCount = 1;
            this.ViewingsCalendar.Name = "ViewingsCalendar";
            this.ViewingsCalendar.TabIndex = 11;
            this.ViewingsCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.ViewingsCalendar_DateChanged);
            // 
            // btnAddViewing
            // 
            this.btnAddViewing.Location = new System.Drawing.Point(488, 227);
            this.btnAddViewing.Name = "btnAddViewing";
            this.btnAddViewing.Size = new System.Drawing.Size(87, 23);
            this.btnAddViewing.TabIndex = 10;
            this.btnAddViewing.Text = "New Viewing";
            this.btnAddViewing.UseVisualStyleBackColor = true;
            this.btnAddViewing.Click += new System.EventHandler(this.btnAddViewing_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(783, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRemoveViewing
            // 
            this.btnRemoveViewing.Location = new System.Drawing.Point(896, 82);
            this.btnRemoveViewing.Name = "btnRemoveViewing";
            this.btnRemoveViewing.Size = new System.Drawing.Size(96, 23);
            this.btnRemoveViewing.TabIndex = 8;
            this.btnRemoveViewing.Text = "Remove Viewing";
            this.btnRemoveViewing.UseVisualStyleBackColor = true;
            // 
            // btnViewingDetails
            // 
            this.btnViewingDetails.Location = new System.Drawing.Point(896, 111);
            this.btnViewingDetails.Name = "btnViewingDetails";
            this.btnViewingDetails.Size = new System.Drawing.Size(96, 23);
            this.btnViewingDetails.TabIndex = 7;
            this.btnViewingDetails.Text = "Viewing Details";
            this.btnViewingDetails.UseVisualStyleBackColor = true;
            // 
            // lstViewings
            // 
            this.lstViewings.FormattingEnabled = true;
            this.lstViewings.Location = new System.Drawing.Point(670, 53);
            this.lstViewings.Name = "lstViewings";
            this.lstViewings.Size = new System.Drawing.Size(220, 238);
            this.lstViewings.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "All Viewings";
            // 
            // lstBoxProperties
            // 
            this.lstBoxProperties.FormattingEnabled = true;
            this.lstBoxProperties.Location = new System.Drawing.Point(33, 350);
            this.lstBoxProperties.Name = "lstBoxProperties";
            this.lstBoxProperties.Size = new System.Drawing.Size(220, 238);
            this.lstBoxProperties.TabIndex = 13;
            this.lstBoxProperties.SelectedIndexChanged += new System.EventHandler(this.lstBoxProperties_SelectedIndexChanged);
            // 
            // btnShowAllViewings
            // 
            this.btnShowAllViewings.Location = new System.Drawing.Point(896, 53);
            this.btnShowAllViewings.Name = "btnShowAllViewings";
            this.btnShowAllViewings.Size = new System.Drawing.Size(96, 23);
            this.btnShowAllViewings.TabIndex = 14;
            this.btnShowAllViewings.Text = "All Viewings";
            this.btnShowAllViewings.UseVisualStyleBackColor = true;
            this.btnShowAllViewings.Click += new System.EventHandler(this.btnShowAllViewings_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Properties";
            // 
            // dataGridProperties
            // 
            this.dataGridProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProperties.Location = new System.Drawing.Point(12, 53);
            this.dataGridProperties.Name = "dataGridProperties";
            this.dataGridProperties.ReadOnly = true;
            this.dataGridProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProperties.Size = new System.Drawing.Size(407, 284);
            this.dataGridProperties.TabIndex = 16;
            // 
            // frmViewings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 433);
            this.Controls.Add(this.dataGridProperties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAllViewings);
            this.Controls.Add(this.lstBoxProperties);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewingsCalendar);
            this.Controls.Add(this.btnAddViewing);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemoveViewing);
            this.Controls.Add(this.btnViewingDetails);
            this.Controls.Add(this.lstViewings);
            this.Name = "frmViewings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewings";
            this.Load += new System.EventHandler(this.frmViewings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar ViewingsCalendar;
        private System.Windows.Forms.Button btnAddViewing;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemoveViewing;
        private System.Windows.Forms.Button btnViewingDetails;
        private System.Windows.Forms.ListBox lstViewings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxProperties;
        private System.Windows.Forms.Button btnShowAllViewings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridProperties;
    }
}