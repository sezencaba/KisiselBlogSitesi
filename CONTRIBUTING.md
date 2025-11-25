# Katkıda Bulunma Rehberi

Sezen Elif CABA Blog Sitesi projesine katkıda bulunmak istediğiniz için teşekkür ederiz! Bu belge, projeye nasıl katkıda bulunabileceğinizi açıklar.

## 🤝 Nasıl Katkıda Bulunabilirsiniz?

### Hata Bildirimi (Bug Reports)

1. **GitHub Issues** üzerinden yeni bir issue oluşturun
2. Hatanın açıklamasını, adımlarını ve beklenen davranışı belirtin
3. Mümkünse ekran görüntüleri veya hata mesajları ekleyin
4. Kullandığınız .NET versiyonu ve işletim sistemini belirtin

### Özellik İstekleri (Feature Requests)

1. Yeni bir issue oluşturun ve `enhancement` etiketi ekleyin
2. Özelliğin ne yapması gerektiğini detaylıca açıklayın
3. Özelliğin neden faydalı olacağını belirtin

### Pull Request Gönderme

1. **Fork** yapın ve projeyi klonlayın
   ```bash
   git clone https://github.com/kullaniciadi/SezenElifCaba_BlogSitesi.git
   cd SezenElifCaba_BlogSitesi
   ```

2. **Branch** oluşturun
   ```bash
   git checkout -b feature/AmazingFeature
   # veya
   git checkout -b fix/BugFix
   ```

3. **Değişikliklerinizi yapın** ve commit edin
   ```bash
   git add .
   git commit -m "Add: AmazingFeature açıklaması"
   ```

4. **Push** edin
   ```bash
   git push origin feature/AmazingFeature
   ```

5. GitHub'da **Pull Request** oluşturun

## 📝 Commit Mesajları

Commit mesajlarınızı açıklayıcı tutun:

- `Add:` Yeni özellik eklendi
- `Fix:` Hata düzeltildi
- `Update:` Mevcut özellik güncellendi
- `Remove:` Özellik kaldırıldı
- `Refactor:` Kod yeniden düzenlendi
- `Docs:` Dokümantasyon güncellendi

Örnek:
```
Add: Blog yazılarına arama özelliği eklendi
Fix: Admin panelinde görüntüleme hatası düzeltildi
```

## 🧪 Test Etme

Değişikliklerinizi göndermeden önce:

- [ ] Kodunuzun çalıştığından emin olun
- [ ] Mevcut özelliklerin bozulmadığını kontrol edin
- [ ] Kodunuzu test edin

## 📋 Kod Standartları

- C# kodlama standartlarına uyun
- Anlamlı değişken ve fonksiyon isimleri kullanın
- Gereksiz yorumlar eklemeyin, kodun kendisi açıklayıcı olsun
- Entity Framework best practices'lerine uyun

## ❓ Sorularınız mı var?

Herhangi bir sorunuz varsa, bir issue oluşturabilir veya proje sahibiyle iletişime geçebilirsiniz.

---

# Contributing Guide

Thank you for your interest in contributing to Sezen Elif CABA Blog Website! This document explains how you can contribute to the project.

## 🤝 How to Contribute

### Bug Reports

1. Create a new issue on GitHub Issues
2. Describe the bug, steps to reproduce, and expected behavior
3. Include screenshots or error messages if possible
4. Specify your .NET version and operating system

### Feature Requests

1. Create a new issue and add the `enhancement` label
2. Describe in detail what the feature should do
3. Explain why the feature would be useful

### Submitting Pull Requests

1. **Fork** and clone the project
2. Create a **branch** for your changes
3. Make your **changes** and commit them
4. **Push** to your fork
5. Create a **Pull Request** on GitHub

## 📝 Commit Messages

Keep your commit messages descriptive and use prefixes:
- `Add:` for new features
- `Fix:` for bug fixes
- `Update:` for updates
- `Remove:` for removals
- `Refactor:` for refactoring
- `Docs:` for documentation

## 🧪 Testing

Before submitting your changes:
- [ ] Make sure your code works
- [ ] Check that existing features aren't broken
- [ ] Test your code

Thank you for contributing! 🎉

