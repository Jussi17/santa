using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;

public class MapCamera : MonoBehaviour
{
    public GameObject cameraMap;
    public Camera camMap;
    public Slider slider;
    private float minZoom = 21.44716f;
    private float maxZoom = 7f;
    public Image finger;
    public float moveSpeed = 9f;
    public bool isZooming = false;
    private Vector2 touchStartPosition;
    private Vector2 touchEndPosition;
    [SerializeField] private Transform respawnPoint1;
    [SerializeField] private Transform respawnPoint2;
    [SerializeField] private Transform respawnPoint3;
    [SerializeField] private Transform respawnPoint4;
    [SerializeField] private Transform respawnPoint5;
    [SerializeField] private Transform respawnPoint6;
    [SerializeField] private Transform respawnPoint7;
    [SerializeField] private Transform respawnPoint8;
    [SerializeField] private Transform respawnPoint9;
    [SerializeField] private Transform respawnPoint10;
    [SerializeField] private Transform respawnPoint11;
    [SerializeField] private Transform respawnPoint12;
    [SerializeField] private Transform respawnPoint13;
    [SerializeField] private Transform respawnPoint14;
    [SerializeField] private Transform respawnPoint15;
    [SerializeField] private Transform respawnPoint16;
    [SerializeField] private Transform respawnPoint17;
    [SerializeField] private Transform respawnPoint18;
    [SerializeField] private Transform respawnPoint19;
    [SerializeField] private Transform respawnPoint20;
    [SerializeField] private Transform respawnPoint21;
    [SerializeField] private Transform respawnPoint22;
    [SerializeField] private Transform respawnPoint23;
    [SerializeField] private Transform respawnPoint24;
    [SerializeField] private Transform respawnPoint25;
    [SerializeField] private Transform respawnPoint26;
    [SerializeField] private Transform respawnPoint27;
    [SerializeField] private Transform respawnPoint28;
    [SerializeField] private Transform respawnPoint29;
    [SerializeField] private Transform respawnPoint30;
    [SerializeField] private Transform respawnPoint31;
    [SerializeField] private Transform respawnPoint32;
    [SerializeField] private Transform respawnPoint33;
    [SerializeField] private Transform respawnPoint34;
    [SerializeField] private Transform respawnPoint35;

    void Awake()
    {
        if (PlayerPrefs.HasKey("1"))
        {
            cameraMap.transform.position = respawnPoint1.transform.position;
        }
        if (PlayerPrefs.HasKey("2"))
        {
            cameraMap.transform.position = respawnPoint2.transform.position;
        }
        if (PlayerPrefs.HasKey("3"))
        {
            cameraMap.transform.position = respawnPoint3.transform.position;
        }
        if (PlayerPrefs.HasKey("4"))
        {
            cameraMap.transform.position = respawnPoint4.transform.position;
        }
        if (PlayerPrefs.HasKey("5"))
        {
            cameraMap.transform.position = respawnPoint5.transform.position;
        }
        if (PlayerPrefs.HasKey("6"))
        {
            cameraMap.transform.position = respawnPoint6.transform.position;
        }
        if (PlayerPrefs.HasKey("7"))
        {
            cameraMap.transform.position = respawnPoint7.transform.position;
        }
        if (PlayerPrefs.HasKey("8"))
        {
            cameraMap.transform.position = respawnPoint8.transform.position;
        }
        if (PlayerPrefs.HasKey("9"))
        {
            cameraMap.transform.position = respawnPoint9.transform.position;
        }
        if (PlayerPrefs.HasKey("10"))
        {
            cameraMap.transform.position = respawnPoint10.transform.position;
        }
        if (PlayerPrefs.HasKey("11"))
        {
            cameraMap.transform.position = respawnPoint11.transform.position;
        }
        if (PlayerPrefs.HasKey("12"))
        {
            cameraMap.transform.position = respawnPoint12.transform.position;
        }
        if (PlayerPrefs.HasKey("13"))
        {
            cameraMap.transform.position = respawnPoint13.transform.position;
        }
        if (PlayerPrefs.HasKey("14"))
        {
            cameraMap.transform.position = respawnPoint14.transform.position;
        }
        if (PlayerPrefs.HasKey("15"))
        {
            cameraMap.transform.position = respawnPoint15.transform.position;
        }
        if (PlayerPrefs.HasKey("16"))
        {
            cameraMap.transform.position = respawnPoint16.transform.position;
        }
        if (PlayerPrefs.HasKey("17"))
        {
            cameraMap.transform.position = respawnPoint17.transform.position;
        }
        if (PlayerPrefs.HasKey("18"))
        {
            cameraMap.transform.position = respawnPoint18.transform.position;
        }
        if (PlayerPrefs.HasKey("19"))
        {
            cameraMap.transform.position = respawnPoint19.transform.position;
        }
        if (PlayerPrefs.HasKey("20"))
        {
            cameraMap.transform.position = respawnPoint20.transform.position;
        }
        if (PlayerPrefs.HasKey("21"))
        {
            cameraMap.transform.position = respawnPoint21.transform.position;
        }
        if (PlayerPrefs.HasKey("22"))
        {
            cameraMap.transform.position = respawnPoint22.transform.position;
        }
        if (PlayerPrefs.HasKey("23"))
        {
            cameraMap.transform.position = respawnPoint23.transform.position;
        }
        if (PlayerPrefs.HasKey("24"))
        {
            cameraMap.transform.position = respawnPoint24.transform.position;
        }
        if (PlayerPrefs.HasKey("25"))
        {
            cameraMap.transform.position = respawnPoint25.transform.position;
        }
        if (PlayerPrefs.HasKey("26"))
        {
            cameraMap.transform.position = respawnPoint26.transform.position;
        }
        if (PlayerPrefs.HasKey("27"))
        {
            cameraMap.transform.position = respawnPoint27.transform.position;
        }
        if (PlayerPrefs.HasKey("28"))
        {
            cameraMap.transform.position = respawnPoint28.transform.position;
        }
        if (PlayerPrefs.HasKey("29"))
        {
            cameraMap.transform.position = respawnPoint29.transform.position;
        }
        if (PlayerPrefs.HasKey("30"))
        {
            cameraMap.transform.position = respawnPoint30.transform.position;
        }
        if (PlayerPrefs.HasKey("31"))
        {
            cameraMap.transform.position = respawnPoint31.transform.position;
        }
        if (PlayerPrefs.HasKey("32"))
        {
            cameraMap.transform.position = respawnPoint32.transform.position;
        }
        if (PlayerPrefs.HasKey("33"))
        {
            cameraMap.transform.position = respawnPoint33.transform.position;
        }
        if (PlayerPrefs.HasKey("34"))
        {
            cameraMap.transform.position = respawnPoint34.transform.position;
        }
        if (PlayerPrefs.HasKey("35"))
        {
            cameraMap.transform.position = respawnPoint35.transform.position;
        }
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }


    private void Start()
    {
        if (cameraMap.activeInHierarchy)
        {
            finger.enabled = true;
            StartCoroutine(FingerOff());
        }
    }

    IEnumerator FingerOff()
    {
        yield return new WaitForSeconds(1.3f);
        finger.enabled = false;
    }

    void Update()
    {
        if (Input.touchCount > 0 && !isZooming)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                touchStartPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                touchEndPosition = touch.position;
                Vector2 touchDelta = touchEndPosition - touchStartPosition;
                cameraMap.transform.Translate(touchDelta * moveSpeed * Time.deltaTime);
            }
        }
        else
        {
            // Stop camera movement when touch is released
            touchStartPosition = Vector2.zero;
            touchEndPosition = Vector2.zero;
        }

        // Limit camera movement
        float x = Mathf.Clamp(cameraMap.transform.position.x, -65f, -20f);
        float y = Mathf.Clamp(cameraMap.transform.position.y, -225.5f, -155.3f);
        cameraMap.transform.position = new Vector3(x, y, cameraMap.transform.position.z);
    }
    void OnSliderValueChanged(float value)
    {
        isZooming = true;
        float zoom = Mathf.Lerp(minZoom, maxZoom, value);
        camMap.orthographicSize = zoom;
    }
    public void OnSliderReleased()
    {
        isZooming = false;
    }
}
