using System;
using System.Threading;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public float Timer;



    private void Update()
    {
        Timer = Time.time + Timer;

        if (Timer >= 500)
        {
            SpawnObject();
            Timer = 0;
        }
    }


    public void SpawnObject()
    {
        if (prefabToSpawn != null)
        {
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
        
    }

    
}
