using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeView : MonoBehaviour
{
    [SerializeField]
    List<GameObject> _lifes;

    public void SetLife(int lifeCount)
    {
        for (int i = 0; i < _lifes.Count; i++)
        {
            GameObject life = _lifes[i];
            life.SetActive(lifeCount > i);
        }
    }
}
