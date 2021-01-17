namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class ButtonControll : MonoBehaviour
    {
        private CameraControl cameraControlScript;

        public Button eyeViewButton;
        public Button mathViewButton;

        public AudioSource audioSource;
        public AudioClip impact;

        void Start()
        {
            cameraControlScript = FindObjectOfType<CameraControl>();

            eyeViewButton.onClick.AddListener(EyeView);
            mathViewButton.onClick.AddListener(MathView);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void EyeView()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            cameraControlScript.bubbleCamera.SetActive(false);
            cameraControlScript.VisualCamera.SetActive(true);
        }

        public void MathView()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            cameraControlScript.VisualCamera.SetActive(false);
            cameraControlScript.bubbleCamera.SetActive(true);
        }
    }
}
