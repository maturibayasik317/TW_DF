using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kara : MonoBehaviour
{
    public int hp;

    public float speed;

    public int gold;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        var v = Vector3.right;//ˆÚ“®•ûŒü¡‰ñ‚Í‰E

        transform.position += v *

            speed * Time.deltaTime;
    }
}
