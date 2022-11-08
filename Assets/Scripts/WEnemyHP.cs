using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEnemyHP : MonoBehaviour
{
    private float hp = 200f;
    private GameObject focusPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GameObject[] Players = GameObject.FindGameObjectsWithTag("Player");

        // float miniDist = 9999;
        // foreach (GameObject Player in Players)
        // {
        //     // 計算距離
        //     float d = Vector3.Distance(transform.position, Player.transform.position);

        //     // 跟上一個最近的比較，有比較小就記錄下來
        //     if (d < miniDist)
        //     {
        //         miniDist = d;
        //         focusPlayer = Player;
        //     }
        // }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Arrow")
        {
           Bullet bullet = other.GetComponent<Bullet>();

           hp -= Bullet.atk;

           if (hp <= 0)
           {
                E_number2.enemynumber = E_number2.enemynumber - 1;
                gameObject.SetActive(false);
                Destroy(gameObject);
           }
        }
    }
}
