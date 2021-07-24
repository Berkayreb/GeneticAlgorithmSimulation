using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFinder : MonoBehaviour
{

    DNAPositions pos;
    bool hasFinished = false;
    Vector3 nextPosition;
    int index = 0;
    public float multplier=1.5f;

    void Start()
    {
        pos = new DNAPositions(100);
        nextPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(hasFinished == false) 
        { 



            if(transform.position == nextPosition)
            {
                nextPosition = (Vector3)transform.position + pos.positions[index] * multplier;
                nextPosition = new Vector3(nextPosition.x,1,nextPosition.z);
                index++;
                Debug.Log(index);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, nextPosition, 5f * Time.deltaTime);
            }
            
        }
    }
}
