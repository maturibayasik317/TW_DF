using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Long_attak : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(SearchAndShot());
    }

    private IEnumerator SearchAndShot()
    {
        while(true)
        {
            //�͈͓��ɓG��������ł�
            yield return new WaitForSeconds(1.0f);
        }
    }
}
