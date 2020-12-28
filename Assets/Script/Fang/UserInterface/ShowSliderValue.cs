namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class ShowSliderValue : MonoBehaviour
    {
        Text CoordinateText;

        private Slider quaternion;

        private InputField q_InputField;

        void Start()
        {
            CoordinateText = GetComponent<Text>();

            quaternion = gameObject.GetComponent<Slider>();
            q_InputField = gameObject.GetComponent<InputField>();
        }


        public void textUpdate(float value)
        {
            CoordinateText.text = value.ToString();
        }


        public void UpdateValueFromFloat(float value)
        {
            Debug.Log("float value changed: " + value);
            if (quaternion) { quaternion.value = value; }
            if (q_InputField) { q_InputField.text = value.ToString(); }

        }

        // ref https://forum.unity.com/threads/problems-linking-a-slider-and-an-input-field.279083/
    }
}