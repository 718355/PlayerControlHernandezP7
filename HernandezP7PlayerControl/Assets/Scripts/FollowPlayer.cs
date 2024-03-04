using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    private bool camerachange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (camerachange == false)
            {
                offset = new Vector3(0, 2, 1);
                camerachange = true;
            }
            else
            {
                offset = new Vector3(0, 5, -7);
                camerachange = false;
            }
        }
    }


    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
