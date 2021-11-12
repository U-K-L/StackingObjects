using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("space"))
            transform.position += new Vector3(0.0f, 0.0f, 5*Mathf.Sin(Time.time*2))*Time.deltaTime;
        if (Input.GetKey("z"))
            transform.position += new Vector3(5 * Mathf.Cos(Time.time * 2), 0.0f, 5 * Mathf.Sin(Time.time * 2)) * Time.deltaTime;
    }
}
