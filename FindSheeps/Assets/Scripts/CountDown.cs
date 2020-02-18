using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    private Text text;
    public int second;
    public float time;
    private Text Lose;

    private void Start()
    {
        Lose = GameObject.Find("End").GetComponent<Text>();
    }

    void Update()
    {
        text = gameObject.GetComponent<Text>();
        text.text = string.Format("{0:d2}：{1:d2}", second / 60, second % 60);

        if (second > 0)
        {
            if (time >= 1)
            {
                second--;
                time = 0;
            }
        }

        time += Time.deltaTime;

        if (second <= 0)
        {
          Time.timeScale = 0;
            Lose.text = string.Format("LOSE");
        }
        

    }
}
