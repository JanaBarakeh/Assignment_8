using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter=0;
        while(counter < 20 )
        {
            int randomnum = Random.Range(1,20);
            counter++;
              if (randomnum== 5)
            {
                continue;
            }

            Debug.Log(randomnum);

            if (randomnum == 15)
            {
                break; 
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
