using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace womens_race_project
{
   public class ControlGame
   {
        public String checkArray(String data,String name) {
            String[] g = data.Split(' ');
            //   record[cbBetter.SelectedIndex] = cbBetter.Text + " " + cbAmount.Text + " " + playerName;
            //Name, betAmount, contestant, budget
            if(g[2].Equals(name))
            {
                return (Convert.ToInt32(g[3]) + Convert.ToInt32(g[1])).ToString();
            }
            else {
                return (Convert.ToInt32(g[3]) - Convert.ToInt32(g[1])).ToString();
            }
            
        }

   }
}
