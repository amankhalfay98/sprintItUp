using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCube : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(50, 50, 50) * Time.deltaTime);
    }
}
