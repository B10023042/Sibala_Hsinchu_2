﻿using System.Linq;

namespace Sibala_Hsinchu_2
{
    public class NoPointHandler : IDiceHandler
    {
        private Sibara _sibara;

        public NoPointHandler(Sibara sibara)
        {
            _sibara = sibara;
        }

        public void SetResult()
        {
            _sibara.Points = 0;
            _sibara.Status = SibaraStatus.StatusEnum.NoPoint;
            _sibara.MaxPoint = _sibara._nums.First();
            _sibara.Output = "no points";
        }
    }
}