//Aranza Vázquez- A01739377   Natalia Junco-
using UnityEngine;
using UnityEngine.Rendering;

public class VisualGato : MonoBehaviour
{
   
   
    [SerializeField] GameObject Player1Prefab;
    [SerializeField] GameObject Player2Prefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject TheGame = new GameObject();

        //Material rebote perfecto
        PhysicsMaterial pm1 = new PhysicsMaterial(); 
        pm1.bounciness = 1;
        pm1.dynamicFriction = 0;
        pm1.staticFriction = 0;

        //Material pared
        PhysicsMaterial pm2 = new PhysicsMaterial();
        pm2.bounciness = 0;
        pm2.dynamicFriction = 1;
        pm2.staticFriction = 1;

        //Piso
        GameObject piso=GameObject.CreatePrimitive(PrimitiveType.Cube);
        piso.transform.position=new Vector3(0,0,0);
        piso.transform.localScale=new Vector3(7f,0.1f,7f);
        piso.transform.parent = TheGame.transform;

        Rigidbody rb = piso.AddComponent<Rigidbody>();
        rb.isKinematic = true;
        MeshRenderer mr=piso.GetComponent<MeshRenderer>();
        mr.material.color = new Color(0.811f,0.725f,0.592f);

        Collider col = piso.GetComponent<Collider>();
        col.material = pm1;

        //Paredes
        float celda = 1f;
        float alto = 0.3f;
        float ancho =0.2f;
        float largo = 6f;


        GameObject pared1=GameObject.CreatePrimitive(PrimitiveType.Cube);
        pared1.transform.position = new Vector3(-celda, 0.1f, 0);
        pared1.transform.localScale = new Vector3(ancho, alto, largo);
        pared1.transform.parent=TheGame.transform;

        GameObject pared2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        pared2.transform.position = new Vector3(celda, 0.1f, 0);
        pared2.transform.localScale = new Vector3(ancho, alto, largo);
        pared2.transform.parent = TheGame.transform;

        GameObject pared3 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        pared3.transform.position = new Vector3(0, 0.1f, -celda);
        pared3.transform.localScale = new Vector3(largo, alto, ancho);
        pared3.transform.parent = TheGame.transform;

        GameObject pared4 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        pared4.transform.position = new Vector3(0, 0.1f, celda);
        pared4.transform.localScale = new Vector3(largo, alto, ancho);
        pared4.transform.parent = TheGame.transform;

        GameObject[] paredes = {pared1,pared2,pared3,pared4};
        foreach(GameObject p in paredes)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(0.706f, 0.298f, 0.263f);
            p.GetComponent<Collider>().material = pm2;
            Rigidbody rbp =p.AddComponent<Rigidbody>();
            rbp.isKinematic = true;
        }

         //
        List<Vector3> positions = LogicGato.GetLogic();

        for (int i=0;i < positions.Count; i++)
        {
            float tableroX=(positions[i].x-1f)*celda;
            float tableroZ=(positions[i].z-1f)*celda;
            GameObject prefab;

            if (i % 2 == 0)
            {
                prefab = Player1Prefab;
            }
            else
            {
                prefab = Player2Prefab;
            }

            GameObject ficha = Instantiate(prefab);
            }
        






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
