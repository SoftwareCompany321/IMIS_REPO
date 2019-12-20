using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IMIS_CORE.EnumHelper
{
    public class EnumHelper
    {
        public enum PropertyClassfication
        {
            [Description("Building, Structures and Permanent type of Structures")]
            BSAPTOS = 1,
            [Description("Computer,Stastical tools, Furnitures, Fixture and Office Appliances.")]
            CSTFFAOA = 2,
            [Description("Automobiles, Bus and Minibuses")]
            ABAM = 3,
            [Description("Appliances about constructions")]
            AAC = 4,
            [Description("Invisible Assets")]
            IA = 5
        }
    }
}
