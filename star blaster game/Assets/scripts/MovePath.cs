using UnityEngine;

public class MovePath : MonoBehaviour
{
    [SerializeField] EnemyWaves TestEnemy;
    Transform[] GetPointsWave;
    [SerializeField] float EnemyMoveSpeed;
    int waypointIndex = 0;

    void Start()
    {
       GetPointsWave = TestEnemy.WavePoints();

    }

    // Update is called once per frame
    void Update()
    {
       FollowWavePath(); 
    }

    void FollowWavePath()
    {
        if(waypointIndex < GetPointsWave.Length)
        {
            Vector3 targetPosition = GetPointsWave[waypointIndex].position;
            //print(targetPosition);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, EnemyMoveSpeed*Time.deltaTime);
            if(transform.position == targetPosition)
            {
                waypointIndex++;
            }
            if(waypointIndex >= GetPointsWave.Length)
            {
                waypointIndex =0;
            }


        }
    }
}
