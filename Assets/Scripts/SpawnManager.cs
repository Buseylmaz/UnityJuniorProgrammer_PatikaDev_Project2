using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //A�ag�da ki yap�y� public List<Transform> spawnPoint ile de olu�turabilir sadece burada listeleri kullan�rken a�ag�da dizileri kullan�yoruz.
    public GameObject[] animalPrefab;

    float spawnX= 19f;
    float spawnZ = 28;

    float startDelay, spawnInterval = 2;


    void Start()
    {
        //�lk defa g�rd�m InvokeRepeating(�a��r Tekrarlan�yor)
        InvokeRepeating("SpawnRandomAnimal", startDelay,spawnInterval);
    }


    void SpawnRandomAnimal() 
    {
        //animalPrefab[animaIndex] yerine animalPrefab[Random.Range(0,3)] bu kod par�as�n�da yazabilirdik ama dizinin boyutunu art�r�p azalt�l�nca kodda de�i�iklik yapmam�z laz�m


        int animaIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Instantiate(animalPrefab[animaIndex], spawnPos, animalPrefab[animaIndex].transform.rotation);
    }



}
