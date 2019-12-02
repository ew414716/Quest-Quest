using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightRun : MonoBehaviour
{
    public Animator anim;
    Vector3 characterScale;
    float characterScaleX;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        characterScale = transform.localScale;
        characterScaleX = characterScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown(KeyCode.D)))))
            anim.SetTrigger("runTrigger");
        else anim.SetTrigger("idleTrigger");

        if (Input.GetKeyUp(KeyCode.W) || (Input.GetKeyUp(KeyCode.A) || (Input.GetKeyUp(KeyCode.S) || (Input.GetKeyUp(KeyCode.D)))))
            anim.SetTrigger("runTrigger");
        else anim.SetTrigger("idleTrigger");

        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = -characterScaleX;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = characterScaleX;
        }
        transform.localScale = characterScale;

    }
  }
    



