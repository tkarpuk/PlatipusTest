using System;

namespace Platipus.BLL.Operations
{
    public class NumberReverse : IReverse
    {
        readonly int _data;
        public NumberReverse(int data) => _data = data;

        public object GetReverse()
        {
            return new { result = Math.Sqrt(_data) };
        }
    }
}
