using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public float score=0;
    public Text scoreText;

    
    void OnTriggerEnter(Collider collider)
    {
        //increase score by one
        score++;
        
        //update display
        scoreText.text = score.ToString();
        
        
    }
}
