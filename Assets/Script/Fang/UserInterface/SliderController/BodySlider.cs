namespace Fang.UserInterface
{
    using UnityEngine;
    using UnityEngine.UI;

    public class BodySlider : MonoBehaviour
    {
        [SerializeField] private GameObject _target;
        //private EyeController eyecontroller;


        //Euler Angle
        public Slider qxSlider;
        public Slider qySlider;
        public Slider qzSlider;
        public Slider qwSlider;

        public Slider xSlider;
        public Slider ySlider;
        public Slider zSlider;

        public Quaternion QuaternionCurrent
        {
            get => transform.rotation;
        }

        public Quaternion QuaternionTransform
        {
            get => Quaternion.FromToRotation(transform.InverseTransformDirection(transform.forward), transform.InverseTransformDirection(_target.transform.position - transform.position));
        }

        public Quaternion QuaternionFinal
        {
            get => QuaternionCurrent * QuaternionTransform;
        }

        void Start()
        {
            //eyecontroller = FindObjectOfType<EyeController>();
        }


        void Update()
        {

            //qxSlider.value = currentRotation[1];

            //Debug.Log(eyeRight.transform.eulerAngles.y);
            //Debug.Log(eyeRight.transform.eulerAngles.x);
            //Debug.Log(eyeRight.transform.eulerAngles.z);

            // Euler Angle
            xSlider.value = transform.rotation.eulerAngles.x;
            ySlider.value = transform.rotation.eulerAngles.y;
            zSlider.value = transform.rotation.eulerAngles.z;

            // = current_eyeRightX;
            // = current_eyeRightY;
            // = current_eyeRightZ;

            //finalBodyRotation = identityRotation * Minion.transform.localRotation;
            //currentRotation = finalBodyRotation * eyeRight.transform.localRotation;

            qxSlider.value = QuaternionFinal.x;
            qySlider.value = QuaternionFinal.y;
            qzSlider.value = QuaternionFinal.z;
            qwSlider.value = QuaternionFinal.w;


        }

    }
}
