using UnityEngine;

public class Event : MonoBehaviour, IEvent
{

    public void ChooseRandomEvent()
    {
        int _eventType = 0;

        _eventType = Random.Range(1, 7);

        switch (_eventType)
        {
            case 1:
                AllowMovementThroughWalls();
                break;
            case 2:
                LostNextMove();
                break;
            case 3:
                AdditionalDiceRoll();
                break;
            case 4:
                BackToLastTile();
                break;
            case 5:
                LimitEnemyMoveTo3();
                break;
            case 6:
                CurrentPlayerMoveLimitTo3();
                break;
        }

    }

    public void AllowMovementThroughWalls()
    {

    }

    public void LostNextMove()
    {

    }

    public void AdditionalDiceRoll()
    {

    }

    public void BackToLastTile()
    {

    }

    public void LimitEnemyMoveTo3()
    {

    }

    public void CurrentPlayerMoveLimitTo3()
    {

    }
}
