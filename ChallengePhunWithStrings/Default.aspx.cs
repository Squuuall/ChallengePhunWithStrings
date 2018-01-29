using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Joshua Armstrong";
            // In my case, the result would be:
            // robaT boB

            resultLabel.Text = string.Join(" ", name.Split(' ').Select(x => new String(x.Reverse().ToArray())));



            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke

            string[] reorder = names.Split(',');
            string result = "";
            for (int i = reorder.Length - 1; i >= 0; i--)
            {
                result += reorder[i] + ",";
            }

            string result2 = result.Remove(result.Length - 1, 1);
            resultLabel2.Text = result2;

            // 3. Use the sequence to create ascii art:
            string namestwo = "Luke,Leia,Han,Chewbacca";
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***

            string[] names3 = namestwo.Split(',');
            string result3 = "";
            for (int i = 0; i < names3.Length; i++)
            {
                int padLeft = (14 - names3[i].Length) / 2;
                string padded = names3[i].PadLeft(names3[i].Length + padLeft, '*');
                result3 += padded.PadRight(14, '*');
                result3 += "<br />";
            }

            resultLabel3.Text = result3;

            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            var replacements = new[]{
            new{Find="remove-me",Replace=""},
            new{Find="Z",Replace="t"},

            };

            foreach (var set in replacements)
            {
                puzzle = puzzle.Replace(set.Find, set.Replace);
            }
            var myLongStringReplaced = replacements.Aggregate(puzzle, (current, set) => current.Replace(set.Find, set.Replace));

            resultLabel4.Text = puzzle.Substring(0, 1) + puzzle.Substring(1).ToLower();

        }
    }
}