using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PickUpLetter : MonoBehaviour
{
    public GameObject collectTextObj, intText, monster;
    public AudioSource pickingUpSound, ambienceLayer1, ambienceLayer2, ambienceLayer3, ambienceLayer4, ambienceLayer5, ambienceLayer6, ambienceLayer7, ambienceLayer8;
    public bool interactable;
    public static int pagesCollected;
    public TextMeshProUGUI collectText;
    public string gameSceneName;

    void Start()
    {
        pagesCollected = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                pagesCollected = pagesCollected + 1;

                if (monster.active == false)
                {
                    monster.SetActive(true); 
                }

                collectText.text = pagesCollected + "/8 pages";
                collectTextObj.SetActive(true);
                pickingUpSound.Play();

                if (pagesCollected == 1)
                {
                    ambienceLayer1.Play();
                }
                if (pagesCollected == 2)
                {
                    ambienceLayer2.Play();
                }
                if (pagesCollected == 3)
                {
                    ambienceLayer3.Play();
                }
                if (pagesCollected == 4)
                {
                    ambienceLayer4.Play();
                }
                if (pagesCollected == 5)
                {
                    ambienceLayer5.Play();
                }
                if (pagesCollected == 6)
                {
                    ambienceLayer6.Play();
                }
                if (pagesCollected == 7)
                {
                    ambienceLayer7.Play();
                }
                if (pagesCollected == 8)
                {
                    ambienceLayer8.Play();
                }

                intText.SetActive(false);
                this.gameObject.SetActive(false);
                interactable = false;
            }
        }

        if (pagesCollected == 8)
        {
            SceneManager.LoadScene(gameSceneName);
        }
    }
}
