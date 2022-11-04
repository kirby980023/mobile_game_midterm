using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static float atk = 25;
    public float speed = 30f;
    private Rigidbody rb;

    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Scenes")
        {
        //    Bullet bullet = other.GetComponent<Bullet>();

           gameObject.SetActive(false);
           Destroy(gameObject);
        }
    }
}

