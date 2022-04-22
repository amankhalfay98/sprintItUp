using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseballUpdater : MonoBehaviour
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
                          Debug.Log(anglesToRotate);
            this.transform.Rotate(anglesToRotate * Time.deltaTime);
        
      
        }
    }
}
