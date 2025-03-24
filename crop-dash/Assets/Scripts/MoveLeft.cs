using UnityEngine;
using UnityEngine.UIElements;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20.0f;
    private float leftBound = -15;
    private PlayerController playerController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.gameOver == false) 
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound) 
        { 
            Destroy(gameObject);
        }
    }
}
