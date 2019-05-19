using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SaintNicholas.Orders
{
    public class OrderReader
    {
        public List<string> ReadOrdersFromFile()
        {
            var lines = File.ReadAllLines(@"C:\Users\Oksana\Desktop\Orders.txt");

            return lines.ToList();
        }
    }
}
