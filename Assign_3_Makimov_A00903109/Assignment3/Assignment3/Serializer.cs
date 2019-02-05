using System.IO;
using System.Xml.Serialization;

namespace Assignment3
{
    public class Serializer
    {
        public void SerializeXml(Manager employee, bool? isChecked)
        {
            using (FileStream fs = new FileStream("Employee.xml", FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Manager));
                xs.Serialize(fs, employee);
            }
            if (isChecked == true)
            {
                System.Diagnostics.Process.Start("iexplore.exe", Path.GetFullPath("Employee.xml"));
            }
        }

        public Manager Deserialize()
        {
            using (FileStream fs = new FileStream("Employee.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Manager));
                var newEmployee = (Manager)xs.Deserialize(fs);
                return newEmployee;
            }
        }
    }
}
