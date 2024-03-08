using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PropellerSpinning : MonoBehaviour
{


    private Vector3 spin = new Vector3(3, 4, 900);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // To rotate Propeller
        transform.Rotate(spin * Time.deltaTime);
    }
}
