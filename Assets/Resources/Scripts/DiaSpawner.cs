using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaSpawner : MonoBehaviour
{

    public GameObject[] prefabs;

    
    void Start()
    {
        StartCoroutine(SpawnDia());
    }

    
    void Update()
    {

    }

    IEnumerator SpawnDia()
    {
        while (true)
        {

            int diaThisRow = Random.Range(1, 2);

            for (int i = 0; i < diaThisRow; i++)
            {
                Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
            }

            yield return new WaitForSeconds(Random.Range(1, 12));
        }
    }
    public void ResetDiaSpawnSpeed()
    {
        StopAllCoroutines();
        StartCoroutine(SpawnDia());
    }
}
