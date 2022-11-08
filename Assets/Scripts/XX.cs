using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XX : MonoBehaviour
{
    public GameObject pausetext;
    public GameObject XXtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
       pausetext.SetActive(false);
       XXtext.SetActive(false);
    }
}
