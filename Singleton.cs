using System;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual bool ShouldPersist => false; // Override this in derived class to control persistence

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            if (ShouldPersist)
                DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

public class PureSingleton<T> where T : class, new()
{
    private static readonly Lazy<T> _instance = new(() => new T());

    public static T Instance => _instance.Value;
}
