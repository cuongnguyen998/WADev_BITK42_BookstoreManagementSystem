CREATE DATABASE BMS
GO

USE BMS
GO

CREATE TABLE BookCategory
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	displayName NVARCHAR(100),
)
GO

CREATE TABLE AccountRole
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	displayName NVARCHAR(100)
)
GO


CREATE TABLE Accounts
(
	userName NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100),
	passWord NVARCHAR(MAX),
	role INT NOT NULL --1: staff && 2: admin
	
	FOREIGN KEY (role) REFERENCES dbo.AccountRole(id)
)
GO

CREATE TABLE Suppliers
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	displayName NVARCHAR(100),
	address NVARCHAR(100),
	email NVARCHAR(100),
	phoneNumber NVARCHAR(100)
)
GO	

CREATE TABLE Customers
(
	customerId NVARCHAR(100) PRIMARY KEY,
	displayName NVARCHAR(100),
	birthDay DATE,
	personalId NVARCHAR(100),
	address NVARCHAR(100),
	email NVARCHAR(100),
	moreInfo NVARCHAR(MAX)
)
GO

CREATE TABLE Books
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	bookCode NVARCHAR(100) NOT NULL,
	displayName NVARCHAR(100) NOT NULL,
	idCategory INT NOT NULL,
	idSupplier INT NOT NULL,
	status INT DEFAULT 1 --0: hết hàng && 1:còn hàng

	FOREIGN KEY (idCategory) REFERENCES dbo.BookCategory(id),
	FOREIGN KEY (idSupplier) REFERENCES dbo.Suppliers(id)
)
GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	BuyDate DATE NOT NULL DEFAULT GETDATE(),
	discount DECIMAL DEFAULT 0,
	idCustomer NVARCHAR(100) NOT NULL,
	totalPrice DECIMAL DEFAULT 0,
	status INT -- 0: chưa thanh toán && 1: đã thanh toán

	FOREIGN KEY (idCustomer) REFERENCES dbo.Customers(customerId)
)
GO

CREATE TABLE BillDetail
(
	id INT IDENTITY PRIMARY KEY,
	idBook INT NOT NULL,
	amount INT,
	idBill INT NOT NULL

	FOREIGN KEY (idBook) REFERENCES dbo.Books(id),
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id)
)
GO

CREATE TABLE Inputs
(
	inputId NVARCHAR(100) PRIMARY KEY,
	DateReceipt DATE
)
GO

CREATE TABLE InputDetail
(
	id INT IDENTITY PRIMARY KEY,
	idBook INT NOT NULL,
	amount INT,
	idStockReceipt NVARCHAR(100) NOT NULL,
	receiptPrice DECIMAL NOT NULL,
	discount DECIMAL DEFAULT 0,
	outputPrice DECIMAL DEFAULT 0,

	FOREIGN KEY (idBook) REFERENCES dbo.Books(id),
	FOREIGN KEY (idStockReceipt) REFERENCES dbo.Inputs(inputId)
)
GO

INSERT dbo.Inputs
        ( inputId, DateReceipt )
VALUES  ( N'', -- inputId - nvarchar(100)
          GETDATE()  -- DateReceipt - date
          )
SELECT [function] AS [Chức năng], shortcutKey AS [Phím tắt] FROM dbo.Help
------------------------------------------------------------------------------------------------
SELECT * FROM	dbo.AccountRole
SELECT * FROM dbo.Accounts
INSERT INTO dbo.Accounts
        ( userName ,
          displayName ,
          passWord ,
          role
        )
VALUES  ( N'admin' , -- userName - nvarchar(100)
          N'Admin' , -- displayName - nvarchar(100)
          N'db69fc039dcbd2962cb4d28f5891aae1' , -- passWord - nvarchar(max)
          2  -- role - int
        )
INSERT INTO dbo.Accounts
        ( userName ,
          displayName ,
          passWord ,
          role
        )
VALUES  ( N'staff' , -- userName - nvarchar(100)
          N'Staff' , -- displayName - nvarchar(100)
          N'978aae9bb6bee8fb75de3e4830a1be46' , -- passWord - nvarchar(max)
          1  -- role - int
        )
SELECT a.userName,a.displayName,ar.displayName FROM dbo.Accounts a, dbo.AccountRole ar WHERE a.role = ar.id

SELECT * FROM dbo.Accounts
GO
SELECT * FROM dbo.AccountRole
GO

--------------------------------------------------------------------------------------------------------
INSERT INTO dbo.Suppliers
        ( displayName ,
          address ,
          email ,
          phoneNumber
        )
VALUES  ( N'NXB Kim Đồng' , -- displayName - nvarchar(100)
          N'TP HCM' , -- address - nvarchar(100)
          N'kd@gmail.com' , -- email - nvarchar(100)
          N'02838999999'  -- phoneNumber - nvarchar(100)
        )
INSERT INTO dbo.Suppliers
        ( displayName ,
          address ,
          email ,
          phoneNumber
        )
VALUES  ( N'NXB Trẻ' , -- displayName - nvarchar(100)
          N'TP HCM' , -- address - nvarchar(100)
          N'xbt@gmail.com' , -- email - nvarchar(100)
          N'02838666666'  -- phoneNumber - nvarchar(100)
        )

INSERT INTO	dbo.Suppliers
        ( displayName ,
          address ,
          email ,
          phoneNumber
        )
VALUES  ( N'NXB ĐHQG' , -- displayName - nvarchar(100)
          N'TP HCM' , -- address - nvarchar(100)
          N'dhqg@gmail.com' , -- email - nvarchar(100)
          N'02828444444'  -- phoneNumber - nvarchar(100)
        )
INSERT INTO	dbo.Suppliers
        ( displayName ,
          address ,
          email ,
          phoneNumber
        )
VALUES  ( N'NXB Hà Nội' , -- displayName - nvarchar(100)
          N'Hà Nội' , -- address - nvarchar(100)
          N'nxbhn@gmaail.com' , -- email - nvarchar(100)
          N'0434555555'  -- phoneNumber - nvarchar(100)
        )
SELECT * FROM dbo.Suppliers
--------------------------------------------------------------------------------------------------------
INSERT INTO dbo.Customers
        ( customerId ,
          displayName ,
          birthDay ,
          personalId ,
          address ,
          email ,
          moreInfo
        )
VALUES  ( N'KH001' , -- customerId - nvarchar(100)
          N'Cường' , -- displayName - nvarchar(100)
          '08/18/1998' , -- birthDay - date
          N'3215555' , -- personalId - nvarchar(100)
          N'HN' , -- address - nvarchar(100)
          N'hhhh' , -- email - nvarchar(100)
          N'lllll'  -- moreInfo - nvarchar(max)
        )
INSERT INTO	dbo.Customers
        ( customerId ,
          displayName ,
          birthDay ,
          personalId ,
          address ,
          email ,
          moreInfo
        )
VALUES  ( N'KH002' , -- customerId - nvarchar(100)
          N'Trần' , -- displayName - nvarchar(100)
          '04/16/1998' , -- birthDay - date
          N'3214444' , -- personalId - nvarchar(100)
          N'TP HCM' , -- address - nvarchar(100)
          N'mmmm' , -- email - nvarchar(100)
          N'mmmmm'  -- moreInfo - nvarchar(max)
        )
-------------------------------------------------------------------------------------------------------
INSERT INTO dbo.BookCategory
        ( displayName )
VALUES  ( N'Truyện tranh'  -- displayName - nvarchar(100)
          )
INSERT INTO	dbo.BookCategory
        ( displayName )
VALUES  ( N'Thơ'  -- displayName - nvarchar(100)
          )
INSERT INTO	dbo.BookCategory
        ( displayName )
VALUES  ( N'Truyện dài'  -- displayName - nvarchar(100)
          )
INSERT INTO	dbo.BookCategory
        ( displayName )
VALUES  ( N'Truyện ngắn'  -- displayName - nvarchar(100)
          )
INSERT INTO	dbo.BookCategory
        ( displayName )
VALUES  ( N'Tiểu thuyết'  -- displayName - nvarchar(100)
          )
INSERT INTO	dbo.BookCategory
        ( displayName )
VALUES  ( N'Sách tham khảo'  -- displayName - nvarchar(100)
          )
SELECT * FROM dbo.BookCategory
SELECT * FROM dbo.Suppliers
-----------------------------------------------------------------------------------------------------
INSERT INTO dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status
        )
VALUES  ( N'BO001' , -- bookCode - nvarchar(100)
          N'Truyện Kiều' , -- displayName - nvarchar(100)
          2 , -- idCategory - int
          2 , -- idSupplier - int
          1  -- status - int
        )
INSERT INTO	dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status
        )
VALUES  ( N'BO002' , -- bookCode - nvarchar(100)
          N'Thần đồng đất Việt' , -- displayName - nvarchar(100)
          1 , -- idCategory - int
          1 , -- idSupplier - int
          1  -- status - int
        )
INSERT INTO dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status
        )
VALUES  ( N'BO003' , -- bookCode - nvarchar(100)
          N'Clean Code' , -- displayName - nvarchar(100)
          6 , -- idCategory - int
          3 , -- idSupplier - int
          1  -- status - int
        )
INSERT INTO	dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status
        )
VALUES  ( N'BO004' , -- bookCode - nvarchar(100)
          N'Code dạo ký sự' , -- displayName - nvarchar(100)
          6 , -- idCategory - int
          4 , -- idSupplier - int
          1  -- status - int
        )
INSERT INTO dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status
        )
VALUES  ( N'BO005' , -- bookCode - nvarchar(100)
          N'Harry Potter' , -- displayName - nvarchar(100)
          4 , -- idCategory - int
          4 , -- idSupplier - int
          1  -- status - int
        )
INSERT INTO dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          0 , -- discount - decimal
          N'KH001' , -- idCustomer - nvarchar(100)
          200000 , -- totalPrice - decimal
          0  -- status - int
        )
INSERT INTO dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          0 , -- discount - decimal
          N'KH002' , -- idCustomer - nvarchar(100)
          350000 , -- totalPrice - decimal
          0  -- status - int
        )
INSERT INTO dbo.BillDetail
        ( idBook, amount, idBill )
VALUES  ( 7, -- idBook - int
          1, -- amount - int
          1  -- idBill - int
          )
INSERT INTO dbo.BillDetail
        ( idBook, amount, idBill )
VALUES  ( 8, -- idBook - int
          10, -- amount - int
          1  -- idBill - int
          )
INSERT INTO	dbo.BillDetail
        ( idBook, amount, idBill )
VALUES  ( 9, -- idBook - int
          1, -- amount - int
          2  -- idBill - int
          )
INSERT INTO dbo.BillDetail
        ( idBook, amount, idBill )
VALUES  ( 7, -- idBook - int
          1, -- amount - int
          2  -- idBill - int
          )
-----------------------------------------------------------------------------------------------------
GO
CREATE PROC USP_Login
@userName NVARCHAR(100), @password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Accounts WHERE userName = @userName AND passWord = @password
END
GO
CREATE PROC USP_UpdateAccountInfo
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPass NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM	dbo.Accounts WHERE userName = @userName AND	passWord = @password
	IF (@isRightPass = 1)
	BEGIN
		IF (@newPass =  NULL OR @newPass = '')
		BEGIN
			UPDATE dbo.Accounts SET	displayName = @displayName WHERE userName=@userName
        END
		ELSE
			UPDATE dbo.Accounts SET	displayName = @displayName, passWord = @newPass WHERE userName = @userName
    END
END
GO
CREATE PROC USP_GetAccountByUsername
@userName NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Accounts WHERE userName = @userName
END
GO

CREATE PROC USP_InsertBill
@idCustomer NVARCHAR(100)
AS
BEGIN
	INSERT dbo.Bill
	        ( BuyDate ,
	          discount ,
	          idCustomer ,
	          totalPrice ,
	          status
	        )
	VALUES  ( GETDATE() , -- BuyDate - date
	          NULL , -- discount - decimal
	          @idCustomer , -- idCustomer - nvarchar(100)
	          NULL , -- totalPrice - decimal
	          0  -- status - int
	        )
END
GO
CREATE PROC USP_InsertBillDetail
@idBill INT, @idBook INT, @amount INT
AS
BEGIN
	DECLARE @isExistBillDetail INT
	DECLARE @bookAmount INT = 0

	SELECT @isExistBillDetail = id, @bookAmount = amount FROM dbo.BillDetail WHERE idBill = @idBill AND idBook = @idBook
	IF (@isExistBillDetail > 0)
	BEGIN
		DECLARE @newAmount INT = @bookAmount + @amount
		IF(@newAmount > 0)
			UPDATE dbo.BillDetail SET amount = @newAmount WHERE @idBook = idBook
		ELSE
			DELETE dbo.BillDetail WHERE idBill = @idBill AND idBook = @idBook
    END
    ELSE
	BEGIN
		INSERT dbo.BillDetail
	        ( idBook, amount, idBill )
		VALUES  ( @idBook, -- idBook - int
	          @amount, -- amount - int
	          @idBill  -- idBill - int
	          ) 
	END
END
GO

ALTER PROC USP_InsertCustomer
@customerId NVARCHAR(100), @displayName NVARCHAR(100), @birthDay DATETIME, 
@personalId NVARCHAR(100), @address NVARCHAR(100),@email NVARCHAR(100), @moreInfo NVARCHAR(100)
AS
BEGIN
	INSERT INTO dbo.Customers ( customerId , displayName , birthDay , personalId , address , email , moreInfo) VALUES  ( @customerId , @displayName , @birthDay ,  @personalId, @address, @email, @moreInfo )
END
GO

EXEC dbo.USP_InsertCustomer @customerId = N'', @displayName = N'', @birthDay = '2019-03-01 08:15:33', @personalId = N'', @address = N'', @email = N'', @moreInfo = N''
INSERT INTO	 dbo.Customers ( customerId , displayName , birthDay , personalId , address , email , moreInfo ) VALUES(N'KH009', N'Le Van Datq', '11-24-1999', N'45654', N'4564546', N'45654654', N'4656545')
DELETE FROM dbo.Customers WHERE customerId = N'KH004'
SELECT * FROM dbo.Customers

SELECT customerId AS [Mã khách hàng], displayName AS [Họ và tên], birthDay AS [Ngày sinh], personalId AS [CMND], address AS [Địa chỉ], email AS [Email],moreInfo AS [Ghi chú] FROM dbo.Customers WHERE displayName LIKE N'%cuong%'

SELECT * FROM dbo.Books
SELECT * FROM dbo.Inputs
SELECT * FROM dbo.InputDetail

ALTER TABLE dbo.InputDetail DROP COLUMN discount

UPDATE dbo.Customers SET displayName = N'', birthDay = '', personalId = N'',address = N'', email = N'', moreInfo = N'' WHERE customerId = N''
INSERT INTO dbo.Customers ( customerId , displayName , birthDay , personalId , address , email , moreInfo ) VALUES(N'KH004', N'Nguyen Van A', '13/07/1999 3:03:10 CH', N'456454', N'ihfaohsoi', N'iahfoiaiof', N'aiohfioas')
-----------------------------------------------------------------------------------------------------------------------------
ALTER TRIGGER UTG_CheckIdBeforeInsertBill
ON dbo.Bill
FOR INSERT
AS
BEGIN
	DECLARE @id INT
	SELECT @id = MAX(id) FROM Inserted
	RETURN @id
END
GO

INSERT dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          NULL , -- discount - decimal
          N'KH001' , -- idCustomer - nvarchar(100)
          NULL , -- totalPrice - decimal
          0  -- status - int
        )
GO
CREATE TRIGGER UTG_InsertInputDetail
ON dbo.InputDetail
FOR INSERT
AS
BEGIN
	DECLARE @bookId INT
	DECLARE @inputId NVARCHAR(100)
	SELECT @bookId = Inserted.idBook, @inputId = Inserted.idStockReceipt FROM Inserted

	DECLARE @bookCount INT
	SELECT @bookCount= COUNT(*) FROM dbo.Books WHERE id = @bookId

GO



-----------------------------------------------------------------------------------------------------------------------------
 

EXEC dbo.USP_InsertBill @idCustomer = N'' -- nvarchar(100)
EXEC dbo.USP_InsertBillDetail @idBill = 0, @idBook = 0, @amount = 0


EXEC dbo.USP_GetAccountByUsername @userName = N'admin' -- nvarchar(100)
EXEC dbo.USP_UpdateAccountInfo @userName = N'admin',@displayName = N'Cuong',@password = N'admin',@newPass = N''

INSERT dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          NULL , -- discount - decimal
          N'' , -- idCustomer - nvarchar(100)
          NULL , -- totalPrice - decimal
          0  -- status - int
        )

INSERT dbo.BillDetail
        ( idBook, amount, idBill )
VALUES  ( 0, -- idBook - int
          0, -- amount - int
          0  -- idBill - int
          )
-----------------------------------------------------------------------------------------------------
ALTER TABLE dbo.Books ADD unitPrice DECIMAL DEFAULT 0
ALTER TABLE dbo.Bill ADD customerId NVARCHAR(100)

ALTER TABLE dbo.Bill DROP COLUMN customerId

ALTER TABLE dbo.InputDetail DROP COLUMN discount
SELECT * FROM dbo.AccountRole
SELECT * FROM dbo.Accounts
DELETE FROM	 dbo.Accounts
SELECT * FROM dbo.Bill WHERE id = 14
SELECT * FROM dbo.BillDetail
SELECT * FROM dbo.Customers
INSERT INTO dbo.Inputs ( inputId, DateReceipt, idSupplier ) VALUES  ( N'', GETDATE(), 0 )
INSERT dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status ,
          unitPrice ,
          amount
        )
VALUES  ( N'' , -- bookCode - nvarchar(100)
          N'' , -- displayName - nvarchar(100)
          0 , -- idCategory - int
          0 , -- idSupplier - int
          0 , -- status - int
          NULL , -- unitPrice - decimal
          0  -- amount - int
        )

SELECT * FROM dbo.Books

SELECT i.inputId, i.DateReceipt, id.idBook,id.amount FROM dbo.Inputs i, dbo.InputDetail id WHERE i.inputId = id.idStockReceipt


ALTER TABLE dbo.Inputs ADD idSupplier INT
SELECT * FROM dbo.InputDetail
SELECT MAX(id) FROM	dbo.Bill
SELECT id FROM dbo.Books WHERE bookCode = N'BO001'
DELETE FROM dbo.BillDetail WHERE idBill = 3
DELETE FROM dbo.Bill WHERE id = 14
SELECT idCustomer FROM dbo.Bill WHERE id = 14
SELECT idCustomer FROM dbo.Bill WHERE id = 14
SELECT * FROM dbo.Customers WHERE customerId = (SELECT idCustomer FROM dbo.Bill WHERE id = 14)
SELECT * FROM dbo.AccountRole WHERE id = 2
UPDATE dbo.Accounts SET displayName = N'CườngNG', role = 2 WHERE userName = N'admin1'
--------------------------------------------------------------------------------------------------------
SELECT * FROM dbo.Customers
SELECT * FROM dbo.Books
SELECT * FROM dbo.Accounts WHERE userName = N'Admin' AND passWord = N''OR 1=1--db69fc039dcbd2962cb4d28f5891aae1'bô
SELECT * FROM dbo.Books
SELECT * FROM	dbo.BillDetail
SELECT bo.displayName,bi.amount, bo.unitPrice, bi.amount*bo.unitPrice AS totalPrice
FROM dbo. Bill b, dbo.Books bo, dbo.BillDetail bi WHERE b.id = bi.idBill AND bo.id = bi.idBook AND b.id = 2
UPDATE dbo.Bill SET	totalPrice = 0, discount = 0 WHERE id = 1
DELETE FROM dbo.BillDetail
DELETE FROM dbo.Bill
INSERT INTO	dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          NULL , -- discount - decimal
          N'KH001' , -- idCustomer - nvarchar(100)
          NULL , -- totalPrice - decimal
          0  -- status - int
        )

INSERT dbo.Books
        ( bookCode ,
          displayName ,
          idCategory ,
          idSupplier ,
          status ,
          unitPrice ,
          amount
        )
VALUES  ( N'' , -- bookCode - nvarchar(100)
          N'' , -- displayName - nvarchar(100)
          0 , -- idCategory - int
          0 , -- idSupplier - int
          0 , -- status - int
          NULL , -- unitPrice - decimal
          0  -- amount - int
        )

SELECT * FROM dbo.Bill
SELECT * FROM dbo.AccountRole WHERE id = 2
SELECT userName AS [Tên đăng nhập], displayName AS [Tên hiển thị], passWord AS [Mật khẩu], role AS [Quyền] FROM dbo.Accounts
UPDATE dbo.BookCategory SET	displayName = N'' WHERE id = 1
SELECT id AS [Mã danh mục], displayName AS [Tên danh mục] FROM dbo.BookCategory
DELETE FROM dbo.BillDetail WHERE idBill = 14
DELETE FROM dbo.Bill
SELECT MAX(id) FROM dbo.Bill
SELECT * FROM dbo.Bill
INSERT dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          NULL , -- discount - decimal
          N'KH001' , -- idCustomer - nvarchar(100)
          NULL , -- totalPrice - decimal
          0  -- status - int
        )
INSERT dbo.BillDetail
        ( idBook, amount, idBill )
VALUES  ( 0, -- idBook - int
          0, -- amount - int
          0  -- idBill - int
          )
INSERT INTO	 dbo.Customers ( customerId , displayName , birthDay , personalId , address , email , moreInfo )
VALUES  ( N'' , N'' , GETDATE() , N'' , N'' , N'' , N'')

INSERT INTO dbo.BookCategory ( displayName ) VALUES  ( N'')
INSERT INTO	 dbo.Customers ( customerId , displayName , birthDay , personalId , address , email , moreInfo ) VALUES(N'KH003', N'Cường Abv', 28/02/2019, N'sss', N'ssdd', N'ngngn', N'oaoaoa')
SELECT customerId AS [Mã khách hàng], displayName AS [Họ và tên], birthDay AS [Ngày sinh], personalId AS [CMND], address AS [Địa chỉ], email AS [Email],moreInfo AS [Ghi chú] FROM dbo.Customers
INSERT INTO dbo.BookCategory
        ( displayName )
VALUES  ( N''  -- displayName - nvarchar(100)
          )

INSERT dbo.Bill
        ( BuyDate ,
          discount ,
          idCustomer ,
          totalPrice ,
          status
        )
VALUES  ( GETDATE() , -- BuyDate - date
          NULL , -- discount - decimal
          N'KH001' , -- idCustomer - nvarchar(100)
          150000 , -- totalPrice - decimal
          1  -- status - int
        )

SELECT * FROM dbo.Customers
INSERT INTO dbo.Customers
        ( customerId ,
          displayName ,
          birthDay ,
          personalId ,
          address ,
          email ,
          moreInfo
        )
VALUES  ( N'' , -- customerId - nvarchar(100)
          N'' , -- displayName - nvarchar(100)
          GETDATE() , -- birthDay - date
          N'' , -- personalId - nvarchar(100)
          N'' , -- address - nvarchar(100)
          N'' , -- email - nvarchar(100)
          N''  -- moreInfo - nvarchar(max)
        )
		SELECT * FROM dbo.Customers
