# Szyfr Vigenère'a w ASP.NET

## Opis
Projekt implementuje szyfr Vigenère'a w środowisku ASP.NET. Szyfr Vigenère'a jest techniką szyfrowania tekstu przy użyciu serii różnych przesunięć Cezara opartych na literach klucza. Aplikacja umożliwia szyfrowanie i deszyfrowanie tekstu z wykorzystaniem niestandardowego alfabetu zawierającego polskie znaki diakrytyczne.

### Główne funkcje
- **Szyfrowanie tekstu**: Użytkownik może wprowadzić dowolny tekst i klucz, aby uzyskać zaszyfrowaną wersję tekstu.
- **Deszyfrowanie tekstu**: Możliwość odszyfrowania tekstu zaszyfrowanego przy użyciu tego samego klucza.

## Jak uruchomić
Projekt został stworzony przy użyciu ASP.NET i wymaga środowiska .NET do uruchomienia. Po sklonowaniu repozytorium wystarczy uruchomić projekt w środowisku Visual Studio lub innym kompatybilnym IDE.

## Struktura projektu
Projekt składa się z kilku kluczowych plików:
- `VigenereService.cs`: Serwis realizujący logikę szyfru Vigenère'a.
- `VigenereController.cs`: Kontroler MVC obsługujący interfejs użytkownika.
- `Szyfrowanie.cshtml` oraz `Odszyfrowanie.cshtml`: Widoki Razor do interakcji z użytkownikiem.

## Technologie
- .NET 6
- ASP.NET MVC
- Razor Views

## Licencja
Projekt jest udostępniany na licencji [MIT](https://choosealicense.com/licenses/mit/).
