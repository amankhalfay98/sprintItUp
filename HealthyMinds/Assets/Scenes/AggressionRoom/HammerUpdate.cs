using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HammerUpdate : MonoBehaviour
{
    public Vector3 anglesToRotate;
    [SerializeField] private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
      if(Physics.Raycast(ray,out RaycastHit raycastHit)){
          transform.position = raycastHit.point;
      }

if(Input.GetKey("mouse 0")){
            Debug.Log(anglesToRotate);
            this.transform.Rotate(anglesToRotate * Time.deltaTime);
        }
    }
}
