using UnityEngine;

namespace Cicanci.NativeTest
{
    public class NativeTest
    {
        private readonly INativeTest _nativeTest;

        public NativeTest()
        {
#if UNITY_EDITOR
            _nativeTest = new NativeTestDummy();
#elif UNITY_ANDROID
            _nativeTest = new NativeTestAndroid();
#endif
        }

        public int GetCounter()
        {
            return _nativeTest.GetCounter();
        }

        public string GetMessage()
        {
            return _nativeTest.GetMessage();
        }

        public void SetCounter(int counter)
        {
            _nativeTest.SetCounter(counter);
        }

        public void SetMessage(string message)
        {
            _nativeTest.SetMessage(message);
        }
    }
}