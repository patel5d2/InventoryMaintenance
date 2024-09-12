namespace InventoryMaintenance
{
    partial class frmNewItem
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();

            // txtItemNo
            this.txtItemNo.Location = new System.Drawing.Point(120, 30);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 22);
            this.txtItemNo.TabIndex = 0;

            // txtDescription
            this.txtDescription.Location = new System.Drawing.Point(120, 70);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 1;

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(120, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 2;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(30, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(140, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // lblItemNo
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Location = new System.Drawing.Point(30, 30);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(58, 17);
            this.lblItemNo.TabIndex = 5;
            this.lblItemNo.Text = "Item No";

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";

            // lblPrice
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(30, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";

            // frmNewItem
            this.ClientSize = new System.Drawing.Size(280, 220);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblItemNo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPrice);
            this.Name = "frmNewItem";
            this.Text = "New Item";
        }
    }
}
