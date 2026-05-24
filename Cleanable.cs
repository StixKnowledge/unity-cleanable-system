// Attach this to your Cleanable GameObject
public class Cleanable : MonoBehaviour
{
    void Update()
    {
        // Check if all child dirt objects are gone
        if (transform.childCount == 0)
        {
            TriggerFinish();
        }
    }

    void TriggerFinish()
    {
        Debug.Log("Plate is clean!");
        // Your level finish logic here
    }
}