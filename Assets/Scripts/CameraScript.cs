using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
    public float camHeight = 40;
    public float camDistance = 10;

    public Transform tar;

    void Update( ) {
        FollowTarget();
    }

    public void FollowTarget() {
        transform.LookAt(tar);
        transform.position = Vector3.Lerp(transform.position, new Vector3( tar.position.x , camHeight , tar.position.z - camDistance ), .8f);
    }
}
