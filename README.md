# Sezen Elif CABA Blog Sitesi

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-MVC-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg?style=flat-square)](LICENSE)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=flat-square&logo=microsoft-sql-server)](https://www.microsoft.com/sql-server)

ASP.NET Core 8.0 MVC tabanlı, modern ve kullanıcı dostu bir blog ve portföy yönetim sistemi.

## Overview

Bu proje, kişisel blog ve portföy yönetimi için tasarlanmış, yüksek performanslı ve kullanıcı dostu bir web uygulamasıdır. Proje, modern web teknolojileri kullanılarak geliştirilmiştir ve kolay kurulum, genişletilebilir yapı ve güvenli kimlik doğrulama özellikleri sunar.

## 📋 İçindekiler

- [Özellikler](#özellikler)
- [Teknolojiler](#teknolojiler)
- [Gereksinimler](#gereksinimler)
- [Kurulum](#kurulum)
- [Yapılandırma](#yapılandırma)
- [Kullanım](#kullanım)
- [Proje Yapısı](#proje-yapısı)
- [Lisans](#lisans)

## Key Features

### Content Management

* ✍️ **Blog Management** - Create, edit, delete, and view blog posts with rich text editor
* 🎨 **Project Portfolio** - Showcase and manage your projects with images
* 📧 **Contact Form** - Receive and manage visitor messages
* 🎛️ **Admin Panel** - Central management panel for all content

### Technical Features

* 🔐 **Authentication** - Secure cookie-based login system
* 📝 **Rich Text Editor** - Advanced content editing with CKEditor
* 📱 **Responsive Design** - Mobile-friendly interface with Bootstrap
* 🗄️ **Database Migrations** - Automatic database setup with Entity Framework Core
* 🔒 **Security** - SQL injection protection and authorization policies

## Technical Highlights

Bu proje, yüksek performanslı ve modern bir blog yönetim sistemi sunmak için aşağıdaki teknolojileri kullanır:

* **ASP.NET Core 8.0** - Modern, cross-platform web framework
* **Entity Framework Core 8.0** - ORM for database operations
* **SQL Server** - Relational database management system
* **Bootstrap 5** - Responsive CSS framework
* **jQuery** - JavaScript library for DOM manipulation
* **CKEditor** - Rich text editor for content creation
* **Razor Pages** - Server-side rendered views

## 📦 Gereksinimler

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) veya SQL Server Express
- Visual Studio 2022 veya Visual Studio Code (önerilen)

## 🚀 Kurulum

1. **Projeyi klonlayın:**
   ```bash
   git clone https://github.com/kullaniciadi/SezenElifCaba_BlogSitesi.git
   cd SezenElifCaba_BlogSitesi
   ```

2. **Veritabanı bağlantı string'ini yapılandırın:**
   
   `appsettings.example.json` dosyasını `appsettings.json` olarak kopyalayın ve `ConnectionStrings` bölümünü kendi veritabanı bilgilerinizle güncelleyin:
   
   ```bash
   cp appsettings.example.json appsettings.json
   ```
   
   Sonra `appsettings.json` dosyasını düzenleyin:
   
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;TrustServerCertificate=True;"
     }
   }
   ```

3. **Veritabanı migration'larını çalıştırın:**
   
   Proje otomatik olarak migration'ları çalıştıracaktır. Manuel olarak çalıştırmak isterseniz:
   
   ```bash
   dotnet ef database update
   ```

4. **Projeyi çalıştırın:**
   ```bash
   dotnet run
   ```

   Veya Visual Studio'da F5 tuşuna basarak çalıştırabilirsiniz.

5. **Tarayıcıda açın:**
   
   Proje genellikle `https://localhost:5001` veya `http://localhost:5000` adresinde çalışır.

## ⚙️ Yapılandırma

### Veritabanı Bağlantısı

`appsettings.json` dosyasında veritabanı bağlantı string'inizi yapılandırın. Geliştirme ortamı için `appsettings.Development.json` dosyasını da kullanabilirsiniz.

### Kimlik Doğrulama

Proje cookie tabanlı kimlik doğrulama kullanmaktadır. Admin kullanıcısı oluşturmak için veritabanına manuel olarak kullanıcı eklemeniz gerekebilir.

### Dosya Yükleme

Blog ve proje fotoğrafları `wwwroot/images/` klasörüne kaydedilir:
- Blog görselleri: `wwwroot/images/Blogimg/`
- Proje görselleri: `wwwroot/images/Projeimg/`

## 📖 Kullanım

### Admin Paneli

1. `/Security/Login` adresinden giriş yapın
2. Admin paneline erişim için yetkili kullanıcı olmanız gerekir
3. Admin panelinden blog yazıları, projeler ve iletişim mesajlarını yönetebilirsiniz

### Blog Yönetimi

- **Blog Listesi**: `/Blog/Index` - Tüm blog yazılarını görüntüleme
- **Yeni Blog**: `/Blog/Create` - Yeni blog yazısı oluşturma
- **Blog Düzenle**: `/Blog/Edit/{id}` - Mevcut blog yazısını düzenleme
- **Blog Sil**: `/Blog/Delete/{id}` - Blog yazısını silme

### Proje Yönetimi

- **Proje Listesi**: `/Project/Index` - Tüm projeleri görüntüleme
- **Yeni Proje**: `/Project/Create` - Yeni proje ekleme
- **Proje Düzenle**: `/Project/Edit/{id}` - Mevcut projeyi düzenleme

### İletişim Yönetimi

- **Mesaj Listesi**: `/Contact/Index` - Gelen mesajları görüntüleme
- **Mesaj Detayı**: `/Contact/Details/{id}` - Mesaj detaylarını görüntüleme

## 📁 Proje Yapısı

```
SezenElifCaba_BlogSitesi/
├── Controllers/          # MVC Controller'ları
│   ├── AdminController.cs
│   ├── BlogController.cs
│   ├── ContactController.cs
│   ├── HomeController.cs
│   ├── ProjectController.cs
│   └── SecurityController.cs
├── Models/              # Veri modelleri
│   ├── Context/         # DbContext
│   └── Entities/        # Entity sınıfları
├── Views/               # Razor view'ları
│   ├── Admin/
│   ├── Blog/
│   ├── Contact/
│   ├── Home/
│   ├── Project/
│   ├── Security/
│   └── Shared/
├── Migrations/          # Entity Framework migrations
├── wwwroot/             # Statik dosyalar
│   ├── css/
│   ├── js/
│   ├── images/
│   └── lib/
├── Program.cs           # Uygulama giriş noktası
└── appsettings.json     # Yapılandırma dosyası
```

## 🔒 Güvenlik

- Cookie tabanlı kimlik doğrulama
- Yetkilendirme politikaları
- HTTPS yönlendirmesi (production)
- SQL injection koruması (Entity Framework)

## 📝 Notlar

- İlk çalıştırmada veritabanı otomatik olarak oluşturulur
- Admin kullanıcısı oluşturmak için veritabanına manuel olarak kullanıcı eklemeniz gerekebilir
- Geliştirme ortamında `appsettings.Development.json` kullanılır

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For detailed information on how to contribute, please see our [Contributing Guide](CONTRIBUTING.md).

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👤 Author

**Sezen Elif CABA**

---

## Screenshots

Proje ekran görüntüleri için `screenshots/` klasörüne bakabilirsiniz:
- Ana Sayfa
- Blog Sayfası
- Projeler Sayfası
- İletişim Sayfası
- Admin Paneli

---

## 🌐 English

# Sezen Elif CABA Blog Website

A modern and user-friendly blog and portfolio management system built with ASP.NET Core 8.0 MVC.

### Features

- **Blog Management**: Create, edit, delete, and view blog posts
- **Project Portfolio**: Showcase and manage your projects
- **Contact Form**: Receive and manage visitor messages
- **Admin Panel**: Central management panel for all content
- **Authentication**: Secure cookie-based login system
- **Rich Text Editor**: Advanced content editing with CKEditor
- **Responsive Design**: Mobile-friendly interface with Bootstrap

### Technologies

- .NET 8.0
- ASP.NET Core MVC
- Entity Framework Core 8.0.20
- SQL Server
- Bootstrap
- jQuery
- CKEditor

### Installation

1. Clone the repository
2. Configure the database connection string in `appsettings.json`
3. Run migrations (automatic on first run)
4. Run the project with `dotnet run`

For detailed instructions, see the Turkish section above.


