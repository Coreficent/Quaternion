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

        public AudioSource audioSource;
        public AudioClip impact;

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
            audioSource.PlayOneShot(impact, 0.5F);
            rightEyePanel.SetActive(true);
            leftEyePanel.SetActive(false);
        }

        public void ShowLeftEye()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            leftEyePanel.SetActive(true);
            rightEyePanel.SetActive(false);
        }

        public void ShowBody()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            bodyOn = !bodyOn;
            bodyPanel.SetActive(bodyOn);
        }
    }
}
