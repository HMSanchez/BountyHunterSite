using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BountyHunterLib.Model
{
   public class HunterListModel
    {
        public List<HunterModel> Hunters { get; set; }

        public HunterListModel()
        {
            Hunters = new List<HunterModel>();
        }
    }
}
