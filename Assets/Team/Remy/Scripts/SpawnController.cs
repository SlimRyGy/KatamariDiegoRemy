
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpawnController : DualBehaviour 
{
    #region Public Members

    public int m_numberofCube;

    #endregion

    #region Public void

    #endregion

    #region System
    private void Start()
    {
        SpawnLotOfCube(m_numberofCube);
    }

    #endregion

    #region Class Methods

    private void SpawnCube()
    {
        string path_carbo = "Assets/Team/Remy/Prefabs/Cube.prefab";
        Object prefab = AssetDatabase.LoadAssetAtPath(path_carbo, typeof(GameObject));
        Instantiate(prefab,RandomCubePosition(),Quaternion.identity);

    }

    private Vector3 RandomCubePosition()
    {
        Vector3 soupe = new Vector3(RandomX(), RandomY(), RandomZ());
        return soupe;
    }

    float RandomX(float min = 1, float max = 99)    { return UnityEngine.Random.Range(min, max); }
    float RandomY(float min = 1, float max = 24)    { return UnityEngine.Random.Range(min, max); }
    float RandomZ(float min = -100, float max = -1) { return UnityEngine.Random.Range(min, max); }

    private void SpawnLotOfCube(int _cube)
    {
        for (int _i = 1; _i <= _cube; _i++)
        {
            SpawnCube();
        }
    }

    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}
