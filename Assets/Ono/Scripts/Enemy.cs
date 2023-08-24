using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    void Update()
    {
        transform.position += new Vector3(0, 0, 1) * Time.deltaTime;
    }
}
