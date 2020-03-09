using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Script2 : MonoBehaviour
{
    public GameObject health1, health2, health3;
    public GameObject playerScore;
    public static int score = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text_Script2.score = 100;
        Text txt1 = playerScore.GetComponent<Text>();
        txt1.text = (score + "100");
        score--;
        if (score == 100)
        {
            Destroy(health1);
        }
    }
}
