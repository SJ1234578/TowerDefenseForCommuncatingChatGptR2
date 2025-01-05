using UnityEngine;

public class FastEnemy : EnemyCommon
{
    // Calls parent(EnemyCommon)'s constructor
    public FastEnemy(string name, int health, float speed) : base(name, health, speed) { }

    public override void Move(Vector3 direction)
    {
        Debug.Log($"{enemyName} is sprinting in direction {direction}");
    }
}