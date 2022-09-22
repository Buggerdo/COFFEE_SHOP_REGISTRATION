CREATE DATABASE [CoffeeShopProducts]

CREATE TABLE Products(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50) NOT NULL,
Price MONEY NOT NULL,
Category VARCHAR(50) NOT NULL
)

-- Scaffold-DbContext 'Data Source=TROYSPC;Initial Catalog=CoffeeShopProducts; Integrated Security=SSPI;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models