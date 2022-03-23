using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreetStateManager : MonoBehaviour
{
    [SerializeField] CheckGreet greet;

    public enum GreetStatesEnum
    {
        nothing,
        mon,
        tue,
        wed,
        thur
    };

    public GreetStatesEnum currentState = GreetStatesEnum.nothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case GreetStatesEnum.nothing:
            break;

            case GreetStatesEnum.mon:
                break;

            case GreetStatesEnum.tue:
                break;

            case GreetStatesEnum.wed:
                break;

            case GreetStatesEnum.thur:
                break;

        }
    }
}
