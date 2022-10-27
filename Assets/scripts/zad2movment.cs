using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class zad2movment : MonoBehaviour
{
    public float speed;
    int direction = 1;

    void Start()
    {

    }

    void FixedUpdate(){
        if(GetComponent<Transform>().position.x >= 6)
        {
            direction = -1;
        }
        else if(GetComponent<Transform>().position.x <= -6)
        {
            direction = 1;
        }
        GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x + speed * direction, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
    }
}
