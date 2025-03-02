using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    [SerializeField] GameObject Enemy1;
    [SerializeField] GameObject Player;
    [SerializeField] float delayTimer = 1f;
    float tick;
    public int spawnRadius = 30;
    public int PlayerRadius = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy(5);
    }

    // Update is called once per frame
    void Update()
    {
        tick += Time.deltaTime;
        if (tick > delayTimer)
        {
            tick = tick - delayTimer;
            SpawnEnemy(1);
        }
    }
    void SpawnEnemy(int amount)
    {
        while (amount != 0)
        {
            Vector2 randomPos = Random.insideUnitCircle * spawnRadius;
            while (randomPos.magnitude < PlayerRadius)
            {
                randomPos = Random.insideUnitCircle * spawnRadius;
            }
            Vector3 spawnPos = Player.transform.position + new Vector3(randomPos.x, randomPos.y, 0);

            
                Instantiate(Enemy1);
                Enemy1.transform.position = spawnPos;
            
            amount--;
        }
    }
}
