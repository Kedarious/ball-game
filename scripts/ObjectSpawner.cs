using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject player;
    public GameObject[] triangleprefabs;
    private Vector3 spawnObstaclesPosition;

    // Update is called once per frame
    void Update() {
        float distanceTohorizon = Vector3.Distance(player.gameObject.transform.position, spawnObstaclesPosition);
        if (distanceTohorizon < 120) {
            SpawnTriangles();

        }

    }

    void SpawnTriangles() {
        spawnObstaclesPosition = new Vector3(0, 0, spawnObstaclesPosition.z + 20);
        Instantiate(triangleprefabs[(Random.Range(0, triangleprefabs.Length))], spawnObstaclesPosition, Quaternion.identity);
    }
}
