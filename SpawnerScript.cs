using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    
    public GameObject bombPrefab;

    private float minX = -2.55f;
    private float maxX = 2.55f;
    void Start(){
        StartCoroutine (SpawnBombs());
    }

    IEnumerator SpawnBombs () {
        yield return new WaitForSeconds (Random.Range (0f, 1f));

        Instantiate (bombPrefab, new UnityEngine.Vector2 (Random.Range(minX, maxX), transform.position.y ),
            UnityEngine.Quaternion.identity);

        StartCoroutine (SpawnBombs());

    }
}
