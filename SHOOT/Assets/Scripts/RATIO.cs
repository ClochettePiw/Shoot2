using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RATIO : MonoBehaviour
{
    public float counter = 0;
    public float lerpSpeed;
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        counter += Time.deltaTime;
        transform.localScale = Vector3.Lerp(Vector3.zero, new Vector3(2,2,2), counter * 0.5f);
        if (transform.localScale.x >= 1)
        {
            Debug.Log("RATIOED");
            Destroy(gameObject.transform.parent); 
            Destroy(gameObject);
        }
            
            
            
            
    }
}
