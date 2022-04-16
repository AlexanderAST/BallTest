using UnityEngine;

public class DestriyTime : MonoBehaviour
{
   
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    
}
