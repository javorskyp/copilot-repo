
# Copilot Instructions – MyFirstDotNetApp

## Project Architecture
- This is a simple .NET project with models in root files (`User.cs`, `Program.cs`) and API controllers expected in a `Controllers` folder (create if missing).
- Main entities: `User` (with `Id`, `Name`, `Email`) and `Order` (with `Id`, `Product`, `Price`).
- API endpoints for users, products, and orders are expected (see `project-instructions.md` for endpoint details).

## Naming Conventions
- Class names and methods use **PascalCase**.
- Variables and parameters use **camelCase**.
- DTO classes use **[JsonPropertyName]** attributes for serialization.

## Coding Style
- Add concise comments above methods.
- Each class should have a brief XML summary.
- Keep methods short and focused on one task.

## Example Model
```csharp
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
```

## Business Rules
- Orders must include a validation method to ensure `Price > 0`.
- Always validate inputs in API endpoints before saving data.

## Developer Workflows
- Build: `dotnet build`
- Run: `dotnet run`
- Add dependencies: `dotnet add package <PackageName>`
- API endpoints can be tested with Postman/curl (see `project-instructions.md`).

## Patterns & Integration
- Models are defined in root files; controllers should be placed in `Controllers/`.
- Use DTOs with explicit JSON property names for serialization.
- Validate all API inputs before persisting data.

## Key Files
- `User.cs`: User model
- `Program.cs`: Order model and entry point
- `project-instructions.md`: API usage and workflow guide
- `.github/copilot-instructions.md`: AI agent rules and conventions

# Global Copilot Instructions

These guidelines apply to the entire project.

- For backend (C#): see `.github/csharp-guidelines.md`
- For frontend (Blazor): see `.github/blazor-guidelines.md`
