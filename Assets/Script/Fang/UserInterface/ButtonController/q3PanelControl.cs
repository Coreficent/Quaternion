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
        //public GameObject bodyPanel;

        public Button rightEyeButton;
        public Button leftEyeButton;
        //public Button bodyButton;


        public GameObject q3rightEyePanel;
        public GameObject q3leftEyePanel;
        //public GameObject q3bodyPanel;

        public Button q3rightEyeButton;
        public Button q3leftEyeButton;
        //public Button q3bodyButton;

        private bool q3rightOn;
        private bool q3leftOn;
        //private bool q3bodyOn;

        void Start()
        {
            leftEyePanel.SetActive(false);
            //bodyPanel.SetActive(false);
            rightEyeButton.onClick.AddListener(ShowRightEye);
            leftEyeButton.onClick.AddListener(ShowLeftEye);
            //bodyButton.onClick.AddListener(ShowBody);


            //q3rightEyePanel.SetActive(false);
            //q3leftEyePanel.SetActive(true);
            //q3bodyPanel.SetActive(false);
            q3rightEyeButton.onClick.AddListener(Showq3RightEye);
            q3leftEyeButton.onClick.AddListener(Showq3LeftEye);
            //q3bodyButton.onClick.AddListener(Showq3Body);
        }

        public void ShowRightEye()
        {
            rightEyePanel.SetActive(true);
            q3rightEyePanel.SetActive(true);
            leftEyePanel.SetActive(false);
            q3leftEyePanel.SetActive(false);
            //bodyPanel.SetActive(false);
        }

        public void ShowLeftEye()
        {
            leftEyePanel.SetActive(true);
            q3leftEyePanel.SetActive(true);
            rightEyePanel.SetActive(false);
            q3rightEyePanel.SetActive(false);
            //bodyPanel.SetActive(false);
        }

        //public void ShowBody()
        //{
        //    //bodyPanel.SetActive(true);
        //    leftEyePanel.SetActive(false);
        //    rightEyePanel.SetActive(false);
        //}

        public void Showq3RightEye()
        {
            q3rightOn =!q3rightOn;

            q3rightEyePanel.SetActive(!q3rightOn);
            q3leftEyePanel.SetActive(false);
            //q3bodyPanel.SetActive(false);
        }

        public void Showq3LeftEye()
        {
            q3leftOn = !q3leftOn;
            q3rightEyePanel.SetActive(false);
            q3leftEyePanel.SetActive(!q3leftOn);
            //q3bodyPanel.SetActive(false);
        }

        public void Showq3Body()
        {
            //q3bodyOn = !q3bodyOn;

            q3rightEyePanel.SetActive(false);
            q3leftEyePanel.SetActive(false);
            //q3bodyPanel.SetActive(q3bodyOn);
        }
    }
}