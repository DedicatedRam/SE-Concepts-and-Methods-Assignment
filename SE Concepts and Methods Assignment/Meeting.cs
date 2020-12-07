using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_Concepts_and_Methods_Assignment
{
    class Meeting
    {
        // Properties
        private int id;
        private string meetingDate;
        private string meetingTime;
        private List<string> Attendees;
        private string specialRequirements;
        private string meetingRoom;
        private string meetingBuilding;
        private string topic;
        private string loc;

        // Constructor 
        public Meeting(int ID, string Topic, string meetDate, List<string> attendents, string requirements, string location, string time)
        {
            this.id = ID;
            this.topic = Topic;
            this.meetingDate = meetDate;
            this.meetingTime = time;
            this.Attendees = attendents;
            this.specialRequirements = requirements;
            this.loc = location;
        }

        // Functions

        public string getTime()
        {
            return this.meetingTime;
        }
        public int getID()
        {
            return this.id;
        }
        public string getDate()
        {
            return this.meetingDate;
        }
        public List<string> getAttendees()
        {
            return this.Attendees;
        }
        public string getRequirements()
        {
            return this.specialRequirements;
        }
        public string getLocation()
        {
            return this.loc;
        }
        public string getTopic()
        {
            return this.topic;
        }
    }
}
