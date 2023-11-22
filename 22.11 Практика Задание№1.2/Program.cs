using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _22._11_Практика_Задание_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1;
            name1 = Interaction.InputBox("Введите ваше имя",
                "Ввод имени");
            string name2;
            name2 = Interaction.InputBox("Введите вашу фамилию",
                "Ввод фамилии");
            string txt = "Имя: " + name1 + ", Фамилия: " + name2;
            MessageBox.Show(txt, "Итог.");

        }
    }
}
