using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    float MaxX;

    [SerializeField]
    float SpawnInterval;

    public GameObject[] Candies;
    public static CandySpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        // SpawnCandy();
        StartSpawningCandies();
    }

    void Update()
    {

    }

    //Funcja odpowiedzialna za respawn nowych cukierków
    void SpawnCandy()
    {
        int rand = Random.Range(0, Candies.Length);

        //Ustawiamy randomowy spawn cukierków
        float randomX = Random.Range(-MaxX, MaxX);
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(Candies[rand], randomPos, transform.rotation);
    }

    IEnumerator Spawner()
    {
        //Zatrzymuje spawn cukierków na 2s
        yield return new WaitForSeconds(2f);

        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(SpawnInterval);
        }
    }

        //Start CoRoutine
        public void StartSpawningCandies()
        {
            StartCoroutine("Spawner");
        }

        //Stop CoRoutine
        public void StopSpawningCandies()
        {
            StopCoroutine("Spawner");
        }
    }

