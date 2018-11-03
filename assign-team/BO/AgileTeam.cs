using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_team.BO
{
    class AgileTeam
    {
        public List<Developper> TeamDeveloper { get; set; }
        public Developper SM { get; set; }
        public Developper TL { get; set; }
    }
}
