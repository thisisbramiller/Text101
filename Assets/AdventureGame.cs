using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = "We've just crash landed into a new planet on the way to Earth.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
