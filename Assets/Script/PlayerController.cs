using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public GameManager manager;

    Rigidbody2D rigid;
    Animator anim;

    float h;
    float v;
    bool isHorizonMove; //Horzion 수평선
    Vector3 dirVec;
    GameObject scanObject;

    //씬이 로드될 때 실행된다. Start()보다 먼저 실행됨.
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        //3
        //Move Value
        h = manager.isAction ? 0 : Input.GetAxisRaw("Horizontal");
        v = manager.isAction ? 0 : Input.GetAxisRaw("Vertical");

        //Check Button Down & Up
        bool hDown = manager.isAction ? false : Input.GetButtonDown("Horizontal"); //수평 다운
        bool vDown = manager.isAction ? false : Input.GetButtonDown("Vertical"); //수직 다운
        bool hUp = manager.isAction ? false : Input.GetButtonUp("Horizontal"); //수직 업
        bool vUp = manager.isAction ? false : Input.GetButtonUp("Vertical"); //수직 다운

        //Check Horizontal Move
        if(h != 0)
            isHorizonMove = true;
        else if(v != 0)
            isHorizonMove = false;


        //Animation
        //수평 또는 수직의 우선순위 결정 
        if(h != 0 || v != 0)
        {
            if(isHorizonMove)
            {
                anim.SetInteger("hAxisRaw", (int)h);
                anim.SetInteger("vAxisRaw", 0);
            }
            else
            {
                anim.SetInteger("hAxisRaw", 0);
                anim.SetInteger("vAxisRaw", (int)v);
            }
        }
        else
        {
            anim.SetInteger("hAxisRaw", 0);
            anim.SetInteger("vAxisRaw", 0);
        }   

        //Direction
        if(vDown && v == 1)
            dirVec = Vector3.up;
        else if(vDown && v == -1)
            dirVec = Vector3.down;
        else if(hDown && h == -1)
            dirVec = Vector3.left;
        else if(hDown && h == 1)
            dirVec = Vector3.right; 


        //Scan Object & Action
        if(Input.GetButtonDown("Jump") && scanObject != null)
            //Debug.Log("This is:" + scanObject.name);
            manager.Action(scanObject);  //1
    }

    void FixedUpdate()
    {
        //Move
        Vector2 moveVec = isHorizonMove ? new Vector2(h,0) : new Vector2(0, v);
        rigid.linearVelocity = moveVec * Speed;

        //Ray
        Debug.DrawRay(rigid.position, dirVec*1.0f, new Color(0,1,0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 0.7f, LayerMask.GetMask("Object"));
    
        if(rayHit.collider != null)
            scanObject = rayHit.collider.gameObject;
        else
            scanObject = null;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
    }


}
