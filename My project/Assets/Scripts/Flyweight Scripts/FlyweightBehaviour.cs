using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyweightBehaviour : MonoBehaviour
{
    List<NPC> nPCs = new List<NPC>();
    List<Vector3> Pos;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            NPC newNPC = new NPC();
            newNPC.Position = Pos;
            nPCs.Add(newNPC);
        }
    }
    List<Vector3> GetPos()
    {
        List<Vector3> Positions = new List<Vector3>();
        for (int i = 0; i < 1000; i++)
        {
            Positions.Add(new Vector3());
        }
        return Positions;
    }
    internal class NPC
    {
        public List<Vector3> Position { get; internal set; }
    }
}
