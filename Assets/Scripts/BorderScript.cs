using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour
{
    public Transform camera;
    public float offset = 0;
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(offset, camera.position.y, 10);
    }
}
