using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Long_attak : MonoBehaviour
{
    public Arrow arrowPrefab;
    
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
            var collider = Physics2D.OverlapCircle(transform.position,2.0f,LayerMask.GetMask("Enemy"));
            if(collider != null)
            {
                transform.position = Quaternion.FromToRotation(Vector3.right,collider.transform.position - transform.position);
                var arrow = Instantiate(arrowPrefab,transform.position,transform.rotation);
                arrow.targetEnemy = collider.GetComponent<Enemy>();
            }
        }
    }
}
