
namespace Cicanci.NativeTest
{
    public class NativeTestDummy : INativeTest
    {
        private int _counter;
        private string _message = "Hello from Dummy";

        public int GetCounter()
        {
            _counter++;
            return _counter;
        }

        public string GetMessage()
        {
            return _message;
        }

        public void SetCounter(int counter)
        {
            _counter = counter;
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
    }
}