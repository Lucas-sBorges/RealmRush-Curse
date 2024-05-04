using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{   
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;
    
    // Start is called before the first frame update
    void Start()
    {   
        
        StartCoroutine(FollowPath());
        
    }

    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {   
            //Estou passando o valor do transform do waypoint para o transform do player
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
