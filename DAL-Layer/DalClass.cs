using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY_Layer;
using System.IO;
namespace DAL_Layer
{
    public class DalClass
    {

        public bool save(String speed)
        {
            try
            {
                StreamWriter w = new StreamWriter("E:\\Speed2.txt");
                w.WriteLine(speed);
                w.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Car getData()
        {
            Car c = new Car();
            try
            {
                StreamReader read = new StreamReader("E:\\Speed2.txt");
                c.speed = Convert.ToInt32(read.ReadLine());
                read.Close();
                return c;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}
