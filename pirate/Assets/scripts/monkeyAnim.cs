using UnityEngine;
using System.Collections;

public class monkeyAnim : MonoBehaviour
{
    public monkey monkeyScript;
    public  bool grounded1;
    public bool nikise,hollyMonkey;
    public monkey eftase;
   
    void Update()
    {
        hollyMonkey = monkeyScript.holyMonkey;
        nikise = eftase.nikise;
        grounded1 = monkeyScript.grounded;
        if (!nikise)
        {
            if (!grounded1)
            {
                if(hollyMonkey)
                {
                    Animator anim = GetComponent<Animator>();
                    anim.Play("hollyMonkeyJump");
                }
                else if(!hollyMonkey)
                {
                    Animator anim = GetComponent<Animator>();
                    anim.Play("monkeyjump");
                }
                
            }
            else if (hollyMonkey)
            {
                Animator anim = GetComponent<Animator>();
                anim.Play("hollyMonkeyrun2");
            }
            else
            {
                Animator anim = GetComponent<Animator>();
                anim.Play("monkeyrun2");
            }
        }
        else
        {
            Animator anim = GetComponent<Animator>();
            anim.Play("monkeyYahoo");
        }
    }
}
    
