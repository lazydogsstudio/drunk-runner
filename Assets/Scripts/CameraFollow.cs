using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {

        transform.position = new Vector3(0f, player.position.y, player.position.z) + new Vector3(0f, 6f, -17f);
    }
}
