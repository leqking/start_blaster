using UnityEditor.Search;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyWaves", menuName = "New EnemyWaves")]
public class EnemyWaves : ScriptableObject
{
    [SerializeField] Transform MyEnemyWave;
    [SerializeField] float enemymovespeed = 5f;
   

   public Transform Getstartingwaypoint()
  {
          return MyEnemyWave.GetChild(0);
   }

    public float Getenemymovespeed()
    {
        return enemymovespeed;
    }
    public Transform[] WavePoints()
    {
        Transform[] waypoints = new Transform[MyEnemyWave.childCount];
        for (int i =0; i < MyEnemyWave.childCount; i++)
        {
            waypoints[i] = MyEnemyWave.GetChild(i);
        }
        return waypoints;
    }
}
