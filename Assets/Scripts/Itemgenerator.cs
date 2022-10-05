
using UnityEngine;

public class Itemgenerator : MonoBehaviour
{
    public GameObject item;

    public float MinSpeed, MaxSpeed, CurrentSpeed, SpeedMultiplier;
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateObjeto();
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(10.0f, 15.0f);
        Invoke("generateObjeto", randomWait);
    }
    void generateObjeto()
    {
        GameObject ItemIns = Instantiate(item, transform.position, transform.rotation);
        ItemIns.GetComponent<Item>().objeto = this;

    }
    // Update is called once per frame
    void Update()
    {
        if(CurrentSpeed < MaxSpeed)
        {
            CurrentSpeed += SpeedMultiplier;
        }
    }
}
