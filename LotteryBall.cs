using System;

namespace Laba5
{
    class LotteryBall
    {
        private int _maxNumber;
        private static Random _random = new Random();

        public LotteryBall(int maxNumber = 60)
        {
            this._maxNumber = maxNumber;
        }

        public int Draw()
        {
            return _random.Next(1, this._maxNumber + 1);
        }
    }
}