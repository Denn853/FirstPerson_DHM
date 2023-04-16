using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightMovement : MonoBehaviour
{
    public Animator flasshlightAnim;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                flasshlightAnim.ResetTrigger("Walk");
                flasshlightAnim.SetTrigger("Sprint");
            }
            else
            {
                flasshlightAnim.ResetTrigger("Sprint");
                flasshlightAnim.SetTrigger("Walk");
            }
        }
    }
}
