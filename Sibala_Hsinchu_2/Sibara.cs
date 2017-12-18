using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

namespace Sibala_Hsinchu_2
{
    public class Sibara : ISibara
    {
        private List<int> _nums;

        public Sibara(int n1, int n2, int n3, int n4)
        {
            _nums = new List<int> {n1, n2, n3, n4}.OrderByDescending(x=>x).ToList();
            Compute();
        }

        public int Points { get; protected set; }
        public int MaxPoint { get; protected set; }

        public SibaraStatus.DiceTypeEnum DiceType { get; protected set; }

        public string Output { get; protected set; }

        protected  virtual void Compute()
        {
            var distinctCount = _nums.Distinct().Count();

            if (distinctCount == 1)
            {
                this.Points = _nums.Sum()/2;
                this.DiceType = SibaraStatus.DiceTypeEnum.SameColor;
                this.MaxPoint = _nums.First();
            }else if (distinctCount == 4)
            {
                Points = 0;
                DiceType = SibaraStatus.DiceTypeEnum.NoPoint;
                this.MaxPoint = _nums.First();
            }
            else if (distinctCount == 2)
            {
                var count = _nums.GroupBy(item => item).Select(item => item.Count()).Max();
                if (count == 3)
                {
                    Points = 0;
                    DiceType = SibaraStatus.DiceTypeEnum.NoPoint;
                }
                else
                {
                    Points = _nums.Take(2).Sum();
                    DiceType = SibaraStatus.DiceTypeEnum.NormalPoint;
                }

                this.MaxPoint = _nums.Max();

            }
            else
            {
                Points = _nums.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
                DiceType = SibaraStatus.DiceTypeEnum.NormalPoint;
                this.MaxPoint = _nums.GroupBy(x => x).Where(x => x.Count() == 1).Max(x => x.Key);

                
            }

            SetSibaraResult();
        }

        private void SetSibaraResult()
        {
            if (DiceType == SibaraStatus.DiceTypeEnum.SameColor)
                this.Output = "same color";
            else if (DiceType == SibaraStatus.DiceTypeEnum.NoPoint)
                this.Output = "no point";
            else if (DiceType == SibaraStatus.DiceTypeEnum.NormalPoint)
            {
                if (Points == 12)
                    this.Output = "sibala";
                else if(Points == 3)
                {
                    this.Output = "BG";
                }
                else
                    this.Output = $"{Points} point";
            }
        }

    }
}