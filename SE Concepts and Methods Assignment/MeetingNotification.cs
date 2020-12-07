using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Concepts_and_Methods_Assignment
{
    class MeetingNotification
    {
        // Attributes
        private int id;
        private string topic;
        private string time;
        private List<string> suggestedTimes;
        private List<string> invitees;
        private string location;
        private string requirements;

        public MeetingNotification(int ID, string Topic, List<string> Times, List<string>attendees, string loc, string requirement, string Time)
        {
            this.id = ID;
            this.topic = Topic;
            this.suggestedTimes = Times;
            this.time = Time;
            this.invitees = attendees;
            this.location = loc;
            this.requirements = requirement;
        }

        // Functions

        public string getMeetTime()
        {
            return this.time;
        }
        public int getID()
        {
            return this.id;
        }
        public List<string> getTimes()
        {
            return this.suggestedTimes;
        }
        public List<string> getInvitees()
        {
            return this.invitees;
        }
        public string displayAttendees()
        {
            string info = "";
            foreach (string person in invitees)
            {
                info += person + ", ";
            }
            return info;
            
        }
        public string getLocation()
        {
            return this.location;
        }

        public string getTopic()
        {
            return this.topic;
        }
        public string getRequire()
        {
            return this.requirements;
        }
    }
}
