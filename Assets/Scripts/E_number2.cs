using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class E_number2 : MonoBehaviour
{
    public static int enemynumber;
    public Text Showenemynumber;
    // Start is called before the first frame update
    void Start()
    {
      enemynumber = 13;
   
    }

    // Update is called once per frame
    void Update()
    {
        Showenemynumber.text = enemynumber.ToString();
    }
}

