namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using Coreficent.Controller;

    public class EyeRightSliderControl : MonoBehaviour
    {
        //private EyeController eyecontroller;
        public Quaternion currentRotation;
        Quaternion finalBodyRotation;
        Quaternion identityRotation;


        private GameObject eyeRight;

        public GameObject Minion;
        //private GameObject eyeLeft;
        //private GameObject body;

        //Euler Angle
        public Slider qxSlider;
        public Slider qySlider;
        public Slider qzSlider;
        public Slider qwSlider;

        public Slider xSlider;
        public Slider ySlider;
        public Slider zSlider;


        // Start is called before the first frame update
        void Start()
        {
            identityRotation = Minion.transform.rotation;

            eyeRight = GameObject.Find("EyeRight");
            //eyeLeft = GameObject.Find("EyeLeft");
            //body = GameObject.Find("EyeLeft");


        }


        void Update()
        {

            //qxSlider.value = currentRotation[1];

            //Debug.Log(eyeRight.transform.eulerAngles.y);
            //Debug.Log(eyeRight.transform.eulerAngles.x);
            //Debug.Log(eyeRight.transform.eulerAngles.z);

            // Euler Angle
            xSlider.value = eyeRight.transform.rotation.eulerAngles.x;
            ySlider.value = eyeRight.transform.rotation.eulerAngles.y;
            zSlider.value = eyeRight.transform.rotation.eulerAngles.z;

            // = current_eyeRightX;
            // = current_eyeRightY;
            // = current_eyeRightZ;

            finalBodyRotation = identityRotation * Minion.transform.localRotation;
            currentRotation = finalBodyRotation * eyeRight.transform.localRotation;

            qxSlider.value = currentRotation.x;
            qySlider.value = currentRotation.y;
            qzSlider.value = currentRotation.z;
            qwSlider.value = currentRotation.w;


        }

    }
}
