using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : DualBehaviour 
{
    #region Public Members

    public GameObject m_player;

    #endregion

    #region Public void

    #endregion

    #region System

    void Start () 
    {
        m_offset = transform.position - m_player.transform.position;
	}
	
	void LateUpdate () 
    {
        transform.position = m_player.transform.position + m_offset;
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Vector3 m_offset;

    #endregion

}
