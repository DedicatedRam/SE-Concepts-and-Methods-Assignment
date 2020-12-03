﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Concepts_and_Methods_Assignment
{
    class Person
    {
        // Attributes 
        private int ID;
        private string User;
        private string Pass;
        private int accessLevel;
        private List<MeetingNotification> meetingInvite = new List<MeetingNotification>();
        private List<Meeting> acceptedMeetings = new List<Meeting>();
        private Array ExclusionSet;
        private Array PrefferenceSet;
        bool loggedIn = false;

        //Constructor
        public Person(int newID, string newUser, string newPass, int newAccess)
        {
            ID = newID;
            User = newUser;
            Pass = newPass;
            accessLevel = newAccess;
        }

        // Functions
        public void addInviteToList(Meeting accepted)
        {
            acceptedMeetings.Add(accepted);
        }
        //public void acceptInvite(MeetingNotification notif, string meetDate)
        //{

        //    Meeting meet = new Meeting(meetDate, notif.getInvitees(), notif.getRequire(), notif.getLocation());
            
        //}
        public void denyInvite(MeetingNotification id)
        {
            
                
                    meetingInvite.Remove(id);
                    
                
            
        }
        public int getID()
        {
            return this.ID;
        }
        public string getUser()
        {
            return this.User;
        }
        public void setUser(string newUser)
        {
            this.User = newUser;
        }
        public string getPass()
        {
            return this.Pass;
        }
        void setPass(string newPass)
        {
            this.Pass = newPass;
        }
        public int getAccessLevel()
        {
            return this.accessLevel;
        }
        public void setAccessLevel(int newAccess)
        {
            this.accessLevel = newAccess;
        }
        public void setPreferenceSet()
        {

        }
        public void recieveInvite(MeetingNotification Notif)
        {
            meetingInvite.Add(Notif);
        }
        public List<MeetingNotification> getInvitesList()
        {
            return this.meetingInvite;
        }
        public List<Meeting> getAcceptedMeetings()
        {
            return this.acceptedMeetings;
        }
        public void logIn()
        {
            this.loggedIn = true;
        }
        public void logOut()
        {
            this.loggedIn = false;
        }
        public bool getStatus()
        {
            return this.loggedIn;
        }



    }
}
