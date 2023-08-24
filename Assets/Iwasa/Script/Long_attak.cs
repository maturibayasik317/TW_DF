using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Long_attak : MonoBehaviour
{
<<<<<<< HEAD
=======
    public Arrow arrowPrefab;
    
>>>>>>> b8a2f3a4682fd50923f999201252652bad9e02a0
    void Start()
    {
        StartCoroutine(SearchAndShot());
    }

    private IEnumerator SearchAndShot()
    {
        while(true)
        {
            // ここで敵を探して撃つ
            yield return new WaitForSeconds(1.0f);
<<<<<<< HEAD
	    var collider = Physics2D.OverlapCircle(transform.position,2.0f,LayerMask.GetMask("Enemy"));
        if(collider != null)
        {
            Destroy(collider.gameObject);
        }
=======
            var collider = Physics2D.OverlapCircle(transform.position,2.0f,LayerMask.GetMask("Enemy"));
           /* if(collider != null)
            {
                transform.position = Quaternion.FromToRotation(Vector3.right,collider.transform.position - transform.position);
                var arrow = Instantiate(arrowPrefab,transform.position,transform.rotation);
                arrow.targetEnemy = collider.GetComponent<Enemy>();
            }*/
>>>>>>> b8a2f3a4682fd50923f999201252652bad9e02a0
        }
    }
}
