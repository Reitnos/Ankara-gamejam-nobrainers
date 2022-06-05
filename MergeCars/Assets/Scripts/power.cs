using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public int totalPower;
    public int powerVal;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.tag == "1-1")
        {
            powerVal = 3;
        }
        else if (gameObject.tag == "1-2")
        {
            powerVal = 4;
        }
        else if (gameObject.tag == "1-3")
        {
            powerVal = 5;
        }
        else if (gameObject.tag == "1-4")
        {
            powerVal = 6;
        }
        else if (gameObject.tag == "2-1")
        {
            powerVal = 7;
        }
        else if (gameObject.tag == "2-2")
        {
            powerVal = 8;
        }
        else if (gameObject.tag == "2-3")
        {
            powerVal = 9;
        }
        else if (gameObject.tag == "2-4")
        {
            powerVal = 10;
        }
        else if (gameObject.tag == "3-1")
        {
            powerVal = 11;
        }
        else if (gameObject.tag == "3-2")
        {
            powerVal = 12;
        }
        else if (gameObject.tag == "3-3")
        {
            powerVal = 13;
        }
        else if (gameObject.tag == "3-4")
        {
            powerVal = 14;
        }
        else if (gameObject.tag == "4-1")
        {
            powerVal = 15;
        }
        else if (gameObject.tag == "4-2")
        {
            Debug.Log("4-2");
            powerVal = 16;
        }
        else if (gameObject.tag == "4-3")
        {
            powerVal = 17;
        }
        else if (gameObject.tag == "4-4")
        {
            powerVal = 18;
        }

        totalPower = 200 + powerVal * 20;
        powerManager.gridPower += totalPower;
    }

    // Update is called once per frame
    
}
