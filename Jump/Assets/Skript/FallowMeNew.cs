using UnityEngine;

public class FallowMeNew : MonoBehaviour {
     GameObject Player;
    public Vector3 Setting;
    public float SmoothSpeed = 0.125f;

    public string FindGameObjectsWithTag { get; private set; }

    //private void Start()
    //{
    //    Player = GameObject.FindGameObjectWithTag("Player");
    //}
    private void FixedUpdate()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player!=null)
        {
        Vector3 position = Player.transform.position + Setting;
        Vector3 SmoothPosition = Vector3.Lerp(transform.position, position, SmoothSpeed);
        transform.position = SmoothPosition;
        }
    }
}