using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemyPrefab;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            float RNG = Random.Range(-2, 2);  // 적이 나오는 랜덤 minx, maxx
            
            Vector3 launch = new Vector3(RNG, 3, 10);
            
            Instantiate(_enemyPrefab, launch, Quaternion.Euler(0, 180, 0));
            
            yield return new WaitForSeconds(5);
        }    
    }

}
