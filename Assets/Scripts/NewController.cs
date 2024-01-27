using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{

    public class NewController : MonoBehaviour
    {

        float moveInput;
        [SerializeField] float speed;
        [SerializeField] float jumpForce;
        Rigidbody2D rb;

        public GameObject groundRayObject;

        bool jumpOn;

        public LayerMask layerMask;

        void Start()
        {
            jumpOn = false;
            rb = GetComponent<Rigidbody2D>();
        }

        void FixedUpdate()
        {
            //moveInput = Input.GetAxis("Horizontal");
            //rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

            //RaycastHit2D hitGround = Physics2D.Raycast(groundRayObject.transform.position, -Vector2.up);

                  Debug.DrawRay (rb.transform.position, rb.transform.position + groundRayObject.transform.right * 10f, Color.white);

        }

        private void Update()
        {
        }
    }
}