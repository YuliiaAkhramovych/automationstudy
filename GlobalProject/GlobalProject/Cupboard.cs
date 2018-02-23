using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalProject
{
    class Cupboard
    {
        public string WhatCupboard { get; set; }

        List<string> clothes = new List<string>() { "jeans", "shirt", "blouse", "skirt", "dress" };

        public Clothes Pull(string wear)
        {

            string selectedWear = "dress";
            bool isPresent = clothes.Contains(wear);

            if (isPresent)
            {
                return new Clothes(wear);
            }

            else
            {

                throw new Exception("8:45 - Kate selecting other wear");
            }
        }
    }
}
