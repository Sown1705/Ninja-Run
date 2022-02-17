
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject gamePause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Pause()
    {
        Time.timeScale = 0;
        gamePause.SetActive(true);
    }

    public void Remuse()
    {
        Debug.Log("remuse");
        Time.timeScale = 1;
        gamePause.SetActive(false);
    }
    public void Home()
    {
        Debug.Log("Home");
        SceneManager.LoadScene("IntroGame");
    }
}
