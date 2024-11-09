using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get 
        {
            if (_instance == null)
            {
                T newUIManager = new GameObject().AddComponent<T>();
                _instance = newUIManager;
            }
            return _instance;
        }
        set { _instance = value; }
    }

    private void OnEnable()
    {
        if (_instance == null)
        {
            _instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
