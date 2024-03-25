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
        yield return  new WaitForSeconds(3);
        transform.gameObject.SetActive(false);
     //   transform.DOScale(Vector3.zero, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
