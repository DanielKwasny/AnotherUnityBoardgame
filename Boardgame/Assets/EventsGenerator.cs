using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsGenerator : MonoBehaviour
{
    static bool[,] _mapFields = new bool[10,10];

    [SerializeField] GameObject _eventPrefab;
    [SerializeField] Transform _eventsHolder;
    static int _mapOffsetX = -4;
    static int _mapOffsetY = -5;
    // Start is called before the first frame update
    void Start()
    {
        PlaceEventsForQuarter(0, 0);
        PlaceEventsForQuarter(5, 0);
        PlaceEventsForQuarter(0, 5);
        PlaceEventsForQuarter(5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceEventsForQuarter(int startingX, int startingY)
    {
        int _tempCount = 4;
        for(int i = 0; i<_tempCount; i++)
        {
            int _tempPositionX = Random.Range(startingX, startingX + 5);
            int _tempPositionY = Random.Range(startingY, startingY + 5);

            if(_mapFields[_tempPositionX, _tempPositionY] == true)
            {
                _tempCount++;
            }
            else
            {
                _mapFields[_tempPositionX, _tempPositionY] = true;
                SpawnEvent(_tempPositionX, _tempPositionY);
            }
        }
    }

    public void SpawnEvent(int positionX, int positionY)
    {
        Instantiate(_eventPrefab, new Vector3(positionX + _mapOffsetX, positionY + _mapOffsetY, 0), Quaternion.identity, _eventsHolder);
    }

    public static bool CheckForEvent(int xPos, int yPos)
    {
        return _mapFields[xPos - _mapOffsetX, yPos - _mapOffsetY];
    }
}
