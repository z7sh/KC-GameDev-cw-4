using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CookieClicker1 : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
     public void CookiePress()
    {
        score++;
        scoreText.text ="Score " + score.ToString();
    }
     

   
}
