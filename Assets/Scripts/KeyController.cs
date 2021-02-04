using UnityEngine;

public class KeyController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            LevelManager.instance.gotKey = true;
            Destroy(this.gameObject);
        }
    }
}
