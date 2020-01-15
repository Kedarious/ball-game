using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject player;
    public float cameraFollowDistance = 10;

    // Update is called once per frame
    void LateUpdate() {
        transform.position = new Vector3(0, gameObject.transform.position.y, player.gameObject.transform.position.z - cameraFollowDistance);
    }
}
