using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int speed;
    public Transform target;
    void Update()
    {
      
        transform.RotateAround(target.transform.position, target.transform.up, speed * Time.deltaTime);
    }
}
