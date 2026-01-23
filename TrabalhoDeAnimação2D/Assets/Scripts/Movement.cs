using UnityEngine;

public class Movement : MonoBehaviour
{
    public int speed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
        }

         if(Input.GetKey(KeyCode.A)){
            gameObject.transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
    }

}
