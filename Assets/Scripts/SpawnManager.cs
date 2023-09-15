using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Aþagýda ki yapýyý public List<Transform> spawnPoint ile de oluþturabilir sadece burada listeleri kullanýrken aþagýda dizileri kullanýyoruz.
    public GameObject[] animalPrefab;

    float spawnX= 19f;
    float spawnZ = 28;

    float startDelay, spawnInterval = 2;


    void Start()
    {
        //Ýlk defa gördüm InvokeRepeating(Çaðýr Tekrarlanýyor)
        InvokeRepeating("SpawnRandomAnimal", startDelay,spawnInterval);
    }


    void SpawnRandomAnimal() 
    {
        //animalPrefab[animaIndex] yerine animalPrefab[Random.Range(0,3)] bu kod parçasýnýda yazabilirdik ama dizinin boyutunu artýrýp azaltýlýnca kodda deðiþiklik yapmamýz lazým


        int animaIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Instantiate(animalPrefab[animaIndex], spawnPos, animalPrefab[animaIndex].transform.rotation);
    }



}
