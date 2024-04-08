using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    internal class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //The saturation is used only in the Feed method, so in order to keep the value not accessible, then better to make it not as a property, but as a field.
        private int _saturation;

        public bool Feed(int countFood)
        {
            if (countFood > 50) 
            { 
                return false; 
            }

            if (_saturation >= 50)
            {
                return true;
            }
            _saturation += countFood;

            if (_saturation >= 50)
            {
                return true;
            }

            return false;
        }

    }
}
