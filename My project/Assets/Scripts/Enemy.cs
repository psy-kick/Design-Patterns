using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy
{
    public abstract GameObject GetEnemyprefab();
    public abstract void SetEnemyPrefab(GameObject gb);
}
