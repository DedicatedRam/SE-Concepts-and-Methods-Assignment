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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInvitees = new System.Windows.Forms.Label();
            this.lblShowMeetDate = new System.Windows.Forms.Label();
            this.lblMeetDate = new System.Windows.Forms.Label();
            this.lblShowMeetLoc = new System.Windows.Forms.Label();
            this.lblshowMeetRequire = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblRequire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxEnterTime = new System.Windows.Forms.TextBox();
            this.lblTimeInput = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.grpBxLogin.SuspendLayout();
            this.accoutCreate.SuspendLayout();
            this.grpBoxDates.SuspendLayout();
            this.grpBoxInvites.SuspendLayout();
            this.grpBoxMeetingDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Location = new System.Drawing.Point(490, 62);
            this.Welcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(355, 25);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to the meeting schedualar";
            this.Welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 140);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 44);
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
            this.grpBxLogin.Location = new System.Drawing.Point(24, 219);
            this.grpBxLogin.Margin = new System.Windows.Forms.Padding(6);
            this.grpBxLogin.Name = "grpBxLogin";
            this.grpBxLogin.Padding = new System.Windows.Forms.Padding(6);
            this.grpBxLogin.Size = new System.Drawing.Size(296, 192);
            this.grpBxLogin.TabIndex = 2;
            this.grpBxLogin.TabStop = false;
            this.grpBxLogin.Text = "Login";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(14, 90);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(148, 31);
            this.PasswordInput.TabIndex = 1;
            // 
            // UserNameInput
            // 
            this.UserNameInput.Location = new System.Drawing.Point(14, 38);
            this.UserNameInput.Margin = new System.Windows.Forms.Padding(6);
            this.UserNameInput.Name = "UserNameInput";
            this.UserNameInput.Size = new System.Drawing.Size(148, 31);
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
            this.accoutCreate.Location = new System.Drawing.Point(24, 423);
            this.accoutCreate.Margin = new System.Windows.Forms.Padding(6);
            this.accoutCreate.Name = "accoutCreate";
            this.accoutCreate.Padding = new System.Windows.Forms.Padding(6);
            this.accoutCreate.Size = new System.Drawing.Size(400, 254);
            this.accoutCreate.TabIndex = 3;
            this.accoutCreate.TabStop = false;
            this.accoutCreate.Text = "Create Account";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 187);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(368, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Access Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // txtCreateAccess
            // 
            this.txtCreateAccess.Location = new System.Drawing.Point(14, 137);
            this.txtCreateAccess.Margin = new System.Windows.Forms.Padding(6);
            this.txtCreateAccess.Name = "txtCreateAccess";
            this.txtCreateAccess.Size = new System.Drawing.Size(196, 31);
            this.txtCreateAccess.TabIndex = 2;
            // 
            // txtCreatePass
            // 
            this.txtCreatePass.Location = new System.Drawing.Point(14, 87);
            this.txtCreatePass.Margin = new System.Windows.Forms.Padding(6);
            this.txtCreatePass.Name = "txtCreatePass";
            this.txtCreatePass.Size = new System.Drawing.Size(196, 31);
            this.txtCreatePass.TabIndex = 1;
            // 
            // txtCreateUser
            // 
            this.txtCreateUser.Location = new System.Drawing.Point(14, 37);
            this.txtCreateUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtCreateUser.Name = "txtCreateUser";
            this.txtCreateUser.Size = new System.Drawing.Size(196, 31);
            this.txtCreateUser.TabIndex = 0;
            // 
            // btnSetPrefferences
            // 
            this.btnSetPrefferences.Location = new System.Drawing.Point(1622, 90);
            this.btnSetPrefferences.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPrefferences.Name = "btnSetPrefferences";
            this.btnSetPrefferences.Size = new System.Drawing.Size(250, 69);
            this.btnSetPrefferences.TabIndex = 4;
            this.btnSetPrefferences.Text = "Click here to select your available dates";
            this.btnSetPrefferences.UseVisualStyleBackColor = true;
            this.btnSetPrefferences.Visible = false;
            this.btnSetPrefferences.Click += new System.EventHandler(this.btnSetPrefferences_Click);
            // 
            // btnDateSubmission
            // 
            this.btnDateSubmission.Location = new System.Drawing.Point(1622, 171);
            this.btnDateSubmission.Margin = new System.Windows.Forms.Padding(4);
            this.btnDateSubmission.Name = "btnDateSubmission";
            this.btnDateSubmission.Size = new System.Drawing.Size(194, 75);
            this.btnDateSubmission.TabIndex = 10;
            this.btnDateSubmission.Text = "Click this to submit dates";
            this.btnDateSubmission.UseVisualStyleBackColor = true;
            this.btnDateSubmission.Visible = false;
            this.btnDateSubmission.Click += new System.EventHandler(this.btnDateSubmission_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 44);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 31);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(24, 94);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(266, 31);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Visible = false;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(24, 148);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(266, 31);
            this.dateTimePicker3.TabIndex = 13;
            this.dateTimePicker3.Visible = false;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(24, 198);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(266, 31);
            this.dateTimePicker4.TabIndex = 14;
            this.dateTimePicker4.Visible = false;
            // 
            // chckBoxShowPeople
            // 
            this.chckBoxShowPeople.FormattingEnabled = true;
            this.chckBoxShowPeople.Location = new System.Drawing.Point(70, 806);
            this.chckBoxShowPeople.Margin = new System.Windows.Forms.Padding(6);
            this.chckBoxShowPeople.Name = "chckBoxShowPeople";
            this.chckBoxShowPeople.Size = new System.Drawing.Size(366, 228);
            this.chckBoxShowPeople.TabIndex = 16;
            this.chckBoxShowPeople.Visible = false;
            // 
            // txtBxEnterRoom
            // 
            this.txtBxEnterRoom.Location = new System.Drawing.Point(161, 83);
            this.txtBxEnterRoom.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxEnterRoom.Name = "txtBxEnterRoom";
            this.txtBxEnterRoom.Size = new System.Drawing.Size(224, 31);
            this.txtBxEnterRoom.TabIndex = 17;
            this.txtBxEnterRoom.Visible = false;
            // 
            // lblEnterLocation
            // 
            this.lblEnterLocation.AutoSize = true;
            this.lblEnterLocation.Location = new System.Drawing.Point(55, 48);
            this.lblEnterLocation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterLocation.Name = "lblEnterLocation";
            this.lblEnterLocation.Size = new System.Drawing.Size(177, 25);
            this.lblEnterLocation.TabIndex = 18;
            this.lblEnterLocation.Text = "Meeting Location";
            this.lblEnterLocation.Visible = false;
            // 
            // txtBxEnterBuilding
            // 
            this.txtBxEnterBuilding.Location = new System.Drawing.Point(161, 127);
            this.txtBxEnterBuilding.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxEnterBuilding.Name = "txtBxEnterBuilding";
            this.txtBxEnterBuilding.Size = new System.Drawing.Size(224, 31);
            this.txtBxEnterBuilding.TabIndex = 19;
            this.txtBxEnterBuilding.Visible = false;
            // 
            // grpBoxDates
            // 
            this.grpBoxDates.Controls.Add(this.lblTimeInput);
            this.grpBoxDates.Controls.Add(this.txtBoxEnterTime);
            this.grpBoxDates.Controls.Add(this.dateTimePicker1);
            this.grpBoxDates.Controls.Add(this.dateTimePicker2);
            this.grpBoxDates.Controls.Add(this.dateTimePicker3);
            this.grpBoxDates.Controls.Add(this.dateTimePicker4);
            this.grpBoxDates.Location = new System.Drawing.Point(489, 780);
            this.grpBoxDates.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxDates.Name = "grpBoxDates";
            this.grpBoxDates.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxDates.Size = new System.Drawing.Size(583, 254);
            this.grpBoxDates.TabIndex = 20;
            this.grpBoxDates.TabStop = false;
            this.grpBoxDates.Text = "Select Your Dates";
            this.grpBoxDates.Visible = false;
            // 
            // btnShowInvites
            // 
            this.btnShowInvites.Location = new System.Drawing.Point(1622, 279);
            this.btnShowInvites.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowInvites.Name = "btnShowInvites";
            this.btnShowInvites.Size = new System.Drawing.Size(194, 62);
            this.btnShowInvites.TabIndex = 21;
            this.btnShowInvites.Text = "Show Invites";
            this.btnShowInvites.UseVisualStyleBackColor = true;
            this.btnShowInvites.Visible = false;
            this.btnShowInvites.Click += new System.EventHandler(this.btnShowInvites_Click);
            // 
            // inviteSelector
            // 
            this.inviteSelector.FormattingEnabled = true;
            this.inviteSelector.Location = new System.Drawing.Point(9, 64);
            this.inviteSelector.Margin = new System.Windows.Forms.Padding(6);
            this.inviteSelector.Name = "inviteSelector";
            this.inviteSelector.Size = new System.Drawing.Size(238, 33);
            this.inviteSelector.TabIndex = 22;
            this.inviteSelector.Visible = false;
            this.inviteSelector.SelectedIndexChanged += new System.EventHandler(this.inviteSelector_SelectedIndexChanged);
            // 
            // txtBxMeetingTopic
            // 
            this.txtBxMeetingTopic.Location = new System.Drawing.Point(161, 170);
            this.txtBxMeetingTopic.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxMeetingTopic.Name = "txtBxMeetingTopic";
            this.txtBxMeetingTopic.Size = new System.Drawing.Size(224, 31);
            this.txtBxMeetingTopic.TabIndex = 23;
            this.txtBxMeetingTopic.Visible = false;
            // 
            // roomName
            // 
            this.roomName.AutoSize = true;
            this.roomName.Location = new System.Drawing.Point(15, 87);
            this.roomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(136, 25);
            this.roomName.TabIndex = 24;
            this.roomName.Text = "Room Name:";
            this.roomName.Visible = false;
            // 
            // buildingName
            // 
            this.buildingName.AutoSize = true;
            this.buildingName.Location = new System.Drawing.Point(-1, 133);
            this.buildingName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buildingName.Name = "buildingName";
            this.buildingName.Size = new System.Drawing.Size(157, 25);
            this.buildingName.TabIndex = 25;
            this.buildingName.Text = "Building Name:";
            this.buildingName.Visible = false;
            // 
            // meetingTopic
            // 
            this.meetingTopic.AutoSize = true;
            this.meetingTopic.Location = new System.Drawing.Point(81, 173);
            this.meetingTopic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meetingTopic.Name = "meetingTopic";
            this.meetingTopic.Size = new System.Drawing.Size(71, 25);
            this.meetingTopic.TabIndex = 26;
            this.meetingTopic.Text = "Topic:";
            this.meetingTopic.Visible = false;
            // 
            // showDates
            // 
            this.showDates.FormattingEnabled = true;
            this.showDates.Location = new System.Drawing.Point(9, 109);
            this.showDates.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.showDates.Name = "showDates";
            this.showDates.Size = new System.Drawing.Size(238, 33);
            this.showDates.TabIndex = 27;
            this.showDates.Visible = false;
            // 
            // txtBxEnterRequire
            // 
            this.txtBxEnterRequire.Location = new System.Drawing.Point(161, 220);
            this.txtBxEnterRequire.Margin = new System.Windows.Forms.Padding(6);
            this.txtBxEnterRequire.Name = "txtBxEnterRequire";
            this.txtBxEnterRequire.Size = new System.Drawing.Size(224, 31);
            this.txtBxEnterRequire.TabIndex = 28;
            this.txtBxEnterRequire.Visible = false;
            // 
            // lblRequirements
            // 
            this.lblRequirements.AutoSize = true;
            this.lblRequirements.Location = new System.Drawing.Point(5, 225);
            this.lblRequirements.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequirements.Name = "lblRequirements";
            this.lblRequirements.Size = new System.Drawing.Size(151, 25);
            this.lblRequirements.TabIndex = 29;
            this.lblRequirements.Text = "Requirements:";
            this.lblRequirements.Visible = false;
            // 
            // acceptInvite
            // 
            this.acceptInvite.Location = new System.Drawing.Point(259, 52);
            this.acceptInvite.Margin = new System.Windows.Forms.Padding(6);
            this.acceptInvite.Name = "acceptInvite";
            this.acceptInvite.Size = new System.Drawing.Size(150, 44);
            this.acceptInvite.TabIndex = 30;
            this.acceptInvite.Text = "Accept";
            this.acceptInvite.UseVisualStyleBackColor = true;
            this.acceptInvite.Visible = false;
            this.acceptInvite.Click += new System.EventHandler(this.acceptInvite_Click);
            // 
            // DenyInvite
            // 
            this.DenyInvite.Location = new System.Drawing.Point(259, 102);
            this.DenyInvite.Margin = new System.Windows.Forms.Padding(6);
            this.DenyInvite.Name = "DenyInvite";
            this.DenyInvite.Size = new System.Drawing.Size(150, 44);
            this.DenyInvite.TabIndex = 31;
            this.DenyInvite.Text = "Decline";
            this.DenyInvite.UseVisualStyleBackColor = true;
            this.DenyInvite.Visible = false;
            this.DenyInvite.Click += new System.EventHandler(this.DenyInvite_Click);
            // 
            // showMeetings
            // 
            this.showMeetings.Location = new System.Drawing.Point(1622, 387);
            this.showMeetings.Name = "showMeetings";
            this.showMeetings.Size = new System.Drawing.Size(194, 59);
            this.showMeetings.TabIndex = 32;
            this.showMeetings.Text = "Show Meetings";
            this.showMeetings.UseVisualStyleBackColor = true;
            this.showMeetings.Visible = false;
            this.showMeetings.Click += new System.EventHandler(this.showMeetings_Click);
            // 
            // showAccepted
            // 
            this.showAccepted.FormattingEnabled = true;
            this.showAccepted.Location = new System.Drawing.Point(24, 64);
            this.showAccepted.Name = "showAccepted";
            this.showAccepted.Size = new System.Drawing.Size(404, 33);
            this.showAccepted.TabIndex = 33;
            this.showAccepted.Visible = false;
            this.showAccepted.SelectedIndexChanged += new System.EventHandler(this.showAccepted_SelectedIndexChanged);
            // 
            // showAttendees
            // 
            this.showAttendees.FormattingEnabled = true;
            this.showAttendees.Location = new System.Drawing.Point(150, 346);
            this.showAttendees.Margin = new System.Windows.Forms.Padding(2);
            this.showAttendees.Name = "showAttendees";
            this.showAttendees.Size = new System.Drawing.Size(232, 33);
            this.showAttendees.TabIndex = 34;
            this.showAttendees.Visible = false;
            this.showAttendees.SelectedIndexChanged += new System.EventHandler(this.showAttendees_SelectedIndexChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1600, 460);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(235, 74);
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
            this.grpBoxInvites.Location = new System.Drawing.Point(536, 261);
            this.grpBoxInvites.Name = "grpBoxInvites";
            this.grpBoxInvites.Size = new System.Drawing.Size(459, 159);
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
            this.grpBoxMeetingDetails.Location = new System.Drawing.Point(485, 479);
            this.grpBoxMeetingDetails.Name = "grpBoxMeetingDetails";
            this.grpBoxMeetingDetails.Size = new System.Drawing.Size(498, 270);
            this.grpBoxMeetingDetails.TabIndex = 37;
            this.grpBoxMeetingDetails.TabStop = false;
            this.grpBoxMeetingDetails.Text = "Meeting Details";
            this.grpBoxMeetingDetails.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1622, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 37);
            this.button3.TabIndex = 38;
            this.button3.Text = "Save data to file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblShowTime);
            this.groupBox1.Controls.Add(this.lblTime);
            this.groupBox1.Controls.Add(this.lblInvitees);
            this.groupBox1.Controls.Add(this.lblShowMeetDate);
            this.groupBox1.Controls.Add(this.lblMeetDate);
            this.groupBox1.Controls.Add(this.lblShowMeetLoc);
            this.groupBox1.Controls.Add(this.lblshowMeetRequire);
            this.groupBox1.Controls.Add(this.lblLocation);
            this.groupBox1.Controls.Add(this.lblRequire);
            this.groupBox1.Controls.Add(this.showAccepted);
            this.groupBox1.Controls.Add(this.showAttendees);
            this.groupBox1.Location = new System.Drawing.Point(1081, 580);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 454);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Meeting Data";
            this.groupBox1.Visible = false;
            // 
            // lblInvitees
            // 
            this.lblInvitees.AutoSize = true;
            this.lblInvitees.Location = new System.Drawing.Point(19, 354);
            this.lblInvitees.Name = "lblInvitees";
            this.lblInvitees.Size = new System.Drawing.Size(86, 25);
            this.lblInvitees.TabIndex = 39;
            this.lblInvitees.Text = "Invitees";
            // 
            // lblShowMeetDate
            // 
            this.lblShowMeetDate.AutoSize = true;
            this.lblShowMeetDate.Location = new System.Drawing.Point(193, 263);
            this.lblShowMeetDate.Name = "lblShowMeetDate";
            this.lblShowMeetDate.Size = new System.Drawing.Size(0, 25);
            this.lblShowMeetDate.TabIndex = 38;
            this.lblShowMeetDate.Visible = false;
            // 
            // lblMeetDate
            // 
            this.lblMeetDate.AutoSize = true;
            this.lblMeetDate.Location = new System.Drawing.Point(19, 263);
            this.lblMeetDate.Name = "lblMeetDate";
            this.lblMeetDate.Size = new System.Drawing.Size(63, 25);
            this.lblMeetDate.TabIndex = 37;
            this.lblMeetDate.Text = "Date:";
            this.lblMeetDate.Visible = false;
            // 
            // lblShowMeetLoc
            // 
            this.lblShowMeetLoc.AutoSize = true;
            this.lblShowMeetLoc.Location = new System.Drawing.Point(193, 214);
            this.lblShowMeetLoc.Name = "lblShowMeetLoc";
            this.lblShowMeetLoc.Size = new System.Drawing.Size(0, 25);
            this.lblShowMeetLoc.TabIndex = 36;
            // 
            // lblshowMeetRequire
            // 
            this.lblshowMeetRequire.AutoSize = true;
            this.lblshowMeetRequire.Location = new System.Drawing.Point(193, 162);
            this.lblshowMeetRequire.Name = "lblshowMeetRequire";
            this.lblshowMeetRequire.Size = new System.Drawing.Size(0, 25);
            this.lblshowMeetRequire.TabIndex = 35;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(19, 214);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(106, 25);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location: ";
            this.lblLocation.Visible = false;
            // 
            // lblRequire
            // 
            this.lblRequire.AutoSize = true;
            this.lblRequire.Location = new System.Drawing.Point(19, 162);
            this.lblRequire.Name = "lblRequire";
            this.lblRequire.Size = new System.Drawing.Size(157, 25);
            this.lblRequire.TabIndex = 0;
            this.lblRequire.Text = "Requirements: ";
            this.lblRequire.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(927, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Current User:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1076, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Current User:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxEnterTime
            // 
            this.txtBoxEnterTime.Location = new System.Drawing.Point(365, 63);
            this.txtBoxEnterTime.Name = "txtBoxEnterTime";
            this.txtBoxEnterTime.Size = new System.Drawing.Size(100, 31);
            this.txtBoxEnterTime.TabIndex = 15;
            this.txtBoxEnterTime.Visible = false;
            // 
            // lblTimeInput
            // 
            this.lblTimeInput.AutoSize = true;
            this.lblTimeInput.Location = new System.Drawing.Point(260, 26);
            this.lblTimeInput.Name = "lblTimeInput";
            this.lblTimeInput.Size = new System.Drawing.Size(305, 25);
            this.lblTimeInput.TabIndex = 16;
            this.lblTimeInput.Text = "Enter Time in this format 24:30";
            this.lblTimeInput.Visible = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(24, 303);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 25);
            this.lblTime.TabIndex = 40;
            this.lblTime.Text = "Time:";
            this.lblTime.Visible = false;
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(193, 303);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(0, 25);
            this.lblShowTime.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2152, 1081);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grpBoxMeetingDetails);
            this.Controls.Add(this.grpBoxInvites);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.showMeetings);
            this.Controls.Add(this.btnShowInvites);
            this.Controls.Add(this.grpBoxDates);
            this.Controls.Add(this.chckBoxShowPeople);
            this.Controls.Add(this.btnDateSubmission);
            this.Controls.Add(this.btnSetPrefferences);
            this.Controls.Add(this.accoutCreate);
            this.Controls.Add(this.grpBxLogin);
            this.Controls.Add(this.Welcome);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBxLogin.ResumeLayout(false);
            this.grpBxLogin.PerformLayout();
            this.accoutCreate.ResumeLayout(false);
            this.accoutCreate.PerformLayout();
            this.grpBoxDates.ResumeLayout(false);
            this.grpBoxDates.PerformLayout();
            this.grpBoxInvites.ResumeLayout(false);
            this.grpBoxMeetingDetails.ResumeLayout(false);
            this.grpBoxMeetingDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRequire;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblShowMeetLoc;
        private System.Windows.Forms.Label lblshowMeetRequire;
        private System.Windows.Forms.Label lblShowMeetDate;
        private System.Windows.Forms.Label lblMeetDate;
        private System.Windows.Forms.Label lblInvitees;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTimeInput;
        private System.Windows.Forms.TextBox txtBoxEnterTime;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblTime;
    }
}

