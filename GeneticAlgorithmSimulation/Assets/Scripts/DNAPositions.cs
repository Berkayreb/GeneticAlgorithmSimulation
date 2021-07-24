using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNAPositions
{

    public List<Vector3> positions = new List<Vector3>();

    public DNAPositions(int len=100)
    {

        for (int i = 0; i<len;i++)
        {

            positions.Add(new Vector3(Random.Range(-1.0f,1.0f),1, Random.Range(-1.0f, 1.0f)));

        }

    }



}
