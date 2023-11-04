using Interfaces;

namespace SportTeam
{
    public class Basketball : SportTeam, iFunding
    {
        private string[] starters = new string[5];
        private string[] positions = new string[5]
            { "Point Guard", "Shooting Guard", "Small Forward", "Power Forward", "Center"};
        List<string> bench;

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

        public Basketball()
        {
            for(int i = 0; i < 5; i++)
            {
                Starters[i] = string.Empty;
            }
            Bench = new List<string>();
        }
        public Basketball(string name, string primaryContact, string coach,
            string manager, string practiceTimes, string practiceLocation, decimal funding, decimal numPlayers, bool regionalW, bool stateW, bool nationalW,
            string[]starters, List<string>bench)
        : base (name, primaryContact, coach,
            manager, practiceTimes, practiceLocation, funding, numPlayers, regionalW, stateW, nationalW)
        {
            Starters = starters;
            Bench = bench;
        }

        public override string AvailablePositions()
        {
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
                if (output[-2] == ',') { output = output.Remove(output.Length - 1, 1); }
                return output;
            }
        }

        public override string ToString()
        {
            string output = base.ToString();
            output += "\n\n\tStarters:";
            for(int i = 0;i < Starters.Length;i++)
            {
                output += "\n\t\t" + GetPosition(i) + " - " + Starters[i];
            }
            output += "\n\nBackups: ";
            foreach(string s in Bench)
            {
                output += "\n\t\t" + s;
            }

            return output;
        }

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
            if (NumPlayers > 10)
            {
                Funding += 50m;
            }
            if (RegionalW == true)
            {
                Funding += 100m;
            }
            if (StateW == true)
            {
                Funding += 100m;
            }
            if (NationalW == true)
            {
                Funding += 300m;
            }
        }

    }
}