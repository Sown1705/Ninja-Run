
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Replay()
    {
        if (Lose.isGameOver)
        { 
            Lose.isGameOver = false;
            SceneManager.LoadScene("Level1");
        }
        
    }
}
