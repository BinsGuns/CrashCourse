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
    void Start()
    {   
        if(canMove)
            transform.DOMove(new Vector3(transform.position.x,transform.position.y,EndPoint.position.z), speed);
    }
    
    
    // Update is called once per frame
    void Update()
    { 
        if(canMove)
            transform.DOMove(new Vector3(transform.position.x,transform.position.y,EndPoint.position.z), speed);

    }

    public void moveCar()
    {
       
    }
}
