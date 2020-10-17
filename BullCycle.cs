using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BullCycle : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float maxStage;
    public float minStage;
    public GameObject PakBull;
    public Animator monAnimt;
    public GameObject monGreen;
    public Manager manaCh;
    public string chColar;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        if (transform.position.x >=maxStage)
        {
            speed *= -1;
        }
        if (transform.position.x <= minStage)
        {
            speed *= -1;
        }
    }
    private void OnMouseDrag()
    {
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        point.z = 0f;
        transform.position = point;
    }
    private void OnMouseUp()
    {
        Vector2 posPakB = PakBull.transform.position;
        Collider2D hit = Physics2D.OverlapPoint(posPakB);
        if (hit)
        {

            monAnimt.SetBool("chEating", true);

            if(chColar == "Green" && manaCh.Gnum >= 1)
            {
                manaCh.Gnum--;
                manaCh.GText.text = "" + manaCh.Gnum;
                Spown.spawn.spownBall(this.gameObject);
            }
            else if (chColar == "Yellow" && manaCh.Ynum >= 1)
            {
                manaCh.Ynum--;
                manaCh.YText.text = "" + manaCh.Ynum;
                Spown.spawn.spownBall(this.gameObject);
            }
            else if (chColar == "Bull" && manaCh.Bnum >= 1)
            {
                manaCh.Bnum--;
                manaCh.BText.text = "" + manaCh.Bnum;
                Spown.spawn.spownBall(this.gameObject);
            }
            else if (chColar == "Rad" && manaCh.Rnum >= 1)
            {
                manaCh.Rnum--;
                manaCh.RText.text = "" + manaCh.Rnum;
                Spown.spawn.spownBall(this.gameObject);
            }
            else if (manaCh.Gnum == 0 && manaCh.Ynum == 0 && manaCh.Bnum == 0 && manaCh.Rnum == 0)
            {
                SceneManager.LoadSceneAsync(1);
;            }


            //Spown.spawn.spownBall(this.gameObject);

            Destroy(gameObject);
        }
    } 
   

}
