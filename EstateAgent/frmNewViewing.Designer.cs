namespace EstateAgent
{
    partial class frmNewViewing
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
            this.comboBoxAvailableTimes = new System.Windows.Forms.ComboBox();
            this.lblProperty = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstBuyers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreateViewing = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Picked";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxAvailableTimes
            // 
            this.comboBoxAvailableTimes.FormattingEnabled = true;
            this.comboBoxAvailableTimes.Location = new System.Drawing.Point(318, 141);
            this.comboBoxAvailableTimes.Name = "comboBoxAvailableTimes";
            this.comboBoxAvailableTimes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAvailableTimes.TabIndex = 1;
            this.comboBoxAvailableTimes.SelectedIndexChanged += new System.EventHandler(this.comboBoxAvailableTimes_SelectedIndexChanged);
            // 
            // lblProperty
            // 
            this.lblProperty.AutoSize = true;
            this.lblProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.Location = new System.Drawing.Point(60, 72);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProperty.Size = new System.Drawing.Size(68, 20);
            this.lblProperty.TabIndex = 2;
            this.lblProperty.Text = "Property";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 343);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Viewing";
            // 
            // lstBuyers
            // 
            this.lstBuyers.FormattingEnabled = true;
            this.lstBuyers.Location = new System.Drawing.Point(64, 141);
            this.lstBuyers.Name = "lstBuyers";
            this.lstBuyers.Size = new System.Drawing.Size(210, 199);
            this.lstBuyers.TabIndex = 5;
            this.lstBuyers.SelectedIndexChanged += new System.EventHandler(this.lstBuyers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Client: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose Time:";
            // 
            // btnCreateViewing
            // 
            this.btnCreateViewing.Location = new System.Drawing.Point(321, 342);
            this.btnCreateViewing.Name = "btnCreateViewing";
            this.btnCreateViewing.Size = new System.Drawing.Size(118, 23);
            this.btnCreateViewing.TabIndex = 8;
            this.btnCreateViewing.Text = "Create Viewing";
            this.btnCreateViewing.UseVisualStyleBackColor = true;
            this.btnCreateViewing.Click += new System.EventHandler(this.btnCreateViewing_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(110, 343);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(114, 23);
            this.btnAddClient.TabIndex = 9;
            this.btnAddClient.Text = "Add New Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNewViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 393);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnCreateViewing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstBuyers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblProperty);
            this.Controls.Add(this.comboBoxAvailableTimes);
            this.Controls.Add(this.label1);
            this.Name = "frmNewViewing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewViewing";
            this.Load += new System.EventHandler(this.frmNewViewing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAvailableTimes;
        private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstBuyers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreateViewing;
        private System.Windows.Forms.Button btnAddClient;

    }
}