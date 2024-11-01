using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float MaxSpawnTime = 1.5f;

    public float Timer = 0;

    public float SpawnHeight;
    
    public GameObject Pipe;

    

    void Start()
    {
        GameObject NewPipe = Instantiate(Pipe);
        NewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-SpawnHeight, SpawnHeight), 0);
    }

    
    void Update()
    {
        if (Timer > MaxSpawnTime)
        {
            GameObject NewPipe = Instantiate(Pipe);
            NewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-SpawnHeight, SpawnHeight), 0);

            Destroy(NewPipe,10f);
            Timer = 0;
        }

        Timer += Time.deltaTime;
    }
}
