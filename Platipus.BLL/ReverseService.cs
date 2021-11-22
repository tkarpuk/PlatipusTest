using Platipus.BLL.Operations;

namespace Platipus.BLL
{
    public class ReverseService
    {
        private IReverse _reverser;

        private void PrepareService(string data)
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

        public object GetResult(string data)
        {
            PrepareService(data);
            return _reverser.GetReverse();
        }
    }
}
