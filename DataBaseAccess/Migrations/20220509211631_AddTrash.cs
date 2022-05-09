using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataBaseAccess.Migrations
{
    public partial class AddTrash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                            create or alter view ResultToExport as 
                            select 
                            orders.id as OrderId, 
                            consumers.Name as ConsumerName, 
                            consumers.Surname as ConsumerSurname, 
                            employees.Name as EmployeeName,
                            employees.Surname as EmployeeSurname,
                            Employees.PhoneNumber as EmployeePhoneNumber,
                            orders.CreateDate as OrederCreationDate,
                            orders.OrderStatus as OrderStatus
                            from Orders orders JOIN Consumers consumers ON consumers.Id = orders.ConsumerId JOIN Employees employees ON orders.EmploeeId = employees.Id;
                            ");
            migrationBuilder.Sql(@"
                            CREATE OR ALTER PROCEDURE ResultProcedure
                                @StartPeriod DATETIME,
                                @EndPeriod DATETIME
                            AS
                                SELECT * FROM ResultToExport WHERE OrederCreationDate >= @StartPeriod AND OrederCreationDate <= @EndPeriod
                            ");
            migrationBuilder.Sql(@"
                            CREATE OR ALTER VIEW EmployeesWithoutSalary as
                            SELECT Id, Name, Surname, BirthDate, PhoneNumber FROM Employees;
                            ");
            migrationBuilder.Sql(@"
                            CREATE OR ALTER VIEW ConsumersOrdersStatuses AS
                            SELECT consumers.Name, consumers.Surname, orders.OrderStatus, orders.CreateDate 
                            FROM Consumers consumers JOIN Orders orders ON orders.ConsumerId = consumers.Id
                            ");
            migrationBuilder.Sql(@"
                            CREATE PROCEDURE AddEmployee
                                @Name NVARCHAR(MAX),
                                @SurName NVARCHAR(MAX),
                                @BirthDate DATETIME,
                                @PhoneNumber NVARCHAR(MAX),
                                @Salary DECIMAL
                            AS
                            BEGIN
                            SET NOCOUNT ON;
                            
                            INSERT INTO Employees VALUES(@Name,@SurName,@BirthDate,@PhoneNumber,@Salary)
                            DECLARE @Result INT
                            SET @Result = (SELECT MAX(Id) FROM Employees)
                            RETURN @Result 
                            END");
            migrationBuilder.Sql(@"
                            CREATE PROCEDURE MoveOrderStatusToPaid
                            @OrderId  int = 0
                            AS
                            BEGIN
                            Update Orders Set OrderStatus = 1
                            WHERE Orders.Id = @OrderId
                            SELECT OrderStatus FROM Orders WHERE Id = @OrderId
                            END
                            ");
            migrationBuilder.Sql(@"
                            CREATE PROCEDURE MoveOrderStatusToRecieved
                            @OrderId  int = 0
                            AS
                            BEGIN
                            Update Orders Set OrderStatus = 2
                            WHERE Orders.Id = @OrderId
                            SELECT OrderStatus FROM Orders WHERE Id = @OrderId
                            END
                            ");
            migrationBuilder.Sql(@"
                            CREATE PROCEDURE MoveOrderStatusToShipped
                            @OrderId  int = 0
                            AS
                            BEGIN
                            Update Orders Set OrderStatus = 2
                            WHERE Orders.Id = @OrderId
                            SELECT OrderStatus FROM Orders WHERE Id = @OrderId
                            END");
            migrationBuilder.Sql(@"
                            CREATE FUNCTION AverageConsumerAge
                            (
                            ) 
                            RETURNS DATETIME 
                            AS 
                            BEGIN 
                                DECLARE @var decimal(9,2) 
                                SELECT @var = (SELECT AVG(DATEDIFF(hour,BirthDate,GETDATE())/8766.0) FROM Consumers)
                                RETURN @var 
                            END");
            migrationBuilder.Sql(@"
                            CREATE FUNCTION AverageOrderPrice
                            (
                            ) 
                            RETURNS DATETIME 
                            AS 
                            BEGIN 
                                DECLARE @var decimal(9,2) 
                                SELECT @var = (SELECT ((PurchaseProducts.Price * PurchaseProducts.PurchaseCount)/(SELECT COUNT(*) FROM Orders)) FROM PurchaseProducts )
                                RETURN @var 
                            END");
            migrationBuilder.Sql(@"
                            CREATE FUNCTION AverageProductPrice
                            (
                            ) 
                            RETURNS DATETIME 
                            AS 
                            BEGIN 
                                DECLARE @var decimal(9,2) 
                                SELECT @var = (SELECT AVG(Price) FROM Products)
                                RETURN @var 
                            END
                            ");
            migrationBuilder.Sql(@"
                            CREATE TABLE ProductsAudit(
                                Id INT IDENTITY PRIMARY KEY,
                                ProductId INT NOT NULL,
                                ProductName VARCHAR(255) NOT NULL,
                                ProductDescription VARCHAR(255) NOT NULL,
                                ProductPrice DECIMAL(18, 2) NOT NULL,
                                ProductStartStockCount VARCHAR(255) NOT NULL,
                                updated_at DATETIME NOT NULL,
                                operation CHAR(3) NOT NULL,
                                CHECK(operation = 'INS' or operation='DEL')
                            );");
            migrationBuilder.Sql(@"
                            CREATE TRIGGER ProductsAuditTrigger
                            ON Products
                            AFTER INSERT, DELETE
                            AS
                            BEGIN
                                SET NOCOUNT ON;
                                INSERT INTO ProductsAudit(
                                    ProductId, 
                                    ProductName,
                                    ProductDescription,
                                    ProductPrice,
                                    ProductStartStockCount, 
                                    updated_at, 
                                    operation
                                )
                                SELECT i.Id, Name, Description, Price, StockCount, GETDATE(), 'INS'
                                FROM inserted i
                                UNION ALL
                                SELECT d.Id, Name, Description, Price, StockCount, GETDATE(), 'DEL'
                                FROM deleted d;
                            END");
            migrationBuilder.Sql(@"
                            CREATE TABLE EmployeesAudit(
                                Id INT IDENTITY PRIMARY KEY,
                                EmployeeId INT NOT NULL,
                                EmployeeName VARCHAR(255) NOT NULL,
                                EmployeeSurname VARCHAR(255) NOT NULL,
                            	EmployeeBirthDate DATETIME2(7) NOT NULL,
                                EmployeePhoneNumber VARCHAR(MAX) NOT NULL,
                                EmployeeSalary DECIMAL(18, 2) NOT NULL,
                                updated_at DATETIME NOT NULL,
                                operation CHAR(3) NOT NULL,
                                CHECK(operation = 'INS' or operation='DEL')
                            );");
            migrationBuilder.Sql(@"
                            CREATE TRIGGER EmployeesAuditTrigger
                            ON Employees
                            AFTER INSERT, DELETE
                            AS
                            BEGIN
                                SET NOCOUNT ON;
                                INSERT INTO EmployeesAudit(
                                    EmployeeId, 
                                    EmployeeName,
                                    EmployeeSurname,
                                    EmployeeBirthDate,
                                    EmployeePhoneNumber,
                            		EmployeeSalary,
                                    updated_at, 
                                    operation
                                )
                                SELECT i.Id, Name, Surname, BirthDate, PhoneNumber, Salary, GETDATE(), 'INS'
                                FROM inserted i
                                UNION ALL
                                SELECT d.Id, Name, Surname, BirthDate, PhoneNumber, Salary, GETDATE(), 'DEL'
                                FROM deleted d;
                            END");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
