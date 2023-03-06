using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Camera cam;
    Rigidbody rb;

    public Vector2 sensitivity;
    public Vector2 rotationLimit;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        View();
        Move();
    }

    void Move()
    {
        Vector2 temp = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Verical"));
        if (temp.magnitude > 1f)
        {
            temp = temp.normalized;
        }
        temp *= speed * Time.deltaTime;

        transform.position += transform.forward * temp.y + transform.right * temp.x;
    }
    void View()
    {
        float horizontal = Input.GetAxis("Mouse X") * sensitivity.x * Time.deltaTime;
        Debug.Log(horizontal);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + horizontal, transform.eulerAngles.z);

        float vertical = Input.GetAxis("Mouse Y") * sensitivity.y * Time.deltaTime;

        float correctedAngle = cam.transform.localEulerAngles.x;
        if (correctedAngle > 90)
        {
            correctedAngle -= 360;
        }

        vertical = Mathf.Clamp(correctedAngle + vertical, rotationLimit.x, rotationLimit.y);
       
        cam.transform.localEulerAngles = new Vector3(vertical, cam.transform.localEulerAngles.y, cam.transform.localEulerAngles.z);
    }
}
