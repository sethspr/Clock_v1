using UnityEngine;
public class Clock : MonoBehaviour {
    [SerializeField]
    Transform hoursPivot, minutePivot, secondsPivot;

    void Awake () {
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30);
    }
}