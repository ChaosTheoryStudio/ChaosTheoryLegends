using UnityEngine;
using UnityEngine.InputSystem;

public class BulletHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rigidbody;
    [SerializeField] private GameObject Bullet;

    [SerializeField] private Transform BulletsParent;
    [SerializeField] private Camera PlayerCamera;

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (!context.started)
            return;

        Vector2 realPos = PlayerCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        GameObject obj = Instantiate(Bullet, BulletsParent);
        obj.transform.position = realPos;
        obj.transform.up = new Vector2(realPos.x - PlayerCamera.transform.position.x, realPos.y - PlayerCamera.transform.position.y);
    }
}