namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Coreficent.Controller;

    public class Coordinate : MonoBehaviour
    {
        public EyeController EyeController;
        //private EyeValueDisplayer sliderControl;
        //private Transform eyeSimulate;


        // Start is called before the first frame update
        void Start()
        {
            //sliderControl = FindObjectOfType<EyeValueDisplayer>();

        }

        // Update is called once per frame
        void Update()
        {

            //eyeSimulate.localRotation = sliderControl.EyeController.QuaternionFinal;
            transform.localRotation = EyeController.QuaternionFinal;


        }
    }
}
