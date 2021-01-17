namespace Fang.UserInterface
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class InfoControl : MonoBehaviour
    {
        private bool infoOn;
        public GameObject infoPanel;
        public Button infoButton;

        public AudioSource audioSource;
        public AudioClip impact;

        void Start()
        {

            infoPanel.SetActive(false);
            infoButton.onClick.AddListener(Info);
        }

        public void Info()
        {
            audioSource.PlayOneShot(impact, 0.5F);
            infoOn = !infoOn;
            infoPanel.SetActive(infoOn);
        }
    }
}
