using System;
using System.Linq;

namespace Platipus.BLL.Operations
{
    public class StringReverse : IReverse
    {
        readonly string _data;
        public StringReverse(string data) => _data = data;

        public object GetReverse()
        {
            return new { result = new String(_data.Reverse().ToArray()) };
        }
    }
}
