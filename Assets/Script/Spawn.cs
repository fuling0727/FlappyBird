using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    static int objectNumber = 2;   
    public GameObject[] objectToSpawn = new GameObject[objectNumber];
    
    private float timerCreatePipe = 0.0f;
    private float timerDeletePipe = 0.0f;

    //Queue objectQueue = new Queue();

    void Start()
    {
        GameObject newObject = Instantiate(objectToSpawn[0], new Vector3(743.3f, 190.4f, 4.0f), Quaternion.identity);
        GameStatus.objectQueue.Enqueue(newObject);

        timerCreatePipe = 0;
        timerDeletePipe = 0;
    }
    private void Update()
    {
        timerCreatePipe += Time.deltaTime;
        timerDeletePipe += Time.deltaTime;
        

        if ((int)timerCreatePipe == 5) // randomly create new pipes
        {
            int randomNumber = Random.Range(0, objectNumber);
            
            GameObject newObject = Instantiate(objectToSpawn[randomNumber], new Vector3(743.3f, 190.4f, 4.0f), Quaternion.identity);
            GameStatus.objectQueue.Enqueue(newObject);
            
            timerCreatePipe = 0;

        }
        
        /*if ((int)timerDeletePipe == 8) // Delete pipes that already passby
        {
            GameObject deleteObject = (GameObject)GameStatus.objectQueue.Dequeue();
            Destroy(deleteObject);
            timerDeletePipe = 0;
        }*/
        
    }
}
