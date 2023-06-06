using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;


public class PipeController : MonoBehaviour
{

    private float movingSpeed;
    public bool isScore = false;

    void Start()
    {
        movingSpeed = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= movingSpeed;

        transform.position = pos;
        

        if (transform.position.x < 10.0f && isScore == false)
        {
            //Debug.Log(GameStatus.score);

            GameStatus.score += 1;
            
            isScore = true;
        }
        if (transform.position.x < -150.0f) // Delete the pipes that are already passed by.
        {
            GameObject deleteObject = (GameObject)GameStatus.objectQueue.Dequeue();
            Destroy(deleteObject);
        }

        
    }
}
