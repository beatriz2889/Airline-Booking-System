namespace AsiignmentFinal
{
    partial class AddFlight
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
            this.lbMessageAddFlight = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.lbErrorPhoneNumber = new System.Windows.Forms.Label();
            this.lbPortOfOrigin = new System.Windows.Forms.Label();
            this.txtPortOfOrigin = new System.Windows.Forms.TextBox();
            this.lbErrorMaxSeat = new System.Windows.Forms.Label();
            this.lbMaxSeatNo = new System.Windows.Forms.Label();
            this.txtMaxSeatNo = new System.Windows.Forms.TextBox();
            this.lbErrorFlightNumber = new System.Windows.Forms.Label();
            this.lbFlightNumber = new System.Windows.Forms.Label();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDestinationPort = new System.Windows.Forms.Label();
            this.txtDestinationPort = new System.Windows.Forms.TextBox();
            this.btnBackCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMessageAddFlight
            // 
            this.lbMessageAddFlight.AutoSize = true;
            this.lbMessageAddFlight.Location = new System.Drawing.Point(513, 566);
            this.lbMessageAddFlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMessageAddFlight.Name = "lbMessageAddFlight";
            this.lbMessageAddFlight.Size = new System.Drawing.Size(0, 20);
            this.lbMessageAddFlight.TabIndex = 21;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.ForeColor = System.Drawing.Color.Snow;
            this.btnAddFlight.Location = new System.Drawing.Point(482, 472);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(189, 35);
            this.btnAddFlight.TabIndex = 20;
            this.btnAddFlight.Text = "ADD";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // lbErrorPhoneNumber
            // 
            this.lbErrorPhoneNumber.AutoSize = true;
            this.lbErrorPhoneNumber.Location = new System.Drawing.Point(831, 325);
            this.lbErrorPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorPhoneNumber.Name = "lbErrorPhoneNumber";
            this.lbErrorPhoneNumber.Size = new System.Drawing.Size(0, 20);
            this.lbErrorPhoneNumber.TabIndex = 19;
            // 
            // lbPortOfOrigin
            // 
            this.lbPortOfOrigin.AutoSize = true;
            this.lbPortOfOrigin.ForeColor = System.Drawing.Color.Snow;
            this.lbPortOfOrigin.Location = new System.Drawing.Point(194, 325);
            this.lbPortOfOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPortOfOrigin.Name = "lbPortOfOrigin";
            this.lbPortOfOrigin.Size = new System.Drawing.Size(101, 20);
            this.lbPortOfOrigin.TabIndex = 18;
            this.lbPortOfOrigin.Text = "Port of Origin";
            // 
            // txtPortOfOrigin
            // 
            this.txtPortOfOrigin.Location = new System.Drawing.Point(382, 320);
            this.txtPortOfOrigin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPortOfOrigin.Name = "txtPortOfOrigin";
            this.txtPortOfOrigin.Size = new System.Drawing.Size(402, 26);
            this.txtPortOfOrigin.TabIndex = 17;
            this.txtPortOfOrigin.Enter += new System.EventHandler(this.txtPortOfOrigin_Enter);
            // 
            // lbErrorMaxSeat
            // 
            this.lbErrorMaxSeat.AutoSize = true;
            this.lbErrorMaxSeat.Location = new System.Drawing.Point(831, 254);
            this.lbErrorMaxSeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorMaxSeat.Name = "lbErrorMaxSeat";
            this.lbErrorMaxSeat.Size = new System.Drawing.Size(0, 20);
            this.lbErrorMaxSeat.TabIndex = 16;
            // 
            // lbMaxSeatNo
            // 
            this.lbMaxSeatNo.AutoSize = true;
            this.lbMaxSeatNo.ForeColor = System.Drawing.Color.Snow;
            this.lbMaxSeatNo.Location = new System.Drawing.Point(194, 254);
            this.lbMaxSeatNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaxSeatNo.Name = "lbMaxSeatNo";
            this.lbMaxSeatNo.Size = new System.Drawing.Size(174, 20);
            this.lbMaxSeatNo.TabIndex = 15;
            this.lbMaxSeatNo.Text = "Maximum Seat Number";
            // 
            // txtMaxSeatNo
            // 
            this.txtMaxSeatNo.Location = new System.Drawing.Point(382, 249);
            this.txtMaxSeatNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxSeatNo.Name = "txtMaxSeatNo";
            this.txtMaxSeatNo.Size = new System.Drawing.Size(402, 26);
            this.txtMaxSeatNo.TabIndex = 14;
            this.txtMaxSeatNo.Enter += new System.EventHandler(this.txtMaxSeatNo_Enter);
            // 
            // lbErrorFlightNumber
            // 
            this.lbErrorFlightNumber.AutoSize = true;
            this.lbErrorFlightNumber.Location = new System.Drawing.Point(831, 183);
            this.lbErrorFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbErrorFlightNumber.Name = "lbErrorFlightNumber";
            this.lbErrorFlightNumber.Size = new System.Drawing.Size(0, 20);
            this.lbErrorFlightNumber.TabIndex = 13;
            // 
            // lbFlightNumber
            // 
            this.lbFlightNumber.AutoSize = true;
            this.lbFlightNumber.ForeColor = System.Drawing.Color.Snow;
            this.lbFlightNumber.Location = new System.Drawing.Point(194, 183);
            this.lbFlightNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFlightNumber.Name = "lbFlightNumber";
            this.lbFlightNumber.Size = new System.Drawing.Size(108, 20);
            this.lbFlightNumber.TabIndex = 12;
            this.lbFlightNumber.Text = "Flight Number";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(382, 178);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(402, 26);
            this.txtFlightNumber.TabIndex = 11;
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            this.txtFlightNumber.Enter += new System.EventHandler(this.txtFlightNumber_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(831, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 24;
            // 
            // lbDestinationPort
            // 
            this.lbDestinationPort.AutoSize = true;
            this.lbDestinationPort.ForeColor = System.Drawing.Color.Snow;
            this.lbDestinationPort.Location = new System.Drawing.Point(194, 394);
            this.lbDestinationPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDestinationPort.Name = "lbDestinationPort";
            this.lbDestinationPort.Size = new System.Drawing.Size(123, 20);
            this.lbDestinationPort.TabIndex = 23;
            this.lbDestinationPort.Text = "Destination Port";
            // 
            // txtDestinationPort
            // 
            this.txtDestinationPort.Location = new System.Drawing.Point(382, 389);
            this.txtDestinationPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationPort.Name = "txtDestinationPort";
            this.txtDestinationPort.Size = new System.Drawing.Size(402, 26);
            this.txtDestinationPort.TabIndex = 22;
            this.txtDestinationPort.Enter += new System.EventHandler(this.txtDestinationPort_Enter);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(498, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "ADD FLIGHT";
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1101, 677);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBackCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbDestinationPort);
            this.Controls.Add(this.txtDestinationPort);
            this.Controls.Add(this.lbMessageAddFlight);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.lbErrorPhoneNumber);
            this.Controls.Add(this.lbPortOfOrigin);
            this.Controls.Add(this.txtPortOfOrigin);
            this.Controls.Add(this.lbErrorMaxSeat);
            this.Controls.Add(this.lbMaxSeatNo);
            this.Controls.Add(this.txtMaxSeatNo);
            this.Controls.Add(this.lbErrorFlightNumber);
            this.Controls.Add(this.lbFlightNumber);
            this.Controls.Add(this.txtFlightNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFlight";
            this.Load += new System.EventHandler(this.AddFlight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessageAddFlight;
        private System.Windows.Forms.Label lbErrorPhoneNumber;
        private System.Windows.Forms.Label lbPortOfOrigin;
        private System.Windows.Forms.Label lbErrorMaxSeat;
        private System.Windows.Forms.Label lbMaxSeatNo;
        private System.Windows.Forms.Label lbErrorFlightNumber;
        private System.Windows.Forms.Label lbFlightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDestinationPort;
        public System.Windows.Forms.TextBox txtFlightNumber;
        public System.Windows.Forms.TextBox txtMaxSeatNo;
        public System.Windows.Forms.TextBox txtPortOfOrigin;
        public System.Windows.Forms.TextBox txtDestinationPort;
        public System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnBackCustomer;
        private System.Windows.Forms.Label label2;
    }
}