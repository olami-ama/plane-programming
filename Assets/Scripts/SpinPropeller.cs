using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{  
    public Vector3 RotationSpeed = new Vector3(0,0,1000);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //  rotates the propeller
        transform.Rotate( RotationSpeed ) ;
    }
}
