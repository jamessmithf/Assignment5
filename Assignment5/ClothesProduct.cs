using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class ClothesProduct : Product
    {
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nКолір: {Color}\nБренд: {Brand}\nРозмір: {Size}";
        }
    }
}
