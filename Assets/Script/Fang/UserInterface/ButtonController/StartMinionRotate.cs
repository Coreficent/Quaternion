using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMinionRotate : MonoBehaviour
{

    public Button startRotate;

    public GameObject enterPage;


    AudioSource audioSource;
    public AudioClip impact;


    void Start()
    {
        startRotate.onClick.AddListener(StartQuaternion);
        audioSource = GetComponent<AudioSource>();
    }

    public void StartQuaternion()
    {

        audioSource.PlayOneShot(impact, 0.7F);

        enterPage.SetActive(false);

    }
}
