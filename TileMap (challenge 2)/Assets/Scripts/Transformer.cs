using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformer : MonoBehaviour
{


    public float speed;
    Vector3 pointA = new Vector3(6.5f, -3.8f, 0.6f);
    Vector3 pointB = new Vector3(15.5f, -3.8f, 0.6f);



    void Update()
    {

        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
