using UnityEngine;

public class EnemyCommon : MonoBehaviour
{
    public string enemyName;
    public int health;
    public float speed;

    public EnemyCommon(string name, int health, float speed)
    {
        this.enemyName = name;
        this.health = health;
        this.speed = speed;
    }

    public virtual void Move(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
        Debug.Log($"{enemyName} is moving in direction {direction}");
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{enemyName} has died.");
        Destroy(gameObject);
    }
}