using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TScoreUpdater : MonoBehaviour
{
    private TextMeshProUGUI textTMesH;
    public double scoreT;
    // Start is called before the first frame update
    void Start()
    {
        textTMesH = GetComponent<TextMeshProUGUI> ();
        scoreT = 20;
    }

    // Update is called once per frame
    void Update()
    {
        textTMesH.text = "T " + scoreT.ToString();
    }
}
