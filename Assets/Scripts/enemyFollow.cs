using UnityEditor.AdaptivePerformance.Editor;
using UnityEngine;

public class enemyFollow : MonoBehaviour
{
    public float Speed;
    public GameObject Enemy;
    public GameObject Target;
    void FixedUpdate()
    {
        Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, Target.transform.position, Speed * Time.deltaTime);
    }
}
