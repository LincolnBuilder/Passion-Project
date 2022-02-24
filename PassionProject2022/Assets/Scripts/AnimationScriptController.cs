using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScriptController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool leftPressed = Input.GetKey("a");
        bool backPressed = Input.GetKey("s");
        bool rightPressed = Input.GetKey("d");
        //bool runPressed = Input.GetKey("");
        if (!isWalking && forwardPressed | leftPressed | backPressed | rightPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !forwardPressed | leftPressed | backPressed | rightPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }
    }
}
