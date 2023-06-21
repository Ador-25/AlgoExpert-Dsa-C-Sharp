using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert_Easy
{
    public class Tournament_Winner
    {
        public string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.

            Dictionary<string,int> points =  new Dictionary<string,int>();
            int index = 0;
            foreach(List<string> match in competitions)
            {
                string winner = "";
                if (results[index] == 0)
                {
                    winner = match[1];
                }
                else
                {
                    winner = match[0];
                }
                index++;
                if(points.ContainsKey(winner))
                {
                    int point = points[winner];
                    points[winner] = point+3;
                }
                else
                {
                    points.Add(winner, 3);
                }
            }
            string ans = "";
            int max = -1;
            foreach(string item in points.Keys)
            {
                if (points[item] > max)
                {
                    max = points[item];
                    ans = item;
                }
            }
            return ans;
        }
    }
}
