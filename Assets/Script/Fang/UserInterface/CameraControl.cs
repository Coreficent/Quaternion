namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    public class CameraControl : MonoBehaviour
    {
        public GameObject VisualCamera;
        public GameObject bubbleCamera;

        void Start()
        {
            VisualCamera = GameObject.Find("Minion Camera");
            bubbleCamera = GameObject.Find("Inside Bubble Camera");

            VisualCamera.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {
            //Switch camera EyeballView  
            if (Input.GetKeyDown(KeyCode.M))
            {
                bubbleCamera.SetActive(false);
                VisualCamera.SetActive(true);
            }

            //Swith camera to MathView
            if (Input.GetKeyDown(KeyCode.B))
            {
                VisualCamera.SetActive(false);
                bubbleCamera.SetActive(true);
            }
        }
    }
}


