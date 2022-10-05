
using UnityEngine;

public class Item : MonoBehaviour
{
    public Itemgenerator objeto;
    
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * (objeto.CurrentSpeed * Time.deltaTime));
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("nextLine"))
        {
            objeto.GenerateNextSpikeWithGap();
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
