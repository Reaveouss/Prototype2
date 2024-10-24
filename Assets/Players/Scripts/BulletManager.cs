using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] float rawDamage = 7f;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            collision.GetComponent<EnemyHealth>().Morder(rawDamage);
            
        }
    }
}
