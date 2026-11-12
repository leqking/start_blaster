using UnityEngine;

public class MovePath : MonoBehaviour
{
    [SerializeField] EnemyWaves waveconfig;
    Transform[] waypoints;
    [SerializeField] float EnemyMoveSpeed;
    int waypointIndex = 0;

    void Start()
    {
        waypoints = waveconfig.WavePoints();
        transform.position = waveconfig.Getstartingwaypoint().position; 

    }

    // Update is called once per frame
    void Update()
    {
       FollowWavePath(); 
    }

    void FollowWavePath()
    {
        if(waypointIndex < waypoints.Length)
        {
            Vector3 targetPosition = waypoints[waypointIndex].position;
            //print(targetPosition);
            float moveDelta = waveconfig.Getenemymovespeed() * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, EnemyMoveSpeed*Time.deltaTime);
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
            if(waypointIndex >= waypoints.Length)
            {
                waypointIndex =0;
            }
           // else
          //  {
          //      Destroy(gameObject);
          // }


        }
    }
}
