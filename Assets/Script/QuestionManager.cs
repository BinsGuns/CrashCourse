using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class QuestionManager : MonoBehaviour
{

    public GameObject CorrectPanel;
    public GameObject WrongPanel;
    public Transform policeFollow;
    private PlayerInput _playerInput;
    public string CorrectLetter;

    public GameObject policeCar;
    // Start is called before the first frame update
    void Start()
    {
        _playerInput = GameObject.FindWithTag("Player").GetComponent<PlayerInput>();
        CorrectPanel.SetActive(false);
        WrongPanel.SetActive(false);
    }

    public void OnAnswer(string letter)
    {
        if (letter.ToLower() == CorrectLetter.ToLower())
        {
            CorrectPanel.SetActive(true);
            StartCoroutine(showCorrectPanel());
        }
        else
        {
            WrongPanel.SetActive(true);
            policeCar.transform.DOMove(policeFollow.position, 2f);
            StartCoroutine(showWrongPanel());
        }
    }
    
    private IEnumerator showCorrectPanel()
    {
        yield return  new WaitForSeconds(2);
        CorrectPanel.SetActive(false);
        _playerInput.enabled = true;
    }
    
    private IEnumerator showWrongPanel()
    {
        CorrectPanel.SetActive(false);
        yield return  new WaitForSeconds(3);
        _playerInput.enabled = true;
        SceneManager.LoadScene(0);
    }
}
