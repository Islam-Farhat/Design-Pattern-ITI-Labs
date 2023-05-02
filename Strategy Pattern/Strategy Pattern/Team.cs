using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategy_Pattern
{
    internal class Team
    {
        public ITeambeheviour team { get; set; }
        public Team(ITeambeheviour team)
        {
            this.team = team;
        }

        public void Play()
        {
            team.Play();
        }
    }
}
