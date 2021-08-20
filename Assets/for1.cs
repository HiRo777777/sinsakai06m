using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for1 : MonoBehaviour
{
    public int x;
    private int t = 0;
    public void Start()
    {
        for (int i = 0; i < x; i++)
        {
            t += i+1;
        }
        Debug.Log(t);
    }
}
