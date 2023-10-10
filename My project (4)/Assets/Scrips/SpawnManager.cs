using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<Transform> spawnPoints;
    public GameObject note;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        for (int i = 0; i < count; i++)
        {
            int pointIndex = Random.Range(0, spawnPoints.Count - 1);
            Instantiate(note, spawnPoints[pointIndex].position, Quaternion.identity);
            spawnPoints.Remove(spawnPoints[pointIndex]);
        }
    }
}
