Almış olduğu iki yazı (string) parametresini ölçüp birinin herhangi bir permutasyonunun diğerinin içinde olup olmadığının mantıksal (boolean) karşılığını döndüren programda girdiğimiz değerleri yazdığımız fonksiyon üzerinde önce karaktelerine ayırarak dizilerimize ekleme yaptık.

Diziye eklenenlerden sonra if koşulu kullanarak değerlerimiz uzunluğunu ölçüp işlemimizi ona göre yapmasını eğer girilen "1.değer 2.değerden büyük ise 2.değerin 1.değer içerisinde olup olmadığına bak" else kısmında da tam tersi şeklinde çalışmasını sağladık.

İf koşulunun içerisinde döngü kullanarak değerlerimizin uzunluğu kadar harfleri denemesini indexof methodu ile yaptık.Eğer yazdığımız koşul sağlanmaz ise ekrana false, sağlandığı durumda ise ekrana true döndürmesini sağladık.

String IndexOf yöntemi ile tanımlı olan string değerde aranan char karakteri, ilk eşleşen değerin index numarasını geriye döner. Bu yöntem ile string bir ifade içerisinde karakter araması yapılır.
