﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{

    public float Level = 1;

    public GameObject Player;
    public PlayerMotor Controller;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Knight");
        Controller = Player.GetComponent<PlayerMotor>();
    }

    // Update is called once per frame
    void Update()
    {
        DebugControls();
    }

    // Important Note! If you are changing a float a lot and you rely on other things needing to know when that happens,
    // make a function for changing it so you can branch it out to other things!

    public void LevelUp()
    {
        Level += 1;
        Controller.OnLevelUp();

    }

    public void DebugControls()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            LevelUp();
        }
    }
}
