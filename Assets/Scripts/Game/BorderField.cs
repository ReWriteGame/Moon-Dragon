using UnityEngine;
using UnityEngine.Events;

public class BorderField : MonoBehaviour
{
    public UnityEvent onBorderFieldEvent;
    public UnityEvent offBorderFieldEvent;

 
    void Start()
    {
        OnBorder();
    }

    public void OnBorder()
    {
        onBorderFieldEvent?.Invoke();
    }
    public void OffBorder()
    {
        offBorderFieldEvent?.Invoke();
    }

    public UnityEvent getItemEvent;
    public UnityEvent getToxicEvent;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Toxic>())
        {
            collision.gameObject.GetComponent<Destroyable>().Destroy(0);
        }
        if (collision.gameObject.GetComponent<Item>())
        {
            collision.gameObject.GetComponent<Destroyable>().Destroy(0);
        }
    }
}
