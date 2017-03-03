namespace EstateAgent
{
    partial class frmMain
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnProSalesRep = new System.Windows.Forms.Button();
            this.btnOffer = new System.Windows.Forms.Button();
            this.btnCheckView = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(398, 547);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 55);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Location = new System.Drawing.Point(448, 355);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(100, 40);
            this.btnEmail.TabIndex = 14;
            this.btnEmail.Text = "Check Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // btnProSalesRep
            // 
            this.btnProSalesRep.Location = new System.Drawing.Point(488, 166);
            this.btnProSalesRep.Name = "btnProSalesRep";
            this.btnProSalesRep.Size = new System.Drawing.Size(100, 40);
            this.btnProSalesRep.TabIndex = 13;
            this.btnProSalesRep.Text = "Produce Sales Report";
            this.btnProSalesRep.UseVisualStyleBackColor = true;
            this.btnProSalesRep.Click += new System.EventHandler(this.btnProSalesRep_Click);
            // 
            // btnOffer
            // 
            this.btnOffer.Location = new System.Drawing.Point(488, 102);
            this.btnOffer.Name = "btnOffer";
            this.btnOffer.Size = new System.Drawing.Size(100, 40);
            this.btnOffer.TabIndex = 12;
            this.btnOffer.Text = " Offers";
            this.btnOffer.UseVisualStyleBackColor = true;
            this.btnOffer.Click += new System.EventHandler(this.btnOffer_Click);
            // 
            // btnCheckView
            // 
            this.btnCheckView.Location = new System.Drawing.Point(110, 231);
            this.btnCheckView.Name = "btnCheckView";
            this.btnCheckView.Size = new System.Drawing.Size(100, 40);
            this.btnCheckView.TabIndex = 11;
            this.btnCheckView.Text = "Viewing";
            this.btnCheckView.UseVisualStyleBackColor = true;
            this.btnCheckView.Click += new System.EventHandler(this.btnCheckView_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(110, 166);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(100, 40);
            this.btnProperty.TabIndex = 10;
            this.btnProperty.Text = "Property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.Location = new System.Drawing.Point(110, 102);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(100, 40);
            this.btnUpdateStaff.TabIndex = 9;
            this.btnUpdateStaff.Text = "Update Staff";
            this.btnUpdateStaff.UseVisualStyleBackColor = true;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Estate Agency";
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(143, 355);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(100, 34);
            this.btnClients.TabIndex = 16;
            this.btnClients.Text = "Clients";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 631);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.btnProSalesRep);
            this.Controls.Add(this.btnOffer);
            this.Controls.Add(this.btnCheckView);
            this.Controls.Add(this.btnProperty);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnProSalesRep;
        private System.Windows.Forms.Button btnOffer;
        private System.Windows.Forms.Button btnCheckView;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClients;

    }
}