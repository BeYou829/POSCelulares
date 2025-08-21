# 📱 POSCelulares

Un sistema **Punto de Venta (POS)** para una tienda de celulares, desarrollado en **ASP.NET Core 9.0 MVC** con **Entity Framework Core** y **SQL Server**.  
Este proyecto incluye gestión de productos, clientes, empleados, proveedores, ventas y reportes.

---

## 🚀 Tecnologías utilizadas
- ASP.NET Core 9.0 MVC (C#)
- Entity Framework Core (ORM)
- MS SQL Server (base de datos)
- Bootstrap 5 (interfaz de usuario)
- jQuery

---

## ⚙️ Requisitos previos
Antes de ejecutar el proyecto asegúrate de tener instalado:
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) o [VS Code](https://code.visualstudio.com/)
- [.NET SDK 9.0](https://dotnet.microsoft.com/)
- [SQL Server](https://www.microsoft.com/sql-server)
- [Git](https://git-scm.com/)

---

## ▶️ Ejecución del proyecto
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/usuario/POSCelulares.git
   ```
2. Restaurar paquetes:
   ```bash
   dotnet restore
   ```
3. Crear la base de datos (desde la carpeta del proyecto):
   ```bash
   dotnet ef database update
   ```
4. Ejecutar el proyecto:
   ```bash
   dotnet run
   ```

---

## 📋 TODO – Plan de desarrollo

### 1. Configuración inicial
- [X] Crear proyecto **ASP.NET Core MVC** con EF Core y SQL Server  
- [ ] Configurar **DbContext (PosDbContext)**  
- [ ] Crear **cadena de conexión** en `appsettings.json`  
- [ ] Hacer la **migración inicial** (`dotnet ef migrations add InitialCreate`) y aplicar la BD (`dotnet ef database update`)  
- [X] Configurar layout con **sidebar lateral**  

---

### 2. Módulo de Productos (Inventario)
- [ ] Crear entidad `Producto` con propiedades básicas (Nombre, Precio, Stock, Categoría, IMEI)  
- [ ] Generar `DbSet<Producto>` en `PosDbContext`  
- [ ] Crear `ProductosController` con acciones CRUD (Index, Create, Edit, Delete, Details)  
- [ ] Crear vistas con **Bootstrap** (usar scaffolding si se quiere rapidez)  
- [ ] Agregar validaciones con **Data Annotations** (`[Required]`, `[Range]`)  
- [ ] Mostrar **stock bajo en rojo** en el listado de productos  

---

### 3. Módulo de Clientes
- [ ] Crear entidad `Cliente` (Nombre, Teléfono, Email, Dirección)  
- [ ] Agregar `DbSet<Cliente>` al `PosDbContext`  
- [ ] Crear `ClientesController` con CRUD y vistas  
- [ ] Implementar **búsqueda por nombre o teléfono** en el Index  
- [ ] Mostrar **historial de compras** en la vista de detalles del cliente  

---

### 4. Módulo de Empleados
- [ ] Crear entidad `Empleado` (Nombre, Rol, Usuario, PasswordHash)  
- [ ] Agregar `DbSet<Empleado>`  
- [ ] CRUD básico de empleados  
- [ ] Implementar **roles** (Administrador, Cajero, Vendedor)  
- [ ] Integrar con **Identity o autenticación propia** (más adelante)  

---

### 5. Módulo de Ventas
- [ ] Crear entidades `Venta` y `DetalleVenta`  
- [ ] Relacionar: `Venta` → `Cliente`, `Empleado`, `DetallesVenta`  
- [ ] Crear formulario de nueva venta:  
  - [ ] Seleccionar cliente  
  - [ ] Seleccionar productos (autocomplete o dropdown)  
  - [ ] Agregar cantidades y calcular subtotales  
  - [ ] Calcular **total automáticamente**  
- [ ] Guardar venta y reducir stock de productos  
- [ ] Generar **recibo/factura imprimible** (PDF o ticket)  

---

### 6. Módulo de Proveedores
- [ ] Crear entidad `Proveedor` (Nombre, Teléfono, Email)  
- [ ] Relacionar con `Producto`  
- [ ] CRUD de proveedores  
- [ ] Registrar **compras a proveedores** para aumentar stock  

---

### 7. Reportes
- [ ] Reporte de **ventas por día/semana/mes**  
- [ ] Reporte de **productos más vendidos**  
- [ ] Reporte de **clientes con más compras**  
- [ ] Reporte de **stock bajo**  

---

### 8. Extras (para más adelante)
- [ ] Soporte para **varios métodos de pago** (Efectivo, Tarjeta, Transferencia)  
- [ ] Integrar **Identity** para login/roles  
- [ ] Responsive **sidebar** para móviles  
- [ ] Exportar reportes en **Excel / PDF**  
- [ ] Implementar **API REST** para integrarse con apps móviles  

---

## 👨‍💻 Autor
Desarrollado por **Engel Rodriguez** 🚀
