
----------------CREATE----------------
DROP DATABASE QLKS2
GO

CREATE DATABASE QLKS2
GO

USE QLKS2
GO

CREATE TABLE Account
(
	Username varchar(10) PRIMARY KEY,
	Password varchar(20) not null,
	Email varchar(20) not null,
	Name nvarchar(50) not null,
	Phone varchar(10) not null,
	Avatar IMAGE,
	--Position VARCHAR(20) NOT NULL,
)
GO
--
CREATE TABLE Customer
(
	Customer_ID varchar(10) PRIMARY KEY,
	Name nvarchar(50) not null,
	Dob date not null,
	Gender nvarchar(10) not null,
	IDCard varchar(10) not null,
	Phone varchar(10) not null,
	Address nvarchar(50) not null,
)
GO

CREATE TABLE Employee
(
	Employee_ID varchar(10) PRIMARY KEY,
	Name nvarchar(50) not null,
	Dob date not null,
	Gender nvarchar(10) not null,
	IDCard varchar(10) not null,
    Phone varchar(10) not null,
	Address nvarchar(50) not null,
	Status NVARCHAR(5) NOT NULL,
)
GO

CREATE TABLE Room
(
	Room_ID varchar(10) PRIMARY KEY,
	Type nvarchar(10) not null,
	Person int not null,
	Price int not null,
	Status nvarchar(20) not null,
	Description nvarchar(50),
)
GO


CREATE TABLE Service
(
	Service_Code varchar(10) PRIMARY KEY,
	Service_Name nvarchar(30) not null,
	Unit nvarchar(10) not null,
	Price int not null,
)
GO

CREATE TABLE ServiceInvoice
(
	Service_Invoice_Code varchar(10) PRIMARY KEY,
	Customer_ID varchar(10) FOREIGN KEY REFERENCES Customer(Customer_ID)  ON DELETE CASCADE,
	Manager_ID varchar(10) FOREIGN KEY REFERENCES Account(Username),
	Employee_ID varchar(10) FOREIGN KEY REFERENCES Employee(Employee_ID),
	Date_Created date not null,
	Total int not null,
	Status nvarchar(20) not null,
)
GO
CREATE TABLE SelectedService
(	
	No INT,
	Service_Invoice_Code varchar(10) FOREIGN KEY REFERENCES ServiceInvoice(Service_Invoice_Code) ON DELETE CASCADE,
	Service_Code varchar(10) FOREIGN KEY REFERENCES Service(Service_Code),
	Price int,
	Quantity int not null, 
)
GO

SELECT * FROM dbo.ServiceInvoice
DELETE FROM dbo.ServiceInvoice
WHERE Customer_ID = 'KH001'
CREATE TABLE Booking
(
	Booking_ID varchar(10) PRIMARY KEY,
	Manager_ID varchar(10) FOREIGN KEY REFERENCES Account(Username),
	Customer_ID varchar(10) FOREIGN KEY REFERENCES Customer(Customer_ID) ON DELETE CASCADE,
	Room_ID varchar(10) FOREIGN KEY REFERENCES Room(Room_ID),
	Arrival date not null,
)

CREATE TABLE ServiceReport
(
	No int identity(1,1) PRIMARY KEY,
	Date_Created date not null,
	Date_Payment date not null,
	Total int not null,
)

CREATE TABLE BookingReport
(
	No int identity(1,1) PRIMARY KEY,
	Date_Created date not null,
	Date_Payment date not null,
	Total int not null,
)

--OUTPUT inserted.No

----------------INSERT---------------
------- Account -------

INSERT INTO Account
SELECT 'QL01', '1', N'20133062@gmail.com', N'Nguyễn Văn Trường Tốt', '0824520364', BULKCOLUMN 
FROM OPENROWSET (BULK 'D:\QuanLyKhachSan\Avatar\Manager\AvatarTot.jpg', SINGLE_BLOB) AS Picture
GO

INSERT INTO Account
SELECT 'QL02', '1', N'20133091@gmail.com', N'Nguyễn Quốc Thắng', '0824520364', BULKCOLUMN 
FROM OPENROWSET (BULK 'D:\QuanLyKhachSan\Avatar\Manager\AvatarThang.jpg', SINGLE_BLOB) AS Picture
GO

------- Customer -------
INSERT INTO Customer 
VALUES ('KH001', 'Messi', '1987-06-24', 'Male', '2452947210', '0964872091', 'Argentina')

INSERT INTO Customer 
VALUES ('KH002', 'Ronaldo', '1985-02-05', 'Male', '6104737439', '0638209746', 'Poturgal')

INSERT INTO Customer 
VALUES('KH003', 'Neymar', '1992-02-05', 'Male', '9683028942', '0628018548', 'Brazil')

INSERT INTO Customer 
VALUES('KH004', 'Mbappe', '1998-12-20', 'Male', '2784952015', '0271057312', 'France')

INSERT INTO Customer 
VALUES('KH005', 'Kane', '1993-07-28', 'Male', '6389251074', '0912975684', 'England')

INSERT INTO Customer 
VALUES('KH006', 'Ronney', '1985-10-24', 'Male', '6284016384', '0972018647', 'England')

INSERT INTO Customer	
VALUES('KH007', 'Kaka', '1982-04-22', 'Male', '225957006', '0926787910', 'Brazil')
GO

SELECT * FROM dbo.Customer
------- EMPLOYEE -------
INSERT INTO Employee 
VALUES('NV001', 'Jisoo', '1995-09-11', 'Female', '34512125', '0928474747', 'Korea', 'Free')

INSERT INTO Employee 
VALUES('NV002', 'Lisa', '1994-03-25', 'Female', '23775858', '0917483727', 'Korea', 'Free')

INSERT INTO Employee 
VALUES('NV003', 'Roses', '1996-03-07', 'Female', '24563737', '0928474722', 'Korea', 'Free')

INSERT INTO Employee 
VALUES('NV004', 'Jennie', '1996-05-17', 'Female', '80167839', '0927819444', 'Korea', 'Free')

INSERT INTO Employee 
VALUES('NV005', 'Momo', '1995-12-04', 'Female', '29347102', '0918489222', 'Korea', 'Free')

INSERT INTO Employee 
VALUES('NV006', 'Mina', '1996-01-21', 'Female', '90127492', '0916748022', 'Korea', 'Free')

INSERT INTO Employee 
VALUES('NV007', 'Sana', '1997-03-16', 'Female', '67259186', '0916481225', 'Korea', 'Free')


------- ROOM -------
INSERT INTO Room VALUES('Room001', 'Standard', 2, 300000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room002', 'Standard', 2, 300000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room003', 'Standard', 2, 300000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room004', 'Superior', 2, 400000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room005', 'Superior', 2, 400000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room006', 'Superior', 2, 400000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room007', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
INSERT INTO Room VALUES('Room008', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
INSERT INTO Room VALUES('Room009', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
INSERT INTO Room VALUES('Room010', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
GO

SELECT * FROM dbo.Room
------- SERVICE -------
INSERT INTO Service VALUES ('DV001', N'Saigon Beer', N'Can', 20000)
INSERT INTO Service VALUES ('DV002', N'Wash Clothes', N'Times', 10000)
INSERT INTO Service VALUES ('DV003', N'Breakfast', N'Times', 75000)
INSERT INTO Service VALUES ('DV004', N'Massage', N'Hour', 150000)
INSERT INTO Service VALUES ('DV005', N'Water', N'Bottle', 10000)
GO


-------------------------------------------------------------------------
-------------------------------------------------------------------------
-------------------------------------------------------------------------

---------------------------------------------------------------------------------------------------------------------------------------------------
---------- ACCOUNT ----------
-----------------------------
---- GET 
CREATE PROC USP_Get_Account
(@Username varchar(10))
AS 
BEGIN
	 SELECT Username, Name, Phone, Email, Avatar
	 FROM Account
     WHERE Username = @Username
END GO

--EXEC USP_Get_Account 'QL01'

----  LOGIN
CREATE PROCEDURE USP_Login_Account
(@Username varchar(10), @Password varchar(20))
AS 
BEGIN
     SELECT * FROM dbo.Account
	 WHERE Username = @Username and Password = @Password
END GO

--EXEC USP_Login 'QL01', '1'

---- FORGOT 
CREATE PROCEDURE USP_Forgot_Account
(@Email varchar(20), @Username  VARCHAR(10))
AS 
BEGIN
     SELECT * FROM Account 
	 WHERE Email = @Email AND Username = @Username
END GO

--EXEC USP_Forgot_Account '1', 'QL01'

---- UPDATE 
CREATE PROC USP_Update_Account
(@Username VARCHAR(10),
@Name VARCHAR(50),
@Phone VARCHAR(10),
@Email VARCHAR(20),
@Password VARCHAR(20),
@Path VARCHAR(100))
AS
BEGIN
	UPDATE Account 
	SET Name = @Name, Phone = @Phone, Email = @Email, Password = @Password,	Avatar = (SELECT bulkcolumn FROM OPENROWSET(BULK  '@Path', SINGLE_BLOB) AS IMAGE)
	WHERE Username = @Username
END GO

--EXEC USP_Update_Account 'QL01', '1', '1' , '1', '1', 'D:\QuanLyKhachSan\Avatar\Manager\AvatarTot.jpg'

---- UPDATE PASSWORD
CREATE PROC USP_Update_Password
(@Password VARCHAR(10), @Email VARCHAR(20))
AS
BEGIN
    UPDATE ACCOUNT SET Password = @Password 
	WHERE Email = @Email
END GO

--USP_Update_Password '1', '1'
---------------------------------------------------------------------------------------------------------------------------------------------------
---------- CUSTOMER ----------
------------------------------
---- GET LAST ID
CREATE PROC USP_Get_LastCustomerID
AS
BEGIN
	SELECT TOP(1) Customer_ID 
	FROM dbo.Customer
	ORDER BY Customer_ID DESC
END GO

--EXEC USP_Get_LastCustomerID

---- GET
CREATE PROC USP_Get_Customer
AS SELECT  * FROM Customer

--EXEC USP_Get_Customer


---- GET CUSTOMER IN SERVICE
CREATE PROC USP_Get_CustomerInService 
AS
BEGIN
	SELECT Booking.Customer_ID, Name, IDCard, Phone
    FROM dbo.Customer, dbo.Booking
    WHERE Booking.Customer_ID = Customer.Customer_ID
END GO

---- GET CUSTOMER IN BOOKING
CREATE PROC USP_Get_CustomerInBooking
AS
BEGIN
	SELECT Customer.Customer_ID, Name, IDCard, Phone 
							 FROM Customer, (SELECT Customer_ID FROM Customer 
											 EXCEPT 
											 SELECT Customer_ID FROM Booking) AS Customer_N 
							 WHERE Customer.Customer_ID = Customer_N.Customer_ID
END GO
---- SEARCH
CREATE PROC USP_Search_Customer
(@nameCol VARCHAR(30), @value VARCHAR(30))
AS
IF(@nameCol = 'Customer_ID')
	BEGIN
		SELECT * FROM dbo.Customer 
		WHERE Customer_ID LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol = 'Name')
	BEGIN
		SELECT * FROM dbo.Customer 
		WHERE Name LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol = 'IDCard')
	BEGIN
		SELECT * FROM dbo.Customer 
		WHERE IDCard LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol LIKE 'Phone')
	BEGIN
		SELECT * FROM dbo.Customer 
		WHERE Phone LIKE '%' + @value + '%'
	END GO

--EXEC USP_Search_Customer 'Customer_ID', 'KH001'
--EXEC USP_Search_Customer 'FullName', 'Neymar'
--EXEC USP_Search_Customer 'IDCard', '6389251074'
--EXEC USP_Search_Customer 'Phone', '0972018647'

---- SEARCH CUSTOMER IN CHECK-OUT 
CREATE PROC USP_Search_CustomerInServiceInvoice_CheckOut
@Customer_ID VARCHAR(10)
AS
BEGIN
	SELECT SI.Service_Invoice_Code, SI.Customer_ID, SI.Date_Created, SI.Total, SI.Status 
    FROM ServiceInvoice AS SI
    WHERE SI.Customer_ID LIKE N'%' + @Customer_ID + '%'
END GO

CREATE PROC USP_Search_CustomerInBooking_CheckOut
@Customer_ID VARCHAR(10)
AS
BEGIN
	SELECT B.Booking_ID, B.Customer_ID, B.Room_ID,  R.Price, B.Arrival
    FROM Booking AS B, Room AS R
    WHERE B.Room_ID = R.Room_ID and B.Customer_ID LIKE N'%' + @Customer_ID + '%'
END GO

---- INSERT
CREATE PROC USP_Insert_Customer
@Customer_ID VARCHAR(10),
@Name NVARCHAR(50),
@Dob DATE,
@Gender NVARCHAR(10),
@IDCard VARCHAR(10),
@Phone VARCHAR(10),
@Address NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Customer
	VALUES(@Customer_ID, @Name, @Dob, @Gender, @IDCard, @Phone, @Address)
END GO

--EXEC USP_Insert_Customer 'KH08','Messi','1987-10-21','Male','6129638294','0916482927','Argentina'

---- UPDATE
CREATE PROC USP_Update_Customer
@Customer_ID VARCHAR(10),
@Name NVARCHAR(50),
@Dob DATE,
@Gender NVARCHAR(10),
@IDCard VARCHAR(10),
@Phone VARCHAR(10),
@Address NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Customer
	SET Name = @Name, Dob = @Dob, Gender = @Gender, IDCard = @IDCard, Phone = @Phone, Address = @Address
	WHERE Customer_ID = @Customer_ID
END GO

--EXEC USP_Update_Customer 'KH09','Messi','1989-10-21','Male','6129610294','099992927','Argentina'

---- DELETE
CREATE PROC USP_Delete_Customer(@Customer_ID VARCHAR(10))
AS
BEGIN
	DELETE
	FROM dbo.Customer
	WHERE Customer_ID = @Customer_ID
END GO

--EXEC USP_Delete_Customer 'KH01'



---------------------------------------------------------------------------------------------------------------------------------------------------
---------- EMPLOYEE ----------
------------------------------ 
---- GET LAST ID
CREATE PROC USP_Get_LastEmployeeID
AS
BEGIN
	SELECT TOP(1) Employee_ID 
	FROM dbo.Employee
	ORDER BY Employee_ID  DESC
END GO

--EXEC USP_Get_LastEmployeeID

---- GET
CREATE PROC USP_Get_Employee
AS SELECT * FROM dbo.Employee

--EXEC USP_Get_Employee

---- GET EMPLOYEE IN SERVICE
CREATE PROC USP_Get_EmployeeInService
AS
BEGIN
	SELECT Employee_ID 
	FROM dbo.Employee
	WHERE dbo.Employee.Status = 'Free'
END GO

---- SEARCH BY NAME
CREATE PROC USP_Search_Employee(@name NVARCHAR(50))
AS
BEGIN
	SELECT * FROM dbo.Employee
	WHERE Name LIKE N'%' + @name + '%'
END GO

--EXEC USP_Search_Employee 'Lisa'

---- INSERT
CREATE PROC USP_Insert_Employee
@EmployeeID VARCHAR(10),
@Name NVARCHAR(50),
@Dob DATE,
@Gender NVARCHAR(10),
@IDCard VARCHAR(10),
@Phone VARCHAR(10),
@Address NVARCHAR(50),
@Status NVARCHAR(5)
AS
BEGIN

	INSERT INTO dbo.Employee
	VALUES(@EmployeeID, @Name, @Dob, @Gender, @IDCard, @Phone, @Address, @Status)
END GO

--EXEC USP_Insert_Employee 'NV09','Shizuka','1995-10-21','Female','6926108294','0916928927','Korea'

---- UPDATE
CREATE PROC USP_Update_Employee
@Employee_ID VARCHAR(10),
@Name NVARCHAR(50),
@Dob DATE,
@Gender NVARCHAR(10),
@IDCard VARCHAR(10),
@Phone VARCHAR(10),
@Address NVARCHAR(50),
@Status NVARCHAR(5)
AS
BEGIN
	UPDATE dbo.Employee
	SET Name = @Name, Dob = @Dob, Gender = @Gender, IDCard = @IDCard, Phone = @Phone, Address = @Address, Status = @Status
	WHERE Employee_ID = @Employee_ID
END GO

--EXEC USP_Update_Employee '8','Anna','1996-01-27','Female','6926967294','0916991927','Korea'


---- UPDATE STATUS EMPLOYEE
CREATE PROC USP_Update_EmployeeStatus
@Employee_ID NVARCHAR(10)
AS
BEGIN
	UPDATE dbo.Employee
	SET Status = 'Busy'
	WHERE Employee_ID = @Employee_ID
END GO

---- DELETE
CREATE PROC USP_Delete_Employee
(@Employee_ID VARCHAR(10))
AS 
BEGIN
	DELETE
	FROM dbo.Employee
	WHERE Employee_ID = @Employee_ID
END GO
GO

--EXEC USP_Delete_Employee 'NV007' 


---------------------------------------------------------------------------------------------------------------------------------------------------
---------- ROOM ----------
-------------------------- 
---- GET LAST ID
CREATE PROC USP_Get_LastRoomID
AS
BEGIN
	SELECT TOP(1) Room_ID 
	FROM dbo.Room
	ORDER BY Room_ID  DESC
END GO

--EXEC USP_Get_LastRoomID

---- GET ROOM IN BOOKING
CREATE PROC USP_Get_RoomInBooking
AS
BEGIN 
	SELECT Room_ID, Type, Person, Price, Status
	FROM Room
	WHERE Status = 'Available'
END GO

---- GET
CREATE PROC USP_Get_Room
AS SELECT * FROM dbo.Room

--EXEC USP_Get_Room

---- SEARCH
CREATE PROC USP_Search_Room
(@nameCol VARCHAR(30), @value VARCHAR(30))
AS
IF(@nameCol LIKE 'Room_ID')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Room_ID  LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol LIKE 'Type')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Type  LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol LIKE 'Person')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Person  LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol LIKE 'Price')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Price  LIKE '%' + @value + '%'
	END GO
ELSE IF(@nameCol = 'Status')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Status  LIKE '%' + @value + '%'
	END GO

--EXEC USP_Search_Room 'Room_ID', 'Room004'
--EXEC USP_Search_Room 'Type', 'Superior'
--EXEC USP_Search_Room 'Person', 2
--EXEC USP_Search_Room 'Price', 500000
--EXEC USP_Search_Room 'Status', 'Full'

---- INSERT
CREATE PROC USP_Insert_Room
@Room_ID VARCHAR(10),
@Type NVARCHAR(10),
@Person INT,
@Price INT,
@Status NVARCHAR(20),
@Description NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Room
	VALUES(@Room_ID, @Type, @Person, @Price, @Status, @Description)
END GO

--EXEC USP_Insert_Room 'Room011','Superior',2,350000,'Available','1 TV, 1 Bed, Sea View'

---- UPDATE
CREATE PROC USP_Update_Room
@Room_ID VARCHAR(10),
@Type NVARCHAR(10),
@Person INT,
@Price INT,
@Status NVARCHAR(20),
@Description NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Room
	SET Type = @Type, Person = @Person, Price = @Price, Status = @Status, Description = @Description
	WHERE Room_ID = @Room_ID
END GO

--EXEC USP_Update_Room 'Room001','Superior',2,350000,'Available','1 TV, 1 Bed, Sea View'

---- UPDATE STATUS
CREATE PROC USP_Update_RoomStatus
(@RoomID VARCHAR(10), @Status VARCHAR(10))
AS
BEGIN
	UPDATE Room SET Status = @Status 
	WHERE Room_ID = @RoomID 
END GO

--EXEC USP_Update_RoomStatus

---- DELETE
CREATE PROC USP_Delete_Room
(@Room_ID VARCHAR(10))
AS
BEGIN
	DELETE
	FROM dbo.Room
	WHERE Room_ID = @Room_ID
END GO
GO

--EXEC USP_Delete_Room 'Room001'



---------------------------------------------------------------------------------------------------------------------------------------------------
---------- SERVICE  ----------
------------------------------
CREATE FUNCTION FU_Get_Service() RETURNS TABLE
AS RETURN (SELECT * FROM Service)

SELECT * FROM FU_Get_Service()   




---------------------------------------------------------------------------------------------------------------------------------------------------
---------- SERVICE INVOICE ----------
-------------------------------------
---- GET 
CREATE PROC USP_Get_ServiceInvoice
AS
BEGIN
	SELECT * FROM ServiceInvoice 
	WHERE ServiceInvoice.Status = 'UNPAID'
END GO

---- GET LAST SERVICE INVOICE
CREATE PROC USP_Get_LastServiceInvoice
AS
BEGIN
	SELECT TOP(1) Service_Invoice_Code 
	FROM dbo.ServiceInvoice
	ORDER BY Service_Invoice_Code DESC
END GO


---- GET SERVICE INVOICE IN CHECKOUT
CREATE PROC USP_Get_ServiceInvoiceInCheckOut
AS
BEGIN
	SELECT SI.Service_Invoice_Code, SI.Customer_ID, SI.Date_Created, SI.Total, SI.Status 
    FROM ServiceInvoice AS SI 
    WHERE SI.Status = 'UNPAID'
END GO
---- INSERT
CREATE PROC USP_Insert_ServiceInvoice
@Service_Invoice_Code NVARCHAR(10),
@Customer_ID VARCHAR(10),
@Manager_ID VARCHAR(10),
@Employee_ID VARCHAR(10),
@Date_Created DATE,
@Total INT,
@Status NVARCHAR(20) 
AS
BEGIN
	INSERT INTO dbo.ServiceInvoice
	VALUES(@Service_Invoice_Code, @Customer_ID, @Manager_ID, @Employee_ID, @Date_Created, @Total, @Status)
END GO
 
--EXEC USP_Insert_ServiceInvoice '15','KH01','QL01','NV01','2022-10-10',100000,'UNPAID'

---- UPDATE
CREATE PROC USP_Update_ServiceInvoice
(@SIC NVARCHAR(10))
AS
BEGIN 
	UPDATE dbo.ServiceInvoice 
    SET Total = SS.Total, Status = 'UNPAID' 
    FROM dbo.ServiceInvoice AS SI INNER JOIN(SELECT Service_Invoice_Code, Sum(Price* Quantity) as Total 
											 FROM dbo.SelectedService 
											 WHERE Service_Invoice_Code = @SIC
											 GROUP BY Service_Invoice_Code) as SS 
								  ON SI.Service_Invoice_Code = SS.Service_Invoice_Code
END GO

--EXEC USP_Update_ServiceInvoice '11'



---------------------------------------------------------------------------------------------------------------------------------------------------
---------- SELECTED SERVICE ----------
-------------------------------------
---- GET
CREATE PROC USP_Get_SelectedService
(@SIC VARCHAR(10))
AS
BEGIN
	SELECT *, (Price * Quantity) as Total 
    FROM SelectedService  
    WHERE SelectedService.Service_Invoice_Code = @SIC
END GO



---- INSERT
CREATE PROC USP_Insert_SelectedService
@No NVARCHAR(5),
@Service_Invoice_Code NVARCHAR(10),
@Service_Code NVARCHAR(10),
@Price INT,
@Quantity INT
AS
BEGIN
	INSERT INTO dbo.SelectedService
	VALUES (@No, @Service_Invoice_Code, @Service_Code, @Price, @Quantity)
END GO

--USP_Insert_SelectedService '1', 'SIC003', 'DV001', 2000, 2
---- DELETE
CREATE PROC USP_Delete_SelectedService
(@No INT)
AS
BEGIN
	DELETE
	FROM dbo.SelectedService
	WHERE No = @No
END GO

--EXEC DeleteService 1

---- UPDATE NO
CREATE PROC USP_Update_No
(@No INT)
AS
BEGIN
	UPDATE dbo.SelectedService
	SET No = @No
    WHERE No = @No + 1
END GO

--EXEC UpdateNo '1'



---------------------------------------------------------------------------------------------------------------------------------------------------
-------------- BOOKING --------------
-------------------------------------
---- GET LAST BOOKING
CREATE PROC USP_Get_LastBookingID
AS
BEGIN
	SELECT TOP(1) Booking_ID
	FROM dbo.Booking
	ORDER BY Booking_ID  DESC
END GO	

---- GET BOOKING
CREATE PROC USP_Get_Booking
AS
BEGIN
	SELECT Booking_ID, Manager_ID, Customer_ID, Room_ID, Arrival 
	FROM dbo.Booking
END GO

---- GET LIST BOOK
CREATE PROC USP_Get_BookingInCheckOut
AS
BEGIN
	SELECT Booking_ID, Customer_ID, dbo.Booking.Room_ID, Price, Arrival                        
    FROM Booking, Room 
    WHERE dbo.Booking.Room_ID = dbo.Room.Room_ID
END GO

---- INSERT BOOKING
CREATE PROC USP_Insert_Booking
(@BookingID VARCHAR(10), @ManagerID VARCHAR(10), @CustomerID VARCHAR(10), @RoomID VARCHAR(10), @Arrival DATE)
AS
BEGIN
	INSERT INTO Booking(Booking_ID, Manager_ID, Customer_ID, Room_ID, Arrival)
    VALUES(@BookingID, @ManagerID, @CustomerID, @RoomID, @Arrival)
END GO

---- UPDATE BOOKING
CREATE PROC USP_Update_Booking
(@RoomID VARCHAR(10))
AS
BEGIN
	UPDATE Room SET Status = 'Full'
	WHERE Room_ID = @RoomID
END GO

---- DELETE BOOKING
CREATE PROC USP_Delete_Booking
(@BookingID VARCHAR(10))
AS
BEGIN
	DELETE FROM Booking WHERE Booking_ID = @BookingID
END GO
GO
--EXEC dbo.USP_Delete_Booking @BookingID = '' -- varchar(10)

---- SEARCH BOOKING
CREATE PROC USP_Search_Booking
(@BookingID VARCHAR(10))
AS
BEGIN
	SELECT * FROM Booking
    WHERE Booking_ID LIKE '%' + @BookingID + '%'
END GO
GO
------------------
/*
CREATE FUNCTION SearchCustomer(@Name NVARCHAR(50)) RETURNS TABLE
AS 
	RETURN (SELECT Customer_ID, Name, IDCard, Phone FROM Customer 
            WHERE Name LIKE @Name)

SELECT * FROM SearchCustomer('Kaka')  
*/

