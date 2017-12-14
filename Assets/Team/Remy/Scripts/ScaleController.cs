using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleController : MonoBehaviour
{
    #region Public Members

    public float m_minCubeSize = 1;
    public float m_maxCubeSize = 1;

    public float m_size;
    public Transform m_affectedObject;

    #endregion

    #region Public void

    #endregion

    #region System

    private void Start()
    {
        float randomSize = Random();
        m_affectedObject.localScale = new Vector3(randomSize, randomSize, randomSize);
    }

    float Random()
    {
        return UnityEngine.Random.Range(m_minCubeSize, m_maxCubeSize);
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
