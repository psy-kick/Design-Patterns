using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public EnemyFactory Factory;
    public Transform BossSpawnPoint;
    public Transform CrawlerSpawnPoint;
    private static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(Factory.CreateClass("Boss").GetEnemyprefab(), BossSpawnPoint.position, BossSpawnPoint.rotation);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(Factory.CreateClass("Crawler").GetEnemyprefab(), CrawlerSpawnPoint.position, CrawlerSpawnPoint.rotation);
        }
    }
}
