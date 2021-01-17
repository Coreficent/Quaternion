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

        void Start()
        {
            infoPanel.SetActive(true);
            infoButton.onClick.AddListener(Info);
        }

        public void Info()
        {
            infoOn = !infoOn;
            infoPanel.SetActive(!infoOn);
        }
    }
}
