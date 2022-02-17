
using UnityEngine;
using UnityEngine.UI;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameover,player;
    public Text scoreGameOver, highScore;
    public static bool isGameOver = false;
    void Start()
    {
       // PlayerPrefs.SetInt("highScore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < -5.5f || player.transform.position.x < -9.01f)
        {
            int scores = PlayerPrefs.GetInt("highScore");
            scoreGameOver.text = "Score : " + PlayerController.scoreCount;
            if (PlayerController.scoreCount > scores)
            {
                PlayerPrefs.SetInt("highScore", PlayerController.scoreCount);

            }

            highScore.text = "High Score : " + PlayerPrefs.GetInt("highScore"); ;
            gameover.SetActive(true);
            isGameOver = true;
        }
    }
}
