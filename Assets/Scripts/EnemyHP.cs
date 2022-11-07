using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{  
    private float hp = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Arrow")
        {
           Bullet bullet = other.GetComponent<Bullet>();

           hp -= Bullet.atk;

           if (hp <= 0)
           {
                gameObject.SetActive(false);
                Destroy(gameObject);

           }
        }
    }
 }

