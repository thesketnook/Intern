using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoS : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGo()
    {
        SceneManager.LoadSceneAsync(0);
    }

    
}
