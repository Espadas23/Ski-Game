using UnityEngine;

public class DestroyObstacle : BaseObstackle
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    internal override void OnHit()
    {
        base.OnHit();
        Destroy(gameObject);
    }
    
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
