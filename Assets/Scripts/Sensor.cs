using UnityEngine;

public class Sensor : MonoBehaviour

{
    public int penalty = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            FindAnyObjectByType<GameManager>().RemoveScore(penalty);
            Destroy(other.gameObject);
        }
    }
}

