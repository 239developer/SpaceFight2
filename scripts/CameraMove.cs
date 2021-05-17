using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;
    public Vector3 bias = new Vector3(0f, 2f, -3.14f);

    void Update()
    {
        transform.position = player.position + bias;
    }
}
