﻿namespace HotelReservations
{
    partial class ManageReservationsForm
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
            this.manageClientsPanel = new System.Windows.Forms.Panel();
            this.dateTimePickerOUT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerIN = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxRoomNumber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearTheFieldsButton = new System.Windows.Forms.Button();
            this.buttonRemoveReserve = new System.Windows.Forms.Button();
            this.buttonEditReserv = new System.Windows.Forms.Button();
            this.buttonAddReserv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReservId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.manageClientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageClientsPanel
            // 
            this.manageClientsPanel.BackgroundImage = global::HotelReservations.Properties.Resources.reception;
            this.manageClientsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageClientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageClientsPanel.Controls.Add(this.textBoxReservId);
            this.manageClientsPanel.Controls.Add(this.label2);
            this.manageClientsPanel.Controls.Add(this.dateTimePickerOUT);
            this.manageClientsPanel.Controls.Add(this.dateTimePickerIN);
            this.manageClientsPanel.Controls.Add(this.label7);
            this.manageClientsPanel.Controls.Add(this.comboBoxRoomNumber);
            this.manageClientsPanel.Controls.Add(this.label6);
            this.manageClientsPanel.Controls.Add(this.label5);
            this.manageClientsPanel.Controls.Add(this.comboBoxRoomType);
            this.manageClientsPanel.Controls.Add(this.label3);
            this.manageClientsPanel.Controls.Add(this.textBoxClientID);
            this.manageClientsPanel.Controls.Add(this.label4);
            this.manageClientsPanel.Controls.Add(this.clearTheFieldsButton);
            this.manageClientsPanel.Controls.Add(this.buttonRemoveReserve);
            this.manageClientsPanel.Controls.Add(this.buttonEditReserv);
            this.manageClientsPanel.Controls.Add(this.buttonAddReserv);
            this.manageClientsPanel.Controls.Add(this.dataGridView1);
            this.manageClientsPanel.Controls.Add(this.label1);
            this.manageClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageClientsPanel.Location = new System.Drawing.Point(0, 0);
            this.manageClientsPanel.Name = "manageClientsPanel";
            this.manageClientsPanel.Size = new System.Drawing.Size(1282, 703);
            this.manageClientsPanel.TabIndex = 1;
            // 
            // dateTimePickerOUT
            // 
            this.dateTimePickerOUT.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOUT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerOUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOUT.Location = new System.Drawing.Point(977, 399);
            this.dateTimePickerOUT.Name = "dateTimePickerOUT";
            this.dateTimePickerOUT.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerOUT.TabIndex = 27;
            // 
            // dateTimePickerIN
            // 
            this.dateTimePickerIN.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerIN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerIN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerIN.Location = new System.Drawing.Point(978, 347);
            this.dateTimePickerIN.Name = "dateTimePickerIN";
            this.dateTimePickerIN.Size = new System.Drawing.Size(250, 34);
            this.dateTimePickerIN.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(861, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Date Out:";
            // 
            // comboBoxRoomNumber
            // 
            this.comboBoxRoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRoomNumber.FormattingEnabled = true;
            this.comboBoxRoomNumber.Location = new System.Drawing.Point(977, 299);
            this.comboBoxRoomNumber.Name = "comboBoxRoomNumber";
            this.comboBoxRoomNumber.Size = new System.Drawing.Size(270, 34);
            this.comboBoxRoomNumber.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(875, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date In:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(802, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Room Number:";
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Location = new System.Drawing.Point(977, 248);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(270, 34);
            this.comboBoxRoomType.TabIndex = 26;
            this.comboBoxRoomType.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoomType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(840, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Room Type:";
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxClientID.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxClientID.Location = new System.Drawing.Point(977, 193);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(148, 34);
            this.textBoxClientID.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(859, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Client ID:";
            // 
            // clearTheFieldsButton
            // 
            this.clearTheFieldsButton.BackColor = System.Drawing.Color.Transparent;
            this.clearTheFieldsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTheFieldsButton.Location = new System.Drawing.Point(646, 551);
            this.clearTheFieldsButton.Name = "clearTheFieldsButton";
            this.clearTheFieldsButton.Size = new System.Drawing.Size(462, 31);
            this.clearTheFieldsButton.TabIndex = 19;
            this.clearTheFieldsButton.Text = "Clear The Fields";
            this.clearTheFieldsButton.UseVisualStyleBackColor = false;
            this.clearTheFieldsButton.Click += new System.EventHandler(this.clearTheFieldsButton_Click);
            // 
            // buttonRemoveReserve
            // 
            this.buttonRemoveReserve.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemoveReserve.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemoveReserve.Location = new System.Drawing.Point(1114, 503);
            this.buttonRemoveReserve.Name = "buttonRemoveReserve";
            this.buttonRemoveReserve.Size = new System.Drawing.Size(155, 79);
            this.buttonRemoveReserve.TabIndex = 18;
            this.buttonRemoveReserve.Text = "Remove Reservation";
            this.buttonRemoveReserve.UseVisualStyleBackColor = false;
            // 
            // buttonEditReserv
            // 
            this.buttonEditReserv.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditReserv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditReserv.Location = new System.Drawing.Point(883, 503);
            this.buttonEditReserv.Name = "buttonEditReserv";
            this.buttonEditReserv.Size = new System.Drawing.Size(225, 42);
            this.buttonEditReserv.TabIndex = 17;
            this.buttonEditReserv.Text = "Edit Reservation";
            this.buttonEditReserv.UseVisualStyleBackColor = false;
            this.buttonEditReserv.Click += new System.EventHandler(this.buttonEditReserv_Click);
            // 
            // buttonAddReserv
            // 
            this.buttonAddReserv.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddReserv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddReserv.Location = new System.Drawing.Point(646, 503);
            this.buttonAddReserv.Name = "buttonAddReserv";
            this.buttonAddReserv.Size = new System.Drawing.Size(231, 42);
            this.buttonAddReserv.TabIndex = 16;
            this.buttonAddReserv.Text = "Add Reservation";
            this.buttonAddReserv.UseVisualStyleBackColor = false;
            this.buttonAddReserv.Click += new System.EventHandler(this.buttonAddReserv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(544, 437);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(430, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Reservations";
            // 
            // textBoxReservId
            // 
            this.textBoxReservId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReservId.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxReservId.Location = new System.Drawing.Point(977, 145);
            this.textBoxReservId.Name = "textBoxReservId";
            this.textBoxReservId.Size = new System.Drawing.Size(148, 34);
            this.textBoxReservId.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(859, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reserv ID:";
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.manageClientsPanel);
            this.Name = "ManageReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.manageClientsPanel.ResumeLayout(false);
            this.manageClientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageClientsPanel;
        private Button clearTheFieldsButton;
        private Button buttonRemoveReserve;
        private Button buttonEditReserv;
        private Button buttonAddReserv;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxClientID;
        private Label label4;
        private ComboBox comboBoxRoomNumber;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxRoomType;
        private Label label3;
        private DateTimePicker dateTimePickerOUT;
        private DateTimePicker dateTimePickerIN;
        private Label label7;
        private TextBox textBoxReservId;
        private Label label2;
    }
}