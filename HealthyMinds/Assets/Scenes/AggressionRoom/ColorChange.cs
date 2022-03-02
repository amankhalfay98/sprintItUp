using UnityEngine;
 using System.Collections;
 
 public class ColorChange : MonoBehaviour {
 
     private GameObject Cube;
     Color[] colors = new Color[] {Color.white, Color.red, Color.green, Color.blue};
 
     // Use this for initialization
     void Start () {
 
         Cube = GameObject.Find("Cube");
     }
     
     // Update is called once per frame
     void Update () {
 
         if(Input.GetMouseButtonDown(0)){
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
             if (Physics.Raycast(ray, out hit, 100)){
                 if(hit.transform.name=="Cube"){
                     Color goColor = Cube.GetComponent<Renderer>().material.color;
                     for(int i = 0; i < colors.Length; i++){
                         if(goColor == colors[i] && i == colors.Length - 1){
                             Cube.GetComponent<Renderer>().material.color = colors[0];
                             return;
                         }
                         else{
                             Cube.GetComponent<Renderer>().material.color = colors[i+1];
                             return;
     }
 }
                 }
             }
         }
     }
 }
 