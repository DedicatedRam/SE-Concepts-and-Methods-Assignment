﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SE_Concepts_and_Methods_Assignment
{
    public partial class Form1 : Form
    {
        
        
        Dictionary<int, object> personDic = new Dictionary<int, object>();
        Dictionary<int, object> inviteDic = new Dictionary<int, object>();
        Dictionary<int, object> meetingDic = new Dictionary<int, object>();
        
        private int inviteID = 0;
        private int meetingID = 0;

        public void showOptions()
        {
            btnSetPrefferences.Visible = true;
            btnShowInvites.Visible = true;
            btnLogout.Visible = true;
            showMeetings.Visible = true;
        }
        public void clearLoginPage()
        {
            grpBxLogin.Visible = false;
            accoutCreate.Visible = false;
            Welcome.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();


        }
        public void flushCSVData()
        {
            System.IO.File.Delete(@".\\users.txt");
            System.IO.File.Delete(@".\\meetings.txt");
            System.IO.File.Delete(@".\\meetingInvites.txt");
            string strFilePath = @".\\meetings.txt";
            string strFilePath2 = @".\\meetingInvites.txt";
            string strFilePath3 = @".\\users.txt";
            string strSeparator = "/";
            StringBuilder output = new StringBuilder();

            //

            //

            File.WriteAllText(strFilePath, output.ToString());
            File.WriteAllText(strFilePath2, output.ToString());
            File.WriteAllText(strFilePath3, output.ToString());
        }

        public void readInstanciateInvites()
        {
            string line;
            int counter;
            inviteDic.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(@".\\meetingInvites.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] entries = line.Split('/');
                Person Alpha = new Person(int.Parse(entries[0]), entries[1], entries[2], 0);
                personDic.Add(int.Parse(entries[0]), Alpha);

            }
        }

        public void readInstanciateUser()
        {
            string line;
            int counter;
            personDic.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader(@".\\users.txt");
            while((line = file.ReadLine()) != null)
            {
                string[] entries = line.Split('/');
                Person Alpha = new Person(int.Parse(entries[0]), entries[1], entries[2], 0);
                personDic.Add(int.Parse(entries[0]), Alpha);

            }
        }

        public void writeMeetingData()
        {
            string strFilePath = @".\\meeting.txt";
            string strSeperator = "/";


            foreach (Meeting meet in meetingDic.Values)
            {
                string attendees = "";
                foreach (string name in meet.getAttendees())
                {
                    attendees +=  name + ", ";
                }




                string output = (meet.getDate() + "/" + attendees + "/" + meet.getRequirements() + "/" + meet.getLocation() + "/" + meet.getTopic() + "/").ToString();

                using (StreamWriter outputFile = File.AppendText(strFilePath))
                {
                    outputFile.WriteLine(output);
                }
            }
            
        }

        public void writeInviteData()
        {
            string strFilePath = @".\\meetingInvites.txt";
            string strSeparator = "/";

            foreach (MeetingNotification notif in inviteDic.Values)
            {
                string times = "";
                string invitees = "";
                foreach (DateTime time in notif.getTimes())
                {
                    times += time.ToString("MM-dd-yyy") + ",";
                }
                foreach (string person in notif.getInvitees())
                {
                    invitees += person + ",";
                }
                string output = (notif.getID() + "/" + notif.getTopic() + "/" + times + "/" + invitees + "/" + notif.getLocation() + "/" + notif.getRequire() + "/");
                using (StreamWriter outputFile = File.AppendText(strFilePath))
                {
                    outputFile.WriteLine(output);
                }
            }
        }

        public void writeUserData()
        {
            string strFilePath = @".\\users.txt";
            string strSeperator = "/";

            
            foreach (Person person in personDic.Values)
            {
                string inviteList = "";
                string acceptedList = "";
                foreach (MeetingNotification notif in person.getInvitesList())
                {
                    inviteList += notif.getID() + ", ";
                }
                foreach (Meeting meet in person.getAcceptedMeetings())
                {
                    acceptedList += meet.getID() + ", ";
                }
                string Output = (person.getID()+ "/" + person.getUser()+ "/" + person.getPass() + "/" + inviteList + "/" + acceptedList); 

                using (StreamWriter outputFile = File.AppendText(strFilePath))
                {
                    outputFile.WriteLine(Output);
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readInstanciateUser();
            //personDic.Add(Dave.getID(), Dave);
            //personDic.Add(John.getID(), John);
            //personDic.Add(Joe.getID(), Joe);
            //personDic.Add(Stew.getID(), Stew);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Person user in personDic.Values)
            {
                if (user.getUser() == UserNameInput.Text)
                {
                    if (user.getPass() == PasswordInput.Text)
                    {
                        Welcome.Text = "Login Success!";
                        user.logIn();
                        clearLoginPage();
                        showOptions();
                    }
                    if (user.getPass() != PasswordInput.Text)
                    {
                        Welcome.Text = "Login unsuccessful";
                        break;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = txtCreateUser.Text;
            string pass = txtCreatePass.Text;
            int LOA = int.Parse(txtCreateAccess.Text);
            int personID = personDic.Count +1;
            Person Alpha = new Person(personID, name, pass, LOA);
            if (Alpha != null)
            {
                Welcome.Text = "Account created successfully!";
                txtCreatePass.Text = "";
                txtCreateUser.Text = "";
                txtCreateAccess.Text = "";
            }
            personDic.Add(personID, Alpha);


            
        }

        

        private void btnSetPrefferences_Click(object sender, EventArgs e)
        {
            chckBoxShowPeople.Items.Clear();
            grpBoxDates.Visible = true;
            grpBoxMeetingDetails.Visible = true;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            dateTimePicker3.Visible = true;
            dateTimePicker4.Visible = true;
            chckBoxShowPeople.Visible = true;
            lblEnterLocation.Visible = true;
            lblRequirements.Visible = true;
            meetingTopic.Visible = true;
            buildingName.Visible = true;
            roomName.Visible = true;
            txtBxEnterRequire.Visible = true;
            txtBxEnterBuilding.Visible = true;
            txtBxMeetingTopic.Visible = true;
            txtBxEnterRoom.Visible = true;
            btnDateSubmission.Visible = true;
            foreach(Person person in personDic.Values)
            {
                chckBoxShowPeople.Items.Add(person.getUser());
            }
        }

        private void btnDateSubmission_Click(object sender, EventArgs e)
        {
            List<DateTime> suggestedTimes = new List<DateTime>();
            List<string> invitees = new List<string>();
            DateTime suggestedDate1 = dateTimePicker1.Value;
            DateTime suggestedDate2 = dateTimePicker2.Value;
            DateTime suggestedDate3 = dateTimePicker3.Value;
            DateTime suggestedDate4 = dateTimePicker4.Value;
            suggestedTimes.Add(suggestedDate1);
            suggestedTimes.Add(suggestedDate2);
            suggestedTimes.Add(suggestedDate3);
            suggestedTimes.Add(suggestedDate4);
            string Tpic = txtBxMeetingTopic.Text;
            foreach (string person in chckBoxShowPeople.CheckedItems)
            {
                invitees.Add(person);
            }
            string location = txtBxEnterBuilding.Text + txtBxEnterRoom.Text;
            string require = txtBxEnterRequire.Text;
            MeetingNotification invite = new MeetingNotification(inviteID, Tpic, suggestedTimes, invitees, location, require);
            inviteDic.Add(inviteID, invite);
            inviteID++;
            foreach (string invitee in invitees)
            {
                foreach (Person person in personDic.Values)
                {
                    if (invitee == person.getUser())
                    {
                        person.recieveInvite(invite);
                    }
                }
                
            }
            Welcome.Text = "Meeting Invites sent!";
            Welcome.Visible = true;
            grpBoxDates.Visible = false;
            txtBxEnterBuilding.Visible = false;
            txtBxEnterRoom.Visible = false;
            grpBoxMeetingDetails.Visible = false;
            txtBxEnterRequire.Visible = false;
            lblEnterLocation.Visible = false;
            btnDateSubmission.Visible = false;
            lblEnterLocation.Visible = false;
            lblRequirements.Visible = false;
            roomName.Visible = false;
            buildingName.Visible = false;
            meetingTopic.Visible = false;
            chckBoxShowPeople.Visible = false;
            txtBxMeetingTopic.Visible = false;
        }

        private void btnShowInvites_Click(object sender, EventArgs e)
        {
            inviteSelector.Visible = true;
            showDates.Visible = true;
            acceptInvite.Visible = true;
            DenyInvite.Visible = true;
            grpBoxInvites.Visible = true;

            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    foreach (MeetingNotification notif in person.getInvitesList())
                    {
                        
                        inviteSelector.Items.Add(notif.getTopic());

                        
                        
                    }
                }
                

            }
        }

        private void inviteSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (MeetingNotification notif in inviteDic.Values)
            {
                if (inviteSelector.SelectedItem == notif.getTopic())
                {
                    showDates.Items.Clear();
                    foreach (DateTime dates in notif.getTimes())
                    {
                        showDates.Items.Add(dates.ToString("MM/dd/yyyy"));
                    }
                }
            }
        }

        private void acceptInvite_Click(object sender, EventArgs e)
        {
            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    foreach (MeetingNotification notifi in person.getInvitesList())
                    {
                        if (notifi.getTopic() == inviteSelector.SelectedItem.ToString())
                        {
                            Meeting meet = new Meeting(meetingID, notifi.getTopic(), showDates.SelectedItem.ToString(), notifi.getInvitees(), notifi.getRequire(), notifi.getLocation());
                            meetingDic.Add(meetingID, meet);
                            meetingID++;
                            person.addInviteToList(meet);
                            showDates.Visible = false;
                            inviteSelector.Visible = false;
                            acceptInvite.Visible = false;
                            DenyInvite.Visible = false;
                            grpBoxInvites.Visible = false;
                        }
                    }
                    
                }
            }
        }

        private void DenyInvite_Click(object sender, EventArgs e)
        {
            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    for (int i = 0; i < person.getInvitesList().Count; i++)
                    {
                        if (person.getInvitesList()[i].getTopic() == inviteSelector.SelectedItem.ToString())
                        {
                            inviteSelector.Items.RemoveAt(i);
                            showDates.Items.Clear();
                            person.denyInvite(person.getInvitesList()[i]);
                            grpBoxInvites.Visible = false;
                            DenyInvite.Visible = false;
                            acceptInvite.Visible = false;
                            showDates.Visible = false;
                            inviteSelector.Visible = false;
                        }
                    }
                }
            }
        }

        private void showMeetings_Click(object sender, EventArgs e)
        {
            showAccepted.Visible = true;
            showAttendees.Visible = true;
            foreach (Person person in personDic.Values)
            {

                if(person.getStatus() == true)
                {

                
                    foreach (Meeting meet in meetingDic.Values)
                    {
                        showAccepted.Items.Add(meet.getTopic() + " " + meet.getDate() + " " + meet.getLocation());
                        showAttendees.Items.Clear();
                        foreach (string name in meet.getAttendees())
                        {
                            showAttendees.Items.Add(name);
                        }
                    }
                }
            }
        }

        public void goToLogin()
        {
            inviteSelector.Visible = false;
            showDates.Visible = false;
            acceptInvite.Visible = false;
            DenyInvite.Visible = false;
            lblEnterLocation.Visible = false;
            roomName.Visible = false;
            buildingName.Visible = false;
            meetingTopic.Visible = false;
            lblRequirements.Visible = false;
            txtBxEnterRoom.Visible = false;
            txtBxEnterBuilding.Visible = false;
            txtBxMeetingTopic.Visible = false;
            txtBxEnterRequire.Visible = false;
            chckBoxShowPeople.Visible = false;
            showAccepted.Visible = false;
            showAttendees.Visible = false;
            grpBoxDates.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            btnSetPrefferences.Visible = false;
            btnDateSubmission.Visible = false;
            btnShowInvites.Visible = false;
            showMeetings.Visible = false;
            grpBxLogin.Visible = true;
            UserNameInput.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            PasswordInput.Visible = true;
            button1.Visible = true;
            accoutCreate.Visible = true;
            txtCreateUser.Visible = true;
            txtCreatePass.Visible = true;
            txtCreateAccess.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button2.Visible = true;
            grpBoxInvites.Visible = false;
            grpBoxMeetingDetails.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            goToLogin();
            foreach (Person person in personDic.Values)
            {
                if (person.getStatus() == true)
                {
                    person.logOut();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            writeUserData();
            writeInviteData();
            writeMeetingData();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            flushCSVData();
        }

        private void showAccepted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
