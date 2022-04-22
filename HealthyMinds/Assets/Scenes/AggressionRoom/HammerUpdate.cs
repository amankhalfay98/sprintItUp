using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HammerUpdate : MonoBehaviour
{
    public Vector3 anglesToRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   	RaycastHit hit;
   	// Casts the ray and get the first game object hit
   	Physics.Raycast(ray, out hit);
   	Debug.Log("This hit at " + hit.point );
            // Debug.Log(anglesToRotate);
            // this.transform.Rotate(anglesToRotate * Time.deltaTime);
        }
    }
}
