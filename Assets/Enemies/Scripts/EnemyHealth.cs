using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HitPoints;
    [SerializeField] float MaxHitPoints = 10;

    void Start()
    {
        HitPoints = Random.Range(MaxHitPoints / 2, MaxHitPoints);
    }
    public void Morder(float rawDamage)
    {
        HitPoints -= rawDamage;

        if (HitPoints <= 0)
        {
            OnDeath();
        }
    }
    private void OnDeath()
    {
        Destroy(this.gameObject);
    }
}
