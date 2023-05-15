using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimationControler : MonoBehaviour
{

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        animator.Play("MainMenuClose");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
