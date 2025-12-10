using UnityEngine;

public class movingObject : MonoBehaviour
{
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
        //float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        //Vector3 offset = new Vector3(movementX, 0, 0);
        //transform.position += offset;
    }
}
