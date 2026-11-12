namespace Yuson_Week06_Week05
{
    partial class UserProductListing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbItemDetails = new System.Windows.Forms.GroupBox();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtbAmount1 = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpbItemDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbItemDetails
            // 
            this.grpbItemDetails.Controls.Add(this.txtbDescription);
            this.grpbItemDetails.Controls.Add(this.cmbUnit);
            this.grpbItemDetails.Controls.Add(this.txtbAmount1);
            this.grpbItemDetails.Controls.Add(this.lblAmount);
            this.grpbItemDetails.Controls.Add(this.lblDescription);
            this.grpbItemDetails.Location = new System.Drawing.Point(104, 41);
            this.grpbItemDetails.Name = "grpbItemDetails";
            this.grpbItemDetails.Size = new System.Drawing.Size(494, 132);
            this.grpbItemDetails.TabIndex = 0;
            this.grpbItemDetails.TabStop = false;
            this.grpbItemDetails.Text = "ItemDetails";
            this.grpbItemDetails.Enter += new System.EventHandler(this.grpbItemDetails_Enter);
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(125, 37);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(353, 20);
            this.txtbDescription.TabIndex = 5;
            this.txtbDescription.TextChanged += new System.EventHandler(this.txtbDescription_TextChanged);
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(231, 70);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(94, 21);
            this.cmbUnit.TabIndex = 4;
            this.cmbUnit.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // txtbAmount1
            // 
            this.txtbAmount1.Location = new System.Drawing.Point(125, 70);
            this.txtbAmount1.Name = "txtbAmount1";
            this.txtbAmount1.Size = new System.Drawing.Size(100, 20);
            this.txtbAmount1.TabIndex = 3;
            this.txtbAmount1.TextChanged += new System.EventHandler(this.txtbAmount1_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(37, 73);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Click += new System.EventHandler(this.lblAmount_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 37);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(614, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(614, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxItems
            // 
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(106, 188);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(583, 186);
            this.lbxItems.TabIndex = 3;
            this.lbxItems.SelectedIndexChanged += new System.EventHandler(this.lbxItems_SelectedIndexChanged);
            // 
            // lblPrompt
            // 
            this.lblPrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrompt.BackColor = System.Drawing.Color.Firebrick;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(106, 399);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(583, 21);
            this.lblPrompt.TabIndex = 4;
            this.lblPrompt.Text = "Prompt";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPrompt.Click += new System.EventHandler(this.lblPrompt_Click);
            // 
            // UserProductListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lbxItems);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpbItemDetails);
            this.Name = "UserProductListing";
            this.Size = new System.Drawing.Size(946, 502);
            this.Load += new System.EventHandler(this.UserProductListing_Load);
            this.grpbItemDetails.ResumeLayout(false);
            this.grpbItemDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbItemDetails;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtbAmount1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Label lblPrompt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
