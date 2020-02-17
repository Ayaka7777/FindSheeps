using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfo : MonoBehaviour
{
    private Text info;
    private int a;
    private int b;
    private GameObject tt;
    private Text Win;

    void Start()
    {
        info = GetComponent<Text>();
        tt = GameObject.FindGameObjectWithTag("Text");
        Win = GameObject.Find("End").GetComponent<Text>();
    }

    void Update()
    {
        GameObject[] sheep = GameObject.FindGameObjectsWithTag("Sheep");

        a = sheep[0].GetComponent<SheepFinish>().Point +
              sheep[1].GetComponent<SheepFinish>().Point +
              sheep[2].GetComponent<SheepFinish>().Point +
              sheep[3].GetComponent<SheepFinish>().Point +
              sheep[4].GetComponent<SheepFinish>().Point;
        b = 5 - a;

        if (b != 0)
        {
            info.text = string.Format("{0} sheep left", b);
        }
        else
        {
            info.text = string.Format("{0} sheep left", b);
            Destroy(tt.GetComponent<Text>());
            Time.timeScale = 0;
            Win.text = string.Format("WIN");


        }

    }
}
