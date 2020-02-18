using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRock : MonoBehaviour
{
    private Animation ani;
    private bool aaa;
    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animation>();
        aaa = false;
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if(aaa == false)
        {
            ani.Play("RemoveRock");
            aaa = true;
        }
    }
}
