namespace Fang.UserInterface
{
    using Coreficent.Utility;
    using UnityEngine;
    using UnityEngine.UI;

    public class ShowSliderValue : MonoBehaviour
    {
        Text CoordinateText;

        private Slider _quaternionSlider;
        private InputField _inputField;

        protected void Start()
        {
            SanityCheck.Check(this, CoordinateText);

            CoordinateText = GetComponent<Text>();

            _quaternionSlider = gameObject.GetComponent<Slider>();
            _inputField = gameObject.GetComponent<InputField>();

        }

        public void TextUpdate(float value)
        {

            CoordinateText.text = value.ToString();
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
