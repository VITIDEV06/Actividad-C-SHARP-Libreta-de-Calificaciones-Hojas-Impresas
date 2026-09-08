# Laboratorio — Clases en C#

<div align="center">

<img src="https://img.shields.io/badge/C%23-Programming-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="C#">
<img src="https://img.shields.io/badge/.NET-Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET">
<img src="https://img.shields.io/badge/OOP-Object--Oriented-6A5ACD?style=for-the-badge" alt="Object Oriented Programming">
<img src="https://img.shields.io/badge/GitHub-Repository-181717?style=for-the-badge&logo=github&logoColor=white" alt="GitHub">

<br>

**Programación Orientada a Objetos · C# · Control de Repetición**

</div>

---

## Descripción

Este repositorio contiene una actividad práctica desarrollada en **C#** cuyo objetivo principal es reforzar los fundamentos de la **Programación Orientada a Objetos (POO)** mediante la creación y utilización de una clase denominada `LibroCalificaciones`.

La actividad implementa dos versiones de un sistema sencillo para calcular el promedio de calificaciones de una clase. Aunque ambas soluciones utilizan una estructura similar, cada una emplea un mecanismo diferente para controlar la repetición:

* **Programa 1:** repetición controlada por un **contador**.
* **Programa 2:** repetición controlada mediante un **valor centinela**.

De esta manera, la actividad permite comparar dos estrategias fundamentales para controlar ciclos dentro de un programa.

---

## Objetivos

* Comprender la estructura básica de una clase en C#.
* Crear y utilizar objetos mediante constructores.
* Aplicar conceptos de **encapsulamiento**.
* Trabajar con propiedades `get` y `set`.
* Implementar métodos dentro de una clase.
* Utilizar entrada y salida de datos mediante consola.
* Aplicar ciclos `while`.
* Utilizar contadores y acumuladores.
* Implementar ciclos controlados por contador.
* Implementar ciclos controlados por centinela.
* Calcular promedios a partir de datos introducidos por el usuario.
* Comparar diferentes estrategias de repetición.

---

## Tecnologías utilizadas

<div align="center">

<img src="https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white" alt="C#">
<img src="https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white" alt=".NET">
<img src="https://img.shields.io/badge/Console-Application-333333?style=flat-square&logo=windows-terminal&logoColor=white" alt="Console Application">
<img src="https://img.shields.io/badge/OOP-6A5ACD?style=flat-square" alt="OOP">
<img src="https://img.shields.io/badge/Git-FFD54F?style=flat-square&logo=git&logoColor=black" alt="Git">
<img src="https://img.shields.io/badge/GitHub-181717?style=flat-square&logo=github&logoColor=white" alt="GitHub">

</div>

---

## Estructura del proyecto

La actividad está organizada en dos programas independientes que utilizan una estructura similar:

```text
.
├── Programa 1/
│   ├── Program.cs
│   └── Class.cs
│
├── Programa 2/
│   ├── Program.cs
│   └── Class.cs
│
└── README.md
```

### `Program.cs`

Contiene el punto de entrada de la aplicación mediante el método:

```csharp
Main()
```

Su responsabilidad principal es crear una instancia de `LibroCalificaciones` y ejecutar sus métodos.

### `Class.cs`

Contiene la implementación de la clase:

```csharp
LibroCalificaciones
```

Esta clase concentra la información y el comportamiento relacionado con el libro de calificaciones.

---

# Programa 1 — Repetición controlada por contador

## Descripción

La primera solución utiliza un ciclo `while` controlado mediante un contador.

El programa solicita exactamente **10 calificaciones** al usuario. Cada valor introducido se acumula y, una vez completadas las diez iteraciones, se calcula el promedio.

### Flujo de ejecución

```text
        ┌──────────────────────┐
        │ Iniciar programa     │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ Crear objeto         │
        │ LibroCalificaciones  │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ Mostrar bienvenida   │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ contadorCalif = 1   │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ ¿contador <= 10?     │
        └───────┬────────┬─────┘
                │ Sí     │ No
                ▼        ▼
        ┌─────────────┐  ┌─────────────────┐
        │ Leer nota   │  │ Calcular        │
        │ y acumular  │  │ promedio        │
        └──────┬──────┘  └────────┬────────┘
               │                  │
               ▼                  ▼
        ┌─────────────┐    ┌──────────────┐
        │ Incrementar │    │ Mostrar      │
        │ contador    │    │ resultados   │
        └──────┬──────┘    └──────┬───────┘
               │                  │
               └───────┐          │
                       ▼          ▼
                    Repetir     Fin
```

## Características

| Característica        | Implementación       |
| --------------------- | -------------------- |
| Control de repetición | Contador             |
| Número de entradas    | 10                   |
| Variable de control   | `contadorCalif`      |
| Acumulador            | `total`              |
| Tipo del promedio     | `int`                |
| Ciclo utilizado       | `while`              |
| Entrada               | `Console.ReadLine()` |

### Concepto principal

El ciclo continúa mientras:

```csharp
while (contadorCalif <= 10)
```

Esto garantiza que el usuario introduzca exactamente diez calificaciones.

---

# Programa 2 — Repetición controlada por centinela

## Descripción

La segunda solución modifica la estrategia utilizada para controlar el ciclo.

En lugar de establecer una cantidad fija de calificaciones, el usuario puede introducir **tantas calificaciones como desee**.

Para finalizar la introducción de datos se utiliza el valor:

```text
-1
```

Este valor recibe el nombre de **centinela**, ya que indica al programa que debe finalizar el ciclo.

### Flujo de ejecución

```text
        ┌──────────────────────┐
        │ Iniciar programa     │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ Crear objeto         │
        │ LibroCalificaciones  │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ Solicitar            │
        │ calificación         │
        └──────────┬───────────┘
                   │
                   ▼
        ┌──────────────────────┐
        │ ¿Calificación = -1?  │
        └───────┬────────┬─────┘
                │ No     │ Sí
                ▼        ▼
        ┌─────────────┐  ┌──────────────────┐
        │ Acumular    │  │ ¿Hay notas?      │
        │ calificación│  └──────┬─────┬─────┘
        └──────┬──────┘         │ Sí  │ No
               │                ▼     ▼
               ▼          ┌────────┐ ┌──────────┐
        ┌─────────────┐   │Calcular│ │ Mostrar  │
        │ Incrementar │   │promedio│ │ mensaje  │
        │ contador    │   └────┬───┘ │ de error │
        └──────┬──────┘        │      └────┬─────┘
               │               ▼           │
               └───────►  Mostrar          │
                          resultados ◄──────┘
```

## Características

| Característica        | Implementación                             |
| --------------------- | ------------------------------------------ |
| Control de repetición | Centinela                                  |
| Número de entradas    | Variable                                   |
| Valor centinela       | `-1`                                       |
| Variable de control   | `calificacion`                             |
| Acumulador            | `total`                                    |
| Tipo del promedio     | `double`                                   |
| Ciclo utilizado       | `while`                                    |
| Validación            | Comprobación de cantidad de calificaciones |

### Concepto principal

El ciclo continúa mientras el usuario no introduzca el valor centinela:

```csharp
while (calificacion != -1)
```

Esto permite determinar dinámicamente cuándo debe finalizar la entrada de datos.

---

# Comparación entre ambos programas

Una de las partes fundamentales de la actividad es observar cómo un mismo problema puede resolverse utilizando diferentes mecanismos de control de repetición.

| Aspecto          | Programa 1            | Programa 2            |
| ---------------- | --------------------- | --------------------- |
| Estrategia       | Contador              | Centinela             |
| Entradas         | Exactamente 10        | Ilimitadas hasta `-1` |
| Control          | `contadorCalif <= 10` | `calificacion != -1`  |
| Promedio         | Entero                | Decimal               |
| Tipo             | `int`                 | `double`              |
| Precisión        | Sin decimales         | 2 decimales           |
| Manejo sin datos | No aplica             | Sí                    |
| Flexibilidad     | Baja                  | Mayor                 |

### Diferencia conceptual

**Control por contador**

```text
"Repite una cantidad determinada de veces."
```

**Control por centinela**

```text
"Repite hasta que ocurra una condición específica."
```

Esta diferencia es especialmente importante al diseñar algoritmos, ya que la estrategia adecuada depende de si conocemos previamente la cantidad de datos que serán procesados.

---

# Conceptos de Programación Orientada a Objetos

Ambos programas utilizan una misma clase:

```csharp
LibroCalificaciones
```

La clase representa un libro de calificaciones y encapsula tanto sus datos como las operaciones que pueden realizarse sobre ellos.

## Encapsulamiento

El nombre del curso se mantiene como un campo privado:

```csharp
private string nombreCurso;
```

El acceso se realiza mediante la propiedad:

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

Esto permite controlar cómo se accede al dato desde fuera de la clase.

---

## Constructor

La clase dispone de un constructor:

```csharp
public LibroCalificaciones(string nombre)
{
    NombreCurso = nombre;
}
```

Su función es inicializar el objeto cuando este es creado.

Ejemplo:

```csharp
LibroCalificaciones miLibroCalificaciones =
    new LibroCalificaciones(
        "CS101 Introducción a la programación en C#"
    );
```

---

## Métodos

La clase proporciona métodos para realizar diferentes operaciones.

### Mostrar mensaje

```csharp
MostrarMensaje()
```

Muestra un mensaje de bienvenida junto con el nombre del curso.

### Determinar promedio

Programa 1:

```csharp
DeterminarPromedioClase()
```

Programa 2:

```csharp
DeterminaPromedioClase()
```

Ambos métodos calculan el promedio, pero utilizan diferentes estrategias de repetición.

---

# Entrada y procesamiento de datos

Los programas utilizan la consola para recibir información del usuario:

```csharp
Console.ReadLine();
```

Posteriormente, el texto recibido se convierte a entero mediante:

```csharp
Convert.ToInt32(Console.ReadLine());
```

El acumulador:

```csharp
total = total + calificacion;
```

permite sumar progresivamente todas las calificaciones introducidas.

El contador:

```csharp
contadorCalif = contadorCalif + 1;
```

registra la cantidad de calificaciones procesadas.

---

# Cálculo del promedio

## Programa 1

Como siempre se introducen diez calificaciones:

```csharp
promedio = total / 10;
```

El resultado se almacena como `int`, por lo que se realiza una división entera.

## Programa 2

La cantidad de calificaciones puede variar:

```csharp
promedio = (double)total / contadorCalif;
```

La conversión a `double` permite obtener un resultado decimal.

Además, el resultado se muestra con dos posiciones decimales:

```csharp
Console.WriteLine(
    "El promedio de la clase es {0:F2}",
    promedio
);
```

---

# Manejo de casos especiales

El segundo programa incorpora una validación para comprobar si el usuario introdujo al menos una calificación:

```csharp
if (contadorCalif != 0)
```

Si no se introdujeron calificaciones, se muestra:

```text
No se introdujeron calificaciones.
```

Esta comprobación evita intentar calcular un promedio utilizando una cantidad de datos igual a cero.

---

# Ejemplo de ejecución

## Programa 1

```text
Bienvenido al libro de calificaciones de
CS101 Introducción a la programación en C#!

Escriba calificación: 85
Escriba calificación: 90
Escriba calificación: 78
Escriba calificación: 95
Escriba calificación: 88
Escriba calificación: 92
Escriba calificación: 80
Escriba calificación: 87
Escriba calificación: 91
Escriba calificación: 84

El total de las 10 calificaciones es 870
El promedio de la clase es 87
```

## Programa 2

```text
Bienvenido al libro de calificaciones para
CS101 Introducción a la programación en C#!

Escriba calificación o -1 para salir: 85
Escriba calificación o -1 para salir: 90
Escriba calificación o -1 para salir: 78
Escriba calificación o -1 para salir: 95
Escriba calificación o -1 para salir: -1

El total de las 4 calificaciones introducidas es 348
El promedio de la clase es 87.00
```

---

# Requisitos

Para ejecutar los programas se recomienda contar con:

* **.NET SDK**
* **C#**
* Un editor o IDE compatible, como:

  * Visual Studio
  * Visual Studio Code
  * JetBrains Rider

Para comprobar que .NET está instalado:

```bash
dotnet --version
```

---

# Ejecución

Clona el repositorio:

```bash
git clone <URL-DEL-REPOSITORIO>
```

Accede al directorio correspondiente:

```bash
cd <NOMBRE-DEL-REPOSITORIO>
```

Si los proyectos están configurados como aplicaciones .NET:

```bash
dotnet run
```

También es posible abrir los proyectos directamente desde un IDE compatible con C#.

---

# Aprendizajes obtenidos

Esta actividad permite reforzar varios fundamentos esenciales del desarrollo en C#:

```text
                   PROGRAMACIÓN EN C#
                          │
          ┌───────────────┴───────────────┐
          │                               │
      POO / CLASES                 CONTROL DE FLUJO
          │                               │
    ┌─────┼─────┐                   ┌─────┴─────┐
    │     │     │                   │           │
 Constructor  Propiedades        Contador    Centinela
    │     │     │                   │           │
    └─────┴─────┘                   └─────┬─────┘
          │                               │
          └──────────────┬────────────────┘
                         │
                  Procesamiento
                   de datos
                         │
                         ▼
                    PROMEDIOS
```

Entre los principales aprendizajes se encuentran:

* Creación y utilización de clases.
* Instanciación de objetos.
* Uso de constructores.
* Encapsulamiento mediante propiedades.
* Implementación de métodos.
* Manejo de datos mediante consola.
* Uso de ciclos `while`.
* Diferencias entre contador y centinela.
* Uso de acumuladores.
* Conversión entre tipos de datos.
* Manejo básico de condiciones.
* Cálculo de promedios.

---

# Conclusión

Los dos programas resuelven un problema similar, pero demuestran que la forma de controlar la repetición puede cambiar considerablemente la flexibilidad de una solución.

El **Programa 1**, basado en un contador, resulta apropiado cuando la cantidad de datos que se procesará es conocida de antemano.

Por otro lado, el **Programa 2**, basado en un centinela, permite que el usuario determine cuándo finalizar la entrada de información, haciendo que la solución sea más flexible y adaptable.

Además, ambos ejercicios permiten aplicar conceptos fundamentales de la **Programación Orientada a Objetos en C#**, estableciendo una base importante para el desarrollo de programas más complejos.

---

<div align="center">

### Laboratorio de Programación Orientada a Objetos

**C# · .NET · Clases · Métodos · Propiedades · Ciclos**

<br>

<img src="https://img.shields.io/badge/Made%20with-C%23-239120?style=for-the-badge&logo=csharp&logoColor=white" alt="Made with C#">

</div>
