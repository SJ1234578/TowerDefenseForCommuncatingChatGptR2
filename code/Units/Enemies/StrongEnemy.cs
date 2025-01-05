using UnityEngine;

public class StrongEnemy : EnemyCommon
{
    public StrongEnemy(string name, int health, float speed) : base(name, health, speed) { }

    public void SmashAttack()
    {
        Debug.Log($"{enemyName} is performing a smash attack!");
    }
}
