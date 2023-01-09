using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quatquay : MonoBehaviour
{
    float tocdo = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            tocdo = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            tocdo = 200.0f;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            tocdo = 400.0f;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            tocdo = 600.0f;
        }

        transform.Rotate(0, 0, tocdo * Time.deltaTime);
    }
}
