using UnityEngine;

public class AlienSpecies : MonoBehaviour
{
    public string speciesName;
    public Color skinColor;
    public float size;
    public float mutationRate;

    void Start()
    {
        // Randomize initial traits
        skinColor = new Color(Random.value, Random.value, Random.value);
        size = Random.Range(0.5f, 2.0f);
        mutationRate = Random.Range(0.01f, 0.1f);
    }

    void Update()
    {
        // Placeholder for evolution logic
        // Example: Mutate trait over time
        if (Random.value < mutationRate * Time.deltaTime)
        {
            size += Random.Range(-0.05f, 0.05f);
            skinColor = new Color(Random.value, Random.value, Random.value);
        }
    }
}
