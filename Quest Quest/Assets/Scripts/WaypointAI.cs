using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour
{
    public GameObject[] waypoints; //Public array that holds the desired waypoints, create empties then add them to the list.
    int current = 0; //counter for the waypoints
    public float speed; //speed of object moving towards waypoint
    float wayRadius = 1; //makes sure the object hits the waypoint

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(waypoints[current].transform.position, transform.position) < wayRadius)
        {
            //Two options for cycling through the array, if we want to go in order, it's the first. If we want it randomized, it's the second.

            //current++;
            //current = Random.Range(0,waypoints.Length);
            if(current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}
