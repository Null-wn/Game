using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject player;
    public Camera pc;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        pc.transform.position = player.transform.position;
        pc.transform.rotation = player.transform.rotation;
    }
}
