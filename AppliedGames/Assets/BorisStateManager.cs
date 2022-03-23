using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorisStateManager : MonoBehaviour
{
    [SerializeField] CheckCorrectOutfit outfit;

    public enum BorisStatesEnum
    {
        nothing,
        red,
        green,
        blue,
        yellow
    };

    public BorisStatesEnum currentState = BorisStatesEnum.nothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case BorisStatesEnum.nothing:
            break;

            case BorisStatesEnum.red:
                break;

            case BorisStatesEnum.green:
                break;

            case BorisStatesEnum.blue:
                break;

            case BorisStatesEnum.yellow:
                break;

        }
    }
}
