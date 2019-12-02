using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelUI : MonoBehaviour
{
    public Text Leveltext;
    public GameObject Player;
    public PlayerLevel Playerlevel;

    // Start is called before the first frame update
    void Start()
    {
        Leveltext = gameObject.GetComponent<Text>();
        Player = GameObject.Find("Knight");
        Playerlevel = Player.GetComponent<PlayerLevel>();
    }

    // Update is called once per frame
    void Update()
    {
        Leveltext.text = Playerlevel.Level.ToString();
    }
}
