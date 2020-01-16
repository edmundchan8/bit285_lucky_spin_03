using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class TextTransformService
    {
        public string numberToText(int num) 
        {
            string output;
            switch (num)
            {
                case 1:
                    output = "One";
                    break;
                case 2:
                    output = "Two";
                    break;
                case 3:
                    output = "Three";
                    break;
                case 4:
                    output = "Four";
                    break;
                case 5:
                    output = "Five";
                    break;
                case 6:
                    output = "Six";
                    break;
                case 7:
                    output = "Seven";
                case 8:
                    output = "Eight";
                    break;
                case 9:
                    output = "Nine";
                    break;
                default:
                    output = "Number";
                    break;
            }
            return output;
        }
    }
}
