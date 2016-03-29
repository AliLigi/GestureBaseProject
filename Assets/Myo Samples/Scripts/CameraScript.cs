using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    // Use this for initialization
    void Start()
    {

        offset = transform.position - player.transform.position;
       
    }

    //update every frame
    void LateUpdate()
    {

        transform.position = player.transform.position + offset;

    }
}
