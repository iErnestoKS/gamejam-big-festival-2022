using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print($" rotation: {transform.rotation}");
        print($" Euler: {transform.rotation.eulerAngles}");
    }
}