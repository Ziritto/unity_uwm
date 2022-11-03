using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3i4 : MonoBehaviour
{

    public Transform player;

    public float sensitivity = 200f;

    private Quaternion rotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        rotation = transform.localRotation;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;


        player.Rotate(Vector3.up * mouseXMove);

        rotation.x += Input.GetAxis("Mouse Y");
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x = Mathf.Clamp(rotation.x, -90f, 90f);
        transform.localRotation = Quaternion.Euler(-rotation.x, 0, 0);
    }
}
