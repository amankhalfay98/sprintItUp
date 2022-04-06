using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public GameObject competitor;

    private Vector3 Balance;

    // Start is called before the first frame update
    void Start()
    {
        Balance = transform.position - competitor.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = competitor.transform.position + Balance;
    }
}
