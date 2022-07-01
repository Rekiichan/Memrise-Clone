﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memrise_net5
{
    internal class VocaLearning
    {
        public VocaLearning(VocaRepo repo)
        {
            vocaRepo = repo;
        }
        VocaRepo vocaRepo = new VocaRepo();
        public void ShowVoca()
        {
            VocaRepo tempVoca = new VocaRepo();
            tempVoca = vocaRepo;
            Random random = new Random();
            tempVoca.getNumOfVoca();
            while (tempVoca.NumOfVoca > 0)
            {
                Console.Clear();
                var r = random.Next(0, tempVoca.NumOfVoca);
                tempVoca.list[r].ShowDetail();
                tempVoca.list.RemoveAt(r);
                tempVoca.NumOfVoca--;
                Console.WriteLine("press Enter to continue!");
                Console.ReadKey();
            }
        }
        public void ProcessVoca()
        {
            VocaRepo tempVoca = new VocaRepo();
            tempVoca = vocaRepo;
            tempVoca.getNumOfVoca();
            Random random = new Random();
            int[] EngChecked = new int[vocaRepo.NumOfVoca];
            int[] VietChecked = new int[vocaRepo.NumOfVoca];
            while (tempVoca.NumOfVoca > 0)
            {
                Console.Clear();
                int r = random.Next(0, tempVoca.NumOfVoca);
                bool valCheckEng = checkEng(r);
                if (valCheckEng && (EngChecked[r] < 3))
                {
                    Console.WriteLine();
                    Console.WriteLine("DUNG!");
                    Console.WriteLine();
                    tempVoca.list[r].ShowDetail();
                    EngChecked[r]++;
                    Console.WriteLine();
                    Console.WriteLine("--> Press Enter to continue!");
                    Console.ReadKey();
                }
                else if (!valCheckEng)
                {
                    Console.WriteLine();
                    Console.WriteLine("SAI!!!!");
                    Console.WriteLine($"tu do la: {tempVoca.list[r].Eng}");
                    Console.WriteLine();
                    Console.WriteLine("--> Press Enter to continue!");
                    Console.ReadKey();
                }
                Console.Clear();
                bool valCheckViet = checkViet(r);
                if (valCheckViet && (VietChecked[r] < 3))
                {
                    Console.WriteLine();
                    Console.WriteLine("DUNG!");
                    Console.WriteLine();
                    tempVoca.list[r].ShowDetail();
                    VietChecked[r]++;
                    Console.WriteLine();
                    Console.WriteLine("--> Press Enter to continue!");
                    Console.ReadKey();
                }
                else if (!valCheckViet)
                {
                    Console.WriteLine();
                    Console.WriteLine("SAI!!!!");
                    Console.WriteLine($"tu do la: {tempVoca.list[r].Viet}");
                    Console.WriteLine();
                    Console.WriteLine("Press Enter to continue!");
                    Console.ReadKey();
                }
                if ((EngChecked[r] == 3)&&(VietChecked[r] == 3))
                {
                    tempVoca.list.RemoveAt(r);
                    tempVoca.NumOfVoca--;
                }
            }
            tempVoca.DisplayVoca();
        }
        public bool checkEng(int ID)
        {  
            Console.Write($"nhap nghia tieng anh cua {vocaRepo.list[ID].Viet}  -->    ");
            string check = Console.ReadLine();
            if (check == vocaRepo.list[ID].Eng)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool checkViet(int ID)
        {
            Console.Write($"nhap nghia tieng viet cua {vocaRepo.list[ID].Eng}  -->    ");
            string check = Console.ReadLine();
            if (check == vocaRepo.list[ID].Viet)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
