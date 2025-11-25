# GitHub'a Yükleme Rehberi

Bu rehber, projenizi GitHub'a yüklemek için gereken adımları açıklar.

## 📋 Ön Hazırlık

1. **GitHub hesabı oluşturun** (henüz yoksa)
   - https://github.com adresine gidin
   - "Sign up" butonuna tıklayın ve hesap oluşturun

2. **Git kurulumunu kontrol edin**
   ```bash
   git --version
   ```
   Eğer Git yüklü değilse: https://git-scm.com/downloads

## 🚀 GitHub'a Yükleme Adımları

### 1. GitHub'da Yeni Repository Oluşturma

1. GitHub'a giriş yapın
2. Sağ üst köşedeki **"+"** butonuna tıklayın
3. **"New repository"** seçeneğini seçin
4. Repository bilgilerini doldurun:
   - **Repository name**: `SezenElifCaba_BlogSitesi` (veya istediğiniz isim)
   - **Description**: "ASP.NET Core 8.0 MVC Blog and Portfolio Management System"
   - **Visibility**: Public veya Private seçin
   - **Initialize repository**: ❌ Bu seçenekleri işaretlemeyin (README, .gitignore, license)
5. **"Create repository"** butonuna tıklayın

### 2. Projeyi Git ile Başlatma

Proje klasörünüzde PowerShell veya Command Prompt'u açın ve şu komutları çalıştırın:

```bash
# Git repository'sini başlat
git init

# Tüm dosyaları staging area'ya ekle
git add .

# İlk commit'i yap
git commit -m "Initial commit: Blog and Portfolio Management System"
```

### 3. GitHub Repository'sine Bağlama

GitHub'da oluşturduğunuz repository sayfasında, "Quick setup" bölümünden URL'yi kopyalayın (örnek: `https://github.com/kullaniciadi/SezenElifCaba_BlogSitesi.git`)

```bash
# Remote repository'yi ekle (URL'yi kendi repository URL'inizle değiştirin)
git remote add origin https://github.com/kullaniciadi/SezenElifCaba_BlogSitesi.git

# Branch'i main olarak ayarla (GitHub'ın varsayılan branch adı)
git branch -M main

# Dosyaları GitHub'a yükle
git push -u origin main
```

### 4. Kimlik Doğrulama

İlk push işleminde GitHub kimlik doğrulaması isteyebilir:

**Personal Access Token (Önerilen):**
1. GitHub → Settings → Developer settings → Personal access tokens → Tokens (classic)
2. "Generate new token" → "Generate new token (classic)"
3. İzinleri seçin (en azından `repo` seçeneğini işaretleyin)
4. Token'ı kopyalayın
5. Push yaparken şifre yerine bu token'ı kullanın

**Alternatif: GitHub CLI**
```bash
# GitHub CLI yükleyin: https://cli.github.com/
gh auth login
```

## ✅ Kontrol

1. GitHub repository sayfanızı yenileyin
2. Tüm dosyaların yüklendiğini kontrol edin
3. README.md dosyasının düzgün göründüğünü kontrol edin

## 🔄 Sonraki Güncellemeler

Projede değişiklik yaptıktan sonra GitHub'a yüklemek için:

```bash
# Değişiklikleri kontrol et
git status

# Değişiklikleri ekle
git add .

# Commit yap
git commit -m "Açıklayıcı commit mesajı"

# GitHub'a yükle
git push
```

## 📝 Önemli Notlar

### .gitignore Dosyası

Projede `.gitignore` dosyası mevcuttur ve şu dosyaları GitHub'a yüklemeyecektir:
- `bin/` ve `obj/` klasörleri
- `appsettings.Development.json` (hassas bilgiler içerebilir)
- Visual Studio ayar dosyaları
- Geçici dosyalar

### Hassas Bilgiler

**ÖNEMLİ:** `appsettings.json` dosyasında veritabanı şifreleri veya API anahtarları varsa:

1. `appsettings.json` dosyasını `.gitignore`'a ekleyin
2. `appsettings.example.json` adında bir örnek dosya oluşturun (şifreler olmadan)
3. README'de kullanıcılara `appsettings.json` dosyasını kendilerinin oluşturması gerektiğini belirtin

Örnek `.gitignore` eklemesi:
```
appsettings.json
appsettings.*.json
!appsettings.example.json
```

## 🎨 Repository Ayarları

GitHub repository sayfanızda:

1. **About** bölümünü doldurun:
   - Description ekleyin
   - Website URL (varsa)
   - Topics ekleyin: `aspnet-core`, `mvc`, `blog`, `portfolio`, `csharp`, `dotnet`

2. **Settings** → **Pages** (isteğe bağlı):
   - GitHub Pages ile projeyi yayınlayabilirsiniz

3. **Settings** → **General**:
   - Default branch: `main`
   - Features: Issues, Projects, Wiki'yi etkinleştirebilirsiniz

## 📚 Ek Kaynaklar

- [Git Documentation](https://git-scm.com/doc)
- [GitHub Guides](https://guides.github.com/)
- [GitHub Desktop](https://desktop.github.com/) - GUI alternatifi

---

## 🆘 Sorun Giderme

### "fatal: remote origin already exists" Hatası

```bash
git remote remove origin
git remote add origin https://github.com/kullaniciadi/SezenElifCaba_BlogSitesi.git
```

### "Permission denied" Hatası

- Personal Access Token kullanıyor musunuz?
- Repository'ye erişim izniniz var mı?

### Büyük Dosya Hatası

GitHub 100MB'dan büyük dosyaları kabul etmez. Eğer büyük dosyalar varsa:
- `.gitignore` dosyasına ekleyin
- Git LFS kullanın (Large File Storage)

---

Başarılar! 🎉

