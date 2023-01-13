using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyAPrefab,enemyBossPrefab;
    [SerializeField]
    private GameObject EnemyContainer;

    private bool IsAlive = true;


    void Start()
    {
        
    }

    void Update()
    {
     
    }
    public void activateRoutines()
    {
        StartCoroutine(SpawnEnemyRoutine());

    }
    IEnumerator SpawnEnemyRoutine()
    {
        yield return new WaitForSeconds(3f);
        while (IsAlive)
        {
            float randomX = Random.Range(-4.1f, 4.1f);
            GameObject newEnemy = Instantiate(enemyAPrefab, new Vector3(randomX, 6, 0), Quaternion.identity);
            newEnemy.transform.parent = EnemyContainer.transform;
            yield return new WaitForSeconds(4.0f);
        }
    }

public void setPlayerDead()
    {
        IsAlive= false;
    }
}
