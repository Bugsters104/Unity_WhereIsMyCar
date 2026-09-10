using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropScript : MonoBehaviour, 
    IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObjectsScript gameObjectsScript;
    private CanvasGroup canvasGroup;
    private RectTransform rectTransform;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }

        rectTransform = GetComponent<RectTransform>();
        gameObjectsScript = Object.FindFirstObjectByType<GameObjectsScript>();
    }


    public void OnPointerDown(PointerEventData eventData)
    {
        if(Input.GetMouseButton(0) && !Input.GetMouseButton(1) && !Input.GetMouseButton(2))
        {
            Debug.Log("Left mouse button clicked on " + gameObject.name);
            gameObjectsScript.carSoundSource.PlayOneShot(gameObjectsScript.sounds[0]);
        }
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       
    }

    public void OnDrag(PointerEventData eventData)
    {
      
    }

    public void OnEndDrag(PointerEventData eventData)
    {
      
    }

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
