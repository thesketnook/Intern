using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BronRun : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float maxStage;
    public float minStage;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,speed * Time.deltaTime , 0);
        if (transform.position.y >= maxStage)
        {
            speed *= -1;
        }
        if (transform.position.y <= minStage)
        {
            speed *= -1;
        }
    }
}
