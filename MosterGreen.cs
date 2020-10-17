using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MosterGreen : MonoBehaviour

{
    public Animator greenAnim;
    public void oneat()
    {
        greenAnim.SetBool("chEating", true);
    }
}
