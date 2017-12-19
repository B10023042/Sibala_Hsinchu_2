using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class NormalPointHandler : IDiceHandler
    {
        private Sibara _sibara;

        public NormalPointHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetResult()
        {
            if (_sibara._nums.Distinct().Count() == 2)
            {
                _sibara.Points = _sibara._nums.Take(2).Sum();
                _sibara.DiceType = SibaraStatus.DiceTypeEnum.NormalPoint;
                _sibara.MaxPoint = _sibara._nums.Max();
            }
            else
            {
                _sibara.Points = _sibara._nums.GroupBy(x => x).Where(x => x.Count() == 1).Sum(x => x.Key);
                _sibara.DiceType = SibaraStatus.DiceTypeEnum.NormalPoint;
                _sibara.MaxPoint = _sibara._nums.GroupBy(x => x).Where(x => x.Count() == 1).Max(x => x.Key);
            }
            SetOutput();
        }

        private Dictionary<int, string> specialOutput = new Dictionary<int, string>
        {
            { 12,"sibala"},
            {3,"BG" }
        };

        private void SetOutput()
        {
            _sibara.Output = IsSpecialOutput(specialOutput)
                ? specialOutput[_sibara.Points]
                : $"{_sibara.Points} point";
        }

        private bool IsSpecialOutput(Dictionary<int, string> dictionary)
        {
            return specialOutput.ContainsKey(_sibara.Points);
        }
    }
}