using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorisHatStateManager : MonoBehaviour
{
    [SerializeField] CheckCorrectOutfit outfit;

    public enum BorisStatesEnum
    {
        nothing,
        mon,
        tue,
        wed,
        thur
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

            case BorisStatesEnum.mon:
                break;

            case BorisStatesEnum.tue:
                break;

            case BorisStatesEnum.wed:
                break;

            case BorisStatesEnum.thur:
                break;

        }
    }
}
