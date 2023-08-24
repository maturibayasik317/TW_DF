/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Enemy targetEnemy;
    private float speed = 10;

    private void Update()
    {
        if(targetEnemy == null)
        {
            Destroy(gameObject);
            return;
        } 
        var v = targetEnemy.transform.position - transform.position;
        transform.position += v.normalized * speed * Time.deltaTime;
        //ìGÇ∆ÇÃãóó£Ç≈ÇOÅDÇVÇÜñ¢ñûÇ≈ìñÇΩÇ¡ÇΩÇ∆Ç›Ç»Ç∑
        /*if(v.magniude < 0.7f)
        {
            targetEnemy.hp -= 1;
            if(targetEnemy.hp <= 0)
            {
                Destroy(targetEnemy.gameObject);
            }
            Destroy(gameObject);
        }*/
    }
    
    
}*/
