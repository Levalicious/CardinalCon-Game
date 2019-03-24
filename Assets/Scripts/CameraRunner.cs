using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunner : MonoBehaviour
{
    public Transform player;
    private float ytemp = 0;

    // Update is called once per frame
    void Update()
    {
        float ytemp = 0;
        if (player.position.y > ytemp)
        {
            ytemp = player.position.y;
        }
        transform.position = new Vector3(player.position.x, ytemp, -10);
    }
}
