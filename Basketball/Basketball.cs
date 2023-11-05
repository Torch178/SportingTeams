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

namespace SportTeam
{
    public class Basketball : SportTeam, iFunding
    {
        //declare data members for class
        private string[] starters = new string[5];
        private string[] positions = new string[5]
            { "Point Guard", "Shooting Guard", "Small Forward", "Power Forward", "Center"};
        List<string> bench;

        //define Properties for class
        public string[] Starters
        {
            get { return starters; }
            set { starters = value; }
        }

        public List<string> Bench
        {
            get { return bench; }
            set { bench = value; }
        }

        //default constructor
        public Basketball()
        {
            for(int i = 0; i < 5; i++)
            {
                Starters[i] = string.Empty;
            }
            Bench = new List<string>();
        }

        //Overloaded Constructor
        public Basketball(string name, string primaryContact, string coach,
            string manager, string practiceTimes, string practiceLocation, decimal funding, decimal numPlayers, bool regionalW, bool stateW, bool nationalW,
            string[]starters, List<string>bench)
        //feed input paramaters into base class constructor
        : base (name, primaryContact, coach,
            manager, practiceTimes, practiceLocation, funding, numPlayers, regionalW, stateW, nationalW)
        {
            Starters = starters;
            Bench = bench;
        }

        //returns all available/ unfilled positions on the team, which are open for tryouts
        public override string AvailablePositions()
        {
            //starters are full
            if(NumPlayers >= 5)
            {
                return "Starter Positions Full\n" +
                    "Accepting tryouts for Backup Positions";
            }
            else
            {
                string output = "";
                for(int i = 0;i < 5;i++)
                {
                    output += "Starter Positions needed, open for tryouts: \n\t";
                    if (Starters[i] == string.Empty)
                    {
                        output += GetPosition(i) + ", ";

                        
                    }
                }
                //Cut off dangling space and comma from last entry
                if (output.EndsWith(", ")) { output = output.Substring(0, output.Length - 2); }
                return output;
            }
        }

        public override string ToString()
        {
            //call base class ToString override
            string output = base.ToString();
            output += "\n\n\tStarters:";
            for(int i = 0;i < Starters.Length;i++)
            {
                output += "\n\t\t" + GetPosition(i) + " - " + Starters[i];
            }
            output += "\n\n\tBackups: ";
            foreach(string s in Bench)
            {
                output += "\n\t\t" + s;
            }
            output += "\n\nBudget: " + String.Format("{0:C}", Funding);
            output += "\nBudget Breakdown: ";
            output += "\n\tBase: $200.00\n\t";
            if (NumPlayers >= 10) { output += "Full Team: $50.00\n\t"; }
            if (RegionalW) { output += "Regional Champs: $100.00\n\t"; }
            if (StateW) { output += "State Champs: $150.00\n\t"; }
            if (NationalW) { output += "National Champs: $300.00\n"; }

            return output;
        }

        //Converts array index in team array to the corresponding position it represents
        public string GetPosition(int i)
        {
            switch (i)
            {
                case 0:
                    return "Point Guard";
                case 1:
                    return "Shooting Guard";
                case 2:
                    return "Small Forward";
                case 3:
                    return "Power Forward";
                case 4:
                    return "Center";
                default:
                    return "";
            }
        }

        public void SetFunding()
        {
            Funding = 200m;
            if (NumPlayers >= 10)
            {
                Funding += 50m;
            }
            if (RegionalW == true)
            {
                Funding += 100m;
            }
            if (StateW == true)
            {
                Funding += 150m;
            }
            if (NationalW == true)
            {
                Funding += 300m;
            }
        }

    }
}