using UnityEngine;

public class CommonUnitManager : MonoBehaviour
{
    void Start()
    {
        EnemyCommon fastEnemy = new FastEnemy("Speedy", 50, 10f);
        EnemyCommon strongEnemy = new StrongEnemy("Tanky", 100, 5f);

        fastEnemy.Move(Vector3.right);
        strongEnemy.Move(Vector3.left);
    }
}