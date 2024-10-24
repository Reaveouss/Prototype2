using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] float rawDamage = 1f;
    [SerializeField] float delayTimer = 0.2f;
    float tick;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && attackReady())
        {
            HealthManager.instance.Hit(rawDamage);
        }
    }
    bool attackReady()
    {
        if (tick > delayTimer)
        {
            tick -= Time.deltaTime;
            return false;
        }
        return true;
    }
}
