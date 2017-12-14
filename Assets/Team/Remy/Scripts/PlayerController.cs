using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class PlayerController : DualBehaviour 
{
    #region Public Members

    public float m_movementSpeed;

    #endregion

    #region Public void

    #endregion

    #region System

    private void Awake()
    {
        m_transform = GetComponent<Transform>();
        m_rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    #endregion

    #region Class Methods

    private void Move()
    {
        float m_moveVertical = Input.GetAxisRaw("Vertical");
        float m_moveHorizontal = Input.GetAxisRaw("Horizontal");
        //Vector3 m_movement      = new Vector3(0.0f, 0.0f, m_moveVertical);

        Vector3 camDirection = Camera.main.transform.forward;
        camDirection.y = 0;
        Vector3 camDirectionRight = Camera.main.transform.right;
        camDirection.y = 0;

        m_rigidbody.AddForce(camDirection * m_movementSpeed * m_moveVertical, ForceMode.Force);

       // m_rigidbody.AddForce(camDirectionRight * m_movementSpeed * m_moveHorizontal, ForceMode.Force);



        /////
        //float _moveHorizontal = Input.GetAxis("Horizontal");
        //float _moveVertical = Input.GetAxis("Vertical");

        //Vector3 _movement = new Vector3(_moveHorizontal, 0.0f, _moveVertical);

        //Transform maCamera = Camera.main.transform;


        ////  Quaternion.Lerp()

        //Vector3 angle90 = new Vector3(0, 0, 0);
        //Vector3 newDireciton = Quaternion.Euler(angle90) * maCamera.forward;




        //m_rigidbody.AddForce(newDireciton * Time.deltaTime * _speed, _forceType);
        //m_rigidbody.AddForce(maCamera.forward * Time.deltaTime * _speed, _forceType);`
        ////

    }
    
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Rigidbody m_rigidbody;
    
    #endregion

}
