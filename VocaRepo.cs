using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memrise_net5
{
    internal class VocaRepo
    {
        public List<VocaDetail> list = new List<VocaDetail>();
        public int NumOfVoca;
        public void getNumOfVoca()
        {
            int count = 0;
            foreach (var i in list)
            {
                count++;
            }
            NumOfVoca = count;
        }
        public void DisplayVoca()
        {
            Console.Clear();
            foreach (var i in list)
            {
                i.ShowDetail();
            }
        }
    }
}
