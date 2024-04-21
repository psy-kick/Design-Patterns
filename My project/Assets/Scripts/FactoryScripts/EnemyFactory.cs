using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour
{
    [SerializeField]
    GameObject BossPrefab;
    [SerializeField]
    GameObject CrawlerPrefab;
    public Enemy CreateClass(string s)
    {
        Enemy enemy = null;
        if(s=="Boss")
        {
            enemy = new Boss();
            enemy.SetEnemyPrefab(BossPrefab);
            return enemy;
        }
        else if(s=="Crawler")
        {
            enemy = new Crawler();
            enemy.SetEnemyPrefab(CrawlerPrefab);
            return enemy;
        }
        else
        {
            Debug.Log("Unknown Enemy");
            return null;
        }
    }
}
