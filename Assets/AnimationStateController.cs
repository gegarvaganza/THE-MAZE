using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    int IsWalkingHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("IsWalking");
    }

    // Update is called once per frame
    void Update()
    {
        bool IsWalking = animator.GetBool(IsWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        // if player press w key
        if (!IsWalking && forwardPressed)
        {
            // then set the IsWalking boolean to be true
            animator.SetBool(IsWalkingHash, true);
        }

        // if player not pressing w key
        if (IsWalking && !forwardPressed)
        {
            // then set the IsWalking boolean to be false
            animator.SetBool(IsWalkingHash, false);
        }


    }
}
