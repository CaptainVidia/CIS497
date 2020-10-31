using UnityEngine;
using System.Collections;

// the singleton of type <T> where T must extend Singleton <T>
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;

    public static T Instance
    {
        get { return Instance; }
    }
    public static bool IsInitialized
    {
        get { return instance != null; }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("[Singleton] Trying to instantiate a second instance of a singleton class");
        }
        else
        {
            instance = (T)this;
        }
    }
    protected virtual void OnDestroy()
    {
        //if instance is destroyed, make instance null so another can be created
        if (instance==this)
        {
            instance = null;
        }
    }


}
