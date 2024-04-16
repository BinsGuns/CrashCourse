using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public Transform EndPoint;
    public bool canMove;
    public float speed;
    // Start is called before the first frame update

    
    // Update is called once per frame
    void Update()
    { 
        if(canMove)
            transform.DOMove(EndPoint.transform.position, speed);
    }

  
}
