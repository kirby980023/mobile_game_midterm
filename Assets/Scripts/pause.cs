using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public GameObject pausetext;
    public GameObject XXtext;
    public GameObject Joystick;
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
       pausetext.SetActive(true);
       XXtext.SetActive(true);
       Joystick.SetActive(false);
       Pause();
    }

    private void Pause()
    {
        Time.timeScale = 0f;
    }
}
