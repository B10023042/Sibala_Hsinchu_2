using System.Collections.Generic;
using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class Sibara : ISibara
    {
        public List<int> _nums;

        public Sibara(int n1, int n2, int n3, int n4)
        {
            _nums = new List<int> { n1, n2, n3, n4 }.OrderByDescending(x => x).ToList();
            Compute();
        }

        public int Points { get; set; }
        public int MaxPoint { get; set; }

        public SibaraStatus.DiceTypeEnum DiceType { get; set; }

        public string Output { get; set; }

        protected virtual void Compute()
        {
            GetHandler().SetResult();
        }

        private IDiceHandler GetHandler()
        {
            var handlerLookup = new Dictionary<int, IDiceHandler>
            {
                {4, new SameColorHandler(this)},
                {3, new NoPointHandler(this)},
                {2, new NormalPointHandler(this)},
                {1, new NoPointHandler(this)}
            };
            return handlerLookup[_nums.GroupBy(x => x).Max(x => x.Count())];
        }
    }
}