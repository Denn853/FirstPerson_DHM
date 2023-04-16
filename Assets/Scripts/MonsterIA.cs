using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterIA : MonoBehaviour
{
    public NavMeshAgent ia;
    public Animator anim;
    public Transform player;
    Vector3 dest;

    void Update()
    {
        dest = player.position; 
        ia.destination = dest;  

        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 1.5f;
            anim.speed = 0.2f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 1.7f;
            anim.speed = 0.4f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 1.9f;
            anim.speed = 0.6f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 2.5f;
            anim.speed = 0.8f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 3f;
            anim.speed = 1f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 3.5f;
            anim.speed = 1.2f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 3.8f;
            anim.speed = 1.4f;
        }
        if (PickUpLetter.pagesCollected == 1)
        {
            ia.speed = 4f;
            anim.speed = 1.6f;
        }
    }
}
