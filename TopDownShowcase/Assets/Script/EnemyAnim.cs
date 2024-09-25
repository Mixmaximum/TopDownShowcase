using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class EnemyAnim : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<Animator>().SetFloat("x", GetComponent<Rigidbody2D>().velocity.x);
        GetComponent<Animator>().SetFloat("y", GetComponent<Rigidbody2D>().velocity.y);
    }
}
