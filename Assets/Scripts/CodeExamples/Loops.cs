using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 0;
        
        while(count < 2)
        {
            Debug.Log(count);
            count++; //count = count +1; elikkä lisää yhden counttiin. voi myös kirjoittaa count +=1;
        

        }


        int numberOfEnemies = 0;
        while(numberOfEnemies < 10)
        {
            Debug.Log("Creating enemy " + numberOfEnemies);
            numberOfEnemies++;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
