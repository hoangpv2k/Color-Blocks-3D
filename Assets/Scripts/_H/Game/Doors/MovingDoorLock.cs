using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDoorLock : MonoBehaviour
{
    private Door currentDoor;

    [SerializeField]
    private AnimationCurve jumpEase;

    [SerializeField]
    private SkinnedMeshRenderer skinnedMeshRenderer;

    [SerializeField]
    private int blendIndex;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Transform modelParent;

    private float animationDuration;

    public Door CurrentDoor => null;
}
