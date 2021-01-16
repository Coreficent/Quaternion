namespace Fang.UserInterface
{
    using Coreficent.Utility;
    using UnityEngine;
    using UnityEngine.UI;

    public class SliderValueDisplayer : MonoBehaviour
    {
        private Text _coordinateText;
        private Slider _quaternionSlider;
        private InputField _inputField;

        protected void Start()
        {
            _coordinateText = GetComponent<Text>();
            _quaternionSlider = GetComponent<Slider>();
            _inputField = GetComponent<InputField>();

            SanityCheck.Check(this, _coordinateText, _quaternionSlider, _inputField);
        }

        public void UpdateText(float value)
        {
            _coordinateText.text = value.ToString();
        }

        public void UpdateValueFromFloat(float value)
        {
            Debug.Log("float value changed: " + value);
            if (_quaternionSlider) { _quaternionSlider.value = value; }
            if (_inputField) { _inputField.text = value.ToString(); }

        }

        // ref https://forum.unity.com/threads/problems-linking-a-slider-and-an-input-field.279083/
    }
}
