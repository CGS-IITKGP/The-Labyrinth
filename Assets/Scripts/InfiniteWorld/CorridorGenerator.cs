using System.Collections.Generic;
using UnityEngine;

public class CorridorGenerator_
{
    public Vector2Int corridorEnd = Vector2Int.zero;
    public CorridorGenerator_()
    {
        
    }
    
    public HashSet<Vector2Int> GenerateCorridor(Vector2Int startPosition, int corridorLength)
    {
        var corridor = RandomWalk.StraightCorridorWalk(startPosition, corridorLength);
        corridorEnd = RandomWalk.lastCorridorPosition;
        
        return corridor;
    }
}
