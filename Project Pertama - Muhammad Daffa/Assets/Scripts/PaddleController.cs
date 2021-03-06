using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ambil Input
        Vector2 movement = GetInput();

        // Move The Object Using Input 
        moveObject(movement);
        
    }

    private Vector2 GetInput()
    {
        // Get Input User
        if (Input.GetKey(upKey))
        {
            // Moving Up
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            // Moving Down
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void moveObject(Vector2 movement)
    {
        Debug.Log("Test: " + movement);
        rig.velocity = movement;
    }

    public void SpeedUpPadle(){
        speed *= 2;
    }

    public void ResetSpeedPadle(){
        speed /= 2;
    }

    public void ScaleUp(GameObject paddle){
        paddle.transform.localScale += new Vector3(0, paddle.transform.localScale.y, 0);
    }

    public void ScaleDown(GameObject paddle){
        paddle.transform.localScale -= new Vector3(0, paddle.transform.localScale.y/2, 0);
    }
}
