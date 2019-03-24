using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }
    
    void Spawn()
    {
        float radius = 20f;
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        int i = 0;
        float range = 3f;
        bool safe = true;

        while (i < hitColliders.Length)
        {
            if (Mathf.Abs(hitColliders[i].transform.position.y - transform.position.y) < 2)
            {
                safe = false;
            }
            i++;
        }
        
        if (safe)
        {
            Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        }
        
    }
}
