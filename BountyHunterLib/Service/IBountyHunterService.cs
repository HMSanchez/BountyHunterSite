using BountyHunterLib.Model;
using HunterDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BountyHunterLib.Service
{
   public interface IBountyHunterService
    {
        HunterListModel GetAllHunters();
        HunterModel GetHunterById(int id);
        void DeleteHunterById(int id);
       void AddNewHunter(HunterModel hm);
       void UpdateHunter(HunterModel hm);

    }
}
