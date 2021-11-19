using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectionShift : MonoBehaviour
{
    PlayerInput input;
    [SerializeField]
    Camera perspective;
    [SerializeField]
    Camera orthografic;
    bool isPerspective = true;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (input.GetProjectionShift())
        {
            isPerspective = !isPerspective;
            perspective.enabled = isPerspective;
            orthografic.enabled = !isPerspective;
        }

    }
}
