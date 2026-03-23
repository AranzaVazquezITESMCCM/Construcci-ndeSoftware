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
            

            int player;
            if(i%2==0)
                player=1;
            else
             player=2;
            
            if (Win(positions, player))
            {
                break;
            }
        } 
    static bool Win(List<Vector3> positions, int player)
        {
            List<Vector3> game=new List<Vector3>();
            for (int i=0;i<positions.Count; i+=2)
                game.Add(positions[i]);
            
            for (int n=0; n < 3; n++)
            {
                if(game.Contains(new Vector3(n,0,0))&& game.Contains(new Vector3(n,0,1))&&game.Contains(new Vector3(n,0,2))) 
                {
                return true;
                }
                if(game.Contains(new Vector3(0,0,n))&& game.Contains(new Vector3(1,0,n))&&game.Contains(new Vector3(2,0,n)))
                {
                return true;
                }
            
            }
            if(game.Contains(new Vector3(0,0,2))&& game.Contains(new Vector3(1,0,1))&&game.Contains(new Vector3(2,0,0))) 
            {
                return true;
            }

            if(game.Contains(new Vector3(2,0,2))&& game.Contains(new Vector3(1,0,1))&&game.Contains(new Vector3(0,0,0)))
            {
                return true;
            }
            
            return false;
        }
        return positions;
     
    }
}
