namespace HotelReservations
{
    partial class MainMenuForm
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
            this.signOutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.clientsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsManagementFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // signOutButton
            // 
            this.signOutButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signOutButton.ForeColor = System.Drawing.Color.Teal;
            this.signOutButton.Location = new System.Drawing.Point(664, 581);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(130, 40);
            this.signOutButton.TabIndex = 0;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.Location = new System.Drawing.Point(800, 581);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(130, 40);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.mainMenuStrip.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsFormToolStripMenuItem,
            this.roomsFormToolStripMenuItem,
            this.reservationsManagementFormToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(942, 33);
            this.mainMenuStrip.TabIndex = 2;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // clientsFormToolStripMenuItem
            // 
            this.clientsFormToolStripMenuItem.Name = "clientsFormToolStripMenuItem";
            this.clientsFormToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.clientsFormToolStripMenuItem.Text = "Client(s) Form";
            this.clientsFormToolStripMenuItem.Click += new System.EventHandler(this.clientsFormToolStripMenuItem_Click);
            // 
            // roomsFormToolStripMenuItem
            // 
            this.roomsFormToolStripMenuItem.Name = "roomsFormToolStripMenuItem";
            this.roomsFormToolStripMenuItem.Size = new System.Drawing.Size(157, 29);
            this.roomsFormToolStripMenuItem.Text = "Rooms Form";
            this.roomsFormToolStripMenuItem.Click += new System.EventHandler(this.roomsFormToolStripMenuItem_Click);
            // 
            // reservationsManagementFormToolStripMenuItem
            // 
            this.reservationsManagementFormToolStripMenuItem.Name = "reservationsManagementFormToolStripMenuItem";
            this.reservationsManagementFormToolStripMenuItem.Size = new System.Drawing.Size(372, 29);
            this.reservationsManagementFormToolStripMenuItem.Text = "Reservation(s) Management Form";
            this.reservationsManagementFormToolStripMenuItem.Click += new System.EventHandler(this.reservationsManagementFormToolStripMenuItem_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.dateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker.Location = new System.Drawing.Point(611, 54);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(319, 30);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.Value = new System.DateTime(2022, 10, 19, 17, 1, 38, 0);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = global::HotelReservations.Properties.Resources.hotel;
            this.ClientSize = new System.Drawing.Size(942, 633);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signOutButton);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenuForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button signOutButton;
        private Button exitButton;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem clientsFormToolStripMenuItem;
        private ToolStripMenuItem roomsFormToolStripMenuItem;
        private ToolStripMenuItem reservationsManagementFormToolStripMenuItem;
        private DateTimePicker dateTimePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}