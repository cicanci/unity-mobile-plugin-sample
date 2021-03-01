
namespace Cicanci.NativeTest
{
    public interface INativeTest
    {
        string GetMessage();
        int GetCounter();
        void SetMessage(string message);
        void SetCounter(int counter);
    }
}