namespace Fang.UserInterface
{
    using Coreficent.Controller;
    using UnityEngine;
    using UnityEngine.UI;

    public class BodyValueDisplayer : MonoBehaviour
    {
        [SerializeField] private BodyController _body;

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

        }


        protected void Update()
        {
            XSlider.value = _body.transform.rotation.eulerAngles.x;
            YSlider.value = _body.transform.rotation.eulerAngles.y;
            ZSlider.value = _body.transform.rotation.eulerAngles.z;

            XText.text = _body.transform.rotation.eulerAngles.x.ToString();
            YText.text = _body.transform.rotation.eulerAngles.y.ToString();
            ZText.text = _body.transform.rotation.eulerAngles.z.ToString();

            QxSlider.value = _body.transform.rotation.x;
            QySlider.value = _body.transform.rotation.y;
            QzSlider.value = _body.transform.rotation.z;
            QwSlider.value = _body.transform.rotation.w;

            QxText.text = _body.transform.rotation.x.ToString();
            QyText.text = _body.transform.rotation.y.ToString();
            QzText.text = _body.transform.rotation.z.ToString();
            QwText.text = _body.transform.rotation.w.ToString();
        }
    }
}
