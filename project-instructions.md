
# Instrukcje dotyczące projektu MyFirstDotNetApp

## Jak uruchomić projekt

1. Upewnij się, że masz zainstalowany .NET SDK (zalecana wersja 9.0 lub wyższa).
2. Otwórz terminal w katalogu projektu.
3. Zbuduj projekt:
   ```
   dotnet build
   ```
4. Uruchom projekt:
   ```
   dotnet run
   ```

## Dostępne endpointy API

Po uruchomieniu aplikacji możesz korzystać z następujących endpointów:

- `GET /api/users` – pobiera listę użytkowników
- `POST /api/users` – dodaje nowego użytkownika
- `GET /api/products` – pobiera listę produktów
- `POST /api/products` – dodaje nowy produkt
- `GET /api/orders` – pobiera listę zamówień
- `POST /api/orders` – dodaje nowe zamówienie

Możesz testować API za pomocą narzędzi takich jak Postman lub curl.

## Struktura projektu

- Kontrolery API znajdują się w folderze `Controllers`.
- Przykładowe modele (np. `Order`) znajdują się w plikach źródłowych projektu, np. w `Program.cs`.
- Możesz dodawać kolejne klasy modeli w osobnych plikach lub rozbudowywać istniejące.

## Rozszerzanie projektu

- Aby dodać nowe funkcje, edytuj lub dodaj nowe kontrolery w folderze `Controllers`.
- Dodawaj modele i logikę biznesową według potrzeb.

## Wskazówki

- Jeśli pojawią się błędy, sprawdź czy wszystkie zależności są zainstalowane.
- W razie potrzeby zainstaluj pakiet ASP.NET Core:
  ```
  dotnet add package Microsoft.AspNetCore.App
  ```
- Dokumentacja .NET: https://learn.microsoft.com/en-us/dotnet/core/

---
W razie pytań lub problemów napisz!