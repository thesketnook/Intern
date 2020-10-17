using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChEating : MonoBehaviour
{
    

   public void OnFinshEating()
    {
        //testHotfix
        GetComponent<Animator>().SetBool("chEating", false);
    }
}
