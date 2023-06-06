using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Bird : MonoBehaviour
{

    public float jumpHeight = 350;
    
    public Rigidbody2D rb;
    [SerializeField] private string gameOver = "GameOver";

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 4;
        
    }
    void Update()
    {
        Vector3 pos = transform.position;
        
        if (Input.GetButtonDown("Jump"))
        {
            
            pos.y += jumpHeight;
            rb.velocity = new Vector2(0.0f, 0.0f); ;
            
        }
        
        transform.position = pos;


    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        Bird bird = collision.collider.GetComponent<Bird>();
        if(bird == null)
        {
            //Debug.Log("collision");
            SceneManager.LoadScene(gameOver);
            GameStatus.score = 0;
        }
    }



}
