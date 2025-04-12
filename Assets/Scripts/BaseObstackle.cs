using Unity.VisualScripting;
using UnityEngine;

public class BaseObstackle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string obstacleName;
    void OnCollisionEnter()
    {
        OnHit();
    }

    internal virtual void OnHit()
    {
        GameEvents.CallTakeDamage();
        Debug.Log("obctackle was hit!");
    }
    
    
    
    
    // Update is called once per frame
    void Update()
    {

    }
}
