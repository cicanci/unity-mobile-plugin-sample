#if UNITY_ANDROID
using UnityEngine;

namespace Cicanci.NativeTest
{
    public class NativeTestAndroid : INativeTest
    {
        private readonly AndroidJavaObject _nativeTestClass;

        public NativeTestAndroid()
        {
            _nativeTestClass = new AndroidJavaObject("com.cicanci.unity.NativeTest");
        }

        public int GetCounter()
        {
            return _nativeTestClass.Call<int>("getCounter");
        }

        public string GetMessage()
        {
            return _nativeTestClass.Call<string>("getMessage");
        }

        public void SetCounter(int counter)
        {
            _nativeTestClass.Call("setCounter", counter);
        }

        public void SetMessage(string message)
        {
            _nativeTestClass.Call("setMessage", message);
        }
    }
}
#endif
