using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float moveSpeed;
    public float MoveSpeed
    {
        get
        { return moveSpeed; }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-moveSpeed*0.01f, 0, 0,Space.World);
        
        if(transform.position.x < -30)
        {
            transform.Translate(65, 0, 0, Space.World);
        }
    }
}
