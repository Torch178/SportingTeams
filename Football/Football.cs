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

using Interfaces;
using System.Security.Cryptography;

namespace SportTeam
{
    public class Football : SportTeam, iFunding
    {
        //declare data members for class
        private string[] offense = new string[11];
        private string[] defense = new string[11];
        private string[] special = new string[4];
        private int numOffense;
        private int numDefense;
        private int numSpecial;
        private List<string> practiceTeam;

        public string[] defPos = 
        {"Corner Back 1", "Corner Back 2", "Safety 1", "Safety 2", "Outside Line Back 1", "Outside Line Back 2", "Defensive End 1", "Defensive End 2", "Defensive Tackle 1", "Defensive Tackle 2", "Mid Line Back"};
        public string[] offPos = 
        { "Quarter Back", "Wide Reciever 1","Wide Reciever 2","Full Back", "Half Back", "Tight End", "Offensive Guard 1", "Offensive Guard 2", "Offensive Tackle 1", "Offensive Tackle 2", "Offensive Center"};
        public string[] specialPos = 
        { "Kicker", "Punter", "Holder", "Snapper"};

        //define Properties for class
        public string[] Offense
        {
            get { return offense; }
            set { offense = value; }
        }

        public string[] Defense
        {
            get { return defense; }
            set { defense = value; }
        }

        public string[] Special
        {
            get { return special; }
            set { special = value; }
        }

        public int NumOffense
        {
            get { return numOffense; }
            set { numOffense = value; }
        }

        public int NumDefense
        {
            get { return numDefense; }
            set { numDefense = value; }
        }

        public int NumSpecial
        {
            get { return numSpecial; }
            set { numSpecial = value; }
        }

        public List<string> PracticeTeam
        {
            get { return practiceTeam; }
            set { practiceTeam = value; }
        }

        //default constructor
        public Football()
        {
            NumOffense = 0;
            NumDefense = 0;
            NumSpecial = 0;
            for(int i = 0; i < 11; i++)
            { 
                if(i < 4)
                {
                    Special[i] = String.Empty;
                }
                Offense[i] = String.Empty;
                Defense[i] = String.Empty;

            }

            PracticeTeam = new List<string>();
        }

        //Overloaded Constructor
        public Football(string name, string primaryContact, string coach,
            string manager, string practiceTimes, string practiceLocation, decimal funding, decimal numPlayers, bool regionalW, bool stateW, bool nationalW,
            int numDefense, int numOffense, int numSpecial, string[]offense, string[]defense, string[]special, List<string>practice)
         //feed input paramaters into base class constructor
         : base(name, primaryContact, coach,
            manager, practiceTimes, practiceLocation, funding, numPlayers, regionalW, stateW, nationalW)
        {
            NumDefense= numDefense;
            NumOffense= numOffense;
            NumSpecial= numSpecial;
            Offense= offense;
            Defense= defense;
            Special= special;
            PracticeTeam = practice;
        }

        public override string ToString()
        {
            //call base class ToString override
            string output = base.ToString();
            output += "\n\n\tOffense:";
            for (int i = 0; i < Offense.Length; i++)
            {
                output += "\n\t\t" + GetPosition(i, 'o') + " - " + Offense[i];
            }
            output += "\n\tDefense:";
            for (int i = 0; i < Defense.Length; i++)
            {
                output += "\n\t\t" + GetPosition(i, 'd') + " - " + Defense[i];
            }
            output += "\n\tSpecial:";
            for (int i = 0; i < Special.Length; i++)
            {
                output += "\n\t\t" + GetPosition(i, 's') + " - " + Special[i];
            }

            output += "\n\tPractice Squad: ";
            foreach (string s in PracticeTeam)
            {
                output += "\n\t\t" + s;
            }
            output += "\n\nBudget: " + String.Format("{0:C}", Funding);
            output += "\nBudget Breakdown: ";
            output += "\n\tBase: $500.00\n\t";
            if (NumPlayers >= 25) { output += "Full Team: $100.00\n\t"; }
            if (RegionalW) { output += "Regional Champs: $150.00\n\t"; }
            if (StateW) { output += "State Champs: $250.00\n\t"; }
            if(NationalW) { output += "National Champs: $500.00\n"; }
            return output;
        }

        //returns all available/ unfilled positions on the team, which are open for tryouts
        public override string AvailablePositions()
        {
            string output = String.Empty;
            //retreive unfilled offensive positions
            if(NumOffense < 11)
            {
                for(int i = 0;i < Offense.Length;i++)
                {
                    if (Offense[i] == String.Empty)
                    {
                        output += GetPosition(i, 'o') + ", ";
                    }
                }
            }
            //retreive unfilled defensive positions
            if (NumDefense < 11)
            {
                for (int i = 0; i < Defense.Length; i++)
                {
                    if (Defense[i] == String.Empty)
                    {
                        output += GetPosition(i, 'd') + ", ";
                    }
                }
            }
            //retreive unfilled special team positions
            if (NumSpecial < 4)
            {
                for (int i = 0; i < Special.Length; i++)
                {
                    if (Special[i] == String.Empty)
                    {
                        output += GetPosition(i, 's') + ", ";
                    }
                }
            }
            if(output == String.Empty)
            {
                return "Positions full, accepting tryouts for Practice Squad.";
            }
            else
            {
                //Cut off dangling space and comma from last entry
                if (output.EndsWith( ", ")) { output = output.Substring(0, output.Length-2); }
                return "Positions needed, open for tryouts:\n\t" +
                    output + "\n";
            }
        }

        //Converts array index in team array to the corresponding position it represents
        public string GetPosition(int i, char c)
        {
            switch (c)
            {
                case 'o':
                    switch (i)
                    {
                        case 0:
                            return "Quarter Back";
                        case 1:
                            return "Wide Reciever 1";
                        case 2:
                            return "Wide Reciever 2";
                        case 3:
                            return "Full Back";
                        case 4:
                            return "Half Back";
                        case 5:
                            return "Tight End";
                        case 6:
                            return "Offensive Guard 1";
                        case 7:
                            return "Offensive Guard 2";
                        case 8:
                            return "Offensive Tackle 1";
                        case 9:
                            return "Offensive Tackle 2";
                        case 10:
                            return "Offensive Center";
                        default:
                            return "";
                    }
                    
                case 'd':
                    switch (i)
                    {
                        case 0:
                            return "Corner Back 1";
                        case 1:
                            return "Corner Back 2";
                        case 2:
                            return "Safety 1";
                        case 3:
                            return "Safety 2";
                        case 4:
                            return "Outside Line Back 1";
                        case 5:
                            return "Outside Line Back 2";
                        case 6:
                            return "Defensive End 1";
                        case 7:
                            return "Defensive End 2";
                        case 8:
                            return "Defensive Tackle 1";
                        case 9:
                            return "Defensive Tackle 2";
                        case 10:
                            return "Mid Line Back";
                        default:
                            return "";
                    }
                    
                case 's':
                    switch (i)
                    {
                        case 0:
                            return "Kicker";
                        case 1:
                            return "Punter";
                        case 2:
                            return "Holder";
                        case 3:
                            return "Snapper";
                        default:
                            return "";
                        
                    }
                    
                default:
                    return "";
            }
        }

        public void SetFunding()
        {
            Funding = 500m;
            if(NumPlayers >= 25)
            {
                Funding += 100m;
            }
            if(RegionalW == true)
            {
                Funding += 150M;
            }
            if(StateW == true)
            {
                Funding += 250M;
            }
            if(NationalW == true)
            {
                Funding += 500M;
            }
        }

    }
}