using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    [SerializeField]
    GameObject objectToOrbit;
    [SerializeField]
    float distanceFromObject = 5f;
    [SerializeField]
    float yOffset = 0f;
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

    //moves the object along a circular orbit on a horizontal plane
    void OrbitObject()
    {
        velocity += Time.deltaTime * speed / 10f;
        Vector3 pos;
        if (switchDirection)
        {
                pos = new Vector3(
                Mathf.Cos(velocity) * distanceFromObject,
                yOffset,
                -Mathf.Sin(velocity) * distanceFromObject);        
        }
        else
        {
                pos = new Vector3(
                Mathf.Cos(velocity) * distanceFromObject,
                yOffset,
                Mathf.Sin(velocity) * distanceFromObject);
        }
        transform.position = objectToOrbit.transform.position + pos;
    }
}
