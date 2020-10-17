using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChEating : MonoBehaviour
{
    

   public void OnFinshEating()
    {
        //testRelese
        GetComponent<Animator>().SetBool("chEating", false);
    }
}
