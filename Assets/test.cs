using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int targetCount = 1;
    private void Start()
    {
        while (targetCount<100)
        {
            Debug.Log("targetCount:" + targetCount);
            targetCount++;
        }
    }
}
