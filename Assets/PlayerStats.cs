using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public List<Assets.System> systems;
    public int CurrentHP;
    public int MaxHP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int hp = 0;
        int max = 0;
        foreach(Assets.System s in systems)
        {
            hp += s.actions.FindAll((e) => { return !e.damaged; }).Count;
            max += s.actions.Count;
        }
    }
}
