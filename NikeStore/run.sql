CREATE DATABASE NikeStore;
GO
use NikeStore;

CREATE TABLE Customers(
	[Id] [varchar](64) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Surname] [varchar](64) NOT NULL,
	[Phone] [varchar](25) NOT NULL,
	[Mail] [varchar](250) NOT NULL,
	[Address] [varchar](250) NOT NULL,   
 primary key(Id)
);

CREATE TABLE Products(
	[Id] [varchar](64) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[Category] [varchar](250) NOT NULL,
	[Price] [float] NOT NULL,
	[StockAmount] [float] NOT NULL,
	[UnitPrice] [varchar](16) NOT NULL,
	[Detail] [varchar](250) NOT NULL,    
primary key(Id)
);

CREATE TABLE [Sales](
	[Id] [varchar](64) NOT NULL,
	[CustomerId] [varchar](64) NOT NULL,
	[ProductId] [varchar](64) NOT NULL,
	[SaleDate] [datetime] NOT NULL,
	[SalePrice] [float] NOT NULL,    
primary key(Id),
   
    foreign key(CustomerId) references Customers(Id)
        on delete cascade on update cascade,
        
    foreign key(ProductId)    references Products(Id)
        on delete cascade on update cascade                         
);

CREATE TABLE Payments(
	[Id] [varchar](64) NOT NULL,
	[CustomerId] [varchar](64) NOT NULL,
	[TransactionDate] [datetime] NOT NULL,
	[Amount] [float] NOT NULL,
	[PaymentType] [varchar](25) NOT NULL,
	[Description] [varchar](250) NOT NULL,    
   primary key(Id),
   
   foreign key(CustomerId)  references Customers(Id)
        on delete cascade on update cascade
);

CREATE TABLE Users(
	[Id] uniqueidentifier NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[Surname] [varchar](64) NOT NULL,
	[Username] [varchar](64) NOT NULL,
	[Mail] [varchar](250) NOT NULL,
	[PasswordHash] [varchar](MAX) NOT NULL,   
	[PasswordSalt] [varbinary](MAX) NOT NULL,   
 primary key(Id)
); 

GO
CREATE PROCEDURE Nike_GetCustomers
AS
BEGIN
    SELECT * FROM Customers;
END

GO
CREATE PROCEDURE Nike_AddCustomer (
    @id      varchar(64) ,
    @name      varchar(64) ,
    @surname     varchar(64) ,
    @phone     varchar(25) ,
    @mail    varchar(250),
    @address     varchar(250)
)
AS
BEGIN
    INSERT INTO Customers
    VALUES (@id, @name, @surname , @phone, @mail, @address);
END 

GO
CREATE PROCEDURE Nike_UpdateCustomer (
    @id      varchar(64) ,
    @name      varchar(64) ,
    @surname     varchar(64) ,
    @phone     varchar(25) ,
    @mail    varchar(250),
    @address     varchar(250)
)
AS
BEGIN
    UPDATE Customers
    SET 
        Name      = @name,
        Surname   = @surname,
        Phone     = @phone,
        Mail      = @mail,
        Address   = @address
    WHERE 
        Id      = @id;
END 

GO
CREATE PROCEDURE Nike_DeleteCustomer (
    @id      varchar(64) 
)
AS
BEGIN
    DELETE FROM Customers
    WHERE   Id  = @id;
END


GO
CREATE PROCEDURE Nike_SearchCustomers (
    @search varchar(32) 
)
AS
BEGIN
    SELECT * FROM Customers
    WHERE 
        Name LIKE CONCAT('%',@search,'%')
		OR
        Surname LIKE CONCAT('%',@search,'%')
		OR
        Phone     LIKE  CONCAT('%',@search,'%')
		OR
        Mail LIKE  CONCAT('%',@search,'%')
END  

GO
CREATE PROCEDURE Nike_GetProducts
AS
BEGIN
    SELECT * FROM Products;
END

GO
CREATE PROCEDURE Nike_AddProduct (
    @id          varchar(64)  ,
    @name        varchar(250) ,
    @category    varchar(250) ,
    @price       float        ,
    @stockamount float        ,
    @unitprice   varchar(16)  ,
    @detail      varchar(250)
)
AS
BEGIN
    INSERT INTO Products
    VALUES  (@id, @name, @category, @price, @stockamount, @unitprice, @detail);
END

GO
CREATE PROCEDURE Nike_UpdateProduct (
    @id          varchar(64)  ,
    @name          varchar(250) ,
    @category    varchar(250) ,
    @price      float        ,
    @stockamount        float        ,
    @unitprice      varchar(16)  ,
    @detail      varchar(250) 
)
AS
BEGIN
    UPDATE Products
    SET 
        Name    = @name,
        Category = @category,
        Price    = @price,
        Stockamount     = @stockamount,
       UnitPrice    = @unitprice,
        Detail   = @detail
    WHERE 
        Id       = @id;
END

GO
CREATE PROCEDURE Nike_DeleteProduct (
    @id          varchar(64)  
)
AS
BEGIN
    DELETE FROM Products
    WHERE Id  = @id
END 

GO
CREATE PROCEDURE Nike_SearchProducts (
    @search varchar(32) 
)
AS
BEGIN
    SELECT * FROM Products
    WHERE 
        Name LIKE CONCAT('%',@search,'%')
		OR
        Category LIKE CONCAT('%',@search,'%')
		OR
        Detail     LIKE  CONCAT('%',@search,'%')
END   

GO
CREATE PROCEDURE Nike_AddSale (
    @sid     varchar(64) ,
    @mid     varchar(64) ,
    @uid     varchar(64) ,    
    @tarih   datetime    ,
    @fiyat   float       
)
AS
BEGIN
    INSERT INTO Sales
    VALUES  (@sid, @mid, @uid, @tarih, @fiyat);
END 

GO
CREATE PROCEDURE Nike_DeleteSale(
    @id    varchar(64)  
)
AS
BEGIN
    DELETE FROM Sales
    WHERE Id = @id;
END

GO
CREATE PROCEDURE Nike_UpdateSale (
    @sid         varchar(64),
    @mid         varchar(64),
    @uid         varchar(64),
    @tarih       datetime   ,
    @fiyat       float      
)
AS
BEGIN
    UPDATE Sales
    SET 
        ProductId  = @uid,
        CustomerId  = @mid,
        SaleDate = @tarih,
        SalePrice = @fiyat
    WHERE 
        Id = @sid;
END


GO
CREATE PROCEDURE Nike_GetSales
AS
BEGIN
SELECT   
        sale.Id as 'Satış Id',
        customer.Id as 'Müşteri Id',
        product.Id as 'Ürün Id',
        CONCAT(customer.Name,' ', customer.Surname) as 'Müşteri Ad Soyad',
        product.Name as 'Ürün',
        product.Category as 'Kategori',
        product.Price as 'Birim Fiyat',
        sale.SalePrice as 'Satış Fiyatı',
        sale.SaleDate as 'Satış Tarihi'
FROM    Sales sale 
		inner join Customers customer on customer.Id = sale.CustomerId
        inner join Products product on product.Id = sale.ProductId;
END

GO
CREATE PROCEDURE Nike_GetSaleById(
    @id varchar(64)  
)
AS
BEGIN
	SELECT   
        sale.Id as 'Id',
        customer.Id as 'CustomerId',
        product.Id as 'ProductId',
        customer.Name as 'CustomerName',
		customer.Surname as 'CustomerSurname',
        product.Name as 'ProductName',
        sale.SalePrice as 'SalePrice',
        sale.SaleDate as 'SaleDate'
FROM    Sales sale 
		inner join Customers customer on customer.Id = sale.CustomerId
        inner join Products product on product.Id = sale.ProductId
WHERE 
		sale.Id = @id
END

GO
CREATE PROCEDURE Nike_SearchSales(
    @search varchar(64)  
)
AS
BEGIN
	SELECT   
        sale.Id as 'Satış Id',
        customer.Id as 'Müşteri Id',
        product.Id as 'Ürün Id',
        CONCAT(customer.Name,' ', customer.Surname) as 'Müşteri Ad Soyad',
        product.Name as 'Ürün',
        product.Category as 'Kategori',
        product.Price as 'Birim Fiyat',
        sale.SalePrice as 'Satış Fiyatı',
        sale.SaleDate as 'Satış Tarihi'
FROM    Sales sale 
		inner join Customers customer on customer.Id = sale.CustomerId
        inner join Products product on product.Id = sale.ProductId
WHERE 
		customer.Name LIKE CONCAT('%',@search,'%')
		OR
		customer.Surname LIKE CONCAT('%',@search,'%')
		OR
        product.Name LIKE CONCAT('%',@search,'%')
		OR
        product.Category LIKE CONCAT('%',@search,'%')
END

GO
CREATE PROCEDURE Nike_AddPayment (
    @oid     varchar(64) ,
    @mid     varchar(64) ,   
    @tarih   datetime    ,
    @tutar   float       ,
    @tur     varchar(25) ,
    @aciklama varchar(250)
)
AS
BEGIN
    INSERT INTO Payments
    VALUES  (@oid, @mid, @tarih, @tutar, @tur, @aciklama);
END

GO
CREATE PROCEDURE Nike_SearchPayments
(
    @search varchar(64)  
)
AS
BEGIN
	SELECT   
        payment.Id as 'Ödeme Id',
        customer.Id as 'Müşteri Id',
        CONCAT(customer.Name,' ', customer.Surname) as 'Müşteri Ad Soyad',
		payment.TransactionDate as 'Ödeme Tarihi',
		payment.Amount as 'Ödeme Tutarı',
		payment.PaymentType as 'Ödeme Türü',
		payment.Description as 'Açıklama'

FROM    Payments payment 
		inner join Customers customer on customer.Id = payment.CustomerId
WHERE 
		customer.Name LIKE CONCAT('%',@search,'%')
		OR
		customer.Surname LIKE CONCAT('%',@search,'%')
		OR
        payment.PaymentType LIKE CONCAT('%',@search,'%')
		OR
        payment.Description LIKE CONCAT('%',@search,'%')
END

GO
CREATE PROCEDURE Nike_GetPayments
AS
BEGIN
SELECT   
        payment.Id as 'Ödeme Id',
        customer.Id as 'Müşteri Id',
        CONCAT(customer.Name,' ', customer.Surname) as 'Müşteri Ad Soyad',
		payment.TransactionDate as 'Ödeme Tarihi',
		payment.Amount as 'Ödeme Tutarı',
		payment.PaymentType as 'Ödeme Türü',
		payment.Description as 'Açıklama'


FROM    Payments payment
		inner join Customers customer on customer.Id = payment.CustomerId
END

GO
CREATE PROCEDURE Nike_GetPaymentById(
    @id varchar(64)  
)
AS
BEGIN
	SELECT   
        payment.Id as 'Id',
        customer.Id as 'CustomerId',
        customer.Name as 'CustomerName',
		customer.Surname as 'CustomerSurname',
		payment.TransactionDate as 'TransactionDate',
		payment.Amount as 'Amount',
		payment.PaymentType as 'PaymentType',
		payment.Description as 'Description'
FROM    Payments payment
		inner join Customers customer on customer.Id = payment.CustomerId
WHERE 
		payment.Id = @id
END

GO
CREATE PROCEDURE Nike_UpdatePayment
(
    @oid     varchar(64) ,
    @mid     varchar(64) ,   
    @tarih   datetime    ,
    @tutar   float       ,
    @tur     varchar(25) ,
    @aciklama varchar(250)
)
AS
BEGIN
    UPDATE Payments
    SET
        CustomerId      = @mid,
        TransactionDate = @tarih,
        Amount          = @tutar,
        PaymentType     = @tur,
        Description     = @aciklama
    WHERE 
        Id = @oid; 
END

GO
CREATE PROCEDURE Nike_DeletePayment (
    @id     varchar(64) 
)
AS
BEGIN
    DELETE FROM Payments
    WHERE Id = @id;
END 
