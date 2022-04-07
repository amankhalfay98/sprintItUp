using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI textMesH;
    private double score;
    // Start is called before the first frame update
    void Start()
    {
        textMesH = GetComponent<TextMeshProUGUI> ();
        score = 100;
    }

    // Update is called once per frame
    void Update()
    {
        textMesH.text = "A " + score.ToString();
        if(Input.GetKey("mouse 0") && score != 0){
        score-= 0.5;
        }
    }
}
