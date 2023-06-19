using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSACQIACTIVITYNDM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample list of medicines with their concentration and volume
            List<Medicine> medicines = new List<Medicine>()
        {
            new Medicine("Medicine A", 10, 100),
            new Medicine("Medicine B", 5, 200),
            new Medicine("Medicine C", 15, 50),
            new Medicine("Medicine D", 8, 150),
            new Medicine("Medicine E", 12, 80)
        };
            Console.WriteLine("************* BEFORE SORTING *************");
            foreach (Medicine medicine in medicines)
            {
                Console.WriteLine("\t" + medicine.Name + "\t" + medicine.Concentration + "\t" + medicine.Volume);
            }
            Console.WriteLine("\n");
            // Sort the medicines based on their volume in descending order
            SelectionSort(medicines);

            Console.WriteLine("************* AFTER SORTING *************");
            foreach (Medicine medicine in medicines)
            {
                Console.WriteLine("\t" + medicine.Name +"\t"+ medicine.Concentration +"\t"+ medicine.Volume);
            }
            Console.WriteLine("\nThis Scenario is Sorted using Selection Sort Technique\n");
        }

        static void SelectionSort(List<Medicine> medicines)
        {
            int n = medicines.Count;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (medicines[j].Volume > medicines[maxIndex].Volume)
                    {
                        maxIndex = j;
                    }
                }

                if (maxIndex != i)
                {
                    Swap(medicines, i, maxIndex);
                }
            }
        }

        static void Swap(List<Medicine> medicines, int i, int j)
        {
            Medicine temp = medicines[i];
            medicines[i] = medicines[j];
            medicines[j] = temp;
        }
    }

    class Medicine
    {
        public string Name { get; set; }
        public int Concentration { get; set; }
        public int Volume { get; set; }

        public Medicine(string name, int concentration, int volume)
        {
            Name = name;
            Concentration = concentration;
            Volume = volume;
        }
    }
}
