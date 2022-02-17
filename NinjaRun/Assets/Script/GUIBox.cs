using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GUIBox : MonoBehaviour
{
    // Start is called before the first frame update
    int width, height;
    void Start()
    {
        width = Screen.width;
        height = Screen.height;
    }
    private void OnGUI()
    {
        //(((width/2)-250)/2-50)
        GUI.Box(new Rect(((width / 2) - 250), ((height / 2) - 200), 500, 400), "SONHANDSOME");//rect(vị trí x đầu tiên để vẽ, vị trí y đầu tiên để vẽ,chiều dài, chiều rộng)
       if (GUI.Button(new Rect((width / 2)-100, (height / 2)-15, 200, 30), "Hello")) { 
        
            Debug.Log("Xin chào !♥");
            SceneManager.LoadScene("Level1");
        }
        if (GUI.Button(new Rect((width / 2) - 100, (height / 2)+15, 200, 30), "Exit"))
        {
            Application.Quit();
            Debug.Log("Tạm biệt !♥");
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
