using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space : MonoBehaviour
{
    float timer = 0;
    private int counter = 0;
    //public GameObject[] Flower = new GameObject[10];
    public GameObject Flower1;
    public int repeats =10;
   
    void Start()
    {
        counter = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("spacepressed");
            counter++;
            timer = 0;
        }
        if (counter >= repeats)
        {
            Debug.Log("10timesPressed");
            //timer += Time.deltaTime;
            
        }
        if (timer > 1)
        {
            Debug.Log("1sec");
            SpawnFlowers();
            timer = 0;
            counter = 0;
        }   

    }
    void SpawnFlowers()
    {
        
        for (int i = 0; i < counter; i++)
        {
            GameObject flowers = Instantiate(Flower1);
            flowers.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>(), false);
            flowers.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-200, 400), Random.Range(-150, 150), 0);
        }
        
    }





}
