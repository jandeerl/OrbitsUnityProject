using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public float yRotation = 5f;
    public float rotationSpeed = 4f;
    public bool changeDirections;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!changeDirections)
        {
            yRotation += Time.deltaTime * rotationSpeed;
            transform.rotation = Quaternion.Euler(0, yRotation, 0);
            if (yRotation > 360)
                yRotation = transform.rotation.y;
        }
        else
        {
            yRotation -= Time.deltaTime * rotationSpeed;
            transform.rotation = Quaternion.Euler(0, yRotation, 0);
            if (yRotation < -360)
                yRotation = transform.rotation.y;
        }

    }
}
