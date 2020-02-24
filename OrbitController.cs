using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    [SerializeField]
    GameObject objectToOrbit;
    [SerializeField]
    float xAxis = 5f;
    [SerializeField]
    float zAxis = 5f;
    [SerializeField]
    float yAxis = 0f;
    [SerializeField]
    float speed = 5f;
    [SerializeField]
    bool switchDirection;

    float velocity;

    void Start()
    {
        if (objectToOrbit == null)
        {
            Debug.LogWarning("No object to orbit around!");
        }
    }

    void Update()
    {
        if (objectToOrbit != null)
        OrbitObject();
    }

    //moves the object along selected axes on an orbit
    void OrbitObject()
    {
        velocity += Time.deltaTime * speed / 10f;
        Vector3 pos;

        //reverses the movement along z Axis
        if (switchDirection)
        {
                pos = new Vector3(
                Mathf.Cos(velocity) * xAxis,
                Mathf.Cos(velocity) * yAxis,
                -Mathf.Sin(velocity) * zAxis);        
        }
        else
        {
                pos = new Vector3(
                Mathf.Cos(velocity) * xAxis,
                Mathf.Cos(velocity) * yAxis,
                Mathf.Sin(velocity) * zAxis);
        }
        transform.position = objectToOrbit.transform.position + pos;
    }
}
