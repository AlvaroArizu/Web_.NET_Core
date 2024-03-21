# Modulo 1
- POO
- Tipos - Clases - Herencias
- Propiedades y metodos 
- Ensamblados
- Constructores - Sobrecarga - Conversiones
- Visibilidad y Sobreescritura 

# POO 
## Diferencias entre Programación Estructurada y Programación Orientada a Objetos (POO)

### Programación Estructurada

- **Origen:** Evolución de la programación imperativa para solucionar sus limitaciones.
- **Características:**
  - Se basa en procedimientos o subrutinas.
  - Utiliza estructuras de control como secuencia, selección (`if`, `switch`) e iteración (`for`, `while`).
  - Rechaza el uso de la instrucción `goto`, considerándola una mala práctica.
- **Enfoque:** Lineal y procedimental, siguiendo el orden en que el código es escrito.

### Programación Orientada a Objetos (POO)

- **Origen:** Paradigma basado en la interacción de objetos para diseñar aplicaciones y programas.
- **Características:**
  - Utiliza objetos que encapsulan datos y comportamientos.
  - Se apoya en pilares conceptuales como herencia, abstracción, polimorfismo y encapsulamiento.
- **Enfoque:** Diseño modular, facilitando la reutilización de código y la división de problemas en unidades más pequeñas y manejables.
- **Popularidad:** Se popularizó en los años 90 y es soportada por múltiples lenguajes de programación.

### Conclusión

Mientras que la **programación estructurada** se enfoca en la lógica procedimental y estructuras de control claras para la secuenciación de instrucciones, la **POO** introduce un enfoque basado en objetos, permitiendo un diseño más flexible y reutilizable a través de la encapsulación de datos y comportamiento en unidades modulares (objetos).

## Conceptos Clave en Programación Orientada a Objetos (POO)

### Objetos

- **Definición:** Entidades con estado, comportamiento e identidad.
  - **Estado:** Determinado por atributos (datos) con valores concretos.
  - **Comportamiento:** Definido por métodos (operaciones que el objeto puede realizar).
  - **Identidad:** Propiedad única que diferencia un objeto de otros, incluso dentro de la misma clase.

### Clase

- **Definición:** Plantilla o molde para construir objetos con estructuras similares.
- **Funcionalidad:** Permite definir los atributos (estado) y métodos (comportamiento) que tendrán los objetos creados a partir de ella.
- **Unicidad:** Cada objeto instanciado desde una clase tiene su propia identidad y puede tener distintos valores en sus atributos, pese a compartir una estructura común.

### Métodos

- **Definición:** Mecanismos de interacción entre objetos.
- **Comunicación:** Permiten a los objetos enviar y recibir información entre sí, cambiando su estado o realizando operaciones específicas.
- **Cohesión:** Contribuyen a tratar los objetos como unidades indivisibles, donde estado y comportamiento están interrelacionados.

### Conclusión

En la POO, **objetos** son las entidades fundamentales que interactúan entre sí mediante **métodos**, siguiendo las definiciones estructurales y de comportamiento especificadas en las **clases**. Estos conceptos trabajan conjuntamente para permitir la creación de sistemas modulares, reutilizables y fácilmente mantenibles.

## Ventajas de la Programación Orientada a Objetos (POO)

La POO es un paradigma que ofrece múltiples ventajas en el desarrollo de software, entre ellas:

- **Organización Modular:** Permite modelar sistemas como conjuntos de objetos que interactúan, reflejando la complejidad del mundo real de manera intuitiva.
- **Mantenimiento y Desarrollo:** Facilita la creación, puesta a punto y mantenimiento de los componentes de software, haciéndolos más sencillos y rápidos.
- **Reutilización:** Promueve la reutilización de componentes existentes o de terceros, potenciando la eficiencia en el desarrollo.
- **Integración en Entornos Gráficos:** Su lógica se alinea bien con aplicaciones que funcionan en entornos gráficos.
- **Aplicaciones Distribuidas:** Se adapta perfectamente a la codificación de aplicaciones que distribuyen sus contenidos en varias máquinas.
- **Desacoplamiento:** Mejora la colaboración en equipo al reducir el código repetido y solapado, lo que a su vez facilita un sistema de trabajo más eficaz.

## Principios Básicos de la POO

- **Abstracción:** Captura las características esenciales de los objetos, enfocándose en sus comportamientos e interacciones más que en sus detalles concretos.
- **Encapsulamiento:** Agrupa en una misma entidad todos los elementos relacionados, protegiendo el estado interno del objeto y exponiendo operaciones a través de métodos.
- **Ocultamiento:** Asegura que cada objeto está aislado del exterior, promoviendo módulos bien definidos con interfaces claras para la interacción.
- **Herencia:** Permite que una clase derive propiedades y comportamientos de otra, facilitando la extensión y personalización de clases existentes.
- **Polimorfismo:** Ofrece la capacidad de tratar objetos de diferentes clases de manera uniforme, permitiendo que un mismo método o propiedad se comporte de manera diferente según el objeto que lo implemente.

Estas ventajas y principios fundamentales de la POO habilitan a los desarrolladores a enfrentar complejidades del software de una manera más eficiente, promoviendo la creación de sistemas robustos, mantenibles y escalables.

# Tipos en C#

C# es un lenguaje fuertemente tipado que soporta varios tipos de datos definidos en la Common Type System (CTS). Estos tipos son esenciales para la creación de aplicaciones robustas y mantenibles.

### Clases

- **Definición**: Son la implementación en C# del concepto de clase del paradigma orientado a objetos.
- **Uso**: Define objetos que encapsulan tanto estado (atributos) como comportamiento (métodos).

### Estructuras

- **Definición**: Similar a las clases, pero optimizadas para tipos de datos pequeños y simples.
- **Características**: Se almacenan en la pila, lo que puede mejorar el rendimiento de la aplicación.

### Interfaces

- **Definición**: Define un contrato que las clases pueden implementar, especificando un conjunto de métodos sin implementar.
- **Uso**: Facilita la comunicación y colaboración entre clases.

### Enumeraciones

- **Definición**: Define un tipo que se limita a un conjunto fijo de constantes.
- **Ejemplo**: `enum Dias { Lunes, Martes, Miércoles, Jueves, Viernes, Sábado, Domingo }`

### Delegados

- **Definición**: Encapsulan un método en un objeto, permitiendo manejar métodos como entidades de primera clase.
- **Características**: Ofrecen seguridad de tipos para punteros a funciones y son fundamentales para la gestión de eventos.

Cada uno de estos tipos tiene un papel crucial en la definición de la estructura y comportamiento de las aplicaciones en C#. Las clases y estructuras permiten la creación de complejas estructuras de datos. Las interfaces promueven un diseño de software flexible y desacoplado. Las enumeraciones mejoran la legibilidad y seguridad del código. Los delegados facilitan la programación de eventos y callbacks, esenciales en muchos patrones de diseño.


## Herencia en C# y el Tipo System.Object

En C#, todas las clases heredan directa o indirectamente de `System.Object`. Esto significa que `System.Object` es la clase base de todos los tipos en .NET, ya sean predefinidos o definidos por el usuario. La herencia de `Object` es implícita en C#, por lo que no es necesario declararla explícitamente en las clases.

### System.Object y System.ValueType

- `System.Object`: Es la base de todos los tipos en .NET y proporciona métodos y funcionalidades comunes que todas las clases heredan.
- `System.ValueType`: Se convierte en la base de los tipos de datos "valores" en .NET, adaptándose a los métodos de `System.Object`.

### Métodos de Object

La clase `System.Object` proporciona varios métodos que son heredados por todas las clases en .NET:

- `Equals(object)`: Compara el objeto actual con otro objeto y determina si son iguales.
- `Finalize()`: Permite que un objeto realice operaciones de limpieza antes de que sea reclamado por el recolector de basura.
- `GetHashCode()`: Devuelve un código hash para el objeto actual.
- `GetType()`: Obtiene el tipo de tiempo de ejecución del objeto actual.
- `MemberwiseClone()`: Crea una copia superficial del objeto actual.
- `ToString()`: Devuelve una cadena que representa el objeto actual.

Estos métodos son fundamentales en la programación en C# y se utilizan para diversas operaciones, como la comparación de objetos, la obtención de su representación como cadena y la gestión de la memoria.

# Clase en C#

Una clase en C# es una construcción fundamental que permite la creación de tipos personalizados. En ella se pueden agrupar variables de otros tipos, métodos y eventos para definir el comportamiento y la estructura de un objeto.

### Definición y Funcionalidad

- **Definición:** Una clase es como una plantilla que define los datos y el comportamiento del tipo personalizado.
- **Persistencia en Memoria:** Los objetos creados a partir de una clase permanecen en memoria hasta que todas las referencias a ellos están fuera de alcance, momento en el cual el Garbage Collector los marca para la recolección de elementos no utilizados.
- **Uso de Clases:**
  - Si la clase no se declara como estática, se pueden crear objetos o instancias de ella que se asignan a variables.
  - Si la clase se declara como estática (`static`), solo existe una copia en memoria y el código de cliente puede acceder a ella solo a través de la propia clase y no de una instancia.

### Declaración de Clases

Las clases se declaran mediante la palabra clave `class`. A continuación, se muestra un ejemplo de declaración de clase en C#:

```csharp
public class Cliente
{
    // Campos, propiedades, métodos y eventos van aquí
}
```
Los modificadores de visibilidad, como public, indican quién puede usar la clase y sus miembros.

### Miembros de Clase

Los campos, propiedades, métodos y eventos de una clase se conocen colectivamente como miembros de clase. Estos son los componentes que definen el comportamiento y la estructura de la clase, y pueden ser accedidos y utilizados por el código cliente según su visibilidad.

# Objeto en C#

Un objeto en C# es una instancia concreta de una clase. Aunque a menudo se mencionan juntos, una clase y un objeto son entidades diferentes. Mientras que una clase define el tipo de objeto, un objeto es una instancia específica de esa clase.

### Creación de Objetos

Los objetos se crean utilizando la palabra clave `new`, seguida del nombre de la clase en la que se basará el objeto. Aquí hay un ejemplo de cómo crear un objeto en C#:

```csharp
Cliente nuevoCliente = new Cliente();
```
En este ejemplo, nuevoCliente es una referencia a un objeto basado en la clase Cliente. Es una variable de instancia que apunta al nuevo objeto, pero no contiene los datos del objeto en sí. En cambio, contiene la dirección de memoria donde residen los datos del objeto.

### Referencias a Objetos

En C#, también es posible crear una referencia a un objeto sin crear el objeto en sí:

```csharp
Cliente otroCliente;
```
No se recomienda crear este tipo de referencias que no apuntan a un objeto existente, ya que intentar acceder a un objeto a través de esa referencia generará un error en tiempo de ejecución. Sin embargo, estas referencias se pueden utilizar para referenciar objetos existentes, ya sea creando un nuevo objeto o asignándolas a un objeto existente.

### Tipos por Referencia

Dado que el acceso a los objetos basados en clases se realiza por referencia, las clases en C# se denominan tipos por referencia. Esto significa que cuando se crea una referencia a un objeto, se está manipulando la dirección de memoria donde residen los datos del objeto, no los datos en sí mismos. Por lo tanto, los cambios realizados en un objeto a través de una referencia se reflejarán en todas las referencias posteriores a ese objeto.

# Propiedades de la POO
## Herencia en Programación Orientada a Objetos (POO)

La herencia es un concepto fundamental en la Programación Orientada a Objetos (POO) que permite la creación de nuevas clases basadas en clases existentes. En este curso, se proporcionará una introducción breve sobre la herencia, con un estudio más detallado en módulos posteriores.

### Concepto Básico

La herencia se realiza mediante la derivación, lo que implica que una clase se declara utilizando una clase base de la cual hereda los datos y el comportamiento. Para especificar una clase base, se utiliza la notación de dos puntos seguida del nombre de la clase base después del nombre de la clase derivada.

### Ejemplo

Veamos un ejemplo básico de cómo se utiliza la herencia en C#:

```csharp
public class Empleado : Persona
{
    // Propiedades y métodos adicionales de la clase Empleado
}
```
## Herencia en C#

En C#, cuando una clase deriva de otra clase base, hereda todos los miembros de la clase base excepto los métodos constructores.

### Herencia Simple y Múltiple

A diferencia de C++, donde se permite la herencia múltiple, en C# se admite únicamente la herencia simple. Esto significa que una clase en C# puede heredar directamente de una sola clase base. Sin embargo, como una clase base puede heredar de otra clase, una clase en C# puede heredar indirectamente de varias clases base. Además, una clase puede implementar directamente más de una interfaz, lo que permite lograr una forma de herencia múltiple.

### Clase Abstracta y Clase Sellada

- **Clase Abstracta:** Se puede declarar una clase como abstracta utilizando la palabra clave `abstract`. Una clase abstracta contiene métodos abstractos, que tienen una definición de firma pero no una implementación. No se pueden crear instancias de clases abstractas directamente; solo se pueden utilizar a través de clases derivadas que implementan los métodos abstractos.

- **Clase Sellada:** Una clase sellada se declara utilizando la palabra clave `sealed`. Esta clase no permite que otras clases deriven de ella. Es decir, una clase sellada no puede ser la clase base de ninguna otra clase.

# Propiedades en C#

Una propiedad en C# es un miembro que proporciona un mecanismo flexible para leer, escribir o calcular el valor de un campo privado. Aunque se pueden utilizar las propiedades como si fueran miembros de datos públicos, en realidad son métodos especiales conocidos como descriptores de acceso.

## Funcionamiento de las Propiedades

- **Flexibilidad de Acceso:** Las propiedades permiten acceder fácilmente a los datos de un objeto, pero detrás de escena son métodos especiales que proporcionan seguridad y flexibilidad.
- **Tipos de Propiedades:**
  - **Propiedades de Lectura y Escritura:** Permiten leer y escribir el valor de un campo privado.
  - **Propiedades de Solo Lectura:** Solo permiten la lectura del valor de un campo privado.
  - **Propiedades Calculadas:** Calculan y devuelven un valor en función de otras propiedades o datos del objeto.

## Sintaxis de las Propiedades

La sintaxis para definir una propiedad en C# es la siguiente:

```csharp
public Tipo NombrePropiedad
{
    get
    {
        // Código para leer el valor de la propiedad
        return valor;
    }
    set
    {
        // Código para escribir el valor de la propiedad
        // Se utiliza la palabra clave 'value' para representar el valor asignado
    }
}
```
En este ejemplo:

El bloque `get` se utiliza para obtener el valor de la propiedad.
El bloque `set` se utiliza para establecer el valor de la propiedad.

```csharp
classPeriodoDeTiempo
        {
privatedouble segundos;
publicdouble Horas
            {
get{ return segundos / 3600; }
set{ segundos = value * 3600; }
```
```csharp
public class Persona
{
    private string nombre;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
}
```
En este ejemplo, la clase Persona tiene una propiedad llamada Nombre, que permite leer y escribir el nombre de la persona.


# Cuerpos de Expresión en Propiedades en C#

En C#, es común tener propiedades que simplemente devuelvan el resultado de una expresión. Para definir estas propiedades de manera concisa, se utiliza un acceso directo de sintaxis conocido como cuerpo de expresión, utilizando el operador lambda (`=>`).

## Características de los Cuerpos de Expresión

- **Sintaxis Abreviada:** Utilizan el operador `=>` para definir de manera compacta una propiedad que devuelve el resultado de una expresión.
- **Solo Lectura:** Las propiedades definidas con cuerpos de expresión son de solo lectura, es decir, no tienen un descriptor de acceso `get`.
- **Simplicidad y Claridad:** Los cuerpos de expresión permiten definir propiedades de manera más concisa, lo que mejora la legibilidad y claridad del código.

## Sintaxis

La sintaxis para definir una propiedad con cuerpo de expresión es la siguiente:

```csharp
public Tipo NombrePropiedad => expresión;
```

Donde:

- `Tipo`: Es el tipo de dato que devuelve la propiedad.
- `NombrePropiedad`: Es el nombre de la propiedad.
- `expresión`: Es la expresión cuyo resultado se devuelve como valor de la propiedad.

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public string NombreCompleto => Nombre + " " + Apellido;
}
```
En este ejemplo, la propiedad `NombreCompleto` utiliza un cuerpo de expresión para devolver el nombre completo de la persona, que es la concatenación del nombre y el apellido.

## Propiedades Auto-implementadas en C#

En C# 3.0 y versiones posteriores, se introdujeron las propiedades auto-implementadas para hacer la declaración de propiedades más concisa cuando no es necesaria ninguna lógica adicional en los descriptores de acceso de la propiedad. Esto permite que el compilador cree automáticamente un campo de respaldo privado y anónimo al que solo se puede acceder a través de los descriptores de acceso de propiedad `get` y `set`.

### Características de las Propiedades Auto-implementadas

- **Concisión:** Simplifican la declaración de propiedades al eliminar la necesidad de definir explícitamente un campo de respaldo privado.
- **Acceso Controlado:** Aunque el campo de respaldo es privado, se puede acceder a través de los descriptores de acceso de propiedad `get` y `set`.
- **Sin Lógica Adicional:** Son ideales para propiedades simples que no requieren ninguna lógica adicional en los descriptores de acceso.

### Sintaxis

La sintaxis para definir una propiedad auto-implementada es la siguiente:

```csharp
public Tipo NombrePropiedad { get; set; }
```

Donde:

- Tipo: Es el tipo de dato que almacena la propiedad.
- NombrePropiedad: Es el nombre de la propiedad.
```csharp
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
```
En este ejemplo, la clase Persona tiene dos propiedades auto-implementadas: Nombre y Edad. El compilador crea automáticamente un campo de respaldo privado y anónimo para cada una de estas propiedades.

## Inicialización de Propiedades Auto-implementadas en C#

En C# 6 y versiones posteriores, se introdujo la capacidad de inicializar las propiedades auto-implementadas de manera similar a como se inicializan los campos. Esto proporciona una forma más conveniente y concisa de inicializar propiedades sin necesidad de escribir un constructor personalizado.

### Características de la Inicialización de Propiedades

- **Conveniencia:** Permite inicializar propiedades auto-implementadas directamente en su declaración, sin necesidad de escribir un constructor personalizado.
- **Legibilidad Mejorada:** Mejora la legibilidad del código al proporcionar una forma más clara y concisa de inicializar propiedades.

### Sintaxis

La sintaxis para inicializar propiedades auto-implementadas en C# 6 y versiones posteriores es la siguiente:

```csharp
public Tipo NombrePropiedad { get; set; } = valorInicial;
```
Donde:

- Tipo: Es el tipo de dato que almacena la propiedad.
- NombrePropiedad: Es el nombre de la propiedad.
- valorInicial: Es el valor inicial que se asignará a la propiedad.
```csharp
public class Persona
{
    public string Nombre { get; set; } = "John";
    public int Edad { get; set; } = 30;
}
```
En este ejemplo, las propiedades auto-implementadas Nombre y Edad se inicializan directamente en su declaración. Esto significa que, si no se proporciona ningún valor al crear una instancia de Persona, las propiedades tendrán los valores predeterminados especificados.


## Información General sobre Propiedades en C#

Las propiedades en C# permiten que una clase exponga una manera pública de obtener y establecer valores, al mismo tiempo que oculta el código de implementación o comprobación subyacente.

### Características Principales

- **Descriptores de Acceso:** Se utiliza un descriptor de acceso de propiedad `get` para obtener el valor de la propiedad y un descriptor `set` para asignarle un nuevo valor. Estos descriptores de acceso pueden tener diferentes niveles de acceso, es decir, distinta visibilidad.
- **Palabra Clave `value`:** La palabra clave `value` se utiliza en el descriptor de acceso `set` para referirse al valor que se asigna a la propiedad. Esto permite que el usuario ingrese un valor al campo de la propiedad.
- **Propiedades de Sólo Lectura:** Las propiedades que no implementan un descriptor de acceso `set` son de solo lectura. También pueden tener un descriptor `set` privado para lograr este mismo comportamiento. Otra forma de emular este comportamiento es declarar el miembro con la visibilidad `readonly`, lo que garantiza que los valores de la variable no puedan cambiar en ningún hilo de ejecución (thread) de la aplicación.
- **Propiedades Auto-implementadas:** Para propiedades sencillas que no requieren ningún código de descriptor de acceso personalizado, se puede considerar la posibilidad de utilizar propiedades implementadas automáticamente.

### Ejemplo de Propiedad Auto-implementada

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}
```
En este ejemplo, la clase Persona tiene dos propiedades auto-implementadas: Nombre y Edad. Esto permite que se puedan obtener y establecer valores de estas propiedades de manera pública.

# Métodos, Firmas de Método y Sobrecargas en C#

Los métodos en C# definen la funcionalidad de una clase o estructura. Se declaran con un nivel de acceso, un valor de retorno, un nombre y cualquier parámetro que pueda necesitar.

### Firmas de Método

La firma de un método se compone del tipo de retorno del método, su nombre y los tipos y orden de sus parámetros. Esto significa que dos métodos pueden tener el mismo nombre, pero deben tener firmas diferentes (es decir, diferentes tipos o número de parámetros) para ser considerados sobrecargas válidas.

```csharp
// Ejemplo de método con una firma específica
public string MostrarNombreCompleto(string nombre, string apellido)
{
    return nombre + ' ' + apellido;
}

// Sobrecarga del método anterior con una firma diferente
public string MostrarNombreCompleto(string nombre, char otroNombre, string apellido)
{
    return nombre + ' ' + otroNombre + ' ' + apellido;
}
```

### Sobrecarga de Métodos

La sobrecarga de métodos es cuando se tienen múltiples métodos con el mismo nombre pero diferentes firmas. Esto permite tener una funcionalidad similar con diferentes tipos de entrada o diferentes cantidades de parámetros.

### Ejemplo de Clase Abstracta con Métodos

En el siguiente ejemplo, se muestra una clase abstracta Moto que contiene varios métodos con diferentes niveles de acceso y modificadores. También incluye un método abstracto que debe ser implementado por cualquier clase que herede de Moto.

```csharp
public abstract class Moto
{
    // Método público que puede ser llamado desde cualquier lugar
    public void IniciarMotor() {/* Aquí iría el código */ }

    // Método protegido solo visible para clases derivadas
    protected void CargarNafta(int litros) {/* Aquí iría el código */ }

    // Método virtual que puede ser sobrescrito por clases derivadas
    public virtual int Conducir(int kilómetros, int velocidad) {/* Aquí iría el código */ return 1; }

    // Método abstracto que debe ser implementado por clases derivadas
    public abstract double ObtenerVelocidadMáxima();
}
```
Este ejemplo ilustra cómo se definen y utilizan métodos en C#, incluyendo la sobrecarga de métodos y la creación de métodos abstractos en una clase abstracta.


##  Constructores en C#

Cada vez que se crea una clase o estructura en C#, se utiliza un constructor. El constructor es un método especial que se invoca automáticamente cuando se crea una instancia de la clase o estructura. Los constructores pueden tener diferentes formas y propósitos, como establecer valores predeterminados, limitar la creación de instancias y proporcionar flexibilidad en la inicialización de objetos.

### Sobrecarga de Constructores

Una clase puede tener varios constructores, lo que se conoce como sobrecarga de constructores. Estos constructores pueden tomar diferentes conjuntos de argumentos para permitir la creación de objetos con diferentes estados iniciales. Si no se proporciona un constructor para la clase, C# creará uno de forma predeterminada que inicializa los valores de las propiedades en los valores predeterminados.

### Ejemplo de Constructor por Omisión

```csharp
public class Coordenadas
{
    public int x, y;
    
    // Constructor por omisión
    public Coordenadas()
    {
        x = 0;
        y = 0;
    }
}
```
### Constructor con Argumentos
```csharp
public class Coordenadas
{
    public int x, y;
    
    // Constructor con dos argumentos
    public Coordenadas(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

// Uso del constructor
Coordenadas p1 = new Coordenadas();
Coordenadas p2 = new Coordenadas(5, 3);
```

### Llamada a Constructores de Clases Base

Los constructores de una clase derivada pueden invocar el constructor de la clase base a través del inicializador base.

#### Ejemplo de Llamada a Constructor de Clase Base
```csharp
public class Circulo : Figura
{
    // Constructor de clase derivada que llama al constructor de clase base
    public Circulo(double radio) : base(radio, 0)
    {
    }
}
```

## Object.ToString()

El método `Object.ToString()` es un método fundamental en .NET Framework que convierte un objeto en una representación de cadena adecuada para su presentación. Si no se proporciona una implementación personalizada, este método devuelve el nombre completo, incluyendo el espacio de nombres, del tipo de objeto.


# Ensamblados (ASSEMBLY)

Los ensamblados son los componentes fundamentales de las aplicaciones .NET Framework. Constituyen unidades de implementación, control de versiones, reutilización, ámbitos de activación y permisos de seguridad. Un ensamblado es una colección de tipos y recursos compilados para funcionar en conjunto y formar una unidad lógica de funcionalidad.

## Tipos de Ensamblados

### Bibliotecas o Librerías de Clase (DLL)
Las DLL son archivos con código ejecutable que contienen funcionalidades específicas. Pueden ser reutilizadas utilizando cualquier lenguaje de programación.

### Archivos Ejecutables (.exe)
Los archivos ejecutables son programas que pueden ser ejecutados directamente por el sistema operativo.

## Referencias del Proyecto

Para utilizar un componente o librería en una aplicación, primero se debe agregar una referencia a ese componente. Visual Studio proporciona diversas opciones para agregar referencias, incluyendo:

- **Ensamblados:** Enumera los componentes de .NET Framework disponibles para referenciar.
- **Proyectos:** Enumera los componentes reutilizables creados en proyectos locales dentro de la misma solución.
- **COM:** Enumera los componentes de COM disponibles para hacer referencias.
- **Examinar:** Permite buscar un componente en el sistema de archivos.
- **Reciente:** Contiene una lista de componentes recién agregados a proyectos de su equipo.

El número de opciones puede variar según el tipo de proyecto y los recursos utilizados.

## Palabra Clave "using"

La palabra clave `using` tiene dos usos principales:

### Como Directiva
Se utiliza para crear un alias para un espacio de nombres o para importar tipos definidos en otros espacios de nombres. Esto evita tener que escribir el nombre completo del ensamblado cada vez que se accede a las clases contenidas en ese espacio de nombres.

### Como Instrucción
Define un ámbito o alcance al final del cual el objeto se destruye. Se utiliza para liberar recursos de manera segura una vez que ya no son necesarios, como en el caso de conexiones a bases de datos.

Ejemplo de uso:

```csharp
using (var conexion = new SqlConnection(Utils.ConnectionString))
{
    conexion.Open();
    // Aquí se realizan operaciones con la conexión a la base de datos
}
// La variable 'conexion' ya no existe fuera de este ámbito
```
La palabra clave `using` garantiza la liberación de recursos incluso en casos de excepciones durante la ejecución del código.


# Variables de Instancia vs. Miembros Estáticos

Por defecto, los miembros de una clase son variables de instancia, lo que significa que cada instancia de la clase tiene su propia copia de estos datos. Por otro lado, los miembros estáticos son compartidos por todas las instancias de la clase y son comunes a todas ellas. Veamos las diferencias:

## Variables de Instancia
- Cada instancia de la clase tiene su propia copia de los datos.
- Los métodos operan en los datos de una instancia específica.
- Se utilizan para almacenar datos únicos para cada instancia.
- Accedidos utilizando una instancia de la clase (`this`).

## Miembros Estáticos
- Compartidos por todas las instancias de la clase.
- No pueden acceder a variables de instancia ni al objeto `this`.
- No se recomienda abusar de ellos ya que son similares a datos y funciones globales en entornos orientados a objetos.

## Constantes (const)
- Son datos cuyo valor se evalúa en tiempo de compilación.
- Implícitamente estáticas.
- No es necesario recompilar los clientes de la clase si cambia su valor.

## Campos (fields)
- Almacenan datos en una clase.
- Pueden ser de solo lectura (readonly), cuyo valor se inicia en tiempo de ejecución.

## Propiedades
- Campos virtuales que pueden ser de solo lectura, de solo escritura o de lectura y escritura.
- Implementadas con código como los métodos.

## Indexadores (indexers)
- Permiten definir código a ejecutar cada vez que se accede a un objeto utilizando la sintaxis propia de las tablas.

## Métodos
- Implementan operaciones que pueden realizar los objetos de un tipo concreto.
- Pueden ser sobrecargados para tener distintas implementaciones según los parámetros.
- Pueden tener parámetros pasados por valor o por referencia.

## Constructores
- Métodos especiales invocados al instanciar una clase.
- Se utilizan para inicializar correctamente un objeto.
- Pueden ser sobrecargados y tener distintas firmas.

## Destructores
- Se utilizan para liberar recursos reservados por una instancia antes de ser eliminada.
- No se garantiza su llamada, se recomienda utilizar `using` y el interfaz `IDisposable`.

## Sobrecarga de Operadores
- Permite definir el comportamiento de los operadores para tipos personalizados.
- Algunos operadores pueden ser sobrecargados de forma unaria o binaria.

## Conversiones de Tipo
- Permiten convertir valores entre diferentes tipos.
- Pueden ser implícitas, explícitas o definidas por el usuario.

En resumen, las variables de instancia son únicas para cada instancia de la clase, mientras que los miembros estáticos son compartidos por todas las instancias y son similares a datos y funciones globales.

# Modificadores de Visibilidad en C#

Los modificadores de visibilidad en C# permiten controlar el alcance y la accesibilidad de los tipos y miembros de una clase. Esto es crucial para la encapsulación y la gestión adecuada de la interfaz pública de una clase.

## Modificadores para Clases

- **public:** La clase es accesible desde cualquier lugar.
- **internal:** La clase solo es accesible dentro del assembly que la contiene.

## Modificadores para Miembros de Clase

- **public:** El miembro es accesible desde cualquier lugar.
- **private (por omisión):** El miembro solo es accesible desde dentro de la clase que lo contiene.
- **protected:** El miembro es accesible dentro de la clase que lo contiene y en las clases derivadas de esa clase.
- **internal:** El miembro es accesible desde todas las clases dentro del mismo assembly.
- **protected internal:** El miembro es accesible dentro de la clase, en las clases derivadas y en todas las clases del mismo assembly.

## Herencia

La herencia es un mecanismo fundamental en la programación orientada a objetos que permite definir nuevas clases basadas en clases existentes. En C#, la herencia es simple y se define con la sintaxis `class <claseHija> : <clasePadre>`.

## Redefinición de Métodos (Sobreescritura)

Para redefinir un método de la clase base en una clase derivada, se utiliza la palabra clave `override`. Esto evita redefiniciones accidentales y asegura un comportamiento predecible. Por ejemplo, `public override string ToString() {...}`.

## Métodos Virtuales

Un método es virtual si puede redefinirse en una clase derivada. Los métodos virtuales se definen en la clase base con la palabra clave `virtual`, y pueden ser reemplazados en las subclases utilizando la palabra clave `override`.