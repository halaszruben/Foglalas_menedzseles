namespace HotelReservations
{
    partial class ManageRoomsForm
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
            this.comboBoxRoomsType = new System.Windows.Forms.ComboBox();
            this.clearTheFieldsButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.buttonEditRoom = new System.Windows.Forms.Button();
            this.buttonAddRoom = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.manageClientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // manageClientsPanel
            // 
            this.manageClientsPanel.BackgroundImage = global::HotelReservations.Properties.Resources.reception;
            this.manageClientsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.manageClientsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageClientsPanel.Controls.Add(this.comboBoxRoomsType);
            this.manageClientsPanel.Controls.Add(this.clearTheFieldsButton);
            this.manageClientsPanel.Controls.Add(this.RemoveButton);
            this.manageClientsPanel.Controls.Add(this.buttonEditRoom);
            this.manageClientsPanel.Controls.Add(this.buttonAddRoom);
            this.manageClientsPanel.Controls.Add(this.dataGridView1);
            this.manageClientsPanel.Controls.Add(this.textBoxPhoneNumber);
            this.manageClientsPanel.Controls.Add(this.label6);
            this.manageClientsPanel.Controls.Add(this.label4);
            this.manageClientsPanel.Controls.Add(this.label5);
            this.manageClientsPanel.Controls.Add(this.label3);
            this.manageClientsPanel.Controls.Add(this.textBoxNumber);
            this.manageClientsPanel.Controls.Add(this.label2);
            this.manageClientsPanel.Controls.Add(this.label1);
            this.manageClientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageClientsPanel.Location = new System.Drawing.Point(0, 0);
            this.manageClientsPanel.Name = "manageClientsPanel";
            this.manageClientsPanel.Size = new System.Drawing.Size(1282, 703);
            this.manageClientsPanel.TabIndex = 1;
            this.manageClientsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.manageClientsPanel_Paint);
            // 
            // comboBoxRoomsType
            // 
            this.comboBoxRoomsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomsType.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRoomsType.FormattingEnabled = true;
            this.comboBoxRoomsType.Location = new System.Drawing.Point(999, 205);
            this.comboBoxRoomsType.Name = "comboBoxRoomsType";
            this.comboBoxRoomsType.Size = new System.Drawing.Size(270, 34);
            this.comboBoxRoomsType.TabIndex = 20;
            // 
            // clearTheFieldsButton
            // 
            this.clearTheFieldsButton.BackColor = System.Drawing.Color.Transparent;
            this.clearTheFieldsButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearTheFieldsButton.Location = new System.Drawing.Point(774, 530);
            this.clearTheFieldsButton.Name = "clearTheFieldsButton";
            this.clearTheFieldsButton.Size = new System.Drawing.Size(335, 31);
            this.clearTheFieldsButton.TabIndex = 19;
            this.clearTheFieldsButton.Text = "Clear The Fields";
            this.clearTheFieldsButton.UseVisualStyleBackColor = false;
            this.clearTheFieldsButton.Click += new System.EventHandler(this.clearTheFieldsButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.RemoveButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoveButton.Location = new System.Drawing.Point(1115, 482);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(155, 79);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.Text = "Remove Room";
            this.RemoveButton.UseVisualStyleBackColor = false;
            // 
            // buttonEditRoom
            // 
            this.buttonEditRoom.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditRoom.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditRoom.Location = new System.Drawing.Point(937, 482);
            this.buttonEditRoom.Name = "buttonEditRoom";
            this.buttonEditRoom.Size = new System.Drawing.Size(172, 42);
            this.buttonEditRoom.TabIndex = 17;
            this.buttonEditRoom.Text = "Edit Room";
            this.buttonEditRoom.UseVisualStyleBackColor = false;
            // 
            // buttonAddRoom
            // 
            this.buttonAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddRoom.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddRoom.Location = new System.Drawing.Point(774, 482);
            this.buttonAddRoom.Name = "buttonAddRoom";
            this.buttonAddRoom.Size = new System.Drawing.Size(157, 42);
            this.buttonAddRoom.TabIndex = 16;
            this.buttonAddRoom.Text = "Add New Room";
            this.buttonAddRoom.UseVisualStyleBackColor = false;
            this.buttonAddRoom.Click += new System.EventHandler(this.buttonAddRoom_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(544, 437);
            this.dataGridView1.TabIndex = 15;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(999, 256);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(270, 34);
            this.textBoxPhoneNumber.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(999, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "YES";
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(926, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Free:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(820, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(862, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Room Type:";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumber.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumber.Location = new System.Drawing.Point(1000, 156);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(148, 34);
            this.textBoxNumber.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(824, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(430, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Rooms";
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.manageClientsPanel);
            this.Name = "ManageRoomsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.manageClientsPanel.ResumeLayout(false);
            this.manageClientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel manageClientsPanel;
        private Button clearTheFieldsButton;
        private Button RemoveButton;
        private Button buttonEditRoom;
        private Button buttonAddRoom;
        private DataGridView dataGridView1;
        private TextBox textBoxPhoneNumber;
        private Label label5;
        private Label label3;
        private TextBox textBoxNumber;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxRoomsType;
        private Label label4;
        private Label label6;
    }
}