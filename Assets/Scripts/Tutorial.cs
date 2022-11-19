using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{

    public GameObject fingerTap;
    public GameObject seaweed;
   
    void Start()
    {
        StartCoroutine(FingerInfo());
    }

   
    private IEnumerator FingerInfo()
    {
        fingerTap.SetActive(true);

        yield return new WaitForSeconds(2);

        StartCoroutine(SeaweedInfo());
    }

    private IEnumerator SeaweedInfo()
    {
        fingerTap.SetActive(false);
        seaweed.SetActive(true);

        yield return new WaitForSeconds(2);

        seaweed.SetActive(false);
    }
}
