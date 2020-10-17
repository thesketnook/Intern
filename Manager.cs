using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text GText;
    public Text YText;
    public Text BText;
    public Text RText;
    public float Gnum =5;
    public float Ynum =5;
    public float Bnum =5;
    public float Rnum =5;


    void Start()
    {
        GText.text = ""+Gnum;
        YText.text = "" + Ynum;
        BText.text = "" + Bnum;
        RText.text = "" + Rnum;




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
