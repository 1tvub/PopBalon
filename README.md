# PopBalon

Unity bootcamp Raycast ödevi için yaptığım balon atış oyunu.

## Nasıl Oynanır
- Fare ile nişan alınır.
- Oyun başlatıldıktan sonra hedef balonlara sol tık ile atış yapılır.
- Mermi bitmeden tüm balonlar patlatılırsa oyun kazanılır.
- Toplam 25 mermi vardır, mermi biterse oyun kaybedilir.

## Özellikler
- Renkli balonlar normal hedefler, siyah balonlar zor hedeflerdir.
- Renkli balonlar 2 atışta, siyah balonlar 4 atışta patlar.
- Atış raycast ile yapılır, vurulan balon impact force ile geri itilir.
- Siyah balonlar vurulunca daha uzağa itilir.
- Mermi sayısı sınırlıdır.

## Scriptler
- NisanAlma: Fare hareketiyle kamerayı döndürür.
- Atici: Sol tık ile raycast atar ve vurulan balona hasar verir.
- Balon: Balonun canını tutar, vurulunca geri iter, can bitince patlatır.
- OyunYoneticisi: Mermi ve balon sayısını takip eder, oyunun kazanılıp kaybedildiğini kontrol eder.

## Nasıl Açılır
- Unity 6 (6000.6.7f1) ile açılır.
- Assets/Scenes klasöründeki SampleScene sahnesi açılıp Play'e basılır.
- Sonuçlar Console penceresinde görünür.
