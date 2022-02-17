

using UnityEngine;

public class WallController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 5f;
    public GameObject[] wallArray;
    public GameObject Wall_A;
    public GameObject Wall_B;
    public GameObject Wall_C;
    public GameObject Wall_D;
    public GameObject Wall_E;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   
    {
        
        Wall_A.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        Wall_B.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        Wall_C.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        Wall_D.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        Wall_E.transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (Wall_A.transform.position.x < -12.50f)
        {
            Destroy(Wall_A);
            Wall_A = Instantiate(wallArray[Random.Range(0, 1)], new Vector3(6.5f, Random.Range(-7, -4), 0), transform.rotation); 
        }
        if (Wall_B.transform.position.x < -12.50f)
        {
            Destroy(Wall_B);
            Wall_B = Instantiate(wallArray[Random.Range(0, 1)], new Vector3(6.6f, Random.Range(-7, -4), 0), transform.rotation);
        }
        if (Wall_C.transform.position.x < -12.50f)
        {
            Destroy(Wall_C);
            Wall_C = Instantiate(wallArray[Random.Range(0, 1)], new Vector3(6.7f, Random.Range(-7, -4), 0), transform.rotation);
        }
        if (Wall_D.transform.position.x < -12.50f)
        {
            Destroy(Wall_D);
            Wall_D = Instantiate(wallArray[Random.Range(0, 1)], new Vector3(6.8f, Random.Range(-7, -4), 0), transform.rotation);
        }
        if (Wall_E.transform.position.x < -12.50f)
        {
            Destroy(Wall_E);
            Wall_E = Instantiate(wallArray[Random.Range(0,1)], new Vector3(6.9f, Random.Range(-7, -4), 0), transform.rotation);
        }
    }
}
