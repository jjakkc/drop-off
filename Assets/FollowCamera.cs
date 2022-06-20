using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    // using LateUpdate over Update to reduce possible jitteryness that may be caused in script order execution
    void LateUpdate()
    {
        transform.position = new Vector3(
            thingToFollow.transform.position.x, 
            thingToFollow.transform.position.y, 
            transform.position.z);
    }
}
