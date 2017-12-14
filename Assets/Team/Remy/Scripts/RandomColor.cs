using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour 
{

    public Renderer m_rendererAffected;

    #region Public Members

    #endregion

    #region Public void
    
    #endregion

    #region System

    void Start () 
    {
        m_rendererAffected.material.color = new Color(Random(), Random(), Random());


    }
    public float Random(float min = 0, float max = 1) { return UnityEngine.Random.Range(min, max); }
	
	void Update () 
    {
		
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}
