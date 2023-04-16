using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsSound : MonoBehaviour
{
    public AudioSource footWalk, footSprint;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                footWalk.enabled = false;
                footSprint.enabled = true;
            }
            else
            {
                footWalk.enabled = true;
                footSprint.enabled = false;
            }
        }
        else
        {
            footWalk.enabled = false;
            footSprint.enabled = false;
        }
    }
}
