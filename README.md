# CartFlow

.NET 9 ile geliştirilmiş, monolitik mimaride e-ticaret sepet motoru.
İndirim kuralları sepet mantığından bağımsız tutularak genişletilebilir bir yapı hedeflenmiştir.

---

## Motivasyon

Geleneksel sepet implementasyonlarında indirim hesaplamaları doğrudan sepet sınıfına gömülür.
Bu yaklaşım, her yeni kural eklendiğinde mevcut kodu kırmak zorunda bırakır.
CartFlow bu sorunu çözmek için indirim mantığını soyutlanmış bir katmana taşır.

---

## Teknolojiler

- .NET 9
- C#
- Monolithic Architecture
- Entity Framework Core

---

## Temel Özellikler

- Sepet oluşturma, ürün ekleme/çıkarma
- İndirim kurallarını sınıf kırmadan genişletme
- Kupon, miktar ve kategori bazlı indirim desteği
- RESTful API

---

## Kurulum

```bash
git clone https://github.com/Muhammed-Samil-Ozdemir/CartFlow.git
cd CartFlow
dotnet restore
dotnet run --project CartFlow.API
```

---

## Katkı

Pull request açmadan önce ilgili branch'i oluşturun ve değişikliği küçük tutun.
Her indirim kuralı ayrı bir sınıf olarak eklenmelidir.