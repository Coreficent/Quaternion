namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Coordinate : MonoBehaviour
    {

        private EyeSliderController sliderControl;
        public Transform ball;


        // Start is called before the first frame update
        void Start()
        {
            sliderControl = FindObjectOfType<EyeSliderController>();

        }

        // Update is called once per frame
        void Update()
        {
            


            //ball.localRotation = sliderControl.QuaternionFinal;


        }
    }
}
