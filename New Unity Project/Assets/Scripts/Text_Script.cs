using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Script : MonoBehaviour
{
    public GameObject health1, health2, health3;
    //public GameObject playerScore;
    public GameObject playerAmmo;
    public static int ammo = 50;
    //public static int score = 100;
    //set the score to 100

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Text txt = playerAmmo.GetComponent<Text>();
            txt.text = (ammo + "/50");
            ammo--;
        }



        if (ammo == 0)
        {
            ammo = 50;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ammo = 50;
        }






    }
}
