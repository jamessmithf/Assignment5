using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Product
    {
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public string OriginCountry { get; set; }   
        public string Name { get; set; }            
        public DateTime PackagingDate { get; set; }
        public string Description { get; set; }
        public Color FrameColor { get; set; }
        public virtual string ShowInfo()
        {
            return $"Опис: {Description}\nЦіна: {Price}{Currency}\nКраїна: {OriginCountry}";
        }

    }
}
