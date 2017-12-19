using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class SameColorHandler : IDiceHandler
    {
        private Sibara _sibara;

        public SameColorHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetResult()
        {
            _sibara.Points = 0;
            _sibara.DiceType = SibaraStatus.DiceTypeEnum.SameColor;
            _sibara.MaxPoint = _sibara._nums.First();
            _sibara.Output = "same color";
        }
    }
}