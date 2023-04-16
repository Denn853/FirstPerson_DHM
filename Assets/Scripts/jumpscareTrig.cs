using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jumpscareTrig : MonoBehaviour
{
    public GameObject playerObj, jumpsacareCam, ambienceLayer;
    public Animator monsterAnim;
    public string sceneName;
    public float jumpscareTime;
    public MonsterIA monsterScript;
    public AudioSource screamAudio;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerObj.SetActive(false); 
            monsterScript.enabled = false;  
            monsterAnim.speed = 1f;
            jumpsacareCam.SetActive(true);
            ambienceLayer.SetActive(false);
            StartCoroutine(changeScene());
            monsterAnim.SetTrigger("JumpScare");
            screamAudio.enabled = true;
            screamAudio.Play();
        }
    }

    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
