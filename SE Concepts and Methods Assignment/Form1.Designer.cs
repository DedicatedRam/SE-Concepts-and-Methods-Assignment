namespace SE_Concepts_and_Methods_Assignment
{
    partial class Form1
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
            this.Welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBxLogin = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UserNameInput = new System.Windows.Forms.TextBox();
            this.accoutCreate = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateAccess = new System.Windows.Forms.TextBox();
            this.txtCreatePass = new System.Windows.Forms.TextBox();
            this.txtCreateUser = new System.Windows.Forms.TextBox();
            this.btnSetPrefferences = new System.Windows.Forms.Button();
            this.btnDateSubmission = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.chckBoxShowPeople = new System.Windows.Forms.CheckedListBox();
            this.txtBxEnterRoom = new System.Windows.Forms.TextBox();
            this.lblEnterLocation = new System.Windows.Forms.Label();
            this.txtBxEnterBuilding = new System.Windows.Forms.TextBox();
            this.grpBoxDates = new System.Windows.Forms.GroupBox();
            this.btnShowInvites = new System.Windows.Forms.Button();
            this.inviteSelector = new System.Windows.Forms.ComboBox();
            this.txtBxMeetingTopic = new System.Windows.Forms.TextBox();
            this.roomName = new System.Windows.Forms.Label();
            this.buildingName = new System.Windows.Forms.Label();
            this.meetingTopic = new System.Windows.Forms.Label();
            this.showDates = new System.Windows.Forms.ComboBox();
            this.txtBxEnterRequire = new System.Windows.Forms.TextBox();
            this.lblRequirements = new System.Windows.Forms.Label();
            this.acceptInvite = new System.Windows.Forms.Button();
            this.DenyInvite = new System.Windows.Forms.Button();
            this.showMeetings = new System.Windows.Forms.Button();
            this.showAccepted = new System.Windows.Forms.ComboBox();
            this.showAttendees = new System.Windows.Forms.ComboBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpBoxInvites = new System.Windows.Forms.GroupBox();
            this.grpBoxMeetingDetails = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.grpBxLogin.SuspendLayout();
            this.accoutCreate.SuspendLayout();
            this.grpBoxDates.SuspendLayout();
            this.grpBoxInvites.SuspendLayout();
            this.grpBoxMeetingDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(776, 92);
            this.Welcome.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(527, 37);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to the meeting schedualar";
            this.Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(415, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpBxLogin
            // 
            this.grpBxLogin.Controls.Add(this.label5);
            this.grpBxLogin.Controls.Add(this.label4);
            this.grpBxLogin.Controls.Add(this.PasswordInput);
            this.grpBxLogin.Controls.Add(this.button1);
            this.grpBxLogin.Controls.Add(this.UserNameInput);
            this.grpBxLogin.Location = new System.Drawing.Point(38, 324);
            this.grpBxLogin.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpBxLogin.Size = new System.Drawing.Size(469, 284);
            this.grpBxLogin.TabIndex = 2;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(22, 133);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(232, 44);
            this.PasswordInput.TabIndex = 1;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(22, 56);
            this.UserNameInput.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(232, 44);
            this.UserNameInput.TabIndex = 0;
            // 
            // accoutCreate
            // 
            this.accoutCreate.Controls.Add(this.button2);
            this.accoutCreate.Controls.Add(this.label3);
            this.accoutCreate.Controls.Add(this.label2);
            this.accoutCreate.Controls.Add(this.label1);
            this.accoutCreate.Controls.Add(this.txtCreateAccess);
            this.accoutCreate.Controls.Add(this.txtCreatePass);
            this.accoutCreate.Controls.Add(this.txtCreateUser);
            this.accoutCreate.Location = new System.Drawing.Point(38, 626);
            this.accoutCreate.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.accoutCreate.Name = "accoutCreate";
            this.accoutCreate.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.accoutCreate.Size = new System.Drawing.Size(633, 376);
            this.accoutCreate.TabIndex = 3;
            this.accoutCreate.TabStop = false;
            this.accoutCreate.Text = "Create Account";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 277);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(583, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Access Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // txtCreateAccess
            // 
            this.txtCreateAccess.Location = new System.Drawing.Point(22, 203);
            this.txtCreateAccess.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCreateAccess.Name = "txtCreateAccess";
            this.txtCreateAccess.Size = new System.Drawing.Size(308, 44);
            this.txtCreateAccess.TabIndex = 2;
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Location = new System.Drawing.Point(22, 129);
            this.txtCreatePass.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(308, 44);
            this.txtCreatePass.TabIndex = 1;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(22, 55);
            this.txtCreateUser.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(308, 44);
            this.txtCreateUser.TabIndex = 0;
            // 
            // btnSetPrefferences
            // 
            this.btnSetPrefferences.Location = new System.Drawing.Point(2568, 133);
            this.btnSetPrefferences.Margin = new System.Windows.Forms.Padding(6);
            this.btnSetPrefferences.Name = "btnSetPrefferences";
            this.btnSetPrefferences.Size = new System.Drawing.Size(396, 102);
            this.btnSetPrefferences.TabIndex = 4;
            this.btnSetPrefferences.Text = "Click here to select your available dates";
            this.btnSetPrefferences.UseVisualStyleBackColor = true;
            this.btnSetPrefferences.Visible = false;
            this.btnSetPrefferences.Click += new System.EventHandler(this.btnSetPrefferences_Click);
            // 
            // btnDateSubmission
            // 
            this.btnDateSubmission.Location = new System.Drawing.Point(2568, 253);
            this.btnDateSubmission.Margin = new System.Windows.Forms.Padding(6);
            this.btnDateSubmission.Name = "btnDateSubmission";
            this.btnDateSubmission.Size = new System.Drawing.Size(307, 111);
            this.btnDateSubmission.TabIndex = 10;
            this.btnDateSubmission.Text = "Click this to submit dates";
            this.btnDateSubmission.UseVisualStyleBackColor = true;
            this.btnDateSubmission.Visible = false;
            this.btnDateSubmission.Click += new System.EventHandler(this.btnDateSubmission_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 65);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(419, 44);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(38, 139);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(419, 44);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(38, 219);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(419, 44);
            this.dateTimePicker3.TabIndex = 13;
            this.dateTimePicker3.Visible = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(38, 293);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(419, 44);
            this.dateTimePicker4.TabIndex = 14;
            this.dateTimePicker4.Visible = false;
            // 
            // chckBoxShowPeople
            // 
            this.chckBoxShowPeople.FormattingEnabled = true;
            this.chckBoxShowPeople.Location = new System.Drawing.Point(111, 1193);
            this.chckBoxShowPeople.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.chckBoxShowPeople.Name = "chckBoxShowPeople";
            this.chckBoxShowPeople.Size = new System.Drawing.Size(577, 168);
            this.chckBoxShowPeople.TabIndex = 16;
            this.chckBoxShowPeople.Visible = false;
            // 
            // txtBxEnterRoom
            // 
            this.txtBxEnterRoom.Location = new System.Drawing.Point(255, 123);
            this.txtBxEnterRoom.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtBxEnterRoom.Name = "txtBxEnterRoom";
            this.txtBxEnterRoom.Size = new System.Drawing.Size(352, 44);
            this.txtBxEnterRoom.TabIndex = 17;
            this.txtBxEnterRoom.Visible = false;
            // 
            // lblEnterLocation
            // 
            this.lblEnterLocation.AutoSize = true;
            this.lblEnterLocation.Location = new System.Drawing.Point(87, 71);
            this.lblEnterLocation.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lblEnterLocation.Name = "lblEnterLocation";
            this.lblEnterLocation.Size = new System.Drawing.Size(260, 37);
            this.lblEnterLocation.TabIndex = 18;
            this.lblEnterLocation.Text = "Meeting Location";
            this.lblEnterLocation.Visible = false;
            // 
            // txtBxEnterBuilding
            // 
            this.txtBxEnterBuilding.Location = new System.Drawing.Point(255, 188);
            this.txtBxEnterBuilding.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtBxEnterBuilding.Name = "txtBxEnterBuilding";
            this.txtBxEnterBuilding.Size = new System.Drawing.Size(352, 44);
            this.txtBxEnterBuilding.TabIndex = 19;
            this.txtBxEnterBuilding.Visible = false;
            // 
            // grpBoxDates
            // 
            this.grpBoxDates.Controls.Add(this.dateTimePicker1);
            this.grpBoxDates.Controls.Add(this.dateTimePicker2);
            this.grpBoxDates.Controls.Add(this.dateTimePicker3);
            this.grpBoxDates.Controls.Add(this.dateTimePicker4);
            this.grpBoxDates.Location = new System.Drawing.Point(1017, 1151);
            this.grpBoxDates.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpBoxDates.Name = "grpBoxDates";
            this.grpBoxDates.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.grpBoxDates.Size = new System.Drawing.Size(633, 376);
            this.grpBoxDates.TabIndex = 20;
            this.grpBoxDates.TabStop = false;
            this.grpBoxDates.Text = "Select Your Dates";
            this.grpBoxDates.Visible = false;
            // 
            // btnShowInvites
            // 
            this.btnShowInvites.Location = new System.Drawing.Point(2568, 413);
            this.btnShowInvites.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.btnShowInvites.Name = "btnShowInvites";
            this.btnShowInvites.Size = new System.Drawing.Size(307, 92);
            this.btnShowInvites.TabIndex = 21;
            this.btnShowInvites.Text = "Show Invites";
            this.btnShowInvites.UseVisualStyleBackColor = true;
            this.btnShowInvites.Visible = false;
            this.btnShowInvites.Click += new System.EventHandler(this.btnShowInvites_Click);
            // 
            // inviteSelector
            // 
            this.inviteSelector.FormattingEnabled = true;
            this.inviteSelector.Location = new System.Drawing.Point(14, 95);
            this.inviteSelector.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.inviteSelector.Name = "inviteSelector";
            this.inviteSelector.Size = new System.Drawing.Size(375, 45);
            this.inviteSelector.TabIndex = 22;
            this.inviteSelector.Visible = false;
            this.inviteSelector.SelectedIndexChanged += new System.EventHandler(this.inviteSelector_SelectedIndexChanged);
            // 
            // txtBxMeetingTopic
            // 
            this.txtBxMeetingTopic.Location = new System.Drawing.Point(255, 252);
            this.txtBxMeetingTopic.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtBxMeetingTopic.Name = "txtBxMeetingTopic";
            this.txtBxMeetingTopic.Size = new System.Drawing.Size(352, 44);
            this.txtBxMeetingTopic.TabIndex = 23;
            this.txtBxMeetingTopic.Visible = false;
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(24, 129);
            this.roomName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(206, 37);
            this.roomName.TabIndex = 24;
            this.roomName.Text = "Room Name:";
            this.roomName.Visible = false;
            // 
            // buildingName
            // 
            this.buildingName.AutoSize = true;
            this.buildingName.Location = new System.Drawing.Point(-2, 197);
            this.buildingName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buildingName.Name = "buildingName";
            this.buildingName.Size = new System.Drawing.Size(235, 37);
            this.buildingName.TabIndex = 25;
            this.buildingName.Text = "Building Name:";
            this.buildingName.Visible = false;
            // 
            // meetingTopic
            // 
            this.meetingTopic.AutoSize = true;
            this.meetingTopic.Location = new System.Drawing.Point(128, 256);
            this.meetingTopic.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.meetingTopic.Name = "meetingTopic";
            this.meetingTopic.Size = new System.Drawing.Size(105, 37);
            this.meetingTopic.TabIndex = 26;
            this.meetingTopic.Text = "Topic:";
            this.meetingTopic.Visible = false;
            // 
            // showDates
            // 
            this.showDates.FormattingEnabled = true;
            this.showDates.Location = new System.Drawing.Point(14, 161);
            this.showDates.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.showDates.Name = "showDates";
            this.showDates.Size = new System.Drawing.Size(375, 45);
            this.showDates.TabIndex = 27;
            this.showDates.Visible = false;
            // 
            // txtBxEnterRequire
            // 
            this.txtBxEnterRequire.Location = new System.Drawing.Point(255, 326);
            this.txtBxEnterRequire.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtBxEnterRequire.Name = "txtBxEnterRequire";
            this.txtBxEnterRequire.Size = new System.Drawing.Size(352, 44);
            this.txtBxEnterRequire.TabIndex = 28;
            this.txtBxEnterRequire.Visible = false;
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(8, 333);
            this.lblRequirements.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(223, 37);
            this.lblRequirements.TabIndex = 29;
            this.lblRequirements.Text = "Requirements:";
            this.lblRequirements.Visible = false;
            // 
            // acceptInvite
            // 
            this.acceptInvite.Location = new System.Drawing.Point(410, 77);
            this.acceptInvite.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.acceptInvite.Name = "acceptInvite";
            this.acceptInvite.Size = new System.Drawing.Size(238, 65);
            this.acceptInvite.TabIndex = 30;
            this.acceptInvite.Text = "Accept";
            this.acceptInvite.UseVisualStyleBackColor = true;
            this.acceptInvite.Visible = false;
            this.acceptInvite.Click += new System.EventHandler(this.acceptInvite_Click);
            // 
            // DenyInvite
            // 
            this.DenyInvite.Location = new System.Drawing.Point(410, 151);
            this.DenyInvite.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.DenyInvite.Name = "DenyInvite";
            this.DenyInvite.Size = new System.Drawing.Size(238, 65);
            this.DenyInvite.TabIndex = 31;
            this.DenyInvite.Text = "Decline";
            this.DenyInvite.UseVisualStyleBackColor = true;
            this.DenyInvite.Visible = false;
            this.DenyInvite.Click += new System.EventHandler(this.DenyInvite_Click);
            // 
            // showMeetings
            // 
            this.showMeetings.Location = new System.Drawing.Point(2568, 573);
            this.showMeetings.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.showMeetings.Name = "showMeetings";
            this.showMeetings.Size = new System.Drawing.Size(307, 87);
            this.showMeetings.TabIndex = 32;
            this.showMeetings.Text = "Show Meetings";
            this.showMeetings.UseVisualStyleBackColor = true;
            this.showMeetings.Visible = false;
            this.showMeetings.Click += new System.EventHandler(this.showMeetings_Click);
            // 
            // showAccepted
            // 
            this.showAccepted.FormattingEnabled = true;
            this.showAccepted.Location = new System.Drawing.Point(1732, 573);
            this.showAccepted.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.showAccepted.Name = "showAccepted";
            this.showAccepted.Size = new System.Drawing.Size(637, 45);
            this.showAccepted.TabIndex = 33;
            this.showAccepted.Visible = false;
            this.showAccepted.SelectedIndexChanged += new System.EventHandler(this.showAccepted_SelectedIndexChanged);
            // 
            // showAttendees
            // 
            this.showAttendees.FormattingEnabled = true;
            this.showAttendees.Location = new System.Drawing.Point(1732, 636);
            this.showAttendees.Name = "showAttendees";
            this.showAttendees.Size = new System.Drawing.Size(637, 45);
            this.showAttendees.TabIndex = 34;
            this.showAttendees.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(2799, 1138);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(372, 110);
            this.btnLogout.TabIndex = 35;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // grpBoxInvites
            // 
            this.grpBoxInvites.Controls.Add(this.inviteSelector);
            this.grpBoxInvites.Controls.Add(this.showDates);
            this.grpBoxInvites.Controls.Add(this.acceptInvite);
            this.grpBoxInvites.Controls.Add(this.DenyInvite);
            this.grpBoxInvites.Location = new System.Drawing.Point(849, 386);
            this.grpBoxInvites.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpBoxInvites.Name = "grpBoxInvites";
            this.grpBoxInvites.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpBoxInvites.Size = new System.Drawing.Size(727, 235);
            this.grpBoxInvites.TabIndex = 36;
            this.grpBoxInvites.TabStop = false;
            this.grpBoxInvites.Text = "Show Invites";
            this.grpBoxInvites.Visible = false;
            // 
            // grpBoxMeetingDetails
            // 
            this.grpBoxMeetingDetails.Controls.Add(this.lblRequirements);
            this.grpBoxMeetingDetails.Controls.Add(this.txtBxEnterRequire);
            this.grpBoxMeetingDetails.Controls.Add(this.meetingTopic);
            this.grpBoxMeetingDetails.Controls.Add(this.roomName);
            this.grpBoxMeetingDetails.Controls.Add(this.txtBxMeetingTopic);
            this.grpBoxMeetingDetails.Controls.Add(this.txtBxEnterBuilding);
            this.grpBoxMeetingDetails.Controls.Add(this.buildingName);
            this.grpBoxMeetingDetails.Controls.Add(this.lblEnterLocation);
            this.grpBoxMeetingDetails.Controls.Add(this.txtBxEnterRoom);
            this.grpBoxMeetingDetails.Location = new System.Drawing.Point(768, 709);
            this.grpBoxMeetingDetails.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpBoxMeetingDetails.Name = "grpBoxMeetingDetails";
            this.grpBoxMeetingDetails.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grpBoxMeetingDetails.Size = new System.Drawing.Size(789, 400);
            this.grpBoxMeetingDetails.TabIndex = 37;
            this.grpBoxMeetingDetails.TabStop = false;
            this.grpBoxMeetingDetails.Text = "Meeting Details";
            this.grpBoxMeetingDetails.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1719, 987);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 55);
            this.button3.TabIndex = 38;
            this.button3.Text = "Save data to file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2018, 987);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 55);
            this.button4.TabIndex = 39;
            this.button4.Text = "Flush File Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3407, 1600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grpBoxMeetingDetails);
            this.Controls.Add(this.grpBoxInvites);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.showAttendees);
            this.Controls.Add(this.showAccepted);
            this.Controls.Add(this.showMeetings);
            this.Controls.Add(this.btnShowInvites);
            this.Controls.Add(this.grpBoxDates);
            this.Controls.Add(this.chckBoxShowPeople);
            this.Controls.Add(this.btnDateSubmission);
            this.Controls.Add(this.btnSetPrefferences);
            this.Controls.Add(this.accoutCreate);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.Welcome);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.accoutCreate.ResumeLayout(false);
            this.accoutCreate.PerformLayout();
            this.grpBoxDates.ResumeLayout(false);
            this.grpBoxInvites.ResumeLayout(false);
            this.grpBoxMeetingDetails.ResumeLayout(false);
            this.grpBoxMeetingDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpBxLogin;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UserNameInput;
        private System.Windows.Forms.GroupBox accoutCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateAccess;
        private System.Windows.Forms.TextBox txtCreatePass;
        private System.Windows.Forms.TextBox txtCreateUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetPrefferences;
        private System.Windows.Forms.Button btnDateSubmission;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckedListBox chckBoxShowPeople;
        private System.Windows.Forms.TextBox txtBxEnterRoom;
        private System.Windows.Forms.Label lblEnterLocation;
        private System.Windows.Forms.TextBox txtBxEnterBuilding;
        private System.Windows.Forms.GroupBox grpBoxDates;
        private System.Windows.Forms.Button btnShowInvites;
        private System.Windows.Forms.ComboBox inviteSelector;
        private System.Windows.Forms.TextBox txtBxMeetingTopic;
        private System.Windows.Forms.Label roomName;
        private System.Windows.Forms.Label buildingName;
        private System.Windows.Forms.Label meetingTopic;
        private System.Windows.Forms.ComboBox showDates;
        private System.Windows.Forms.TextBox txtBxEnterRequire;
        private System.Windows.Forms.Label lblRequirements;
        private System.Windows.Forms.Button acceptInvite;
        private System.Windows.Forms.Button DenyInvite;
        private System.Windows.Forms.Button showMeetings;
        private System.Windows.Forms.ComboBox showAccepted;
        private System.Windows.Forms.ComboBox showAttendees;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpBoxInvites;
        private System.Windows.Forms.GroupBox grpBoxMeetingDetails;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

