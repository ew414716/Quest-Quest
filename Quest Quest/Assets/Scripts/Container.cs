﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    //This script needs to be on a trigger that is a child of a gameobject named "ContainerObject" in the heirarchy. 

    //public GameObject ContainerObject;
    //public SpriteRenderer ContainerBox;
    public SpriteRenderer FirstSprite;
    public SpriteRenderer SecondSprite;
    public GameObject Player;
    public PlayerLevel Playerlevel;

    bool isInChestZone;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Knight");
        Playerlevel = Player.GetComponent<PlayerLevel>();
        //ContainerObject = GameObject.Find("ContainerObject");
        //ContainerBox = ContainerObject.GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        isInChestZone = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {

        isInChestZone = false;
    }

    void Update()
    {
        if (isInChestZone)
        {

            Debug.Log("In the zone!");

            if (Input.GetKeyDown(KeyCode.E))
            {
                Playerlevel.LevelUp();
                //ContainerBox.color = Color.black;
                FirstSprite.enabled = false;
                SecondSprite.enabled = true;
                Debug.Log("Is this thing on?");
                Destroy(gameObject);
            }
        }
    }
}
