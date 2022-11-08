using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HP_number : MonoBehaviour
{
    public static int HPnumber;
    public Text ShowHPnumber;
    // Start is called before the first frame update
    void Start()
    {
        HPnumber=3;
    }

    // Update is called once per frame
    void Update()
    {
        ShowHPnumber.text = HPnumber.ToString();
    }
}
