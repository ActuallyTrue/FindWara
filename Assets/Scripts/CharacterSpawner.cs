using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject Wara;
    public GameObject[] Characters;
    public float lowestSpeed;
    public float highestSpeed;
    public int spawnCount;

    public void SpawnCharacters()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomIndex = Random.Range(0,Characters.Length);
            SpawnPrefab(Characters[randomIndex]);
        }

        SpawnPrefab(Wara);
    }

    void SpawnPrefab(GameObject prefab)
    {
        Vector2 randomPosition = new Vector2(Random.Range(-4.0f,5.0f), Random.Range(-4.0f,5.0f));
        float xSpeed = Random.Range(lowestSpeed, highestSpeed);
        float ySpeed = Random.Range(lowestSpeed, highestSpeed);
        Vector2 randomVelocity = new Vector2(Random.Range(0,2) == 0 ? -1 * xSpeed : 1 * xSpeed, Random.Range(0,2) == 0 ? -1 * ySpeed : 1 * ySpeed);
        Rigidbody2D rb = Instantiate(prefab).GetComponent<Rigidbody2D>();
        rb.linearVelocity = randomVelocity;
    }
}
