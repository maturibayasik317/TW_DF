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
            //”ÍˆÍ“à‚É“G‚ª‚¢‚½‚ç‘Å‚Â
            yield return new WaitForSeconds(1.0f);
        }
    }
}
