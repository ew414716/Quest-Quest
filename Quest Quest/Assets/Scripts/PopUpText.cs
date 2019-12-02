using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpText : MonoBehaviour
{
    public GameObject Player;
    public Transform PlayerTransform;
    public float ShowOnDistance = 2;
    private MeshRenderer textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = gameObject.GetComponent<MeshRenderer>();
        Player = GameObject.Find("Knight");
        PlayerTransform = Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PlayerTransform.position) < ShowOnDistance)
        {
            textMesh.enabled = true;
        }
        else
        {
            textMesh.enabled = false;
        }

    }
}
