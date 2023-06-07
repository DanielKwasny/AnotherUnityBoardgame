using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehaviour : MonoBehaviour
{
    [SerializeField]
    SpriteRenderer _cursorIndicator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos = new Vector3(
            Mathf.RoundToInt(worldPos.x),
            Mathf.RoundToInt(worldPos.y),
            0
        );
        _cursorIndicator.transform.position = worldPos;
    }
}
