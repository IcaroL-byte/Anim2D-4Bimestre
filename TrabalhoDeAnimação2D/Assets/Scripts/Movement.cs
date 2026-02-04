using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    private bool isFacingRight;
    private SpriteRenderer srPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isFacingRight = true;
        srPlayer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(Input.GetKey(KeyCode.D)){
            gameObject.transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            if (!isFacingRight)
            {
                srPlayer.flipX = false;
                isFacingRight = true;
            }

        }

         if(Input.GetKey(KeyCode.A)){
            gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            if (isFacingRight)
            {
                srPlayer.flipX = true;
                isFacingRight = false;
            }
        }
    }

}
