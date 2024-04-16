using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int sceneIndex;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        StartCoroutine(NextSceneGo());
     
    }
    
    private IEnumerator NextSceneGo()
    {
        yield return  new WaitForSeconds(3);
        SceneManager.LoadScene(sceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
