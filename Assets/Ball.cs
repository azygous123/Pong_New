using System.IO;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float startingSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetBallLocation();
    }

    // Update is called once per frame
    void Update()
    {
        float ballLocationx = transform.position.x;
        float ballLocationy = transform.position.y;

        // Reset ball if it goes out of bounds
        if (ballLocationx < -10.3f || ballLocationx > 10.3f)
        {
            ResetBallLocation();
        }
    }

    private void ResetBallLocation()
    {
        rb.transform.position = new Vector2(0f, 0f);

        bool isRight = UnityEngine.Random.value >= 0.5;

        // Set initial velocity to the left or right randomly
        float xVelocity = -1f;

        if (isRight)
        {
            xVelocity = 1f;
        }

        // Random y velocity between -1 and 1

        float yVelocity = UnityEngine.Random.Range(-1, 1);


        rb.linearVelocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed * 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float ballLocationx = transform.position.x;
        float ballLocationy = transform.position.y;
        float paddleLocationy = collision.transform.position.y;
        float difference = ballLocationy - paddleLocationy;
        //float halfPaddleHeight = collision.collider.bounds.extents.y;
        //float normalizedHit = difference / halfPaddleHeight;

        Paddle paddle = collision.gameObject.GetComponent<Paddle>();
        if (paddle != null)
        {
             //Increase ball speed by 10% upon collision with Player1
            //rb.linearVelocity = rb.linearVelocity * 1.1f;
            Debug.Log("Ball collided with paddle");
            Debug.Log("Ball x" + ballLocationx.ToString());
            Debug.Log("Ball y" + ballLocationy.ToString());
            Debug.Log("Paddle y" + paddleLocationy.ToString());
            Debug.Log("Difference" + difference.ToString());
          //  Debug.Log("Half paddle height: " + halfPaddleHeight.ToString());
           // Debug.Log("Normalized hit: " + normalizedHit);

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, difference * startingSpeed);

        }

    }
}
