using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 4f;
    [SerializeField]
    bool changeDirections;

    float yRotation;

    void Update()
    {
        RotateSelf();
    }

    //Rotates the object along Y axis
    void RotateSelf()
    {
        if (!changeDirections)
        {
            yRotation += Time.deltaTime * rotationSpeed;
            transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }
        else
        {
            yRotation -= Time.deltaTime * rotationSpeed;
            transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }

        //makes sure both yRotation and transform's rotation
        //don't increment to infinity
        if (yRotation > 360 || yRotation < -360)
            yRotation = transform.rotation.y;
    }
}
