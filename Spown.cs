using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{

    // Start is called before the first frame update
    
    public Transform pointSpawn;


    static public Spown spawn;
    private void Start() { 
        spawn = this;
}
    public void spownBall(GameObject sapwnname)
    {
        Instantiate(sapwnname, pointSpawn.position, Quaternion.identity);
<<<<<<< HEAD
        //tiweslesr
=======
        //test
>>>>>>> feature/tiw

    }
}
