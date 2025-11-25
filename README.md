# 🧩 API Night – .NET Core MVC & API Entegrasyon Projesi

Bu proje, **ASP.NET Core MVC** ile hazırlanmış bir **API tüketim uygulamasıdır**. Projede kategori ve ürün yönetimi yapılabilmekte, CRUD işlemleri API üzerinden gerçekleştirilmektedir. API tarafında oluşturulan uç noktalar, MVC arayüzü üzerinden **HttpClientFactory** kullanılarak tüketilmiştir.

---

## 🚀 Proje Özeti

Bu uygulama, .NET Core API ile geliştirilmiş bir backend’den veri alıp işleyen bir MVC frontend içerir.  
Projede aşağıdaki özellikler uygulanmıştır:

- 🔄 **CRUD İşlemleri (Create, Read, Update, Delete)**  
- 🌐 **HttpClientFactory ile API Tüketimi**  
- 📦 **Kategori Yönetimi**  
- 🛒 **Ürün Yönetimi**  
- 📡 **DTO Yapısı ile Veri Transferi**  
- 🔍 **Swagger Entegrasyonu ile API Testleri**

---

## ⚙️ Kullanılan Teknolojiler

- **.NET Core 8.0**
- **ASP.NET Core MVC**
- **ASP.NET Core Web API**
- **HttpClientFactory**
- **Newtonsoft.Json**
- **DTO (Data Transfer Object) yapısı**
- **Bootstrap 5**
- **Swagger**

---


## 🧪 API Testleri – Swagger

API uç noktalarını test etmek için Swagger kullanılmıştır.

Swagger arayüzünden;

- GET /Categories  
- POST /Categories  
- DELETE /Categories  
- PUT /Categories  

gibi tüm uç noktalar manuel olarak test edilmiştir.

---

## 🔧 MVC Üzerinden API Tüketimi

Tüm controller işlemlerinde **IHttpClientFactory** kullanılmıştır:

```csharp
var client = _httpClientFactory.CreateClient();
var response = await client.GetAsync("https://localhost:7124/api/Categories");
```

API'den dönen veriler:

```csharp
var json = await response.Content.ReadAsStringAsync();
var values = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(json);
```

---

## 📝 Eklenen Ana Özellikler

### ✔ Kategori İşlemleri
- Kategori listeleme
- Kategori ekleme
- Kategori silme
- Kategori güncelleme

### ✔ Ürün İşlemleri
- Ürün listeleme
- Ürün ekleme
- Ürün silme
- Ürün güncelleme

---

## 🛠 Çalıştırma

### API'yi başlat:
```
ApiNight.WebApi
```

### MVC Arayüzünü başlat:
```
ApiNight.WebUI
```

MVC projesi açıldığında ilgili controller üzerinden API’ye istek atılır.
