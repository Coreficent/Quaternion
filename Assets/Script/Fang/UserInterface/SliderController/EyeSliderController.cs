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

        public Slider XSlider;
        public Slider YSlider;
        public Slider ZSlider;

        protected void Start()
        {
            DebugLogger.Log("eye controller is on", this);
            SanityCheck.Check(this, EyeController, QxSlider, QySlider, QzSlider, QwSlider, XSlider, YSlider, ZSlider);
        }


        protected void Update()
        {
            XSlider.value = EyeController.QuaternionFinal.eulerAngles.x;
            YSlider.value = EyeController.QuaternionFinal.eulerAngles.y;
            ZSlider.value = EyeController.QuaternionFinal.eulerAngles.z;

            QxSlider.value = EyeController.QuaternionFinal.x;
            QySlider.value = EyeController.QuaternionFinal.y;
            QzSlider.value = EyeController.QuaternionFinal.z;
            QwSlider.value = EyeController.QuaternionFinal.w;
        }
    }
}
