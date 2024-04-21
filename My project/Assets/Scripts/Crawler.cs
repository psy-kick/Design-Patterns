using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crawler : Enemy
{
    [SerializeField]
    GameObject CrawlerObject;
    public override void SetEnemyPrefab(GameObject gb)
    {
        CrawlerObject = gb;
    }
    public override GameObject GetEnemyprefab()
    {
        Debug.Log("Crawler Enemy Type Created");
        return CrawlerObject;
    }
}
