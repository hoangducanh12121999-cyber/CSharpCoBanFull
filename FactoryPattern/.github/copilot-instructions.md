# FactoryPattern Project - Copilot Instructions

## Project Overview
This is a C# .NET 9.0 console application demonstrating the Factory Pattern design pattern. The project is currently in early stages with a minimal `Vector2` utility class.

## Architecture & Key Patterns

### Factory Pattern Implementation
When implementing the Factory Pattern in this project:
- Create factory interfaces/classes that encapsulate object creation logic
- Keep factories separate from client code (see `Program.Main`)
- Factory methods should return abstractions (interfaces), not concrete types
- Example pattern: `IProductFactory` interface with concrete factory implementations

### Current Code Structure
- **Program.cs**: Contains entry point and incomplete `Vector2` class
  - `Vector2`: Custom vector implementation with operator overloading (+ operator)
  - `Main()`: Entry point where factory demonstrations should be added

## Build & Run

### Build Commands
```powershell
dotnet build
dotnet build -c Release
```

### Run Commands
```powershell
dotnet run
dotnet run --configuration Release
```

### Clean
```powershell
dotnet clean
```

## Project Configuration
- **Target Framework**: .NET 9.0
- **Output Type**: Console executable
- **Implicit Usings**: Enabled (`global using` statements auto-included)
- **Nullable Reference Types**: Enabled (strict null safety)
- **Project File**: `FactoryPattern.csproj`

## Key Development Notes

1. **Nullable Safety**: `<Nullable>enable</Nullable>` is enabled in the project. Use nullable reference types throughout new code.

2. **Global Usings**: Standard system namespaces are auto-imported. No need to add `using` statements for `System`, `System.Collections.Generic`, `System.Linq`, etc.

3. **Class Organization**: Keep factory-related classes in `Program.cs` for this single-file project, or extract to separate files as the codebase grows.

4. **No External Dependencies**: Currently uses only .NET standard library. Keep additional NuGet packages minimal unless necessary.

## Common Workflows

- **Add new factory types**: Create them in `Program.cs` or new files, then instantiate in `Main()`
- **Test implementations**: Run with `dotnet run` and verify console output
- **Debug**: Use `dotnet build` to check for compilation errors with the strict nullable rules

## References
- `Program.cs`: Entry point and current implementation
- `FactoryPattern.csproj`: Project configuration and target framework settings
