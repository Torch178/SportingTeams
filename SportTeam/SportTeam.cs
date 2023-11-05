/*
 * Name: Christian Luke
 * Date: 11/5/2023
 * Description:
 *      This program showcases my knowledge and skills when working with object-oriented programming. I create a base sports team class to define some generic data members/ properties and functions which
 *      will be used by the derived classes, which in this case, will be individual sports teams on campus. For this program I have defined paramaters for a basketball child class and a football child class.
 *      Now of course, the team composition and budgetary needs of a basketball team is going to be very different from that of a football team. So each class will have different individual data members and properties
 *      which define the component positions of each team as well as an interface for setting the budget/ funding for each. The basketball team will only have starters and backup players, while a football team will
 *      have more players/ positions split between an  offensive team, a defensive team, a special team, and a practice squad / backup team. As such, each team will need to override a virtual function for displaying 
 *      the information and roster for each team as well as displaying unfilled positions which each team still needs. This functionality will all be shown and tested within the context of a Windows form application.
 *      Users will be prompted to select a team. There are two separate buttons wired up to event triggers for displaying the team information, as well as fetching open positions the team still needs. A simple popup
 *      message box will appear prompting the user to select a team if they attempt to trigger these buttons without selecting one of the two teams beforehand.
 * Loom Video Walkthrough Link:
 *      https://www.loom.com/share/3cc8cee312104b409920c3bc3549e9dc
 */

namespace SportTeam
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
        private bool regionalW;
        private bool stateW;
        private bool nationalW;

        //default constructor
        public SportTeam()
        {

        }

        //Overloaded Constructor
        public SportTeam(string name, string primaryContact, string coach,
            string manager, string practiceTimes, string practiceLocation, decimal funding, decimal numPlayers, bool regionalW, bool stateW, bool nationalW)
        {
            Name = name;
            PrimaryContact = primaryContact;
            Coach = coach;
            Manager = manager;
            PracticeLocation = practiceLocation;
            PracticeTimes = practiceTimes;
            Funding = funding;
            NumPlayers = numPlayers;
            RegionalW = regionalW;
            StateW = stateW;
            NationalW = nationalW;
        }

        //declare Properties for base class
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

        public bool RegionalW
        {
            get { return regionalW; }
            set { regionalW = value; }
        }

        public bool StateW
        {
            get { return stateW; }
            set { stateW = value; }
        }

        public bool NationalW
        {
            get { return nationalW; }
            set { nationalW = value; }
        }

        public override string ToString()
        {
            string output = string.Empty;
            if (NationalW) { output += "Current National Champions!\n\n"; }
            else if (StateW) { output += "Current State Champions!\n\n"; }
            else if (RegionalW) { output += "Current Regional Champions!\n\n"; }
            output += "Team: " + Name + "\n\tCoach: " + Coach +
                "\n\tManager: " + Manager +
                "\n\tPrimary Contact: " + PrimaryContact +
                "\n\tPractice Times:  " + PracticeTimes +
                "\n\tPractice Location: " + PracticeLocation +
                "\n\tTeam Size - " + NumPlayers;
            return output;


        }

        //virtual function to be overloaded by derived classes
        public virtual string AvailablePositions()
        {
            return "";
        }

    }
}