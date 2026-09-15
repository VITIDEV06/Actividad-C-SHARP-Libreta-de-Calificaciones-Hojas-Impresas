<div align="center">

# ACTIVIDAD — LIBRETA DE CALIFICACIONES EN C#

### C# · .NET · Clases · Objetos · Ciclo `while` · Consola

<br>

<img src="assets/banner-libretacalificaciones-csharp.jpg" alt="Libreta de Calificaciones en C#">

<br><br>

**Victor Montes**
**Universidad Tecnológica de Panamá — UTP**
**Facultad de Ingeniería de Sistemas Computacionales — FISC**

<br>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge\&logo=csharp\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge\&logo=visualstudio\&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge\&logo=git\&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge\&logo=github\&logoColor=white)

<br>

**Fecha:** 15/09/2026

</div>

---

## 1. Información de la Actividad

<div align="center">

|                    |                                  |
| ------------------ | -------------------------------- |
| **Actividad**   | Libreta de Calificaciones        |
| **Lenguaje**    | C#                               |
| **Plataforma**  | .NET 10                          |
| **Aplicación** | Consola                          |
| **Estructura**  | `while`                          |
| **Paradigma**   | Programación Orientada a Objetos |
| **Autor**    | Victor Montes                    |
| **Institución** | UTP — FISC                       |

</div>

---

## 2. Contenido del Repositorio

<div align="center">

<table>
<tr>

<td align="center">
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" width="60">

**C#**

</td>

<td align="center">
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg" width="60">

**.NET**

</td>

<td align="center">
<img src="https://img.icons8.com/fluency/96/class.png" width="60">

**CLASES**

</td>

<td align="center">
<img src="https://img.icons8.com/fluency/96/object.png" width="60">

**OBJETOS**

</td>

<td align="center">
<img src="https://img.icons8.com/fluency/96/repeat.png" width="60">

**WHILE**

</td>

<td align="center">
<img src="https://img.icons8.com/fluency/96/calculator.png" width="60">

**PROMEDIO**

</td>

</tr>
</table>

</div>

La actividad desarrolla una aplicación de consola para registrar **10 calificaciones**, calcular su total y obtener el promedio de la clase.

```mermaid
flowchart LR

    A["📥 10 CALIFICACIONES"] --> B["➕ ACUMULAR"]
    B --> C["🧮 CALCULAR"]
    C --> D["📊 RESULTADO"]

    classDef input fill:#172554,stroke:#60A5FA,color:#FFFFFF,stroke-width:3px;
    classDef process fill:#3B0764,stroke:#C084FC,color:#FFFFFF,stroke-width:3px;
    classDef result fill:#064E3B,stroke:#34D399,color:#FFFFFF,stroke-width:3px;

    class A input;
    class B,C process;
    class D result;
```

---

## 3. Tecnologías Utilizadas

<div align="center">

<table>
<tr>

<td align="center" width="150">

<img src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white" width="105">

<br>

**C#**

</td>

<td align="center" width="150">

<img src="https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" width="105">

<br>

**.NET**

</td>

<td align="center" width="150">

<img src="https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat-square&logo=visualstudio&logoColor=white" width="105">

<br>

**Visual Studio**

</td>

<td align="center" width="150">

<img src="https://img.shields.io/badge/Git-F05032?style=flat-square&logo=git&logoColor=white" width="90">

<br>

**Git**

</td>

<td align="center" width="150">

<img src="https://img.shields.io/badge/GitHub-181717?style=flat-square&logo=github&logoColor=white" width="90">

<br>

**GitHub**

</td>

</tr>
</table>

</div>

---

## 4. Estructura del Proyecto

```text
Actividad-C-SHARP-Libreta-de-Calificaciones-Hojas-Impresas/
│
└── Codigo#1 - Victor Montes/
    │
    ├── Codigo#1 - Victor Montes.slnx
    │
    └── Codigo#1 - Victor Montes/
        │
        ├── Program.cs
        ├── Class1.cs
        └── Codigo#1 - Victor Montes.csproj
```

```mermaid
flowchart TD

    A["📁 Proyecto"] --> B["📄 Program.cs"]
    A --> C["📄 Class1.cs"]
    A --> D["⚙️ .csproj"]
    A --> E["🧩 .slnx"]

    B --> F["Main()"]
    C --> G["LibroCalificaciones"]

    G --> H["Constructor"]
    G --> I["NombreCurso"]
    G --> J["MostrarMensaje()"]
    G --> K["DeterminarPromedioClase()"]

    classDef project fill:#111827,stroke:#38BDF8,color:#FFFFFF,stroke-width:3px;
    classDef file fill:#172554,stroke:#60A5FA,color:#FFFFFF,stroke-width:2px;
    classDef code fill:#3B0764,stroke:#C084FC,color:#FFFFFF,stroke-width:2px;

    class A project;
    class B,C,D,E file;
    class F,G,H,I,J,K code;
```

---

## 5. Clase `LibroCalificaciones`

```mermaid
classDiagram

    class LibroCalificaciones {
        -string nombreCurso
        +string NombreCurso
        +LibroCalificaciones(string nombre)
        +void MostrarMensaje()
        +void DeterminarPromedioClase()
    }

    class PruebaLibroCalificaciones {
        +Main(string[] args)
    }

    PruebaLibroCalificaciones --> LibroCalificaciones
```

<div align="center">

| 🧩 Elemento                 | ⚙️ Función                   |
| --------------------------- | ---------------------------- |
| `nombreCurso`               | Almacena el nombre del curso |
| `NombreCurso`               | Propiedad `get / set`        |
| Constructor                 | Inicializa el curso          |
| `MostrarMensaje()`          | Muestra bienvenida           |
| `DeterminarPromedioClase()` | Procesa las calificaciones   |

</div>

---

## 6. Creación del Objeto

```mermaid
flowchart LR

    A["Program.cs"] --> B["new"]
    B --> C["LibroCalificaciones"]
    C --> D["Constructor"]
    D --> E["NombreCurso"]

    classDef main fill:#111827,stroke:#38BDF8,color:#FFFFFF,stroke-width:3px;
    classDef object fill:#172554,stroke:#60A5FA,color:#FFFFFF,stroke-width:3px;
    classDef constructor fill:#3B0764,stroke:#C084FC,color:#FFFFFF,stroke-width:3px;
    classDef property fill:#064E3B,stroke:#34D399,color:#FFFFFF,stroke-width:3px;

    class A main;
    class B,C object;
    class D constructor;
    class E property;
```

```csharp
LibroCalificaciones miLibroCalificaciones =
    new LibroCalificaciones(
        "CS101 Introducción a la programación en C#"
    );
```

---

## 7. Propiedad `NombreCurso`

```mermaid
flowchart LR

    A["NombreCurso"] --> B["GET"]
    A --> C["SET"]

    B --> D["Obtener valor"]
    C --> E["Modificar valor"]

    D --> F["nombreCurso"]
    E --> F

    classDef property fill:#3B0764,stroke:#C084FC,color:#FFFFFF,stroke-width:3px;
    classDef access fill:#713F12,stroke:#FACC15,color:#FFFFFF,stroke-width:3px;
    classDef value fill:#064E3B,stroke:#34D399,color:#FFFFFF,stroke-width:3px;

    class A property;
    class B,C access;
    class D,E,F value;
```

```csharp
public string NombreCurso
{
    get
    {
        return nombreCurso;
    }

    set
    {
        nombreCurso = value;
    }
}
```

---

## 8. Registro de Calificaciones

```mermaid
flowchart TD

    A["🔢 contadorCalif = 1"] --> B{"contadorCalif <= 10"}
    B -- "Sí" --> C["⌨️ Leer calificación"]
    C --> D["🔄 Convertir a entero"]
    D --> E["➕ total += calificación"]
    E --> F["🔢 contadorCalif++"]
    F --> B
    B -- "No" --> G["✅ Finalizar"]

    classDef start fill:#111827,stroke:#38BDF8,color:#FFFFFF,stroke-width:3px;
    classDef condition fill:#713F12,stroke:#FACC15,color:#FFFFFF,stroke-width:3px;
    classDef process fill:#172554,stroke:#60A5FA,color:#FFFFFF,stroke-width:2px;
    classDef finish fill:#064E3B,stroke:#34D399,color:#FFFFFF,stroke-width:3px;

    class A start;
    class B condition;
    class C,D,E,F process;
    class G finish;
```

```csharp
while (contadorCalif <= 10)
{
    Console.Write("Escriba calificación: ");

    calificacion =
        Convert.ToInt32(Console.ReadLine());

    total = total + calificacion;

    contadorCalif = contadorCalif + 1;
}
```

---

## 9. Cálculo del Promedio

<div align="center">

<table>
<tr>

<td align="center">

### 📥 ENTRADA

**10 calificaciones**

</td>

<td align="center">

### ➕

**Acumulación**

</td>

<td align="center">

### 🧮

**Total ÷ 10**

</td>

<td align="center">

### 📊 SALIDA

**Promedio**

</td>

</tr>
</table>

</div>

```csharp
promedio = total / 10;
```

```mermaid
flowchart LR

    A["90"] --> E["880"]
    B["85"] --> E
    C["95"] --> E
    D["80 ..."] --> E

    E --> F["÷ 10"]
    F --> G["88"]

    classDef grade fill:#172554,stroke:#60A5FA,color:#FFFFFF,stroke-width:2px;
    classDef total fill:#3B0764,stroke:#C084FC,color:#FFFFFF,stroke-width:3px;
    classDef result fill:#064E3B,stroke:#34D399,color:#FFFFFF,stroke-width:3px;

    class A,B,C,D grade;
    class E,F total;
    class G result;
```

---

## 10. Flujo de la Aplicación

```mermaid
flowchart TD

    A["▶ INICIO"] --> B["Crear LibroCalificaciones"]
    B --> C["MostrarMensaje()"]
    C --> D["DeterminarPromedioClase()"]
    D --> E["🔢 10 calificaciones"]
    E --> F["➕ Total"]
    F --> G["🧮 Promedio"]
    G --> H["📊 Mostrar resultados"]
    H --> I["■ FIN"]

    classDef start fill:#111827,stroke:#38BDF8,color:#FFFFFF,stroke-width:3px;
    classDef process fill:#172554,stroke:#60A5FA,color:#FFFFFF,stroke-width:2px;
    classDef calculation fill:#3B0764,stroke:#C084FC,color:#FFFFFF,stroke-width:3px;
    classDef result fill:#064E3B,stroke:#34D399,color:#FFFFFF,stroke-width:3px;

    class A,I start;
    class B,C,D,E process;
    class F,G calculation;
    class H result;
```

---

## 11. Capturas de Pantalla

### Ejecución

<div align="center">

<img src="assets/actividad-ejecucion.png" alt="Ejecución de la aplicación" width="850">

</div>

### Ingreso de Calificaciones

<div align="center">

<img src="assets/actividad-calificaciones.png" alt="Ingreso de calificaciones" width="850">

</div>

### Resultado

<div align="center">

<img src="assets/actividad-resultado.png" alt="Resultado de la aplicación" width="850">

</div>

---

## 12. Salida del Programa

```text
Bienvenido al libro de calificaciones de
CS101 Introducción a la programación en C#!

Escriba calificación: 90
Escriba calificación: 85
Escriba calificación: 95
Escriba calificación: 80
Escriba calificación: 88
Escriba calificación: 92
Escriba calificación: 75
Escriba calificación: 89
Escriba calificación: 100
Escriba calificación: 86

El total de las 10 calificaciones es 880
El promedio de la clase es 88
```

---

## 13. Conceptos Aplicados

<div align="center">

| 🧩  | Concepto    | 🧩 | Concepto        |
| --- | ----------- | -- | --------------- |
| 📦  | Clase       | 🧍 | Objeto          |
| 🏗️ | Constructor | 🔐 | Encapsulamiento |
| ⚙️  | Métodos     | 🔄 | `while`         |
| 📥  | Entrada     | 📤 | Salida          |
| ➕   | Acumulador  | 🔢 | Contador        |
| 🧮  | Promedio    | 🔠 | Conversión      |

</div>

---

## 14. Ejecución

### Visual Studio

```text
Abrir solución
      ↓
Codigo#1 - Victor Montes.slnx
      ↓
Ejecutar ▶
      ↓
Ingresar 10 calificaciones
      ↓
Ver resultado
```

### Terminal

```bash
dotnet run
```

---

## 15. Autor y Contexto

<div align="center">

<img src="https://img.shields.io/badge/Victor%20Montes-UTP-0F172A?style=for-the-badge">

<br><br>

**Universidad Tecnológica de Panamá — UTP**

**Facultad de Ingeniería de Sistemas Computacionales — FISC**

**Ingeniería en Sistemas y Computación**

<br>

**15/09/2026**

</div>

---

## 16. Referencias

<div align="center">

[![C#](https://img.shields.io/badge/C%23-Documentation-239120?style=for-the-badge\&logo=csharp\&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-Documentation-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)](https://learn.microsoft.com/en-us/dotnet/)
[![Visual Studio](https://img.shields.io/badge/Visual%20Studio-Documentation-5C2D91?style=for-the-badge\&logo=visualstudio\&logoColor=white)](https://learn.microsoft.com/en-us/visualstudio/)

</div>

---

<div align="center">

### C# · .NET · POO · Consola

<br>

**Victor Montes**

**Universidad Tecnológica de Panamá**

</div>
