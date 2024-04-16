using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(hideTutorial());
    }

    private IEnumerator hideTutorial()
    {
        yield return  new WaitForSeconds(5);
        transform.gameObject.SetActive(false);
   
    }

   
}
