using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
        //var pos = (Vector2)transform.position;

        //var x = Vector2.Distance(pos, player.transform.position);

        //if (x > 4)
        //    transform.position = player.transform.position + offset;

        //Debug.Log("Player: " + player.transform.position);
        //Debug.Log("offset: " + offset);
        //Debug.Log("transform.position: " + transform.position);
    }
}
