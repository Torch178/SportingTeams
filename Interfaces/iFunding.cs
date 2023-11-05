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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iFunding
    {
        void SetFunding();
    }
}
