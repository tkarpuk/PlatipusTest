using Platipus.BLL.Operations;

namespace Platipus.BLL
{
    public class ReverseService
    {
        private readonly IReverse _reverser;

        public ReverseService(string data)
        {
            int dataAsInt;
            if (int.TryParse(data, out dataAsInt))
            {
                _reverser = new NumberReverse(dataAsInt);
            }
            else
            {
                _reverser = new StringReverse(data);
            }
        }

        public object GetResult()
        {
            return _reverser.GetReverse();
        }
    }
}
