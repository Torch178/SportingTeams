﻿namespace SportTeam
{
    public abstract class SportTeam
    {
        private string name;
        private string primaryContact;
        private string coach;
        private string manager;
        private string practiceTimes;
        private string practiceLocation;
        private decimal funding;
        private decimal numPlayers;

        public SportTeam()
        {

        }

        public SportTeam(string name, string primaryContact, string coach,
            string manager, string practiceTimes, string practiceLocation, decimal funding, decimal numPlayers)
        {
            this.name = name;
            this.primaryContact = primaryContact;
            this.coach = coach;
            this.manager = manager;
            this.practiceLocation = practiceLocation;
            this.practiceTimes = practiceTimes;
            this.funding = funding;
            this.numPlayers = numPlayers;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PrimaryContact
        {
            get { return primaryContact; }
            set { primaryContact = value; }
        }

        public virtual string Coach
        {
            get { return coach; }
            set { coach = value; }
        }

        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public string PracticeTimes
        {
            get { return practiceTimes; }
            set { practiceTimes = value; }
        }

        public string PracticeLocation
        {
            get { return practiceLocation; }
            set { practiceLocation = value; }
        }

        public decimal Funding
        {
            get { return funding; }
            set { funding = value; }
        }

        public decimal NumPlayers
        {
            get { return numPlayers; }
            set { numPlayers = value; }
        }

        public override string ToString()
        {
            return "Team: " + Name + "\n\tCoach: " + Coach +
                "\n\tManager: " + Manager +
                "\n\tPrimary Contact: " + PrimaryContact +
                "\n\tPractice Times:  " + PracticeTimes +
                "\n\tPractice Location: " + PracticeLocation +
                "\n\tTeam Size - " + NumPlayers;
                  
                
        }

        public virtual string AvailablePositions()
        {
            return "";
        }

    }
}