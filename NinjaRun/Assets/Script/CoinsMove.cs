
using UnityEngine;

public class CoinsMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D cdn;
    void Start()
    {
        cdn = GetComponent<Rigidbody2D>();
    }
   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "trai")
        {
            Debug.Log("final");
            Destroy(collision.gameObject);
        }
    }*/
    // Update is called once per frame
    void Update()
    {
        cdn.velocity = new Vector2(transform.localScale.x,0)*-3f;
    }
}
