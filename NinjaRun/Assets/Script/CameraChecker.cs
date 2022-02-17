
using System.Collections.Generic;
using UnityEngine;

public class CameraChecker : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    List<float> positions = new List<float>();
    float currentPlayerPos = 0;
    private float HeightMove = 1;

    void Start()
    {
        if (Player != null)
        {
            currentPlayerPos = Player.transform.position.y;
            HeightMove = 2.6f * (float)Mathf.Abs(Player.transform.position.y - transform.position.y);
            positions.Add(transform.position.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            if (currentPlayerPos + HeightMove < Player.transform.position.y)
            {
                Vector3 pos = transform.position;
                pos.y = positions[0] + HeightMove / 2;
                transform.position = pos;
            }
            else
            {
                Vector3 pos = transform.position;
                pos.y = positions[0] ;
                transform.position = pos;
            }
        }
        
    }
}
