# 📊 Getting Started — Blazor Pivot Table CRUD with Entity Framework & SQL Server

[![License](https://img.shields.io/badge/license-SEE%20LICENSE-blue.svg)](https://www.syncfusion.com/content/downloads/syncfusion_license.pdf)
[![.NET 7.0](https://img.shields.io/badge/.NET-7.0-512BD4.svg)](https://dotnet.microsoft.com/)
[![Blazor Server](https://img.shields.io/badge/Blazor-Server-blueviolet.svg)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-7.0.5-green.svg)](https://docs.microsoft.com/ef/core/)
[![Visual Studio 2022](https://img.shields.io/badge/Visual%20Studio-2022-purple.svg)](https://visualstudio.microsoft.com/)

> 🚀 **Blazor Server quick-start template** demonstrating Syncfusion `PivotTable` with complete **CRUD operations**, **Entity Framework Core**, **SQL Server LocalDB**, and **real-time data synchronization** — includes NORTHWND sample database, layered architecture, and production-ready configuration for enterprise business intelligence applications.

> **📺 Official Demo:** https://blazor.syncfusion.com/demos/pivot-table/overview?theme=fluent2  
> **📚 Official Documentation:** https://ej2.syncfusion.com/blazor/documentation/pivot-table/getting-started

---

## 📑 Table of Contents

- [🔍 Overview](#-overview)
- [✨ Key Features](#-key-features)
- [📋 Prerequisites](#-prerequisites)
- [🧭 Quick Start](#-quick-start)
- [🗂️ Project Structure](#-project-structure)
- [🧱 Architecture & Data Flow](#-architecture--data-flow)
- [⚙️ Configuration & Customization](#-configuration--customization)
- [💡 Usage Examples](#-usage-examples)
- [🔧 CRUD Operations](#-crud-operations)
- [🧪 Testing](#-testing)
- [❓ Troubleshooting & FAQ](#-troubleshooting--faq)
- [🤝 Contributing](#-contributing)
- [📜 License & Support](#-license--support)

---

## 🔍 Overview

This repository provides a **production-ready starter template** for integrating Syncfusion's powerful `PivotTable` component with **Entity Framework Core** and **SQL Server** in **Blazor Server applications**. It demonstrates a complete end-to-end solution for building data-driven business intelligence dashboards with full database CRUD capabilities.

The sample includes:
- ✅ Interactive Pivot Table with CRUD operations (Create, Read, Update, Delete)
- ✅ Entity Framework Core for type-safe database access
- ✅ SQL Server LocalDB with NORTHWND sample database
- ✅ Real-time data synchronization between UI and database
- ✅ Layered architecture with proper separation of concerns
- ✅ RESTful API controller for data operations
- ✅ Inline cell editing with immediate database persistence
- ✅ Pre-configured connection strings and database context

### Who Should Use This?

- 📈 Business analysts building custom reporting and analytics tools
- 💼 Enterprise developers creating data-driven dashboards
- 🎓 .NET developers learning Syncfusion Blazor integration
- 🛠️ Teams building ERP, CRM, or business intelligence systems
- 🏢 Organizations migrating from ASP.NET to Blazor Server

### What Problems Does This Solve?

- ❌ **Problem:** Complex pivot table implementations require extensive custom code
- ✅ **Solution:** Ready-to-use Syncfusion PivotTable with minimal configuration

- ❌ **Problem:** Database operations in pivot tables are difficult to implement
- ✅ **Solution:** Complete CRUD operations with Entity Framework Core integration

- ❌ **Problem:** Real-time synchronization between UI and database is challenging
- ✅ **Solution:** Event-driven architecture with `EditCompleted` event handlers

---

## ✨ Key Features

| Feature | Description | Benefit |
|---------|-------------|---------|
| 🎯 **Inline CRUD Operations** | Edit, add, and delete records directly in pivot table cells | Streamlined data entry without separate forms |
| 📊 **Entity Framework Core** | Type-safe database access with LINQ queries | Compile-time validation and reduced runtime errors |
| 💾 **SQL Server LocalDB** | Embedded database with NORTHWND sample data | Zero-configuration development environment |
| 🔄 **Real-Time Sync** | Immediate database updates on user edits | Consistent data state across application |
| 🏗️ **Layered Architecture** | Clear separation: UI → Controller → DAL → DbContext | Maintainable and testable codebase |
| 📡 **RESTful API** | HTTP endpoints for CRUD operations | Scalable for microservices and API clients |
| 🎨 **Virtual Scrolling** | Efficient rendering for large datasets | Handles 10,000+ records smoothly |
| 🔒 **Transaction Safety** | EF Core change tracking and SaveChanges | Data integrity and rollback support |
| 📈 **Multi-Dimensional Analysis** | Rows, columns, values, and filters configuration | Flexible business intelligence reporting |
| 🧮 **Data Formatting** | Currency, date, and number format settings | Professional data presentation |

---

## 📋 Prerequisites

Ensure you have the following installed on your system:

- **Visual Studio 2022** (17.0 or higher) — [Download](https://visualstudio.microsoft.com/downloads/)
  - Workload: ASP.NET and web development
  - Workload: .NET desktop development
- **.NET SDK 7.0** or higher — [Download](https://dotnet.microsoft.com/download/dotnet/7.0)
- **SQL Server LocalDB** (included with Visual Studio) — [Standalone Download](https://docs.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb)
- **Git** (for cloning repository) — [Download](https://git-scm.com/)

### Supported Platforms

- ✅ Windows 10/11 (LocalDB requirement)
- ✅ Windows Server 2019/2022
- ⚠️ Linux/macOS (requires SQL Server Express/full edition)

### Supported Browsers

- ✅ Chrome (Latest)
- ✅ Firefox (Latest)
- ✅ Edge (Latest)
- ✅ Safari (Latest)

---

## 🧭 Quick Start

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/SyncfusionExamples/Blazor-PivotTable-CRUD-with-EntityFramework
cd Blazor-PivotTable-CRUD-with-EntityFramework
```

### 2️⃣ Open in Visual Studio 2022

1. Navigate to `MyBlazorApp` folder
2. Open `MyBlazorApp.sln` in Visual Studio 2022
3. Wait for NuGet package restore to complete automatically

### 3️⃣ Verify Database Connection

The project is pre-configured to use **SQL Server LocalDB** with an attached NORTHWND database file:

```csharp
// Located in: Data/OrderContext.cs
optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;
  AttachDbFilename=" + Environment.CurrentDirectory + @"\App_Data\NORTHWND.MDF;
  Integrated Security=True");
```

**Note:** The NORTHWND.MDF file must exist in `MyBlazorApp\App_Data\` directory.

### 4️⃣ Build and Run

#### Using Visual Studio:

1. Press `F5` or click **Debug → Start Debugging**
2. The browser will automatically open to `https://localhost:7XXX`

#### Using Command Line:

```bash
cd MyBlazorApp\MyBlazorApp
dotnet build
dotnet run
```

### 5️⃣ Verify Installation

You should see an interactive pivot table displaying:
- **Rows:** CustomerID, OrderDate
- **Columns:** ShipName
- **Values:** Freight (with N2 number format)

**Test CRUD Operations:**
1. **Edit:** Double-click any cell to modify the value
2. **Add:** Right-click to add new records
3. **Delete:** Right-click to remove records
4. **Verify:** Changes persist immediately to the database

---

## 🗂️ Project Structure

```
Blazor-PivotTable-CRUD-with-EntityFramework/
├── MyBlazorApp/
│   ├── MyBlazorApp.sln              # Visual Studio solution file
│   └── MyBlazorApp/
│       ├── MyBlazorApp.csproj       # Project dependencies & configuration
│       ├── Program.cs               # Application entry point & service registration
│       ├── appsettings.json         # Configuration settings
│       ├── _Imports.razor           # Global Razor component imports
│       ├── App.razor                # Root Blazor component
│       │
│       ├── App_Data/
│       │   └── NORTHWND.MDF         # SQL Server LocalDB database file
│       │
│       ├── Pages/
│       │   ├── Index.razor          # Main pivot table page with CRUD logic
│       │   ├── _Host.cshtml         # Blazor Server host page
│       │   ├── Error.cshtml         # Error handling page
│       │   └── HttpClient.razor     # Alternative HTTP-based CRUD example
│       │
│       ├── Controllers/
│       │   └── PivotController.cs   # RESTful API endpoints for CRUD operations
│       │
│       ├── Data/
│       │   ├── Orders.cs            # Entity model for Orders table
│       │   ├── OrderContext.cs      # EF Core DbContext configuration
│       │   └── OrderDataAccessLayer.cs  # Data access layer with CRUD methods
│       │
│       ├── Shared/
│       │   ├── MainLayout.razor     # Application layout template
│       │   └── NavMenu.razor        # Navigation menu component
│       │
│       ├── wwwroot/
│       │   ├── css/                 # Stylesheets & Syncfusion themes
│       │   ├── images/              # Static images
│       │   └── scripts/             # JavaScript libraries (lodash)
│       │
│       └── Properties/
│           └── launchSettings.json  # Development server configuration
│
└── README.md                        # This file
```

### Key Files Explained:

- **`Pages/Index.razor`** — Main pivot table component with inline CRUD event handling via `EditCompleted` event
- **`Controllers/PivotController.cs`** — RESTful API with `Get`, `Update`, `Add`, and `Delete` endpoints for HTTP-based operations
- **`Data/OrderDataAccessLayer.cs`** — Business logic layer with `GetAllOrders()`, `AddOrder()`, `UpdateOrder()`, `DeleteOrder()` methods
- **`Data/OrderContext.cs`** — Entity Framework DbContext with SQL Server connection configuration
- **`Data/Orders.cs`** — Entity model representing Orders table structure
- **`MyBlazorApp.csproj`** — NuGet package references for Syncfusion, EF Core, and System.Linq.Dynamic.Core

---

## 🧱 Architecture & Data Flow

### Layered Architecture

```
┌─────────────────────────────────────────────────────────────┐
│                   Presentation Layer                        │
│  ┌───────────────────────────────────────────────────────┐  │
│  │  Index.razor (SfPivotView Component)                  │  │
│  │  - User interactions (edit, add, delete)              │  │
│  │  - EditCompleted event handler                        │  │
│  └───────────────────────────────────────────────────────┘  │
└───────────────────────────┬─────────────────────────────────┘
                            │
┌───────────────────────────▼─────────────────────────────────┐
│                    API/Controller Layer                     │
│  ┌───────────────────────────────────────────────────────┐  │
│  │  PivotController.cs (Optional HTTP API)               │  │
│  │  - GET: Fetch data                                    │  │
│  │  - POST /Update: Update records                       │  │
│  │  - POST /Add: Create records                          │  │
│  │  - POST /Delete: Remove records                       │  │
│  └───────────────────────────────────────────────────────┘  │
└───────────────────────────┬─────────────────────────────────┘
                            │
┌───────────────────────────▼─────────────────────────────────┐
│                 Business Logic Layer (DAL)                  │
│  ┌───────────────────────────────────────────────────────┐  │
│  │  OrderDataAccessLayer.cs                              │  │
│  │  - GetAllOrders(): Fetch all orders                   │  │
│  │  - AddOrder(Order): Create new order                  │  │
│  │  - UpdateOrder(Order): Modify existing order          │  │
│  │  - DeleteOrder(int id): Remove order                  │  │
│  └───────────────────────────────────────────────────────┘  │
└───────────────────────────┬─────────────────────────────────┘
                            │
┌───────────────────────────▼─────────────────────────────────┐
│                   Data Access Layer (EF Core)               │
│  ┌───────────────────────────────────────────────────────┐  │
│  │  OrderContext.cs (DbContext)                          │  │
│  │  - DbSet<Order> Orders                                │  │
│  │  - Connection string configuration                    │  │
│  │  - Change tracking & SaveChanges()                    │  │
│  └───────────────────────────────────────────────────────┘  │
└───────────────────────────┬─────────────────────────────────┘
                            │
┌───────────────────────────▼─────────────────────────────────┐
│                      Database Layer                         │
│  ┌───────────────────────────────────────────────────────┐  │
│  │  SQL Server LocalDB                                   │  │
│  │  - NORTHWND.MDF database                              │  │
│  │  - Orders table                                       │  │
│  └───────────────────────────────────────────────────────┘  │
└─────────────────────────────────────────────────────────────┘
```

### Data Flow Sequence

#### **Read Operation:**
1. `Index.razor` renders `SfPivotView` component
2. Component calls `Orders.GetAllOrders()` via dependency injection
3. `OrderDataAccessLayer` queries `OrderContext.Orders` DbSet
4. Entity Framework executes SQL query against LocalDB
5. Results returned as `IQueryable<Order>` and displayed in pivot table

#### **Update Operation:**
1. User double-clicks cell and modifies value
2. `EditCompleted` event fires with `EditCompletedEventArgs<Order>`
3. Event handler extracts modified records from `args.ModifiedData`
4. For each modified order, calls `Orders.UpdateOrder(order)`
5. DAL updates entity state to `EntityState.Modified`
6. `SaveChanges()` commits transaction to database
7. UI automatically refreshes to reflect changes

#### **Create Operation:**
1. User right-clicks and selects "Add New Record"
2. `EditCompleted` event fires with new records in `args.AddedData`
3. Event handler calls `Orders.AddOrder(order)` for each record
4. DAL adds entity to `db.Orders` DbSet
5. `SaveChanges()` inserts new row into database

#### **Delete Operation:**
1. User right-clicks record and selects "Delete"
2. `EditCompleted` event fires with records in `args.RemovedData`
3. Event handler calls `Orders.DeleteOrder(order.OrderID)`
4. DAL finds entity by ID, removes from DbSet
5. `SaveChanges()` executes DELETE SQL statement

---

## ⚙️ Configuration & Customization

### Database Connection String

**Option 1: LocalDB (Default)**

```csharp
// OrderContext.cs
optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;
  AttachDbFilename=" + Environment.CurrentDirectory + @"\App_Data\NORTHWND.MDF;
  Integrated Security=True");
```

**Option 2: Full SQL Server Instance**

```csharp
optionsBuilder.UseSqlServer(@"Server=YOUR_SERVER_NAME;
  Database=NORTHWND;
  User Id=YOUR_USERNAME;
  Password=YOUR_PASSWORD;
  TrustServerCertificate=True");
```

**Option 3: Azure SQL Database**

```csharp
optionsBuilder.UseSqlServer(@"Server=tcp:yourserver.database.windows.net,1433;
  Database=NORTHWND;
  User ID=yourusername@yourserver;
  Password=yourpassword;
  Encrypt=True;
  TrustServerCertificate=False;
  Connection Timeout=30");
```

### Pivot Table Configuration

```razor
<SfPivotView TValue="Order" 
             Width="100%" 
             Height="600" 
             EnableVirtualization="true"   <!-- For large datasets -->
             ShowFieldList="true"          <!-- Show/hide field list -->
             ShowTooltip="true"            <!-- Enable tooltips -->
             AllowConditionalFormatting="true">  <!-- Conditional formatting -->
    
    <PivotViewDataSourceSettings TValue="Order" 
                                 ExpandAll="false"  <!-- Auto-expand rows -->
                                 DataSource="@Orders.GetAllOrders()">
        
        <!-- Define Rows (Hierarchical) -->
        <PivotViewColumns>
            <PivotViewColumn Name="ShipName"></PivotViewColumn>
            <PivotViewColumn Name="ShipCountry"></PivotViewColumn>
        </PivotViewColumns>
        
        <!-- Define Columns -->
        <PivotViewRows>
            <PivotViewRow Name="CustomerID" ExpandAll="true"></PivotViewRow>
            <PivotViewRow Name="OrderDate"></PivotViewRow>
        </PivotViewRows>
        
        <!-- Define Aggregated Values -->
        <PivotViewValues>
            <PivotViewValue Name="Freight" Caption="Total Freight"></PivotViewValue>
            <PivotViewValue Name="OrderID" Caption="Order Count" Type="Count"></PivotViewValue>
        </PivotViewValues>
        
        <!-- Data Formatting -->
        <PivotViewFormatSettings>
            <PivotViewFormatSetting Name="Freight" Format="C2"></PivotViewFormatSetting>
            <PivotViewFormatSetting Name="OrderDate" Format="dd/MM/yyyy"></PivotViewFormatSetting>
        </PivotViewFormatSettings>
    </PivotViewDataSourceSettings>
    
    <!-- Enable CRUD Operations -->
    <PivotViewCellEditSettings AllowEditing="true" 
                               AllowAdding="true" 
                               AllowDeleting="true"
                               Mode="EditMode.Normal">
    </PivotViewCellEditSettings>
    
    <!-- Event Handlers -->
    <PivotViewEvents TValue="Order" 
                     EditCompleted="EditCompleted"
                     OnLoad="OnLoad"
                     DataBound="OnDataBound">
    </PivotViewEvents>
</SfPivotView>
```

### Format String Examples

| Format Code | Example Output | Use Case |
|------------|-----------------|----------|
| `C0` | $1,234 | Currency without decimals |
| `C2` | $1,234.56 | Currency with 2 decimals |
| `N0` | 1,234 | General number |
| `N2` | 1,234.56 | Decimal numbers |
| `P0` | 50% | Percentage |
| `dd/MM/yyyy` | 15/04/2026 | Date format |
| `MMM dd, yyyy` | Apr 15, 2026 | Long date format |

---

## 💡 Usage Examples

### Example 1: Basic Pivot Table with CRUD

```razor
@page "/"
@using MyBlazorApp.Data
@using Syncfusion.Blazor.PivotView
@inject OrderDataAccessLayer Orders

<SfPivotView TValue="Order" Height="400">
    <PivotViewDataSourceSettings TValue="Order" 
                                 DataSource="@Orders.GetAllOrders()">
        <PivotViewColumns>
            <PivotViewColumn Name="ShipName"></PivotViewColumn>
        </PivotViewColumns>
        <PivotViewRows>
            <PivotViewRow Name="CustomerID"></PivotViewRow>
        </PivotViewRows>
        <PivotViewValues>
            <PivotViewValue Name="Freight"></PivotViewValue>
        </PivotViewValues>
    </PivotViewDataSourceSettings>
    
    <PivotViewCellEditSettings AllowEditing="true" 
                               AllowAdding="true" 
                               AllowDeleting="true">
    </PivotViewCellEditSettings>
    
    <PivotViewEvents TValue="Order" EditCompleted="EditCompleted">
    </PivotViewEvents>
</SfPivotView>

@code {
    private void EditCompleted(EditCompletedEventArgs<Order> args)
    {
        if (args.ModifiedData?.Count > 0)
        {
            foreach (var key in args.ModifiedData.Keys)
            {
                Orders.UpdateOrder(args.ModifiedData[key]);
            }
        }
        
        if (args.RemovedData?.Count > 0)
        {
            foreach (int key in args.RemovedData.Keys)
            {
                Orders.DeleteOrder(args.RemovedData[key].OrderID);
            }
        }
        
        if (args.AddedData?.Count > 0)
        {
            foreach (Order order in args.AddedData)
            {
                Orders.AddOrder(order);
            }
        }
    }
}
```

### Example 2: HTTP-Based CRUD with PivotController

```razor
@page "/httpclient"
@using Syncfusion.Blazor.PivotView
@using System.Net.Http.Json
@inject HttpClient Http

<SfPivotView TValue="Order" Height="400">
    <PivotViewDataSourceSettings TValue="Order" Url="api/Pivot">
        <!-- Same configuration as Example 1 -->
    </PivotViewDataSourceSettings>
    
    <PivotViewCellEditSettings AllowEditing="true" 
                               AllowAdding="true" 
                               AllowDeleting="true">
    </PivotViewCellEditSettings>
    
    <PivotViewEvents TValue="Order" EditCompleted="OnEditCompleted">
    </PivotViewEvents>
</SfPivotView>

@code {
    private async Task OnEditCompleted(EditCompletedEventArgs<Order> args)
    {
        if (args.ModifiedData?.Count > 0)
        {
            await Http.PostAsJsonAsync("api/Pivot/Update", args.ModifiedData);
        }
        
        if (args.AddedData?.Count > 0)
        {
            var addedDict = args.AddedData.Select((order, index) => 
                new KeyValuePair<int, Order>(index, order)).ToDictionary(x => x.Key, x => x.Value);
            await Http.PostAsJsonAsync("api/Pivot/Add", addedDict);
        }
        
        if (args.RemovedData?.Count > 0)
        {
            await Http.PostAsJsonAsync("api/Pivot/Delete", args.RemovedData);
        }
    }
}
```

### Example 3: Custom Data Access Layer Method

```csharp
// OrderDataAccessLayer.cs - Add custom query methods

public IEnumerable<Order> GetOrdersByCustomer(string customerId)
{
    try
    {
        return db.Orders.Where(o => o.CustomerID == customerId).ToList();
    }
    catch
    {
        throw;
    }
}

public decimal GetTotalFreightByCustomer(string customerId)
{
    try
    {
        return db.Orders
            .Where(o => o.CustomerID == customerId)
            .Sum(o => o.Freight);
    }
    catch
    {
        throw;
    }
}
```

---

## 🔧 CRUD Operations

### Create (Add New Order)

**UI Interaction:**
1. Right-click on any cell in the pivot table
2. Select "Add New Record" from context menu
3. Fill in the new record details in the dialog
4. Click "Add" button

**Code Flow:**
```csharp
// Index.razor - EditCompleted event handler
if (args.AddedData?.Count > 0)
{
    foreach (Order order in args.AddedData)
    {
        Orders.AddOrder(order);  // Calls DAL method
    }
}

// OrderDataAccessLayer.cs
public void AddOrder(Order Order)
{
    try
    {
        db.Orders.Add(Order);     // Add to EF context
        db.SaveChanges();         // Persist to database
    }
    catch
    {
        throw;
    }
}
```

### Read (Retrieve Orders)

**UI Interaction:**
- Data loads automatically when page renders

**Code Flow:**
```csharp
// Index.razor - Data binding
<PivotViewDataSourceSettings TValue="Order" 
                             DataSource="@Orders.GetAllOrders()">

// OrderDataAccessLayer.cs
public DbSet<Order> GetAllOrders()
{
    try
    {
        return db.Orders;  // Returns IQueryable for deferred execution
    }
    catch
    {
        throw;
    }
}
```

### Update (Edit Existing Order)

**UI Interaction:**
1. Double-click on any cell to enter edit mode
2. Modify the value
3. Press Enter or click outside the cell

**Code Flow:**
```csharp
// Index.razor - EditCompleted event handler
if (args.ModifiedData?.Count > 0)
{
    foreach (var key in args.ModifiedData.Keys)
    {
        Orders.UpdateOrder(args.ModifiedData[key]);
    }
}

// OrderDataAccessLayer.cs
public void UpdateOrder(Order Order)
{
    try
    {
        // Detach local instance if exists (prevents tracking conflicts)
        var local = db.Set<Order>().Local.FirstOrDefault(
            entry => entry.OrderID.Equals(Order.OrderID));
        if (local != null)
        {
            db.Entry(local).State = EntityState.Detached;
        }
        
        db.Entry(Order).State = EntityState.Modified;
        db.SaveChanges();
    }
    catch
    {
        throw;
    }
}
```

### Delete (Remove Order)

**UI Interaction:**
1. Right-click on a row
2. Select "Delete" from context menu
3. Confirm deletion in dialog

**Code Flow:**
```csharp
// Index.razor - EditCompleted event handler
if (args.RemovedData?.Count > 0)
{
    foreach (int key in args.RemovedData.Keys)
    {
        Orders.DeleteOrder(args.RemovedData[key].OrderID);
    }
}

// OrderDataAccessLayer.cs
public void DeleteOrder(int? id)
{
    try
    {
        Order Order = GetOrderData(id);
        if (Order != null)
        {
            db.Orders.Remove(Order);
            db.SaveChanges();
        }
    }
    catch
    {
        throw;
    }
}
```

---

## 🧪 Testing

### Manual Testing Checklist

1. **Data Display**
   - [ ] Pivot table renders with NORTHWND data
   - [ ] All columns and rows are visible
   - [ ] Freight values display with N2 format
   - [ ] OrderDate displays as dd/MM/yyyy

2. **Edit Operation**
   - [ ] Double-click cell to enter edit mode
   - [ ] Modify Freight value and press Enter
   - [ ] Refresh browser and verify change persists

3. **Add Operation**
   - [ ] Right-click and select "Add New Record"
   - [ ] Fill required fields (CustomerID, OrderDate, Freight, ShipName)
   - [ ] Verify new record appears in pivot table
   - [ ] Refresh browser and verify record persists

4. **Delete Operation**
   - [ ] Right-click on a row and select "Delete"
   - [ ] Confirm deletion
   - [ ] Verify record disappears from pivot table
   - [ ] Refresh browser and verify record is permanently deleted

### Database Verification

**Check data directly in SQL Server:**

```sql
-- Connect to (LocalDB)\MSSQLLocalDB
USE NORTHWND;

-- View all orders
SELECT TOP 10 * FROM Orders ORDER BY OrderID DESC;

-- Check recent modifications
SELECT * FROM Orders WHERE OrderID = <YourTestOrderID>;

-- Verify deletions
SELECT COUNT(*) FROM Orders;
```

---

## ❓ Troubleshooting & FAQ

### Common Errors

#### ❌ Error: "Cannot open database 'NORTHWND.MDF'"

**Solution:**
```bash
# Ensure LocalDB is installed
sqllocaldb info

# Create instance if missing
sqllocaldb create MSSQLLocalDB

# Start instance
sqllocaldb start MSSQLLocalDB

# Verify NORTHWND.MDF exists in App_Data folder
dir MyBlazorApp\App_Data\NORTHWND.MDF
```

#### ❌ Error: "The type or namespace name 'Syncfusion' could not be found"

**Solution:**
```bash
# Restore NuGet packages
dotnet restore

# Or in Visual Studio: Right-click Solution → Restore NuGet Packages
```

#### ❌ Error: "EditCompleted event not firing"

**Solution:**
```razor
<!-- Ensure AllowEditing is true -->
<PivotViewCellEditSettings AllowEditing="true" 
                           AllowAdding="true" 
                           AllowDeleting="true">
</PivotViewCellEditSettings>

<!-- Verify event handler is registered -->
<PivotViewEvents TValue="Order" EditCompleted="EditCompleted">
</PivotViewEvents>
```

#### ❌ Error: "Entity Framework tracking conflict"

**Solution:**
```csharp
// OrderDataAccessLayer.cs - Add detach logic before update
var local = db.Set<Order>().Local.FirstOrDefault(
    entry => entry.OrderID.Equals(Order.OrderID));
if (local != null)
{
    db.Entry(local).State = EntityState.Detached;
}
```

### FAQ

**Q: Can I use a different database instead of NORTHWND?**  
A: Yes, modify `OrderContext.cs` connection string and update `Orders.cs` entity model to match your table schema.

**Q: How do I deploy this to production?**  
A: Replace LocalDB connection string with full SQL Server instance, publish via Visual Studio or `dotnet publish`, and configure IIS/Azure App Service.

**Q: Can I add authentication/authorization?**  
A: Yes, implement ASP.NET Core Identity and add `[Authorize]` attributes to `PivotController` and pages.

**Q: How do I handle large datasets (100K+ rows)?**  
A: Enable server-side processing by implementing virtual scrolling, pagination, and asynchronous data loading with `IQueryable`.

**Q: Can I export pivot table data to Excel/PDF?**  
A: Yes, Syncfusion PivotTable supports export functionality. Add `ExcelExport` and `PDFExport` services to `Inject` services.

---

## 🤝 Contributing

We welcome contributions! Here's how you can help:

### Contribution Guidelines

1. **Fork** the repository on GitHub
2. **Clone** your fork locally:
   ```bash
   git clone https://github.com/SyncfusionExamples/Blazor-PivotTable-CRUD-with-EntityFramework
   ```
3. **Create** a feature branch:
   ```bash
   git checkout -b feature/amazing-feature
   ```
4. **Make** your changes following coding standards:
   - Use C# naming conventions (PascalCase for classes, camelCase for parameters)
   - Add XML documentation comments for public methods
   - Include unit tests for new features
5. **Commit** your changes:
   ```bash
   git commit -m "Add amazing feature: detailed description"
   ```
6. **Push** to your branch:
   ```bash
   git push origin feature/amazing-feature
   ```
7. **Open** a Pull Request with detailed description

### Development Setup

```bash
# Clone repository
git clone https://github.com/YourUsername/Blazor-PivotTable-CRUD-with-EntityFramework.git
cd Blazor-PivotTable-CRUD-with-EntityFramework/MyBlazorApp

# Restore packages
dotnet restore

# Build solution
dotnet build

# Run application
cd MyBlazorApp
dotnet run
```

### Code Style Guidelines

- Follow [Microsoft C# Coding Conventions](https://docs.microsoft.com/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- Use 4 spaces for indentation (not tabs)
- Add comments for complex logic
- Keep methods under 50 lines when possible

---

## 📜 License & Support

### License

This project is provided as-is for educational and commercial use. Syncfusion components require a valid license for production deployment. See [Syncfusion Licensing](https://www.syncfusion.com/sales/products) for details.

### Support & Resources

- 📚 **Syncfusion Blazor Documentation:** [https://ej2.syncfusion.com/blazor/documentation/](https://ej2.syncfusion.com/blazor/documentation/)
- 📺 **Video Tutorials:** [Syncfusion YouTube Channel](https://www.youtube.com/c/SyncfusionInc)
- 💬 **Community Forum:** [Syncfusion Blazor Forum](https://www.syncfusion.com/forums/blazor-components)
- 🐛 **Report Issues:** [GitHub Issues](https://github.com/YourUsername/Blazor-PivotTable-CRUD-with-EntityFramework/issues)
- 📧 **Contact:** support@syncfusion.com

### Additional Resources

- 🔗 [Entity Framework Core Documentation](https://docs.microsoft.com/ef/core/)
- 📖 [Blazor Server Documentation](https://docs.microsoft.com/aspnet/core/blazor/)
- 🎯 [SQL Server LocalDB](https://docs.microsoft.com/sql/database-engine/configure-windows/sql-server-express-localdb)
- 🧑‍💻 [Syncfusion Blazor Samples](https://ej2.syncfusion.com/blazor/demos/)

---
