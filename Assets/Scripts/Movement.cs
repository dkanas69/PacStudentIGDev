using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    public GameObject Tree;
    private Tweener tweener;
    private Animator TreeAnimator;
    private Vector3[] TreePositions = {
        new Vector3(1.0f, -1.0f, 0.0f),
        new Vector3(6.0f, -1.0f, 0.0f),
        new Vector3(6.0f, -5.0f, 0.0f),
        new Vector3(1.0f, -5.0f, 0.0f)
    };
    private string[] TreeStates = {
        "TreeRight",
        "TreeDown",
        "TreeLeft",
        "TreeUp"
    };
    private int speed = 1;


    void Start()
    {
      resetMovement();
    }

    void Update()
    {
      playermovement();
    }

    private void playermovement()  {
        for (int i = 0; i < TreePositions.Length; i++) {
            if(Tree.transform.position == TreePositions[i]) {
                float duration = Vector3.Distance(TreePositions[i], TreePositions[(i+1)%4]) / speed;
                tweener.AddTween(Tree.transform, TreePositions[i], TreePositions[(i+1)%4], duration);
                TreeAnimator.Play(TreeStates[i]);
            }
        }
    }

    private void resetMovement() {
       tweener = GetComponent<Tweener>();
        TreeAnimator = Tree.GetComponent<Animator>();
        Tree.transform.position = TreePositions[0];
    }

}
