namespace Assignment5
{
    partial class ContactForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpEmailAndPhone = new System.Windows.Forms.GroupBox();
            this.txtWorkEmail = new System.Windows.Forms.TextBox();
            this.lblWorkEmail = new System.Windows.Forms.Label();
            this.txtPrivateEmail = new System.Windows.Forms.TextBox();
            this.lblPrivateEmail = new System.Windows.Forms.Label();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.grpName.SuspendLayout();
            this.grpEmailAndPhone.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(16, 469);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(139, 469);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpName
            // 
            this.grpName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpName.Controls.Add(this.txtLastName);
            this.grpName.Controls.Add(this.txtFirstName);
            this.grpName.Controls.Add(this.lblLastName);
            this.grpName.Controls.Add(this.lblFirstName);
            this.grpName.Location = new System.Drawing.Point(16, 16);
            this.grpName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpName.Name = "grpName";
            this.grpName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpName.Size = new System.Drawing.Size(653, 94);
            this.grpName.TabIndex = 2;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(109, 52);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(533, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(109, 21);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(533, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(9, 55);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(9, 25);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // grpEmailAndPhone
            // 
            this.grpEmailAndPhone.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpEmailAndPhone.Controls.Add(this.txtWorkEmail);
            this.grpEmailAndPhone.Controls.Add(this.lblWorkEmail);
            this.grpEmailAndPhone.Controls.Add(this.txtPrivateEmail);
            this.grpEmailAndPhone.Controls.Add(this.lblPrivateEmail);
            this.grpEmailAndPhone.Controls.Add(this.txtWorkPhone);
            this.grpEmailAndPhone.Controls.Add(this.txtHomePhone);
            this.grpEmailAndPhone.Controls.Add(this.lblWorkPhone);
            this.grpEmailAndPhone.Controls.Add(this.lblHomePhone);
            this.grpEmailAndPhone.Location = new System.Drawing.Point(16, 117);
            this.grpEmailAndPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEmailAndPhone.Name = "grpEmailAndPhone";
            this.grpEmailAndPhone.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpEmailAndPhone.Size = new System.Drawing.Size(653, 162);
            this.grpEmailAndPhone.TabIndex = 4;
            this.grpEmailAndPhone.TabStop = false;
            this.grpEmailAndPhone.Text = "Email & Phone";
            // 
            // txtWorkEmail
            // 
            this.txtWorkEmail.Location = new System.Drawing.Point(109, 121);
            this.txtWorkEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkEmail.Name = "txtWorkEmail";
            this.txtWorkEmail.Size = new System.Drawing.Size(533, 22);
            this.txtWorkEmail.TabIndex = 7;
            // 
            // lblWorkEmail
            // 
            this.lblWorkEmail.AutoSize = true;
            this.lblWorkEmail.Location = new System.Drawing.Point(9, 124);
            this.lblWorkEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkEmail.Name = "lblWorkEmail";
            this.lblWorkEmail.Size = new System.Drawing.Size(79, 17);
            this.lblWorkEmail.TabIndex = 6;
            this.lblWorkEmail.Text = "Work Email";
            // 
            // txtPrivateEmail
            // 
            this.txtPrivateEmail.Location = new System.Drawing.Point(109, 87);
            this.txtPrivateEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrivateEmail.Name = "txtPrivateEmail";
            this.txtPrivateEmail.Size = new System.Drawing.Size(533, 22);
            this.txtPrivateEmail.TabIndex = 5;
            // 
            // lblPrivateEmail
            // 
            this.lblPrivateEmail.AutoSize = true;
            this.lblPrivateEmail.Location = new System.Drawing.Point(8, 96);
            this.lblPrivateEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrivateEmail.Name = "lblPrivateEmail";
            this.lblPrivateEmail.Size = new System.Drawing.Size(90, 17);
            this.lblPrivateEmail.TabIndex = 4;
            this.lblPrivateEmail.Text = "Private Email";
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(109, 55);
            this.txtWorkPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(533, 22);
            this.txtWorkPhone.TabIndex = 3;
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(109, 23);
            this.txtHomePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(533, 22);
            this.txtHomePhone.TabIndex = 2;
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(11, 64);
            this.lblWorkPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(86, 17);
            this.lblWorkPhone.TabIndex = 1;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(8, 32);
            this.lblHomePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(90, 17);
            this.lblHomePhone.TabIndex = 0;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // grpAddress
            // 
            this.grpAddress.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grpAddress.Controls.Add(this.cmbCountry);
            this.grpAddress.Controls.Add(this.lblCountry);
            this.grpAddress.Controls.Add(this.txtZipcode);
            this.grpAddress.Controls.Add(this.lblZipcode);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblCity);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.Location = new System.Drawing.Point(16, 299);
            this.grpAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpAddress.Size = new System.Drawing.Size(653, 162);
            this.grpAddress.TabIndex = 8;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(109, 116);
            this.cmbCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(533, 24);
            this.cmbCountry.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(9, 124);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 6;
            this.lblCountry.Text = "Country";
            // 
            // txtZipcode
            // 
            this.txtZipcode.Location = new System.Drawing.Point(109, 87);
            this.txtZipcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.Size = new System.Drawing.Size(533, 22);
            this.txtZipcode.TabIndex = 5;
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Location = new System.Drawing.Point(8, 96);
            this.lblZipcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(59, 17);
            this.lblZipcode.TabIndex = 4;
            this.lblZipcode.Text = "Zipcode";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(109, 55);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(533, 22);
            this.txtCity.TabIndex = 3;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(109, 23);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(533, 22);
            this.txtStreet.TabIndex = 2;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(11, 64);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(8, 32);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 516);
            this.Controls.Add(this.grpAddress);
            this.Controls.Add(this.grpEmailAndPhone);
            this.Controls.Add(this.grpName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContactForm";
            this.Text = "ContactForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpEmailAndPhone.ResumeLayout(false);
            this.grpEmailAndPhone.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpEmailAndPhone;
        private System.Windows.Forms.Label lblPrivateEmail;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtPrivateEmail;
        private System.Windows.Forms.TextBox txtWorkEmail;
        private System.Windows.Forms.Label lblWorkEmail;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
    }
}