using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToPosition(Vector3 newPosition)
    {
        transform.DOKill();
        transform.DOMove(newPosition, 0.3f);
    }
}
