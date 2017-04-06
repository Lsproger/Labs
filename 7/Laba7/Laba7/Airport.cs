using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Laba7
{
    internal class Airport
    {
        internal Airport() { }
        internal static int number = 0;
        internal static int NumberOfPlanes()
        {
            string Text = new DirectoryInfo(
                @"D:\Учёба\ООП\2 семестр\Labs\7\Laba7\Laba7\Airplanes"
                ).GetFiles().Length.ToString();
            return Convert.ToInt32(Text);
        }
        internal static void LoadAirport(FAirport form)
        {
            if (Airport.NumberOfPlanes() != 0)
            {
                string[] file_list = Directory.GetFiles(@"D:\Учёба\ООП\2 семестр\Labs\7\Laba7\Laba7\Airplanes", "*.xml");
                XmlSerializer formatter = new XmlSerializer(typeof(Airplane));
                foreach (var file in file_list )
                {
                    using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
                    {
                        Airplane newAirplane = (Airplane)formatter.Deserialize(fs);
                        form.airplanes.Add(newAirplane);
                    }
                }
            }
        }
        internal static Airplane GetAirplane(int id)
        {
            string[] planes;
            Airplane newAirplane;
            planes = Directory.GetFiles(@"D:\Учёба\ООП\2 семестр\Labs\7\Laba7\Laba7\Airplanes");
            XmlSerializer formatter = new XmlSerializer(typeof(Airplane));
            
            using (FileStream fs = new FileStream(planes[id], FileMode.OpenOrCreate))
            { 
                newAirplane = (Airplane)formatter.Deserialize(fs);
            }
            return newAirplane;
        }
    }
}
