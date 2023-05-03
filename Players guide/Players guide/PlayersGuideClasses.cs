using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersGuideClasses
{
    class VinFletchersArrows
    {
        Arrowhead ArrowHeadType = Arrowhead.steel;
        Fletching FletchingType = Fletching.plastic;
        decimal ShaftLength = 60;

        decimal PriceGoldPerCentimmeter = 0.05M;

        public VinFletchersArrows()
        { }

        public VinFletchersArrows(Arrowhead ArrowHeadType, Fletching FletchingType, decimal ShaftLength)
        {
            this.ArrowHeadType = ArrowHeadType;
            this.FletchingType = FletchingType;
            this.ShaftLength = ShaftLength;
        }
        public decimal GetCost() => (decimal)ArrowHeadType + (decimal)FletchingType + ShaftLength * PriceGoldPerCentimmeter;


    }
}
