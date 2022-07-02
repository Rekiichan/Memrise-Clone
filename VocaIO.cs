using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memrise_net5
{
    internal class VocaIO
    {
        public VocaIO(VocaRepo Repo) 
        {
            vocaRepo = Repo; 
        }

        VocaRepo vocaRepo = new VocaRepo();
        public void InputVoca()
        {
            Console.Clear();
            Console.Write("nhap so luong tu muon hoc: ");
            vocaRepo.NumOfVoca = int.Parse(Console.ReadLine());
            while (vocaRepo.NumOfVoca > 0)
            {
                VocaDetail temp = new VocaDetail();
                vocaRepo.list.Add(temp);
                vocaRepo.NumOfVoca--;
            }
            
        }
    }
}
