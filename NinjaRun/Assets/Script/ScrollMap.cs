
using UnityEngine;

public class ScrollMap : MonoBehaviour
{
    // Start is called before the first frame update
    public float scrollSpeed = 0.5f;
    float Offset;
    public Renderer rendere;
    void Start()
    {
        rendere = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Offset += Time.deltaTime * scrollSpeed;
       rendere.material.mainTextureOffset = new Vector2(Offset, 0.01f);
    }
    
}
