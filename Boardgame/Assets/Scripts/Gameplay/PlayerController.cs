using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{

    bool _isPaused = true;

    public UnityEvent OnOneTileMoved;

    public UnityEvent OnPathEndedEvent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartPlayer()
    {

    }

    public void MoveOnPath(List<Vector3> path)
    {
        StartCoroutine(MoveOnPathAnimated(path));
    }

    IEnumerator MoveOnPathAnimated(List<Vector3> path)
    {
        foreach(var elem in path)
        {
            if (_isPaused) yield return null;
            transform.DOKill();
            yield return transform.DOMove(elem, .1f).WaitForCompletion();
            OnOneTileMoved.Invoke();
        }
        OnPathEndedEvent.Invoke();
    }

    public void SetPause(bool state)
    {
        _isPaused = state;
    }

    public void StartPulse()
    {
        StopPulse();
        transform.DOScale(1.5f, 0.5f).SetEase(Ease.InOutSine).SetLoops(-1);
    }

    public void StopPulse()
    {
        transform.DOKill();
        transform.localScale = Vector3.one;
    }
}
