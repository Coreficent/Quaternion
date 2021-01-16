namespace Fang.UserInterface
{
    using UnityEngine;
    using UnityEngine.UI;
    using Coreficent.Controller;
    using Coreficent.Utility;

    public class EyeSliderController : MonoBehaviour
    {
        public EyeController EyeController;

        public Slider QxSlider;
        public Slider QySlider;
        public Slider QzSlider;
        public Slider QwSlider;

        public Text QxText;
        public Text QyText;
        public Text QzText;
        public Text QwText;

        public Slider XSlider;
        public Slider YSlider;
        public Slider ZSlider;

        public Text XText;
        public Text YText;
        public Text ZText;

        protected void Start()
        {
            DebugLogger.Log("eye controller is on", this);
            SanityCheck.Check(this, EyeController, QxSlider, QySlider, QzSlider, QwSlider, XSlider, YSlider, ZSlider, QxText, QyText, QzText, QwText, XText, YText, ZText);
        }


        protected void Update()
        {
            XSlider.value = EyeController.QuaternionFinal.eulerAngles.x;
            YSlider.value = EyeController.QuaternionFinal.eulerAngles.y;
            ZSlider.value = EyeController.QuaternionFinal.eulerAngles.z;

            XText.text = EyeController.QuaternionFinal.eulerAngles.x.ToString();
            YText.text = EyeController.QuaternionFinal.eulerAngles.y.ToString();
            ZText.text = EyeController.QuaternionFinal.eulerAngles.z.ToString();

            QxSlider.value = EyeController.QuaternionFinal.x;
            QySlider.value = EyeController.QuaternionFinal.y;
            QzSlider.value = EyeController.QuaternionFinal.z;
            QwSlider.value = EyeController.QuaternionFinal.w;

            QxText.text = EyeController.QuaternionFinal.x.ToString();
            QyText.text = EyeController.QuaternionFinal.y.ToString();
            QzText.text = EyeController.QuaternionFinal.z.ToString();
            QwText.text = EyeController.QuaternionFinal.w.ToString();
        }
    }
}
