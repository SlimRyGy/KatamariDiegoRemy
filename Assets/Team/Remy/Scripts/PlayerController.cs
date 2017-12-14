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
        float m_moveVertical    = Input.GetAxisRaw("Vertical");
        Vector3 m_movement      = new Vector3(0.0f, 0.0f, m_moveVertical);

        m_rigidbody.AddForce(m_movement * m_movementSpeed, ForceMode.Force);
    }
    
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Rigidbody m_rigidbody;
    
    #endregion

}
