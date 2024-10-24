using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    Rigidbody2D rigidbody1;
    [SerializeField] float moveSpeed = 1f;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
        rigidbody1 = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigidbody1.linearVelocity = (Player.transform.position - transform.position).normalized * moveSpeed;
    }
}
