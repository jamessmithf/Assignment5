using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class FoodProduct : Product
    {
        public int ExpiryTerm { get; set; }        
        public int Quantity { get; set; }          
        public string Unit { get; set; }
        public override string ShowInfo()
        {
            return $"{base.ShowInfo()}\nКількість: {Quantity} {Unit}\nТермін придатності: {ExpiryTerm} днів";
        }
    }

}
