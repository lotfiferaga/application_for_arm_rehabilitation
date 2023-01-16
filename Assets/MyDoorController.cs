using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyDoorController : MonoBehaviour
{

    private  Animator  doorAnim;
    private  bool doorOpen=false;
    
    void Awake()
    {
     doorAnim=gameObject.GetComponent<Animator>();    
    }

    public void PlayAnimation(){
        if(!doorOpen){

            doorAnim.Play("opendoor",0,0.0f);
            doorOpen=true;

        }else{

           doorAnim.Play("animdoor",0,0.0f);
           doorOpen=false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
