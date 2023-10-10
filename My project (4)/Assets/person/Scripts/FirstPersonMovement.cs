using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEditor.SearchService;
using static System.Net.Mime.MediaTypeNames;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    public int deadCount;

    [Header("Running")]
    public bool canRun = true;
    public bool IsRunning { get; private set; }
    public float runSpeed = 9;
    public KeyCode runningKey = KeyCode.LeftShift;
    [SerializeField]  static public int notes;
    public TMP_Text textNotes;
    Rigidbody rigidbody;
    /// <summary> Functions to override movement speed. Will use the last added override. </summary>
    public List<System.Func<float>> speedOverrides = new List<System.Func<float>>();
    public GameObject pic;
    public AudioSource a;
    public TMP_Text text;

    void Awake()
    {
        // Get the rigidbody on this.
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Update IsRunning from input.
        IsRunning = canRun && Input.GetKey(runningKey);

        // Get targetMovingSpeed.
        float targetMovingSpeed = IsRunning ? runSpeed : speed;
        if (speedOverrides.Count > 0)
        {
            targetMovingSpeed = speedOverrides[speedOverrides.Count - 1]();
        }

        // Get targetVelocity from input.
        Vector2 targetVelocity =new Vector2( Input.GetAxis("Horizontal") * targetMovingSpeed, Input.GetAxis("Vertical") * targetMovingSpeed);

        // Apply movement.
        rigidbody.velocity = transform.rotation * new Vector3(targetVelocity.x, rigidbody.velocity.y, targetVelocity.y);
    }

    public void Start()
    {
         deadCount = 0;
    }
    public IEnumerator CoroutineBoo()
    {
        pic.SetActive(true);
        a.Play();
        yield return new WaitForSeconds(1.40f);
        SceneManager.LoadScene(3);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "monster")
        {
            //text = GameObject.Find("loseOrVin").GetComponent<TMP_Text>();
            //AfterScreamer.textLoseOrVin.text  = "поражение";
            StartCoroutine(CoroutineBoo());
            Cursor.lockState = CursorLockMode.None;
        }

    }
}