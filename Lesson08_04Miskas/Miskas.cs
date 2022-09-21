using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_04Miskas
{
    internal class Miskas
    {
        public List<string> MedziuList = new List<string>();

        public void PasodintiMedi()
        {
            int noTree;
            if (MedziuList != null)
            {            
                noTree = MedziuList.Count + 1;
                MedziuList.Add($"Medis_{noTree}");
            }
            else
            {
                noTree = 1;
                MedziuList.Add($"Medis_{noTree}");
            }
            
        }
    }
}
