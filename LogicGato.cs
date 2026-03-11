using System.Collections.Generic;
using UnityEngine;

public class LogicGato
{
    public static List<Vector3> GetLogic()
    {
        List<Vector3> positions = new List<Vector3>();
        for (int i = 0; i < 9; i++)
        {
            Vector3 pos;
            do
            {
                pos = new Vector3(Random.Range(0, 3),0 ,Random.Range(0, 3));
            } while (positions.Contains(pos));
                positions.Add(pos);
            }
            
        return positions;
     
    }
}
