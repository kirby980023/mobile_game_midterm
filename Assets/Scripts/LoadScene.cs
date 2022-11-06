using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Text loadingText;
    public Image progressBar; 
    private int curProgressValue = 0;
    private float deadDelay = 1.5f;
    private float deadDelayTimer = 0;

    void FixedUpdate()
    {
        int progressValue = 100;

        if (curProgressValue < progressValue)
        {
            curProgressValue++;
        }

        loadingText.text = "Loading..." + curProgressValue + "%";
   
        progressBar.fillAmount = curProgressValue / 100f;

        if (curProgressValue == 100)
        {

            loadingText.text = "   OK!   "; 

            deadDelayTimer += Time.deltaTime;

            if (deadDelayTimer >= deadDelay)
            {
                SceneManager.LoadScene ("menu");
            }
        }
    }  
}