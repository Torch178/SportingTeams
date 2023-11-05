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

using SportTeam;

namespace SportingTeams
{
    public partial class SportingTeamsForm : Form
    {
        //declare sub-class objects
        private Football fb;
        private Basketball bb;
        public SportingTeamsForm()
        {
            InitializeComponent();
        }

        private void SportingTeamsForm_Load(object sender, EventArgs e)
        {
            //Create Arrays used to populate data members in Football class object
            string[] offense = { "Josh Newman", "Martin Selleck", "Bob Arnold", "Bel Ferney", "Craig Martinez", "", "Terry Jones", "Andrew Kret", "Fallon Barley", "Bobby Brown", "" };
            string[] defense = { "", "", "", "Johnny Beet", "Martin Bushwick", "Pauly Son", "", "Greg Denzi", "Taka Igni", "John Jones", "Kerry Simmons" };
            string[] special = { "", "Carl Jensen", "Benni Schlen", "Ulysses Hernandez" };
            List<string> practice = new List<string>();

            //instantiate new Football object and set the funding amount
            fb = new Football("The Bulldogs", "Connor Fillion - 8015552143", "Gregory Halsin", "Connor Fillion", "Mon - Fri, 4:30PM - 6:30PM", "North Stadium Field", 0, 19, true, true, false,
                7, 9, 3, offense, defense, special, practice);
            fb.SetFunding();

            //Create Arrays used to populate data members in Basketball class object
            string[] starters = { "Michael Helios", "Danny Hopinski", "Barney Simmons", "Hal Conway", "Ernest Parker" };
            string[] benchPlayers = { "Sal Hammond", "Jerry Smith", "Juan Gonzalez", "Jamie Yfret", "Tony Horowitz" };
            List<string> bench = new List<string>();

            //Populate backup players list with contents from string array
            for (int i = 0; i < benchPlayers.Length; i++)
            {
                bench.Add(benchPlayers[i]);
            }

            // instantiate new Basketball object and set the funding amount
            bb = new Basketball("The Hornets", "Sally Moldova - 8012345677", "Isaac Rush", "Sally Moldova", "Mon - Thurs, 4:30PM - 7:00PM", "Dilbert Hall Gymnasium", 0, 10, true, true, true,
                starters, bench);
            bb.SetFunding();

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (rbBasketball.Checked)
            {
                //Display Basketball Team info
                MessageBox.Show(bb.ToString());
            }
            else if (rbFootball.Checked)
            {
                //Display Football Team info
                MessageBox.Show(fb.ToString());
            }
            else
            {
                //Display error message if user did not select a team
                MessageBox.Show("Please Select a Sports Team to Display Information for.");
            }
        }

        private void btnShowPos_Click(object sender, EventArgs e)
        {
            if (rbBasketball.Checked)
            {
                //Show available positions open for tyrouts
                MessageBox.Show(bb.AvailablePositions());
            }
            else if (rbFootball.Checked)
            {
                //Show available positions open for tyrouts
                MessageBox.Show(fb.AvailablePositions());
            }
            else
            {
                //Display error message if user did not select a team
                MessageBox.Show("Please Select a Sports Team to show Available Positions for Tryouts.");
            }
        }
    }
}