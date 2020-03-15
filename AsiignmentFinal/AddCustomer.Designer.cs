namespace AsiignmentFinal
{
    partial class AddCustomer
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbErrorFirstName = new System.Windows.Forms.Label();
            this.lbErrorLastName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lbMessageAdd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(348, 211);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(402, 26);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.ForeColor = System.Drawing.Color.Snow;
            this.lbFirstName.Location = new System.Drawing.Point(210, 215);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(86, 20);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name";
            // 
            // lbErrorFirstName
            // 
            this.lbErrorFirstName.AutoSize = true;
            this.lbErrorFirstName.Location = new System.Drawing.Point(796, 215);
            this.lbErrorFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorFirstName.Name = "lbErrorFirstName";
            this.lbErrorFirstName.Size = new System.Drawing.Size(0, 20);
            this.lbErrorFirstName.TabIndex = 2;
            // 
            // lbErrorLastName
            // 
            this.lbErrorLastName.AutoSize = true;
            this.lbErrorLastName.Location = new System.Drawing.Point(796, 286);
            this.lbErrorLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorLastName.Name = "lbErrorLastName";
            this.lbErrorLastName.Size = new System.Drawing.Size(0, 20);
            this.lbErrorLastName.TabIndex = 5;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.ForeColor = System.Drawing.Color.Snow;
            this.lbLastName.Location = new System.Drawing.Point(210, 286);
            this.lbLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(86, 20);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(348, 282);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(402, 26);
            this.txtLastName.TabIndex = 3;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            // 
            // lbErrorPhoneNumber
            // 
            this.lbErrorPhoneNumber.AutoSize = true;
            this.lbErrorPhoneNumber.Location = new System.Drawing.Point(796, 357);
            this.lbErrorPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorPhoneNumber.Name = "lbErrorPhoneNumber";
            this.lbErrorPhoneNumber.Size = new System.Drawing.Size(0, 20);
            this.lbErrorPhoneNumber.TabIndex = 8;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.Snow;
            this.lbPhoneNumber.Location = new System.Drawing.Point(210, 357);
            this.lbPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(115, 20);
            this.lbPhoneNumber.TabIndex = 7;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(348, 352);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(402, 26);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            this.txtPhoneNumber.Enter += new System.EventHandler(this.txtPhoneNumber_Enter);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.Snow;
            this.btnAddCustomer.Location = new System.Drawing.Point(447, 431);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(189, 35);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lbMessageAdd
            // 
            this.lbMessageAdd.AutoSize = true;
            this.lbMessageAdd.Location = new System.Drawing.Point(472, 525);
            this.lbMessageAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessageAdd.Name = "lbMessageAdd";
            this.lbMessageAdd.Size = new System.Drawing.Size(0, 20);
            this.lbMessageAdd.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(688, 637);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "XYZ AIRLINE RESERVATION SYSTEM";
            // 
            // btnBackCustomer
            // 
            this.btnBackCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackCustomer.ForeColor = System.Drawing.Color.Snow;
            this.btnBackCustomer.Location = new System.Drawing.Point(18, 18);
            this.btnBackCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackCustomer.Name = "btnBackCustomer";
            this.btnBackCustomer.Size = new System.Drawing.Size(112, 35);
            this.btnBackCustomer.TabIndex = 41;
            this.btnBackCustomer.Text = "Back";
            this.btnBackCustomer.UseVisualStyleBackColor = true;
            this.btnBackCustomer.Click += new System.EventHandler(this.btnBackCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(454, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "ADD CUSTOMER";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1101, 671);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBackCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMessageAdd);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lbErrorPhoneNumber);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lbErrorLastName);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lbErrorFirstName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.Enter += new System.EventHandler(this.AddCustomer_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbErrorFirstName;
        private System.Windows.Forms.Label lbErrorLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbErrorPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbMessageAdd;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtFirstName;
        public System.Windows.Forms.TextBox txtLastName;
        public System.Windows.Forms.TextBox txtPhoneNumber;
        public System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnBackCustomer;
        private System.Windows.Forms.Label label2;
    }
}