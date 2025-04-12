using Unity.VisualScripting;
using UnityEngine;

public class BaseObstackle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter()
    {
        OnHit();
    }

    internal virtual void OnHit()
    {
        Debug.Log("obctackle was hit!");
    }
    
    
    
    
    // Update is called once per frame
    void Update()
    {

    }
}
