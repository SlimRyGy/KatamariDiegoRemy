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
        ScalePlayer();
    }
    void OnCollisionEnter(Collision _col)
    {
        IsAttractObject(_col.transform);
        
    }
    #endregion

    #region Tools Debug and Utility
    //ne pas détecter le sol
    // detecter le type d'objet
    private void IsAttractObject(Transform _t)
    {
        if (_t.tag == "AttractiveObject" && _t.transform.localScale.y<m_transform.localScale.y)// a ameliorer
        {
            if (!m_ObjectsList.Contains(_t)) { 
                m_ObjectsList.Add(_t);
                _t.parent = m_transform;
                Destroy(_t.GetComponent<Rigidbody>());
                Destroy(_t.GetComponent<Collider>());
            }

        }
    }
    private void ScalePlayer()
    {
        if (m_ObjectsList.Count == 1)
        {
            m_transform.localScale = (m_transform.localScale * 1.001f);
        }

    }
    
    #endregion

    #region Private and Protected Members
    [SerializeField]
    private SphereCollider m_sphere_colider;
    [SerializeField]
    private List<Transform> m_ObjectsList;
    [SerializeField]
    private Transform m_transform;

    #endregion
    //Pour plus tard m_transform.Rotate(Vector3,Space.World);


}
