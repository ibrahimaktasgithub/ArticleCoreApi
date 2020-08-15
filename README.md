# ArticleCoreApi

### Kullanılan teknoloji bilgileri:
- ASP.NET Web API konusunda daha önceden bir tecrübem olmadı. Bu projeyi makaleler okuyarak ve araştırmalar yaparak tamamlamaya çalıştım.
- EntityFrameworkCore.Migrations ve buna paralel EntityFramework.Migrations kütüphanesini önceden birçok çalışmamda tecrübe etmiştim.
- .Net Core Framework ve EntityFrameworkCore kütüphanesini özellikle CMS projelerinde ve şu anki iş pozisyonumda oldukça tecrübe ettim.
- AspNetCore.Mvc ve buna paralel AspNet.Mvc kütüphanesini şu anki iş pozisyonum gereği oldukça sık kullanmaktayım.
- Genel veritabanı sistemlerini ve ORM araçlarını tecrübe ettim.
- Repository Pattern kullanımını ilk defa kullandım. 
- Git/Github'a paralel Bitbucket kullanımını önceki ortak projelerimde deneyimledim.
- Postman API testini ilk defa deneyimledim.

### Süre bazlı projeye eklemek istediğim,
Bu API sistemini bir MVC projesi ile entegre olarak çalışmasını sağlamaktır.

### Eklemek istediklerim,
- ORM araçları kullanımında performansın optimum olması suretiyle Repository Pattern'in bu konuda performansı iyileştirici bir yapıda görev yapamayacağı ve SOLID prensiplerine uymadığı kanısındayım. 
- Öte yandan ORM'ler ile yapılan abstraction işleminin üzerine tekrardan Repository ile bir abstract işlemi daha yapılmasıdır. Bu işlemin de coupling'e sebep olacağı düşüncesindeyim.
- Bir başka husus da örnek olarak belirli bir alanda listeleme yapılırken(GET) ilkin tüm tabloların birlikte gelmesi ve buradanın içerisinden listelenecek alanın sonradan filtrelenmesidir. İlk başta tüm tabloların gelmesi performansı kötü etkileyeceği kanısındayım. Bunun yerine kendi CMS projelerimde de kullandığım context üzerinden linq kullanımını daha sağlıklı bir çözüm olarak görüyorum.

#### Projeye ait ekran görüntüleri;

###### *Listeleme*
![Listeleme](https://github.com/ibrahimaktasgithub/ArticleCoreApi/blob/master/ArticleCoreApi/ArticleCoreApi/ScreenShots/list(get).png)
<br/><br/>
###### *Arama*
![Arama](https://github.com/ibrahimaktasgithub/ArticleCoreApi/blob/master/ArticleCoreApi/ArticleCoreApi/ScreenShots/search.png)
<br/><br/>
###### *Ekleme*
![Ekleme](https://github.com/ibrahimaktasgithub/ArticleCoreApi/blob/master/ArticleCoreApi/ArticleCoreApi/ScreenShots/add(post).png)
<br/><br/>
###### *Güncelleme*
![Güncelleme](https://github.com/ibrahimaktasgithub/ArticleCoreApi/blob/master/ArticleCoreApi/ArticleCoreApi/ScreenShots/update(put).png)
###### *Güncelleme Sonrası*
![Güncelleme Sonrası](https://github.com/ibrahimaktasgithub/ArticleCoreApi/blob/master/ArticleCoreApi/ArticleCoreApi/ScreenShots/after%20update(put).png)
<br/><br/>
###### *Silme*
![Silme](https://github.com/ibrahimaktasgithub/ArticleCoreApi/blob/master/ArticleCoreApi/ArticleCoreApi/ScreenShots/delete.png)
