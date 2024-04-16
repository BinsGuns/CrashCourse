using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CheckPoint : MonoBehaviour
{
    public GameObject question;
    private PlayerInput _playerInput;
    public List<MoveCar> MoveCars;

    public MoveCar moveCar;
    // Start is called before the first frame update
    void Start()
    {
        _playerInput = GameObject.FindWithTag("Player").GetComponent<PlayerInput>();
        question.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerInput.enabled = false;
          
            question.SetActive(true);

            if (MoveCars.Count > 0)
            {
                StartCoroutine(moveForward());
            }
        }
    }
    
    private IEnumerator moveForward()
    {
        foreach (var cars in MoveCars)
        {
            
            yield return  new WaitForSeconds(2);
            cars.canMove = true;
          
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
            question.SetActive(false);
    }
}
