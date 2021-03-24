using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset; 
    // Update is called once per frame
    void Update()
    {
        //testing player variable. 
        //Debug.Log(player.position);
        transform.position = player.position + offset;
    }
}
