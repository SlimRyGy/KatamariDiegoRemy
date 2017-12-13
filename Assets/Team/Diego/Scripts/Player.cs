using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

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
        m_transform = this.transform;

    }
    void Start ()
    {
        
    }

    void Update ()
    {
        AttractObject();
    }
    void OnCollisionEnter(Collision _col)
    {
        IsAttractObject(_col.gameObject);
        
    }
    #endregion

    #region Tools Debug and Utility
    //ne pas détecter le sol
    // detecter le type d'objet
    private void IsAttractObject(GameObject _go) {
        if (_go.tag == "AttractiveObject" && _go.transform.localScale.y<m_transform.localScale.y)
        {
            if (!m_ObjectsList.Contains(_go)) { 
                m_ObjectsList.Add(_go);
                _go.transform.parent = m_transform;

                
            }

        }
    }

    private void AttractObject()
    {
        foreach( GameObject go in m_ObjectsList) {
           // go.transform.Translate(m_transform.position);
        }
    }
    #endregion

    #region Private and Protected Members
    [SerializeField]
    private SphereCollider m_sphere_colider;
    [SerializeField]
    private List<GameObject> m_ObjectsList;
    [SerializeField]
    private Transform m_transform;

    #endregion
    //Pour plus tard m_transform.Rotate(Vector3,Space.World);


}
