using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restro
{
    public class MenuItems
    {
        public string name;
        public string description;
        public double price
        {
            get{
                return _price;
            }
            set{
                if(value > 0 ){
                    _price = price;
                } else {
                    throw new ApplicationException("exception here");
                }
            }
        }
        private double _price;


    }
}
