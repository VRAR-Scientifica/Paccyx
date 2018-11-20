using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InkyController : MonoBehaviour {

    public EditorPathScript PathToFollow;

    public int CurrentWaypointID;
    public float speed;
    private float reachDistance = 0;
    public float rotationSpeed = 0.5f;
    public string pathName;

    Vector3 last_position;
    Vector3 current_position;

    void Start()
    {
        //PathToFollow = GameObject.Find(pathName).GetComponent<EditorPathScript> ();
        last_position = transform.position;
    }

    void Update()
    {
        float distance = Vector3.Distance(PathToFollow.path_objs[CurrentWaypointID].position, transform.position);
        transform.LookAt(PathToFollow.path_objs[CurrentWaypointID].position);
        transform.position = Vector3.MoveTowards(transform.position, PathToFollow.path_objs[CurrentWaypointID].position, 3.0f * Time.deltaTime);

        if (distance <= reachDistance)
        {
            CurrentWaypointID++;
        }
        if (CurrentWaypointID >= PathToFollow.path_objs.Count)
        {
            CurrentWaypointID = 0;
        }
    }
}
