using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousemovement : MonoBehaviour
{
    float mousesens=600f;
    float xrotation=0f;
    float yrotation=0f;
    float toplimit=-90f;
    float bottomlimit=90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * mousesens *Time.deltaTime;
        float mousey = Input.GetAxis("Mouse Y") * mousesens *Time.deltaTime;
        xrotation = xrotation-mousey;
        yrotation = yrotation+mousex;
        xrotation = Mathf.Clamp(xrotation,toplimit,bottomlimit);
        transform.localRotation = Quaternion.Euler(xrotation,yrotation,0f);
    }
}
