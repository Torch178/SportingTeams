using Interfaces;

namespace SportTeam
{
    public class Football : SportTeam, iFunding
    {
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

        public Football(string name, string primaryContact, string coach,
            string manager, string practiceTimes, string practiceLocation, decimal funding, decimal numPlayers, bool regionalW, bool stateW, bool nationalW,
            int numDefense, int numOffense, int numSpecial, string[]offense, string[]defense, string[]special, List<string>practice)
         :base(name, primaryContact, coach,
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
            string output = base.ToString();
            output += "\n\n\tOffense:";
            for(int i =0; i < Offense.Length; i++)
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

            return output;
        }

        public override string AvailablePositions()
        {
            string output = String.Empty;
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
            if(NumDefense < 11)
            {
                for (int i = 0; i < Defense.Length; i++)
                {
                    if (Defense[i] == String.Empty)
                    {
                        output += GetPosition(i, 'd') + ", ";
                    }
                }
            }
            if(NumSpecial < 4)
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
                if (output[-2] == ',') { output = output.Remove(output.Length - 1, 1); }
                return "Positions needed, open for tryouts:\n\t" +
                    output + "\n";
            }
        }

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
            if(NumPlayers > 25)
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