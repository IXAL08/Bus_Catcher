using UnityEngine; 

public class EnemigoSpawner : MonoBehaviour
{
    public GameObject spike;

    public float MinSpeed, MaxSpeed, CurrentSpeed, SpeedMultiplier;
    void Awake()
    {
        CurrentSpeed = MinSpeed;
        generateSpike();
    }

    public void GenerateNextSpikeWithGap()
    {
        float randomWait = Random.Range(1.5f, 1.7f);
        Invoke("generateSpike", randomWait);
    }
    void generateSpike()
    {
        GameObject SpikeIns = Instantiate(spike, transform.position, transform.rotation);
        SpikeIns.GetComponent<Enemigos>().spikeGenerator = this;

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
