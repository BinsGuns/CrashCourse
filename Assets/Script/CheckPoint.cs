using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject question;

    public List<MoveCar> MoveCars;
    // Start is called before the first frame update
    void Start()
    {
        question.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            question.SetActive(true);
            foreach (var cars in MoveCars)
            {
                cars.canMove = true;
              //  cars.moveCar();
            }
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            question.SetActive(false);
    }
}
