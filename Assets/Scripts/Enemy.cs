using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected float damage = 30;
    protected float health = 70;
    public Player player;

    public virtual void Attack()
    {
        player.Health -= damage;
    }

    public float GetHealth()
    {
        return health;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
    }
}
