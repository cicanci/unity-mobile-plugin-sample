using UnityEngine;
using UnityEngine.UI;

namespace Cicanci.NativeTest
{
    public class NativeTestComponent : MonoBehaviour
    {
        [SerializeField]
        private Text _messageText = null;

        [SerializeField]
        private Text _counterText = null;

        private NativeTest _nativeTest;
        private string _message;
        private int _counter;

        private void Start()
        {
            _nativeTest = new NativeTest();
            _message = _nativeTest.GetMessage();
            _counter = 0;

            _messageText.text = _message;
            _counterText.text = $"{_counter}";
        }

        public void ResetCounterOnClick()
        {
            _nativeTest.SetCounter(_counter);
            _counterText.text = $"{_counter}";
        }

        public void UpdateCounterOnClick()
        {
            _counterText.text = $"{ _nativeTest.GetCounter()}";
        }

        public void ResetMessageOnClick()
        {
            _message = _nativeTest.GetMessage();
            _nativeTest.SetMessage(_message);
            _messageText.text = _message;
        }

        public void UpdateMessageOnClick()
        {
            _messageText.text = _nativeTest.GetMessage();
        }
    }
}