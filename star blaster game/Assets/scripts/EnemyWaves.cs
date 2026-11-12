using UnityEngine;

[CreateAssetMenu(fileName = "EnemyWaves", menuName = "New EnemyWaves")]
public class EnemyWaves : ScriptableObject
{
    [SerializeField] Transform MyEnemyWave;
   

    public Transform[] WavePoints()
    {
        Transform[] MovePoints = new Transform[MyEnemyWave.childCount];
        for (int i =0; i < MyEnemyWave.childCount; i++)
        {
            MovePoints[i] = MyEnemyWave.GetChild(i);
        }
        return MovePoints;
    }
}
