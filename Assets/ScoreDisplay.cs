using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "" + GameManager.instance.score;
    }
}
