

//-----------------------------------------GetComponent<T>()------------------------


/*
    Yanlış Kullanım:
  
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right; // Her karede arama yapıyor 
    }
    
    Çözüm Önerisi:
    
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Başlangıçta bir kez çağır
    }

    void Update()
    {
        rb.velocity = Vector2.right; // Kullanılması gerektiğinde kullanır
    }
 */


//-----------------------------------------GetComponent<T>()-----------------------------------------



//---------------------------------Find() ve FindGameObjectsWithTag()--------------------------------

/*
    Yanlış Kullanım:
    
    void Update()
    {
        GameObject enemy = GameObject.Find("Enemy"); // Her karede sahneyi tarıyor
    }
    
    Çözüm Önerisi:
    
    private GameObject enemy;

    void Start()
    {
        enemy = GameObject.Find("Enemy"); // Sadece bir kez çağır
    }
 */

//---------------------------------Find() ve FindGameObjectsWithTag()--------------------------------



//-------------------------------------Instantiate() ve Destroy()------------------------------------
 
/*
 
    Yanlış Kullanım:
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab); // Space tuşuna basışta yeni obje oluşturuluyor
        }
    }
 
    Çözüm Önerisi:
    
    private Queue<GameObject> bulletPool = new Queue<GameObject>();

    private void Shoot()
    {
        GameObject bullet = bulletPool.Count > 0 ? bulletPool.Dequeue() : Instantiate(bulletPrefab);//eğer kuyrukta obje varsa kuyruktaki ilk obje bullet değişkenine eşitlenir. Yoksa, yeni nesne oluşturulur.
        bullet.SetActive(true); // nesne, oyuna dahil edilir(tamamen silinmemişti)
    }

    private void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false); //nesne, oyundan kaldırılır(tamamen silinmez)
        bulletPool.Enqueue(bullet);// nesne, kuyruğa eklenir
    }
 */

//-------------------------------------Instantiate() ve Destroy()------------------------------------



//--------------------------------------For ve Foreach Döngüleri-------------------------------------

/*
    Daha Fazla Yoran Kullanım: 
    
    public List<GameObject> enemyList= new List<GameObject>(); // GameObject listesi

    void DisableAllEnemies()
    {
        foreach (GameObject enemy in enemyList) // `IEnumerator` oluşturur
        {
            enemy.SetActive(false);
        }
    }
    
    Daha Az Yoran Kullanım:
    
    public List<GameObject> enemyList= new List<GameObject>(); // GameObject listesi

    void DisableAllEnemies()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].SetActive(false);
        }
    }
 */

//--------------------------------------For ve Foreach Döngüleri-------------------------------------