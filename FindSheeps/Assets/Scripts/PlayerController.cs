using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float vertical;
    private float horizontal;
    private float moveSpeed;
    private Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }


    void Update()
    {
      vertical = Input.GetAxis("Vertical");
      horizontal = Input.GetAxis("Horizontal");
     
        Vector3 dir = new Vector3(horizontal, 0, vertical);
        if(dir != Vector3.zero)
        {
            if (Input.GetKey(KeyCode.LeftShift) == false)
            {
                moveSpeed = 2;
                transform.rotation = Quaternion.LookRotation(dir);
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                ani.SetInteger("run", 1);
            }
            else if (Input.GetKey(KeyCode.LeftShift) == true)
            {
                moveSpeed = 4;
                transform.rotation = Quaternion.LookRotation(dir);
                transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

                ani.SetInteger("run", 2);
            }
        }
        else
        {
            ani.SetInteger("run", 0);
        }
    }
}
