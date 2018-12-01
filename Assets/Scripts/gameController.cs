using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    public GameObject[] shells;
    public Vector2 spawnValues;
    public float hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject shell = shells[Random.Range(0, shells.Length)];
                Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                Quaternion spawnRotation = Quaternion.identity;

                Instantiate(shell, spawnPosition, spawnRotation);

            }
            yield return new WaitForSeconds(waveWait);
        }
    }
}
