using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private float acceleration = 0.8f;
    private float curSpeed;
    private float maxSpeed;
    private Vector2 input;
    [SerializeField] private LayerMask solidObjectsLayer;
    [SerializeField] float obstacleRayDistance;

    //Raycast Objects
    public GameObject groundRayObject;
    public GameObject NewRayDist;

    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.gravityScale = 0.0f;
        _rb.angularDrag = 0.0f;
        Debug.Log("WAHAHAHA");
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        input = input.normalized;
        //// Debug.Log(input.x.ToString() + " " + input.y.ToString());

        /////Raycast try
        //RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position, -Vector2.up);
        //Vector3 dis = _rb.transform.position + new Vector3(2, 6, 4);
        //Debug.DrawRay(groundRayObject.transform.position, dis, Color.red);

        //Enemy
        //RaycastHit2D hitObstacle = Physics2D.Raycast(obstacleRayObject.transform.position, Vector2.right * new Vector2(characterDirection, 0f), obstacleRayDistance, layerMask);
        //Debug.DrawRay(obstacleRayObject.transform.position, Vector2.right * hitObstacle.distance * new Vector2(characterDirection, 0f), Color.red);
        //if (hitObstacle.collider != null)
        //{

        //    Debug.DrawRay(obstacleRayObject.transform.position, Vector2.right * hitObstacle.distance * new Vector2(characterDirection, 0f), Color.red);
        //    Debug.Log("Enemy Detected");
        //}
        //else
        //{
        //    Debug.DrawRay(obstacleRayObject.transform.position, Vector2.right * obstacleRayDistance * new Vector2(characterDirection, 0f), Color.green);

        //}
        ////Enemy

        ////Jump
        //if (Input.GetKeyDown(KeyCode.Space))
        //{

        //    if (jumpOn == true)
        //    {
        //        rb.velocity = Vector2.up * jumpForce;

        //    }
        //    else
        //    {
        //        return;
        //    }

        //}
        //Jump

        Debug.DrawRay(_rb.transform.position, _rb.transform.position + groundRayObject.transform.right * 10f, Color.red);
    }

    private void FixedUpdate()
    {
        
        curSpeed = moveSpeed;
        maxSpeed = curSpeed;

        // the movement magic
        _rb.velocity = new Vector2(
            Mathf.Lerp(0, input.x * curSpeed, acceleration),
            Mathf.Lerp(0, input.y * curSpeed, acceleration)
        );


        ///Raycast try
       // RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position, -Vector2.up);
       // Vector3 dis = NewRayDist.transform.position;
       // Debug.Log("distance new"+NewRayDist.transform.localPosition.x+" "+ NewRayDist.transform.localPosition.y+"old dist"+
         //   groundRayObject.transform.localPosition.x+" "+ groundRayObject.transform.localPosition.y);

       // Debug.DrawRay(_rb.transform.position, _rb.transform.position + _rb.transform.right *10f, Color.red);

    }
}
