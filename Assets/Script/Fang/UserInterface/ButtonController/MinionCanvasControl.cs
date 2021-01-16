namespace Fang.UserInterface
{
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    public class MinionCanvasControl : MonoBehaviour
{
        public GameObject rightEyePanel;
        public GameObject leftEyePanel;
        public GameObject bodyPanel;

        public Button rightEyeButton;
        public Button leftEyeButton;
        public Button bodyButton;

        private bool bodyOn;

        void Start()
        {
            leftEyePanel.SetActive(false);
            bodyPanel.SetActive(false);
            rightEyeButton.onClick.AddListener(ShowRightEye);
            leftEyeButton.onClick.AddListener(ShowLeftEye);
            bodyButton.onClick.AddListener(ShowBody);
        }

        public void ShowRightEye()
        {
            rightEyePanel.SetActive(true);
            leftEyePanel.SetActive(false);
        }

        public void ShowLeftEye()
        {
            leftEyePanel.SetActive(true);
            rightEyePanel.SetActive(false);
        }

        public void ShowBody()
        {
            bodyOn = !bodyOn;
            bodyPanel.SetActive(bodyOn);
        }
    }
}
