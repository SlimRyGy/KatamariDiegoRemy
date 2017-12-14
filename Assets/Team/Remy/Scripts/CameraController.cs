using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : DualBehaviour 
{
    #region Public Members

    public GameObject m_player;
    public float m_deltaRotation;
    public float m_deltaRotationNeg;
    public float m_deltaRotationPos;
    public Transform m_cube;
    int angle = 0;

    #endregion

    #region Public void

    #endregion

    #region System

    void Start () 
    {
        m_offset = transform.position - m_player.transform.position;
	}

    private void Update()
    {
       // m_deltaRotation += Input.mouseScrollDelta.y;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position = (m_player.transform.position + m_offset) + Quaternion.Euler(0,-1,0);
            
            angle--;
            Debug.Log(angle);
           // transform.localPosition = m_transform.position + m_offset;
            transform.localRotation = Quaternion.Euler(new Vector3(0f, angle, 0f));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position = (m_player.transform.position + m_offset) + Quaternion.Euler(0,-1,0);

            angle++;
            Debug.Log(angle);
            transform.localRotation = Quaternion.Euler(new Vector3(0, angle, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { m_deltaRotationPos -= 1; }
       // m_cube.localRotation = Quaternion.Euler(new Vector3(0, m_deltaRotation, 0));

    }

    void LateUpdate () 
    {
        transform.position = Vector3.Lerp( transform.position,m_player.transform.position + m_offset * (m_player.transform.localScale.x/2),0.1f);
	}

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    private Vector3 m_offset;

    #endregion

}
