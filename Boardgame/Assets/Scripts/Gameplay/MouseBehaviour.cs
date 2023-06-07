using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviour : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer _cursorIndicator;

    [SerializeField]
    ObjectPool _objectPool;

    Vector3 _lastPositionCalculated = Vector3.one * float.PositiveInfinity;

    [SerializeField]
    List<Vector3> _fieldsCurrentlySelected = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clampedWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clampedWorldPos = new Vector3(
            Mathf.RoundToInt(clampedWorldPos.x),
            Mathf.RoundToInt(clampedWorldPos.y),
            0
        );
        _cursorIndicator.transform.position = clampedWorldPos;

        if (Input.GetMouseButtonDown(0))
        {
            _objectPool.DestroyAll();
            _lastPositionCalculated = Vector3.one * float.PositiveInfinity;
            _fieldsCurrentlySelected.Clear();
        }
        else if(Input.GetMouseButton(0))
        {
            if (_lastPositionCalculated == clampedWorldPos) return;
            if (_objectPool.IsAtMax()) return;
            if (_fieldsCurrentlySelected.Contains(clampedWorldPos)) return;
            GameObject go = _objectPool.Instantiate(clampedWorldPos);
            _lastPositionCalculated = go.transform.position;
            _fieldsCurrentlySelected.Add(clampedWorldPos);
            go.GetComponent<CursorTile>().SetNumber(_fieldsCurrentlySelected.Count);
        }
        else if(Input.GetMouseButtonUp(0))
        {
            
        }
    }
}
