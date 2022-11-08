using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    private float passedTime = 0; 
    private float timerInterval = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
          passedTime += Time.deltaTime;

        if (passedTime >= timerInterval)
        {

            transform.localPosition += new Vector3(-0.5f, 0, 0) * Time.deltaTime; 

            passedTime = 0;
            
        }      
    }
}
