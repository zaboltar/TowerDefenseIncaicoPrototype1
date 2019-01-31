using UnityEngine;

public class CameraController : MonoBehaviour {

    // se comenta el "bloqueo" de camara con escape... es mejor clampear!

    //private bool doMovement = true;

    public float panSpeed = 30f;
    public float panBorderThickness = 10f;

    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;

    private Vector3 startPosition;

    public Vector3 offSet;

    void Start()
    {
        startPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {

        /*if (GameManager.gameEnded) {
            this.enabled = false;
            return;
        }*/

        /*if (Input.GetKeyDown(KeyCode.Escape))
        doMovement = !doMovement;

        if (!doMovement) {
            return;
        }*/

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {

            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {

            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {

            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {

            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;

    }

    public void LateUpdate()
    {
        Vector3 pos = transform.position;

        if (pos.x < startPosition.x - offSet.x)
            pos.x = startPosition.x - offSet.x;

        if (pos.x > startPosition.x + offSet.x)
            pos.x = startPosition.x + offSet.x;

        if (pos.z < startPosition.z - offSet.z)
            pos.z = startPosition.z - offSet.z;

        if (pos.z > startPosition.z + offSet.z)
            pos.z = startPosition.z + offSet.z;

        transform.position = pos;
    }
}

// falta el clamp del paneo