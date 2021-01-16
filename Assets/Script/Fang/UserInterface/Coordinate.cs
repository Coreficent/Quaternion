namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Coordinate : MonoBehaviour
    {

        private EyeValueDisplayer sliderControl;
        public Transform ball;


        // Start is called before the first frame update
        void Start()
        {
            sliderControl = FindObjectOfType<EyeValueDisplayer>();

        }

        // Update is called once per frame
        void Update()
        {
            


            //ball.localRotation = sliderControl.QuaternionFinal;


        }
    }
}
