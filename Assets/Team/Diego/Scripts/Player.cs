using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Public Members

    #endregion

    #region Public void

    #endregion

    #region System
    private void Reset()
    {
        // TODO mettre les collision entre Layer Player et Level à false
        m_sphere_colider = GetComponent<SphereCollider>();
    }
    void Start ()
    {
        
    }

    void Update ()
    {
        	
    }
    void OnCollisionEnter(Collision _col)
    {
        AttractObject(_col.gameObject);
        
    }
    #endregion

    #region Tools Debug and Utility
    //ne pas détecter le sol
    // detecter le type d'objet
    private void AttractObject(GameObject _go) {
        if (_go.tag == "AttractiveObject")
        {
            Debug.Log("collision obj");
        }
    }
    #endregion

    #region Private and Protected Members
    [SerializeField]
    private SphereCollider m_sphere_colider;
    #endregion
}
