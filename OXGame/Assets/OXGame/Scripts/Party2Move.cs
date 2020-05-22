using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Party2Move : MonoBehaviour
{
    public Vector3 waypointO;
    public Vector3 waypointX;
    public Vector3 waypointD;

    private Vector3 currPosition;
    public float speed = 9f;

    private bool ClickO = false;
    private bool ClickX = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        currPosition = transform.position;
        MoveO();
        MoveX();
    }

    void MoveO()
    {
        if (ClickO == true)
        {
            float MoveSpeed = speed * Time.deltaTime;
            transform.position = Vector3.Lerp(currPosition, waypointO, MoveSpeed);
        }

    }

    public void OnClickO()
    {
        ClickX = false;
        ClickO = true;
    }

    void MoveX()
    {
        if (ClickX == true)
        {
            float MoveSpeed = speed * Time.deltaTime;
            transform.position = Vector3.Lerp(currPosition, waypointX, MoveSpeed);
        }
    }

    public void OnClickX()
    {
        ClickO = false;
        ClickX = true;
    }
}
