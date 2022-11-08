using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GEnemyHP : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private CharacterController controller;
    private float hp = 150f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();

        // 開始一直射擊的 Coroutine 函式
        StartCoroutine(KeepShooting());
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
     void Fire()
    {
        // 產生出子彈
        Instantiate(bulletPrefab, firePoint.transform.position, transform.rotation);
    }


    // 一直射擊的 Coroutine 函式
    IEnumerator KeepShooting()
    {
        while (true)
        {
            Fire();

            yield return new WaitForSeconds(1.3f);
        }
    }
}
