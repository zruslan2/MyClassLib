using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    
    public class Tank
    {
        private string t_name;
        private Int16 ammunition;
        private Int16 armor;
        private Int16 maneuverability;

        public static Random rand = new Random();

        public Tank(string name)
        {
            t_name = name;
            ammunition = (Int16)rand.Next(0, 100);
            armor= (Int16)rand.Next(0, 100);
            maneuverability= (Int16)rand.Next(0, 100);
        }
        public string GetParam()
        {
            string str = string.Format("Боекомплект: {0}%\nУровень брони: {1}%\nУровень маневренности: {2}%", ammunition, armor, maneuverability);
            return str;
        }
        public string GetAmmunition()
        {
            string str = string.Format("Боекомплект: {0}%", ammunition);
            return str;
        }
        public string GetArmor()
        {
            string str = string.Format("Уровень брони: {0}%", armor);
            return str;
        }
        public string GetManeuverability()
        {
            string str = string.Format("Уровень маневренности: {0}%", maneuverability);
            return str;
        }
        public string GetName()
        {
            return this.t_name;
        }
        public static bool operator*(Tank t1,Tank t2)
        {
            short t1c = 0, t2c=0;
            if (t1.ammunition > t2.ammunition) t1c++;
            else t2c++;
            if (t1.armor > t2.armor) t1c++;
            else t2c++;
            if (t1.maneuverability > t2.maneuverability) t1c++;
            else t2c++;
            if (t1c > t2c) return true;
            else return false;
        }
    }
}
