namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;


    public class q3PanelControl : MonoBehaviour
    {
        public GameObject rightEyePanel;
        public GameObject leftEyePanel;

        public GameObject rightCircle;
        public GameObject leftCircle;
        
        //public GameObject bodyPanel;

        public Button rightEyeButton;
        public Button leftEyeButton;
        //public Button bodyButton;


        public GameObject q3rightEyePanel;
        public GameObject q3leftEyePanel;
        //public GameObject q3bodyPanel;

        public Button q3rightEyeButton;
        public Button q3leftEyeButton;
        public Button bothEyeButton;

        private bool q3rightOn;
        private bool q3leftOn;
        //private bool q3bodyOn;

        public GameObject leftArrowSet;
        public GameObject rightArrowSet;

        public AudioSource audioSource;
        public AudioClip impact;

        void Start()
        {
            leftEyePanel.SetActive(false);
            //bodyPanel.SetActive(false);
            rightEyeButton.onClick.AddListener(ShowRightEye);
            leftEyeButton.onClick.AddListener(ShowLeftEye);
            //bodyButton.onClick.AddListener(ShowBody);

            leftArrowSet.SetActive(true);
            rightArrowSet.SetActive(true);

            //q3rightEyePanel.SetActive(false);
            //q3leftEyePanel.SetActive(true);
            //q3bodyPanel.SetActive(false);
            q3rightEyeButton.onClick.AddListener(Showq3RightEye);
            q3leftEyeButton.onClick.AddListener(Showq3LeftEye);
            bothEyeButton.onClick.AddListener(ShowqBothCircle);
        }

        public void ShowRightEye()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            rightEyePanel.SetActive(true);
            q3rightEyePanel.SetActive(true);

            rightCircle.SetActive(true);
            leftCircle.SetActive(false);

            leftEyePanel.SetActive(false);
            q3leftEyePanel.SetActive(false);


            rightArrowSet.SetActive(true);
            leftArrowSet.SetActive(false);
            
        }

        public void ShowLeftEye()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            leftEyePanel.SetActive(true);
            q3leftEyePanel.SetActive(true);
            leftCircle.SetActive(true);
            rightCircle.SetActive(false);
            rightEyePanel.SetActive(false);
            q3rightEyePanel.SetActive(false);

            leftArrowSet.SetActive(true);
            rightArrowSet.SetActive(false);
        }

        //public void ShowBody()
        //{
        //    //bodyPanel.SetActive(true);
        //    leftEyePanel.SetActive(false);
        //    rightEyePanel.SetActive(false);
        //}

        public void Showq3RightEye()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            q3rightOn =!q3rightOn;

            q3rightEyePanel.SetActive(!q3rightOn);
            q3leftEyePanel.SetActive(false);
            //q3bodyPanel.SetActive(false);
        }

        public void Showq3LeftEye()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            q3leftOn = !q3leftOn;
            q3rightEyePanel.SetActive(false);
            q3leftEyePanel.SetActive(!q3leftOn);
            //q3bodyPanel.SetActive(false);
        }

        //public void Showq3Body()
        //{
        //    //q3bodyOn = !q3bodyOn;

        //    q3rightEyePanel.SetActive(false);
        //    q3leftEyePanel.SetActive(false);
        //    //q3bodyPanel.SetActive(q3bodyOn);
        //}

        public void ShowqBothCircle()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            leftArrowSet.SetActive(true);
            rightArrowSet.SetActive(true);
            leftCircle.SetActive(true);
            rightCircle.SetActive(true);
        }
    }
}