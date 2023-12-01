using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject boulderPrefab;
    private Vector3 spawnPos = new Vector3(19, 1, 1);

    private float startDelay = 2;
    private float repeatRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle ()
    {
        Instantiate(boulderPrefab, spawnPos, boulderPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
