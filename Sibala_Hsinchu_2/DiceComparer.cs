using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sibala_Hsinchu_2
{
    class DiceComparer : IComparer<ISibara>
    {
        private Dictionary<int, int> sameColorCompareWeightLookup;

        public DiceComparer()
        {
            sameColorCompareWeightLookup = new Dictionary<int, int>()
            {
                {4,1},
                { 6,2},
                { 10,3},
                { 12,4},
                { 8,5},
                { 2,6}

            };
        }

        public int Compare(ISibara firstDice, ISibara secondDice)
        {

            if (IsSameDiceType(firstDice, secondDice))
            {
                var compareLookup = new Dictionary<SibaraStatus.DiceTypeEnum, Func<ISibara, ISibara, int>>
                {

                    {SibaraStatus.DiceTypeEnum.NoPoint,GetResultWhenNoPoint },
                    {SibaraStatus.DiceTypeEnum.SameColor,GetResultWhenSameColor },
                    {SibaraStatus.DiceTypeEnum.NormalPoint,GetResultWhenNormalPoint },
                };
                return compareLookup[firstDice.DiceType].Invoke(firstDice, secondDice);

            }


            return firstDice.DiceType - secondDice.DiceType;
        }

        private static bool IsSameDiceType(ISibara firstDice, ISibara secondDice)
        {
            return firstDice.DiceType == secondDice.DiceType;
        }

        private static int GetResultWhenNormalPoint(ISibara firstDice, ISibara secondDice)
        {
            return firstDice.MaxPoint - secondDice.MaxPoint;
        }

        private int GetResultWhenSameColor(ISibara firstDice, ISibara secondDice)
        {
            return sameColorCompareWeightLookup[firstDice.MaxPoint]
                   - sameColorCompareWeightLookup[secondDice.MaxPoint];
        }

        private static int GetResultWhenNoPoint(ISibara firstDice, ISibara secondDice)
        {
            return 0;
        }

    }
}
