using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D player;
    public Animator anim;
    int isJump=0;
    public Text score;
    public static int scoreCount=0;

    float jump = 8f;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isJump = 2;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coins")
        {
            scoreCount++;
            Destroy(collision.gameObject);
            score.text = "Score : " + scoreCount;
        }
        if (collision.gameObject.tag == "battery")
        {
            BatteryController.instance.count++;
            Destroy(collision.gameObject);
        }
    }
    void Update()
    {
        //player.transform.Translate(Vector3.right  * Time.deltaTime);nhân vật tự di chuyển
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if(isJump>0)
            {
                anim.SetBool("isRunning", false);
                anim.SetBool("isJumping", true);
                player.velocity = new Vector2(player.velocity.x, jump);
                isJump -=1;
            }
            else if (isJump == 0)
            {
                return;
            }
        }

        else
        {
            anim.SetBool("isRunning", true);
            anim.SetBool("isJumping", false);
        }
        
    }
}
