using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI textTMesH;
    private double scoreT;
    // Start is called before the first frame update
    void Start()
    {
        textTMesH = GetComponent<TextMeshProUGUI> ();
        scoreT = 10;
    }

    // Update is called once per frame
    void Update()
    {
        textTMesH.text = "T " + scoreT.ToString();
        if(Input.GetKey("mouse 0") && scoreT != 50){
        scoreT += 10;
        }
    }
}
