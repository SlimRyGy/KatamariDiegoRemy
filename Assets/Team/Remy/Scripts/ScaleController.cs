using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    #region Public Members

    public float m_size;
    public Transform m_affectedObject;

    #endregion

    #region Public void

    #endregion

    #region System

    private void OnValidate()
    {
        m_affectedObject.localScale = new Vector3(m_size, m_size, m_size);
    }

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}
