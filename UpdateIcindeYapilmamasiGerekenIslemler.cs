/*

-------------------------------------------------------------UPDATE() İÇERİSİNDE YAPILMAMASI GEREKENLER----------------------------------------------


------------------------Update İçerisinde Ağ İşlemleri Yapmak------------------------
 
    Kötü kullanım: 
        void Update()
        {
            GetDataFromServer(); //her karede GetDataFromServer() fonksiyonunu çağırır
        }
        
    Çözüm önerisi:
        void Start()
        {
            StartCoroutine(GetDataFromServer());
        }
        
------------------------Update İçerisinde Ağ İşlemleri Yapmak------------------------




------------------------Update İçerisinde Fizik İşlemleri Yapmak------------------------

    Kötü kullanım:
        void Update()
        {
            rb.MovePosition(rb.position + Vector2.right * Time.deltaTime);
        }
        
    Çözüm önerisi:
        void FixedUpdate()
        {
            rb.MovePosition(rb.position + Vector2.right * Time.fixedDeltaTime);
        }

------------------------Update İçerisinde Fizik İşlemleri Yapmak------------------------




------------------------Update İçerisinde Gereksiz Matematiksel Hesaplamalar Yapmak------------------------

    Kötü kullanım:
        void Update()
        {
            float distance = Vector3.Distance(player.position, enemy.position);
        }
        
    Çözüm önerisi:
        void Start()
        {
            InvokeRepeating(nameof(CheckDistance), 0f, 0.5f);
        }

        void CheckDistance()
        {
            float distance = Vector3.Distance(player.position, enemy.position);
        }

------------------------Update İçerisinde Gereksiz Matematiksel Hesaplamalar Yapmak------------------------




------------------------Update İçerisinde Debug.Log() Kullanmak------------------------

    Kötü kullanım:
        void Update()
        {
            Debug.Log("Oyuncunun hızı: " + speed);
        }
        
    Çözüm önerisi:
        if (debugMode)
        {
            Debug.Log("Oyuncunun hızı: " + speed);
        }

------------------------Update İçerisinde Debug.Log() Kullanmak------------------------
 
 





-------------------------------------------------------------UPDATE() İÇERİSİNDE YAPILMAMASI GEREKENLER----------------------------------------------

*/