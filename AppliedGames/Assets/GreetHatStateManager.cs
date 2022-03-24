using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreetHatStateManager : MonoBehaviour
{
    [SerializeField] CheckGreet greet;

    public enum GreetStatesEnum
    {
        nothing,
        monHat,
        tueHat,
        wedHat,
        thurHat
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

            case GreetStatesEnum.monHat:
                break;

            case GreetStatesEnum.tueHat:
                break;

            case GreetStatesEnum.wedHat:
                break;

            case GreetStatesEnum.thurHat:
                break;

        }
    }
}
