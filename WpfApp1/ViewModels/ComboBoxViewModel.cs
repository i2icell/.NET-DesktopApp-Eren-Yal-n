using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModels
{
    public class ComboBoxViewModel
    {
        public List<string> days { get; set; }

        public List<string> months { get; set; }

        public List<string> years { get; set; }

        public ComboBoxViewModel()
        {
            days = new List<string>();

            for (int i = 1; i < 32; i++)
            {
                if (i < 10)
                {
                    days.Add("0" + i.ToString());
                }
                else
                {
                    days.Add(i.ToString());
                }

            } 


            months = new List<string>
            {
                "Ocak",
                "Şubat",
                "Mart",
                "Nisan",
                "Mayıs",
                "Haziran",
                "Temmuz",
                "Ağustos",
                "Eylül",
                "Ekim",
                "Kasım",
                "Aralık"
            };

            years = new List<string>();

            for (int i = 1869; i < 2007; i++)
            {
                years.Add(i.ToString());
            }



        }
    }
}
