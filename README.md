# Guía-integral-programación
# Ejercicio 1: Fundamentos de POO

**Narrativa:**  
La municipalidad local te ha contratado para desarrollar un pequeño sistema de gestión de ciudadanos para su base de datos.

**Consigna:**  
Desarrollá una clase `Ciudadano` que contenga:
- Nombre completo (`string`)
- DNI (`string`)
- Edad (`int`)
- Método `Saludar()` que devuelva un string personalizado con el nombre y edad del ciudadano.

**Extras sugeridos:**
- Validá que la edad sea mayor o igual a 0.
- Agregá un método que indique si el ciudadano es mayor de edad.

**Objetivo:**  
Practicar encapsulamiento, métodos, constructores y lógica básica.

---

# Ejercicio 2: Herencia y Polimorfismo

**Narrativa:**  
Estás desarrollando un software para una veterinaria que trabaja con diferentes tipos de animales.

**Consigna:**
1. Creá una clase base `Animal` con:
   - Propiedad `Nombre`.
   - Método virtual `EmitirSonido()`.

2. Creá dos clases que hereden de `Animal`:
   - `Perro`: sobreescribí `EmitirSonido()` devolviendo `"Guau!"`.
   - `Gato`: devolvé `"Miau!"`.

3. Agregá un método `Presentarse()` que devuelva por ejemplo:  
   `"Soy un gato llamado (nombre) y hago Miau!"`

**Objetivo:**  
Aplicar herencia, polimorfismo y sobrescritura de métodos.

---

# Ejercicio 3: Principios SOLID

**Narrativa:**  
Un sistema de facturación actual hace todo desde una sola clase: genera la factura, la imprime y la guarda. Te piden refactorizarlo.

**Consigna:**
1. Recibís esta clase `Factura`, que hace todo esto.
2. Refactorizala aplicando SRP:
   - `FacturaCalculator`
   - `FacturaPrinter`
   - `FacturaSaver`

3. Luego agregá una interfaz `IImprimible` y aplicá ISP para separar impresión digital de impresión papel.

**Objetivo:**  
Aplicar SRP e ISP. Iniciar el pensamiento en capas y separación de responsabilidades.

---

# Ejercicio 4: CRUD + JSON + Repository

**Narrativa:**  
Una ferretería quiere registrar productos y realizar operaciones básicas con ellos desde una app de consola.

**Consigna:**
1. Crear clase `Producto` con: `Id`, `Nombre`, `Precio`, `Stock`.
2. Implementá un CRUD por consola:
   - Alta (nuevo producto)
   - Baja (eliminar)
   - Modificación (editar un campo)
   - Consulta (mostrar todos)

3. Usá una clase `ProductoRepository` para manejar una lista interna de productos y serializarla en `productos.json`.

4. Al iniciar el programa, cargá los datos existentes (si hay) y al finalizar, guardalos.

**Objetivo:**  
Comprender el ciclo de vida de un dato, uso de listas, persistencia simple y separación de lógica de negocio y de acceso a datos.

---

# Ejercicio 5: Proyecto Final MVC

**Narrativa:**  
Una biblioteca barrial necesita una app en consola que le permita registrar libros y gestionar préstamos.

**Consigna:**
1. **Modelo:**
   - `Libro`: título, autor, ISBN, disponibilidad.
   - `Usuario`: nombre, email.
   - `Prestamo`: libro, usuario, fecha.

2. **Controladores:**
   - Permiten prestar libros, devolverlos, listar libros disponibles, etc.

3. **Vista:**
   - Menú simple en consola que permita navegar entre opciones.

4. **Separación clara entre carpetas:**  
   `Models`, `Controllers`, `Views`.

**Objetivo:**  
Aplicar todos los conceptos previos, incluyendo separación por capas, lógica de negocio, persistencia y diseño limpio.
