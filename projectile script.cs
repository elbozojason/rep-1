using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedexplosivetipeprojectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log('W');
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("entity")){
            Debug.Log(collision.gameObject.name); 
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("terrain")){
            Debug.Log(collision.gameObject.name); 
            Destroy(gameObject);
        }}
        
}
