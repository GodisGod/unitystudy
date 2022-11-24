using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGGameManager : MonoBehaviour
{
    public static RPGGameManager instance = null;

    public SpawnPoint playerSpawnPoint;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(instance);
        }
        else {
            instance = this;
                }
    }

    // Start is called before the first frame update
    void Start()
    {
        SetupScene();
    }

    private void SetupScene()
    {
        SpawnPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer() {
        if (playerSpawnPoint != null) {
            GameObject player = playerSpawnPoint.SpawnObject();
        }
    }

}
