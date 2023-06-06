using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    // Start is called before the first frame update
    
    static public int score;
    [SerializeField] TextMeshProUGUI scoreText;
    static public Vector3 curLocation;
    static public Queue objectQueue = new Queue();

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
