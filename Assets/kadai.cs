using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kadai : MonoBehaviour
{
    public int x;
    private int targetCount = 0;
    private int total = 0;
    private void Start()
    {
        while(targetCount<x)
        {
            targetCount++;
            total += targetCount;
            
        }
        Debug.Log(total);

    }
}
