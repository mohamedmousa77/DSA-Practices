public enum Direction
{
    North, // 0
    East,  // 1
    South,// 2
    West // 3
}

public class RobotSimulator
{
    private Direction _actualDirection;
    private int _x;
    private int _y;
    public RobotSimulator(Direction direction, int x, int y)
    {
        this._x = x;
        this._y = y;
        this._actualDirection = direction;
    }

    public Direction Direction
    {
        get
        {
            return this._actualDirection;
        }
    }

    public int X
    {
        get
        {
            return this._x;
        }
    }

    public int Y
    {
        get
        {
            return this._y;
        }
    }

    public void Move(string instructions) // R , L , A
    {
        foreach (char instruction in instructions) 
        {
            switch (instruction)
            {
                case 'R':
                    TurnRight();
                    break;
                case 'L':
                    TurnLeft();
                    break;
                case 'A':
                    Advance();
                    break;
                default: 
                    break;
            }
                
        }

    }

    private void Advance()
    {
        switch (_actualDirection) 
        {
            case Direction.North:
                _y++;
                break;
            case Direction.South:
                _y--;
                break;
            case Direction.West:
                _x--;
                break;
            case Direction.East:
                _x++;
                break;
            default:
                break;

        }
    }

    private void TurnLeft()
    {
        _actualDirection = (Direction)(((int)_actualDirection + 3) % 4);
    }

    private void TurnRight()
    {
        _actualDirection = (Direction)(((int)_actualDirection + 1) % 4);

    }
}