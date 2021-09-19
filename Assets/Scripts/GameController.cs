using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    public Text TextController;
    public int BallNubmer;
  
    

    // Start is called before the first frame update
    void Start()
    {
       
        InvokeRepeating("AddABall", 1.0F, 1.0F);
        
    }

   public virtual int count(int ballnumber)
    {
        return BallNubmer;
    }


    void AddABall()
    {
        Instantiate(OneBallPrefab);
        TextController.text = BallNubmer.ToString();
        BallNubmer += 1;

    }
    // Update is called once per frame
    void Update()
    {
  
       
        
       
    }
}
