using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public Vector3 offSet = new Vector3 (0, 0, -10);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = offSet;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
