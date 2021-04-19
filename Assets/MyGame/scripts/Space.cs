using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    private int counter = 0;
    public KeyCode space;


    void Start()
    {
        counter = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacepressed");
            counter++;
        }
        if (counter > 10)
        {
            Debug.Log("wixxa");
        }
    }
    void 
    
}
