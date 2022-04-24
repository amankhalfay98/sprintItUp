using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI textMesH;
    public double score;
    public TScoreUpdater tScoreUpodater;
    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI> ();
        tScoreUpodater = GameObject.FindObjectOfType<TScoreUpdater>();
        score = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = "A " + score.ToString();
        if(Input.GetKey("mouse 0") && score != 0){
        score-= (tScoreUpodater.scoreT -10);
        }

        if(score==0){
            textMesH.text = "You won!";
        }
    }
}