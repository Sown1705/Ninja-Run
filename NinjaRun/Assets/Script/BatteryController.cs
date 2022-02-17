
using UnityEngine;
using UnityEngine.UI;

public class BatteryController : MonoBehaviour
{
    public static BatteryController instance;
    // Start is called before the first frame update
    public Sprite[] batteries;
    public Image img;
    public int count = 0;
    GameObject battery;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        img = gameObject.GetComponent<Image>();
        battery = GameObject.Find("battery");
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 1)
        {
            img.sprite = batteries[0];
        }
        else if (count == 2)
        {
            img.sprite = batteries[1];
        }
        else if (count == 3)
        {
            img.sprite = batteries[2];
        }
        else if (count == 4)
        {
            img.sprite = batteries[3];

        }

    }
}
