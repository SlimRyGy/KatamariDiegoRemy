using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : DualBehaviour
{
    #region Public Members

    public GameObject m_player;
    public Transform m_cube;
    

    #endregion

    #region Public void

    #endregion

    #region System

    void Start()
    {
        
        m_offset =m_transform.position - m_player.transform.position;
        pastScale = m_player.transform.lossyScale;

    }

    private void Update()
    {
        Debug.DrawRay(transform.position, m_player.transform.localPosition-m_transform.localPosition, Color.red);
        //Debug.Log(m_transform.rotation.eulerAngles);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            AngleSet(1f);
            CameraMoving();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            AngleSet(-1f);
            CameraMoving();
        }
        CameraMoving();
    }

    private void CameraMoving() {
        float ratio = 0f;
        //On test si le scale a augmenté
        if (pastScale!=m_player.transform.lossyScale)
        {
            Debug.Log(ratio+"diff "+ (m_player.transform.lossyScale.x - pastScale.x)+"lossyscale"+ m_player.transform.lossyScale.x);
            ratio = ((m_player.transform.lossyScale.x - pastScale.x) / (pastScale.x/100))/100;
            Debug.Log(ratio);
            pastScale = m_player.transform.lossyScale;
            
        }
        //Formule 
        //x=x+rayon*cos(angle)
        //y=y+rayon*sin(angle)
        float diametre = m_offset.magnitude;
        float x = (m_player.transform.position.x) + (diametre / 2) * Mathf.Cos(angle);
        float z = m_player.transform.position.z + (diametre / 2) * Mathf.Sin(angle);
        Vector3 pos = new Vector3(x, m_transform.position.y, z);
        m_transform.position = pos+(pos*ratio);
        m_transform.LookAt(m_player.transform, Vector3.up);
    }
    /*
    private void CameraFollow() {
        Vector3 scaleFactor = m_offset * (m_player.transform.localScale.x / 2);
       m_transformposition = m_player.transform.position+m_offset;
       //m_transformposition = Vector3.Lerp(transform.position, m_player.transform.position + scaleFactor, 0.1f);
       //m_transformposition = Vector3.Lerp(transform.position, m_player.transform.position + m_offset * (m_player.transform.localScale.x / 2), 0.1f);
    }*/
    private float AngleSet(float _angle)
    {
        angle = angle + _angle*Time.deltaTime;
        return angle;
    }
    void LateUpdate()
    {
        
    }
    
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Vector3 m_offset;
    private float angle = 0;
    private Vector3 pastScale;
    #endregion

}
