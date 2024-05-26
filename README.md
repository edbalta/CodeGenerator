Kodların üretilme şekli şudur:
İlk 2 hane verilen karakter kümesinden olacak şekilde tamamen rastgele seçilir.
Bu 2 hane seçiminden sonraki tüm karakterler önceki 2 hanenin ascii değerlerinin toplamının 20ye göre modu alınarak hesaplanıyor. 
Fakat bu durum olası kod sayısını sınırlayacağı için bulunan değere 0 ile 3 arasında rastgele ekleme yapıyoruz.
Yani özetle örneğin ilk iki hane A ve Z, ascii değerleri de sırayla 65 ve 90. 65+90 değerinin 20ye göre modu da 15. Bu 15 değerine 0,1,2,3 değerleri rastgele eklenebilir. 
Yani ilk 2 hanesi AZ olan bir kodun 3. hanesi karakter kümesinde 15,16,17,18 sırasında olan karakterlerden bir tanesi olabilir. Yani Y,Z,2,3. Bunların haricinde bir karakter gelmesi durumunda bu kodun bizim tarafımızdan üretilmediğini düşünebiliriz.

Bu algoritmayla üretilebilecek kod sayısı 23*23*4*4*4*4*4*4 = 2.166.784
Karakter kümesindeki karakterler kullanılarak girilen rastgele 8 haneli bir kodun doğru olma olasılığı da (4/23)^6 yani yaklaşık 36 binde 1.
Bu oran ikinci karakterin de rastgele seçilmemesini sağlayarak daha da düşürülebilir fakat bu durum olası kod sayısını azaltır ve üretilem kodlarda kopya artar.
