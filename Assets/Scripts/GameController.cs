using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public GameObject OneBallPrefab;
    public Text TextController;
    public Text TextScoreController;
    public int BallNubmer;
    public int Score = 0;
    public bool GameOver = true;
    public Button PlayAgainButton;

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
        if (!GameOver)
        {
            
            Instantiate(OneBallPrefab);
            BallNubmer += 1;
            TextController.text = $"BALLS: {BallNubmer}";
            
        }
        else
        {
            TextController.text = "Press Start Button";
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void ClickedOnBall()
    {
        Score++;
        BallNubmer--;
        

        if (BallNubmer <= 0)
        {
            GameOver = true;
            PlayAgainButton.gameObject.SetActive(true);
        }
        else
        {
            if (BallNubmer > 20)
            {
                GameOver = true;
                PlayAgainButton.gameObject.SetActive(true);
                TextController.text = "Game Over too many balls";
            }

        }
        TextScoreController.text = $"SOCRE: {Score}";
    }
    public void StartNewGame()
    {
        
        Score = 0;
        BallNubmer = 0;
        GameOver = false;
        PlayAgainButton.gameObject.SetActive(false);
        TextController.text = "Press Start Button";
        foreach (GameObject OneBallPrefab in GameObject.FindGameObjectsWithTag ("GameController"))
        {
            Destroy(OneBallPrefab);
        }

   
    }
}
