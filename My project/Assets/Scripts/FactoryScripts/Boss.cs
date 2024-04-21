using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    [SerializeField]
    GameObject EnemyPrefab;
    public override void SetEnemyPrefab(GameObject gb)
    {
        EnemyPrefab = gb;
    }
    public override GameObject GetEnemyprefab()
    {
        Debug.Log("created Boss Enemy type");
        return EnemyPrefab;
    }


}
