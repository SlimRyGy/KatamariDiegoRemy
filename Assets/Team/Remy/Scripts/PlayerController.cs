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

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Class Methods
    
    private void Move()
    {
        m_rigidbody.AddForce(new Vector3());
    }
    
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Rigidbody m_rigidbody;

    #endregion

}
