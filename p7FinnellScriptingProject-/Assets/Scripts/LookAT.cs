using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAT : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform target;
        
    

    
    void Update()
    {
        transform.LookAt(target);
    }
}
