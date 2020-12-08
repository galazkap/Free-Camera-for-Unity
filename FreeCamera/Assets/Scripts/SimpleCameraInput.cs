using UnityEngine;

public class SimpleCameraInput : MonoBehaviour
{
    public Axis xAxis;
    public Axis yAxis;
    public Axis zAxis;
    public KeyCode SpeedKey = KeyCode.LeftShift;

    public int GetAxis(Axis axisType)
    {
        if (Input.GetKey(axisType.Positive)) return 1;
        if (Input.GetKey(axisType.Negative)) return -1;
        return 0;
    }
}

[System.Serializable]
public class Axis
{
   public KeyCode Positive;
   public KeyCode Negative;
}
