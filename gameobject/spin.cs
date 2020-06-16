/*
This script spins a gameobject around its axis.
It spins using eulerAngles from a Quaternion, so i'ts not perfect rotation.
But it performs well with the Y axis, one of the most usefull rotation to inspect objects.
Feel free to update and improve this script!
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    public Vector3 current;
    public Vector3 destination;
    //Set "true" from the inspector to start spinning
    public bool spinX, spinY, spinZ = false;
    
    public float spinValX, spinValY, spinValZ = 0.0f;
    public Vector3 spinSpeed = new Vector3(0.1f, 0.1f, 0.1f);
    public float time;
    
    //Change this value from the inspector to change spin/rotation velocity
    public Vector3 currentVelocity = new Vector3(0,0,0);
    
    public float smooth = 0.5f;
    public Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
        time = Time.deltaTime;
    }

       void Update()
    {
        tiggerSpinAxis();
        current = this.gameObject.transform.rotation.eulerAngles;
        destination = new Vector3(current.x+ spinValX, current.y+ spinValY, current.z+ spinValZ);
        rotation.eulerAngles = Vector3.SmoothDamp(current, destination, ref currentVelocity, time * smooth); ;
        this.gameObject.transform.rotation = rotation;
    }

    void tiggerSpinAxis()
    {
        //X Axys
        if (spinX)
        {
            spinValX= spinSpeed.x;
        }
        else
        {
            spinValX = 0;
        }

        //Y Axys
        if (spinY)
        {
            spinValY = spinSpeed.y;
        }
        else
        {
            spinValY = 0;
        }

        //Z Axys
        if (spinZ)
        {
            spinValZ = spinSpeed.z;
        }
        else
        {
            spinValZ = 0;
        }
    }

    public void toggleSpinX()
    {
        if (spinX)
        {
            spinX = false;
        } else
        {
            spinX = true;
        }
    }

    public void toggleSpinY()
    {
        if (spinX)
        {
            spinY = false;
        }
        else
        {
            spinY = true;
        }
    }

    public void toggleSpinZ()
    {
        if (spinX)
        {
            spinZ = false;
        }
        else
        {
            spinZ = true;
        }
    }
}
