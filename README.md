# AbstractClassExcersize
Abstract sınıflarla ilgili bir çalışma yaptım, bakmak isterseniz. 
Uygulama bilgisi : Uygulamaya girince Id istemektedir klavyeden Id girilmesini isteyeceğiz , 
                                 Daha sonra uygulama Futbolcunun Türk olup olmadığına göre farklı iki solu kalıplarını yöneltiyoruz.
                                 En sonda da oyuncunun oynayıp oynayamaması ile ilgili bilgi vermektedir. Örneğin girdiğimiz oyuncu yabancı ise yabancı kuralı ile ilgili bir koşul sunup oynayıp oynamama durumunu sormaktadır. Türk bir oyuncu ise oynamak için herhangi bir koşul sunmamaktadır. 
 
Abstract sınıfların içersinde içine kodlarını yazabileceğimiz methodlar ve içini boş bırakabileceğimiz methodları yazabiliyoruz. Başka bir sınıfta bu abstract sınıfı kalıtım olarak alırsak eğer içi boş olan sınıfı açmak zorundayız, ama içini kod ile yazdığımız kısmı yazmak zorunda değiliz.
Bu uygulamada abstract sınıfları şu şekilde kullandım.
* Oyuncunun maça çıktığında ve gol attığında alacağı extra ücret değişmez. Bunlar abstract sınıf içerisinde içine kodlarını yazdığım methodlar
* Oyuncunun maçta oynayabilmesi için yabancı sınırı ile ilgili şartlar oyuncunun TÜRK olup olmamasına göre değişmektedir. Bu da abstract sınıfdaki içi boş olan method ile kontrol edilecektir
* Yabancı(Foreign) ve Yerli(Native) oyuncular için açtığım sınıflarla da bu abstract sınıfı kalıtım olarak aldım.

Umarım faydalı olur. 
