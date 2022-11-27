﻿----------------CREATE----------------
DROP DATABASE QLKS1
GO

CREATE DATABASE QLKS1
GO

USE QLKS1
GO

CREATE TABLE PersonalInfor
(
	PersonID varchar(20) PRIMARY KEY,
	Name nvarchar(50) not null,
	Gender nvarchar(5) not null,
	Dob date not null,
	Address nvarchar(100) not null,
	Phone varchar(15) not null,
	IDCard varchar(15) not null,
)
GO

CREATE TABLE Account
(
	Username varchar(20) PRIMARY KEY,
	Password nvarchar(15) not null,
	Email nvarchar(50) not null,
	Authority nvarchar(50) not null,
	Avatar IMAGE,
	CONSTRAINT FK_Account FOREIGN KEY (Username) REFERENCES PersonalInfor(PersonID) ON DELETE CASCADE
)	
GO

CREATE TABLE Customer
(
	CustomerID varchar(20) PRIMARY KEY,
	CONSTRAINT FK_Customer FOREIGN KEY(CustomerID) REFERENCES PersonalInfor(PersonID) ON DELETE CASCADE
)
GO

CREATE TABLE Employee
(
	EmployeeID varchar(20) PRIMARY KEY,
	Status NVARCHAR(50) NOT NULL,
	CONSTRAINT FK_Employee FOREIGN KEY(EmployeeID) REFERENCES PersonalInfor(PersonID) ON DELETE CASCADE)
GO

CREATE TABLE Room
(
	RoomID varchar(20) PRIMARY KEY,
	Type nvarchar(50) not null,
	Person varchar(2) not null,
	Price int not null,
	Status nvarchar(50) not null,
	Description nvarchar(50),
)
GO


CREATE TABLE Service
(
	Service_Code varchar(20) PRIMARY KEY,
	Service_Name nvarchar(50) not null,
	Unit nvarchar(50) not null,
	Price int not null,
)
GO

CREATE TABLE ServiceInvoice
(
	Service_Invoice_Code varchar(20) PRIMARY KEY,
	CustomerID varchar(20) FOREIGN KEY REFERENCES Customer(CustomerID) ON DELETE CASCADE,
	ManagerID varchar(20) FOREIGN KEY REFERENCES Account(Username),
	EmployeeID varchar(20) FOREIGN KEY REFERENCES Employee(EmployeeID),
	Date_Created date not null,
	Total int not null,
	Status nvarchar(50) not null,
)
GO

CREATE TABLE Booking
(
	BookingID varchar(20) PRIMARY KEY,
	ManagerID varchar(20) FOREIGN KEY REFERENCES Account(Username),
	CustomerID varchar(20) FOREIGN KEY REFERENCES Customer(CustomerID) ON DELETE CASCADE,
	RoomID varchar(20) FOREIGN KEY REFERENCES Room(RoomID),
	Arrival date not null,
)
GO

CREATE TABLE SelectedService
(	
	No INT,
	Service_Invoice_Code varchar(20) FOREIGN KEY REFERENCES ServiceInvoice(Service_Invoice_Code) ON DELETE CASCADE,
	Service_Code varchar(20) FOREIGN KEY REFERENCES Service(Service_Code),
	Quantity int not null, 
)
GO


CREATE TABLE BookingReport
(
	RoomID VARCHAR(20),
	Type NVARCHAR(20),
	Date_Create date,
	Date_Pay date,
	Total int
)
GO

CREATE TABLE ServiceReport
(
	Service_Name nvarchar(50),
	Type nvarchar(30),
	Date_Create date,
	Quantity int,
	Price int,
	Total AS Quantity * Price
)
GO


CREATE TABLE Detail
(
	DetailID varchar(20) Primary Key,
	Detail nvarchar(100),
)
go
create Table DetailRoom
(
	DetailID varchar(20) FOREIGN KEY REFERENCES Detail(DetailID),
	RoomID  varchar(20) FOREIGN KEY REFERENCES Room(RoomID) ON DELETE CASCADE,
)
go
CREATE TABLE Images
(
	RoomID varchar(20) FOREIGN KEY REFERENCES Room(RoomID) ON DELETE CASCADE,
	Path varchar(255),
)
go
----------------INSERT---------------

------- ROOM -------
INSERT INTO Room VALUES('Room001', 'Standard', 2, 500000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room002', 'Standard', 2, 500000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room003', 'Standard', 2, 500000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room004', 'Superior', 2, 400000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room005', 'Superior', 2, 400000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room006', 'Superior', 2, 400000, 'Available', '1 TV, 1 Bed')
INSERT INTO Room VALUES('Room007', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
INSERT INTO Room VALUES('Room008', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
INSERT INTO Room VALUES('Room009', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
INSERT INTO Room VALUES('Room050', 'Deluxe', 4, 500000, 'Available', '1 TV, 2 Bed')
GO

------- SERVICE -------
INSERT INTO Service VALUES ('DV001', N'Saigon Beer', N'Nước uống', 30000)
INSERT INTO Service VALUES ('DV002', N'Coca', N'Nước uống', 25000)
INSERT INTO Service VALUES ('DV003', N'Pepsi', N'Nước uống', 25000)
INSERT INTO Service VALUES ('DV004', N'Trà xanh', N'Nước uống', 200000)
INSERT INTO Service VALUES ('DV005', N'Nước suối', N'Nước uống', 10000)

INSERT INTO Service VALUES ('DV006', N'Spa', N'Sức khoẻ', 100000)
INSERT INTO Service VALUES ('DV007', N'Gym', N'Sức khoẻ', 100000)

INSERT INTO Service VALUES ('DV008', N'Bar', N'Giải trí', 100000)



GO

---- GET ACCOUNT ----DONE
CREATE PROC USP_Get_Account
(@Username varchar(20))
AS 
BEGIN
	 SELECT Account.*, PersonalInfor.*
	 FROM Account Left JOIN PersonalInfor ON Account.Username = PersonalInfor.PersonID
     WHERE Username = @Username
END
GO

---- GET PASSWORD ----DONE
CREATE PROC USP_Get_Password
(@Username VARCHAR(20))
AS
BEGIN
	SELECT Password
	FROM Account
	WHERE Username = @Username
END
GO

---- SEARCH EMAIL ----DONE
CREATE PROC USP_Search_Email
(@Email NVARCHAR(50))
AS
BEGIN
	SELECT Email
	FROM Account
	Where Email = @Email
END
GO

----  LOGIN ----DONE
CREATE PROCEDURE USP_Login_Account
(@Username varchar(20), @Password varchar(15))
AS 
BEGIN
     SELECT * FROM dbo.Account
	 WHERE Username = @Username and Password = @Password
END
GO

---- FORGOT  ----DONE
CREATE PROCEDURE USP_Forgot_Account
(@Email varchar(50), 
@Username  VARCHAR(20))
AS 
BEGIN
     SELECT * FROM Account 
	 WHERE Email = @Email AND Username = @Username
END
GO

---- INSERT	 ----DONE
CREATE PROC USP_Insert_Account
(@PersonalID VARCHAR(20),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(15),
@IDCard VARCHAR(15),
@Password VARCHAR(20), 
@Email NVARCHAR(50), 
@Authority NVARCHAR(50),
@Avatar Image)
AS 
BEGIN
	BEGIN TRANSACTION
	BEGIN TRY
		INSERT INTO dbo.PersonalInfor VALUES(@PersonalID, @Name, @Gender, @Dob, @Address, @Phone, @IDCard)
		INSERT INTO dbo.Account VALUES(@PersonalID, @Password, @Email, @Authority, @Avatar)
	END TRY
	BEGIN CATCH
	IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION
	END CATCH
	IF (@@TRANCOUNT > 0) COMMIT TRANSACTION
END
GO	
--USP_Insert_Account 'ql01', N'Tốt Nguyễn', 'Nam', '11/09/2002', 'Nha Trang', '0824520365', '225957006', '1', 'lu2002ny@gmail.com', N'Quản lý', '0x00'


---- UPDATE IMAGE ---- DONE
CREATE PROC USP_Update_Image
(@Username varchar(20),
@Avatar image)
AS
BEGIN
	UPDATE Account 
	SET Avatar = @Avatar
	WHERE Username = @Username
END
GO

---- GET LAST ID EMPLOYEE -- DONE
CREATE PROC USP_Get_LastEmployeeID
AS	
BEGIN
	SELECT TOP(1) EmployeeID 
	FROM dbo.Employee
	ORDER BY EmployeeID DESC
END
GO

---- GET EMPLOYEE --- DONE
CREATE PROC USP_Get_Employee
AS 
	SELECT PersonalInfor.*, Status 
	FROM Employee INNER JOIN PersonalInfor ON Employee.EmployeeID = PersonalInfor.PersonID 
GO

---- GET EMPLOYEE IN SERVICE --- DONE
CREATE PROC USP_Get_Employee_Service
AS
BEGIN
	SELECT EmployeeID 
	FROM dbo.Employee
	WHERE Status = N'Đang rảnh'
END
GO

---- SEARCH Employee ---- DONE
CREATE PROC USP_Search_Employee
(@nameCol VARCHAR(50), @value NVARCHAR(50))
AS
IF(@nameCol = 'EmployeeID')
	BEGIN
		SELECT PersonalInfor.*, Status 
		FROM Employee INNER JOIN PersonalInfor ON Employee.EmployeeID = PersonalInfor.PersonID 
		WHERE EmployeeID LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol = 'Name')
	BEGIN
		SELECT PersonalInfor.*, Status 
		FROM Employee INNER JOIN PersonalInfor ON Employee.EmployeeID = PersonalInfor.PersonID 
		WHERE Name LIKE N'%' + @value + '%' 
	END
ELSE IF(@nameCol = 'IDCard')
	BEGIN
		SELECT PersonalInfor.*, Status 
		FROM Employee INNER JOIN PersonalInfor ON Employee.EmployeeID = PersonalInfor.PersonID 
		WHERE IDCard LIKE '%' + @value + '%' 
	END
ELSE IF(@nameCol LIKE 'Phone')
	BEGIN
		SELECT PersonalInfor.*, Status 
		FROM Employee INNER JOIN PersonalInfor ON Employee.EmployeeID = PersonalInfor.PersonID 
		WHERE Phone LIKE '%' + @value + '%' 
	END
GO

---- INSERT EMPLOYEE ---- DONE
CREATE PROC USP_Insert_Employee
@PersonID VARCHAR(20),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Phone VARCHAR(15),
@Address NVARCHAR(100),
@IDCard VARCHAR(15)
AS
BEGIN
	INSERT INTO dbo.PersonalInfor VALUES(@PersonID, @Name, @Gender, @Dob, @Address, @Phone, @IDCard)
	INSERT INTO dbo.Employee VALUES(@PersonID, N'Đang rảnh')
END
GO

---- UPDATE EMPLOYEE --- DONE
CREATE PROC USP_Update_Employee
(@PersonID VARCHAR(20),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Phone VARCHAR(15),
@Address NVARCHAR(100),
@IDCard VARCHAR(15),
@Status NVARCHAR(50))
AS
BEGIN
	UPDATE PersonalInfor
	SET Name = @Name, Dob = @Dob, Gender = @Gender, IDCard = @IDCard, Phone = @Phone, Address = @Address
	WHERE PersonID = @PersonID

	UPDATE Employee
	SET Status = @Status
	WHERE EmployeeID = @PersonID
END
GO

---- UPDATE STATUS EMPLOYEE ---- DONE
CREATE PROC USP_Update_Status_Employee
@EmployeeID NVARCHAR(20)
AS
BEGIN
	UPDATE dbo.Employee
	SET Status = N'Đang bận'
	WHERE EmployeeID = @EmployeeID
END
GO

---- GET LAST ID CUSTOMER --- DONE
CREATE PROC USP_Get_LastCustomerID
AS
BEGIN
	SELECT TOP(1) CustomerID 
	FROM dbo.Customer
	ORDER BY CustomerID DESC
END
GO
---- GET CUSTOMER----  DONE
CREATE PROC USP_Get_Customer
AS 
	SELECT  PersonalInfor.*
	FROM Customer INNER JOIN PersonalInfor ON Customer.CustomerID = PersonalInfor.PersonID
GO

---- GET CUSTOMER IN SERVICE ---- DONE
CREATE PROC USP_Get_Customer_Service 
AS
BEGIN
	SELECT PersonID, Name, Phone
    FROM PersonalInfor, Booking
    WHERE Booking.CustomerID = PersonalInfor.PersonID
END
GO

---- GET CUSTOMER IN BOOKING ---- DONE
CREATE PROC USP_Get_Customer_Booking 
AS
BEGIN
	SELECT PersonID, Name, Phone 
	FROM PersonalInfor, (SELECT CustomerID FROM Customer 
				 		 EXCEPT 
				 		 SELECT CustomerID FROM Booking) AS Customer_New 
	WHERE PersonalInfor.PersonID = Customer_New.CustomerID
END
GO
---- SEARCH CUSTOMER --- DONE
CREATE PROC USP_Search_Customer
(@nameCol VARCHAR(50), @value NVARCHAR(50))
AS
IF(@nameCol = 'CustomerID')
	BEGIN
		SELECT PersonalInfor.* 
		FROM Customer JOIN PersonalInfor ON Customer.CustomerID = PersonalInfor.PersonID
		WHERE Customer.CustomerID LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol = 'Name')
	BEGIN
		SELECT PersonalInfor.* 
		FROM Customer JOIN PersonalInfor ON Customer.CustomerID = PersonalInfor.PersonID
		WHERE Name LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol = 'IDCard')
	BEGIN
		SELECT PersonalInfor.* 
		FROM Customer JOIN PersonalInfor ON Customer.CustomerID = PersonalInfor.PersonID
		WHERE IDCard LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Phone')
	BEGIN
		SELECT PersonalInfor.* 
		FROM Customer JOIN PersonalInfor ON Customer.CustomerID = PersonalInfor.PersonID
		WHERE Phone LIKE '%' + @value + '%'
	END
GO

---- SEARCH CUSTOMER IN ServiceInvoice CHECK-OUT --- DONE
CREATE PROC USP_Search_Customer_ServiceInvoice_CheckOut
@CustomerID VARCHAR(20)
AS
BEGIN
	SELECT Service_Invoice_Code, CustomerID,  Date_Created, Total 
    FROM ServiceInvoice 
    WHERE CustomerID LIKE N'%' + @CustomerID + '%'
END
GO

---- SEARCH CUSTOMER IN BOOKING CHECK-OUT --- DONE
CREATE PROC USP_Search_Customer_Booking_CheckOut
@CustomerID VARCHAR(20)
AS
BEGIN
	SELECT B.BookingID, B.CustomerID, B.RoomID,  R.Price, B.Arrival
    FROM Booking AS B, Room AS R
    WHERE B.RoomID = R.RoomID and B.CustomerID LIKE N'%' + @CustomerID + '%'
END
GO

---- INSERT CUSTOMER --- DONE
CREATE PROC USP_Insert_Customer
(@PersonID VARCHAR(20),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(15),
@IDCard VARCHAR(15))
AS
BEGIN
	INSERT INTO dbo.PersonalInfor VALUES(@PersonID, @Name, @Gender, @Dob, @Address, @Phone, @IDCard)
	INSERT INTO dbo.Customer VALUES(@PersonID)
END
GO

---- UPDATE CUSTOMER --- DONE
CREATE PROC USP_Update_Customer
(@PersonID VARCHAR(20),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(15),
@IDCard VARCHAR(15))
AS
BEGIN
	UPDATE PersonalInfor
	SET Name = @Name, Dob = @Dob, Gender = @Gender, IDCard = @IDCard, Phone = @Phone, Address = @Address
	WHERE PersonID = @PersonID
END
GO

---- DELETE PERSON --- DONE
CREATE PROC USP_Delete_Person
(@PersonID VARCHAR(20))
AS
BEGIN
	DELETE FROM PersonalInfor
	WHERE PersonID = @PersonID
END
GO

---- GET LAST BOOKING --- DONE
CREATE PROC USP_Get_LastBookingID
AS
BEGIN
	SELECT TOP(1) BookingID
	FROM dbo.Booking
	ORDER BY BookingID  DESC
END	
GO

---- GET BOOKING --- DONE
CREATE PROC USP_Get_Booking
AS
BEGIN
	SELECT * FROM dbo.Booking
END
GO

---- GET BOOKING IN CHECK-OUT --- DONE
CREATE PROC USP_Get_Booking_CheckOut
AS
BEGIN
	SELECT BookingID, CustomerID, dbo.Booking.RoomID, Price, Arrival                        
    FROM Booking, Room 
    WHERE dbo.Booking.RoomID = dbo.Room.RoomID
END
GO

---- SEARCH BOOKING --- DONE
CREATE PROC USP_Search_Booking
(@BookingID VARCHAR(20))
AS
BEGIN
	SELECT * FROM Booking
    WHERE BookingID LIKE '%' + @BookingID + '%'
END
GO

---- INSERT BOOKING --- DONE
CREATE PROC USP_Insert_Booking
(@BookingID VARCHAR(20),
@ManagerID VARCHAR(20),
@CustomerID VARCHAR(20),
@RoomID VARCHAR(20),
@Arrival DATE)
AS
BEGIN
	INSERT INTO Booking VALUES(@BookingID, @ManagerID, @CustomerID, @RoomID, @Arrival)
END
GO

---- DELETE BOOKING --- DONE
CREATE PROC USP_Delete_Booking 
(@BookingID VARCHAR(20))
AS
BEGIN
	DELETE FROM Booking 
	WHERE BookingID = @BookingID
END
GO

---- GET LAST ROOM ID --- DONE
CREATE PROC USP_Get_LastRoomID
AS
BEGIN
	SELECT TOP(1) RoomID 
	FROM Room
	ORDER BY RoomID DESC
END
GO
---- GET ROOM--- DONE
CREATE PROC USP_Get_Room
AS SELECT * FROM dbo.Room
GO

---- GET ROOM IN BOOKING ---- DONE
CREATE PROC USP_Get_Room_Booking
AS
BEGIN 
	SELECT RoomID, Type, Person, Price
	FROM Room
	WHERE Status = N'Phòng trống'
END
GO

---- SEARCH ROOM --- DONE
CREATE PROC USP_Search_Room
(@nameCol VARCHAR(50), @value NVARCHAR(50))
AS
IF(@nameCol LIKE 'RoomID')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE RoomID  LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Type')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Type  LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Person')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Person  LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol LIKE 'Price')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Price  LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol = 'Status')
	BEGIN
		SELECT * FROM dbo.Room 
		WHERE Status  LIKE N'%' + @value + '%'
	END
GO

---- INSERT ROOM ---- DONE
CREATE PROC USP_Insert_Room
@RoomID VARCHAR(20),
@Type NVARCHAR(50),
@Person VARCHAR(2),
@Price INT,
@Status NVARCHAR(50),
@Description NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.Room VALUES(@RoomID, @Type, @Person, @Price, @Status, @Description)
END
GO

---- UPDATE ROOM ---- DONE
ALTER PROC USP_Update_Room
@RoomID VARCHAR(20),
@Type NVARCHAR(50),
@Person VARCHAR(2),
@Price INT,
@Status NVARCHAR(50),
@Description NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.Room
	SET Type = @Type, Person = @Person, Price = @Price, Status = @Status, Description = @Description
	WHERE RoomID = @RoomID
END
GO

---- DELETE ROOM ---- DONE
CREATE PROC USP_Delete_Room
(@RoomID VARCHAR(20))
AS
BEGIN
	DELETE FROM dbo.Room
	WHERE RoomID = @RoomID
END
GO

---- GET SERVICE --- DONE
CREATE PROC USP_Get_Service
AS SELECT * FROM Service
GO

--- GET SELECTED SERVICE --- DONE
CREATE PROC USP_Get_SelectedService
(@SIC NVARCHAR(20))
AS
BEGIN
	SELECT No ,SS.Service_Code, Quantity, Price, (Price * Quantity) Total
	FROM SelectedService SS INNER JOIN Service S ON SS.Service_Code = S.Service_Code 
	WHERE SS.Service_Invoice_Code = @SIC
END
GO

--- GET SERVICE INVOICE IN SERVICE --- DONE
CREATE PROC USP_Get_ServiceInvoice
AS 
	SELECT  SI.Service_Invoice_Code, SI.CustomerID, SI.ManagerID, SI.EmployeeID, SI.Date_Created, SI.Total
	FROM ServiceInvoice SI
go

---- GET LAST SERVICE INVOICE --- DONE
CREATE PROC USP_Get_LastServiceInvoice
AS
BEGIN
	SELECT TOP(1) Service_Invoice_Code 
	FROM dbo.ServiceInvoice
	ORDER BY Service_Invoice_Code DESC
END
GO

---- INSERT SELECTED SERVICE --- DONE
CREATE PROC USP_Insert_SelectedService
@No INT,
@Service_Invoice_Code NVARCHAR(20),
@Service_Code NVARCHAR(20),
@Quantity INT
AS
BEGIN
	INSERT INTO dbo.SelectedService
	VALUES (@No, @Service_Invoice_Code, @Service_Code, @Quantity)
END
GO

---- DELETE SELECTED SERVICE --- DONE
CREATE PROC USP_Delete_SelectedService
(@No INT)
AS
BEGIN
	DELETE FROM dbo.SelectedService
	WHERE No = @No
END
GO

---- UPDATE NO --- DONE
CREATE PROC USP_Update_No
(@No INT)
AS
BEGIN
	UPDATE dbo.SelectedService
	SET No = @No
    WHERE No = @No + 1
END
GO

---- INSERT SERVICE INVOICE ---- DONE
CREATE PROC USP_Insert_ServiceInvoice
(@Service_Invoice_Code NVARCHAR(20),
@CustomerID VARCHAR(20),
@ManagerID VARCHAR(20),
@EmployeeID VARCHAR(20),
@DateCreated DATE,
@Total INT,
@Status NVARCHAR(50))
AS
BEGIN
	INSERT INTO dbo.ServiceInvoice VALUES(@Service_Invoice_Code, @CustomerID, @ManagerID, @EmployeeID, @DateCreated, @Total, @Status)
END
GO

---- UPDATE SERVICE INVOICE --- DONE
CREATE PROC USP_Update_ServiceInvoice
(@SIC VARCHAR(20), @EmployeeID varchar(20))
AS
BEGIN 
	UPDATE dbo.ServiceInvoice 
    SET Total = SS.Total, Status = N'Chưa thanh toán' 
    FROM dbo.ServiceInvoice AS SI INNER JOIN(SELECT Service_Invoice_Code, Sum(Price* Quantity) as Total 
											 FROM dbo.SelectedService, Service
											 WHERE Service_Invoice_Code = @SIC and Service.Service_Code = SelectedService.Service_Code
											 GROUP BY Service_Invoice_Code) as SS 
								  ON SI.Service_Invoice_Code = SS.Service_Invoice_Code
	BEGIN TRAN 
	UPDATE dbo.Employee
	SET Status = N'Đang bận'
	WHERE EmployeeID = @EmployeeID

	DECLARE @Total1 int
	SELECT @Total1 = Total FROM dbo.ServiceInvoice WHERE Service_Invoice_Code = @SIC
	IF (@Total1 = 0)
		BEGIN
			ROLLBACK TRAN
			DELETE FROM  dbo.ServiceInvoice WHERE Service_Invoice_Code = @SIC
		END
	ELSE COMMIT TRAN
END
GO

SELECT * FROM SelectedService
SELECT * FROM ServiceInvoice


---- DELETE SERVICE INVOICE --- DONE
CREATE PROC USP_Delete_ServiceInvoice
(@SIC NVARCHAR(20))
AS
BEGIN
	DECLARE @Total1 int
	SELECT @Total1 = Total FROM dbo.ServiceInvoice WHERE Service_Invoice_Code = @SIC
	IF (@Total1 = 0 or @Total1 = null)
		BEGIN
			DELETE FROM  dbo.ServiceInvoice WHERE Service_Invoice_Code = @SIC
		END
END
GO

---- GET SERVICE INVOICE IN CHECKOUT --- DONE
CREATE PROC USP_Get_ServiceInvoice_CheckOut
AS
BEGIN
	SELECT Service_Invoice_Code, CustomerID, Date_Created, Total
    FROM ServiceInvoice  
    WHERE Status = N'Chưa thanh toán'
END
GO

--- INSERT BOOKING REPORT ---- DONE
CREATE PROC USP_Insert_BookingReport
(@RoomID NVARCHAR(20),
@Date_Create date,
@Date_Pay date,
@Total int)
AS
BEGIN
	DECLARE @Type nvarchar(50)
	SELECT @Type = Type FROM Room WHERE RoomID = @RoomID

	INSERT INTO BookingReport
	VALUES(@RoomID, @Type, @Date_Create, @Date_Pay, @Total)
END
GO
--- INSERT SERVICE REPORT --- DONE
create PROC USP_Insert_ServiceReport
(@SIC NVARCHAR(20))
AS
BEGIN
	INSERT INTO ServiceReport
	SELECT * FROM (SELECT S.Service_Name, s.Unit, SI.Date_Created, SS.Quantity, S.Price
					FROM ((SelectedService SS
					INNER JOIN ServiceInvoice SI ON SS.Service_Invoice_Code = SI.Service_Invoice_Code )
					INNER JOIN Service S ON  SS.Service_Code = S.Service_Code)
					WHERE SI.Service_Invoice_Code = @SIC) AS S
END
GO
---- UPDATE PERSONALINFO --- DONE
CREATE PROC USP_Update_PersonalInfo
(@PersonID VARCHAR(20),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(1000),
@Phone VARCHAR(15),
@IDCard VARCHAR(15))
AS
BEGIN
	UPDATE PersonalInfor 
	SET Name = @Name, Gender = @Gender, Dob = @Dob, Address = @Address, Phone = @Phone,  IDCard = @IDCard
	WHERE PersonID = @PersonID
END
GO

---- UPDATE PASSWORD --- DONE
CREATE PROC USP_Update_Password
(@Username VARCHAR(20),
@Password VARCHAR(15))
AS
BEGIN
    UPDATE Account 
	SET Password = @Password 
	WHERE Username = @Username
END
GO

-- UPDATE PASSWORD BY EMAIL --- DONE
CREATE PROC USP_Update_Password_Mail
(@Password NVARCHAR(15),
@Email NVARCHAR(50))
AS
BEGIN
	UPDATE Account 
	SET Password = @Password
	WHERE Email = @Email
END
GO

---- UPDATE ROOM STATUS  --- DONE
CREATE PROC USP_Update_Status_Room
(@RoomID NVARCHAR(20),
@Status NVARCHAR(50))
AS
BEGIN
	UPDATE Room
	SET Status = @Status 
	WHERE RoomID = @RoomID 
END
GO

---- SEARCH CUSTOMER IN SERVICE --- DONE
CREATE PROC USP_Search_Customer_Service
@Name NVARCHAR(50)
AS
BEGIN 
	SELECT  CustomerID, Name, Phone
	FROM Customer INNER JOIN PersonalInfor ON Customer.CustomerID = PersonalInfor.PersonID
	WHERE Name LIKE N'%' + @Name + '%'
END
GO

--- GET STATUS EMPLOYEE IN SERVICE --- DONE
CREATE PROC USP_Get_Status_Employee
@EmployeeID nvarchar(15)
AS
BEGIN
	SELECT Status FROM Employee
	WHERE EmployeeID = @EmployeeID
END
GO

--- GET BOOKING REPORT
CREATE  PROC USP_Get_BookingReport
(@DateFrom date,
@DateTo date)
AS
BEGIN
	SELECT * FROM BookingReport
	WHERE Date_Create >= @DateFrom AND Date_Pay <= @DateTo
END
GO
--- GET SERVICE REPORT --- DONE
CREATE PROC USP_Get_ServiceReport
(@DateFrom date,
@DateTo date)
AS
BEGIN
	SELECT * FROM ServiceReport
	WHERE Date_Create >= @DateFrom AND Date_Create <= @DateTo
END
GO

--- GET AUTHORITY --- DONE
CREATE PROC USP_Get_Authority
@Username NVARCHAR(20)
AS
BEGIN
	Select Authority
	FROM Account
	WHERE Username = @Username
END
GO

---- GET CUSTOMERID IN SERVICE
CREATE PROC USP_Get_CustomerID_Booking
(@CustomerID NVARCHAR(15))
AS
	SELECT CustomerID FROM (SELECT CustomerID FROM Customer 
							EXCEPT 
							SELECT CustomerID FROM Booking) S
	WHERE CustomerID = @CustomerID
GO

CREATE PROC USP_Get_CustomerID 
@CustomerID NVARCHAR(15)
AS
	SELECT CustomerID FROM Booking
	WHERE CustomerID = @CustomerID
GO

---- SEARCH GET LIST ACCOUNT
CREATE PROC USP_Get_ListAccount
as
begin
	SELECT Name, Username, Email, Phone, Authority
	FROM PersonalInfor, Account
	WHERE PersonalInfor.PersonID = Account.Username
end
GO

---- SEARCH ACCOUNT
CREATE PROC USP_Search_Account
(@nameCol VARCHAR(50), @value NVARCHAR(50))
AS
IF(@nameCol = 'Name')
	BEGIN
		SELECT Name, Username, Email, Phone, Authority
		FROM PersonalInfor JOIN Account ON Account.Username = PersonalInfor.PersonID
		WHERE Name LIKE N'%' + @value + '%'
	END
ELSE IF(@nameCol = 'Phone')
	BEGIN
		SELECT Name, Username, Email, Phone, Authority
		FROM PersonalInfor JOIN Account ON Account.Username = PersonalInfor.PersonID
		WHERE Phone LIKE '%' + @value + '%'
	END
ELSE IF(@nameCol = 'Authority')
	BEGIN
		SELECT Name, Username, Email, Phone, Authority
		FROM PersonalInfor JOIN Account ON Account.Username = PersonalInfor.PersonID
		WHERE Authority LIKE N'%' + @value + '%'
	END
GO
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
-----------------------------------------------------------------------------------
--select * from Account


CREATE PROC USP_Insert_Images_Room
(@RoomID varchar(20),
@Path  VARCHAR (255))
as
begin
		INSERT INTO dbo.Images
		VALUES(@RoomID, @Path)
end
GO


create PROC USP_Get_Path
@RoomID varchar(20)
as
begin
	select Path from Images
	WHERE RoomID = @RoomID
end
GO


create PROC USP_Get_Detail_Room
(@RoomID varchar(15))
AS
BEGIN
	Select D.*
	FROM DetailRoom DR INNER JOIN Detail D ON DR.DetailID = D.DetailID
	WHERE RoomID = @RoomID
	ORDER BY DetailID
END

--




create PROC USP_Update_Description_Room
(@RoomID varchar(15),
@Bed nvarchar(30))
AS
BEGIN
	UPDATE Room
	SET Description = @Bed
	WHERE RoomID = @RoomID
END

SELECT Room.*
FROM Room, (SELECT RoomID
			FROM (SELECT * FROM DetailRoom WHERE DetailID = 'DT001' OR DetailID = 'DT002') AS A
			GROUP BY RoomID 
			HAVING COUNT(DetailID) = 3) B
WHERE Room.RoomID = B.RoomID

INSERT INTO Detail VALUES('DT001', N'Hai giường đơn')
INSERT INTO Detail VALUES('DT002', N'Giường đôi')
INSERT INTO Detail VALUES('DT003', N'Hướng ra biển')
INSERT INTO Detail VALUES('DT004', N'Hướng ra phố')
INSERT INTO Detail VALUES('DT005', N'Bồn tắm')
INSERT INTO Detail VALUES('DT006', N'Hồ bơi riêng')
INSERT INTO Detail VALUES('DT007', N'Ban công')
INSERT INTO Detail VALUES('DT008', N'Máy pha cafe')
INSERT INTO Detail VALUES('DT009', N'Hệ thống sưởi')

SELECT * FROM Detail
SELECT * FROM DetailRoom
SELECT * FROM Images

INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT001', 'P101')	
INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT003', 'P101')	
INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT004', 'P101')	
INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT005', 'P101')

CREATE PROC USP_Insert_DetailRoom
(@DetailID varchar(20),
@RoomID varchar(20))
AS
BEGIN
	INSERT INTO DetailRoom VALUES(@DetailID, @RoomID)	
END
GO

INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT002', 'P102')	
INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT003', 'P102')	
INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT004', 'P102')	
INSERT INTO DetailRoom(DetailID, RoomID) VALUES('DT006', 'P102')

SELECT * FROM Account
SELECT * FROM Room
UPDATE Account
SET Authority = N'Quản lý'
WHERE Username = 'ql01'

CREATE PROC USP_Get_Type_Room
@RoomID nvarchar(50)
AS
BEGIN
	Select Type
	From Room
	where RoomID = @RoomID
END
GO

CREATE PROC USP_Get_Person_Room
@RoomID varchar(20)
AS
BEGIN
	Select Person
	From Room
	where RoomID = @RoomID
END
GO


USP_Get_Person_Room 'P101'
select * from Detail
select * from DetailRoom
select * from Room


SELECT Room.* 
FROM Room, (SELECT RoomID FROM (SELECT * FROM DetailRoom WHERE DetailID = 'DT005') AS A
			GROUP BY RoomID
            HAVING COUNT(DetailID) = 1) B 
WHERE Room.RoomID = B.RoomID AND (Type = 'Standard' OR Room.Type = '') AND Room.Person = '2'

SELECT * 
FROM DetailRoom
WHERE RoomID = 'P101'
ORDER BY DetailID

CREATE PROC USP_Delete_DetailRoom 
@RoomID varchar(20)
AS
BEGIN
	DELETE FROM DetailRoom
	WHERE RoomID = @RoomID
END
GO

SELECT * FROM ServiceReport
SELECT * FROM BookingReport

---------

CREATE PROC USP_Chart_Type_Room
@date DATE
AS
BEGIN
	DECLARE @start_date DATE = DATEFROMPARTS(YEAR(@date), MONTH(@date), '01');
	DECLARE @end_date DATE = EOMONTH(@date);

	SELECT Type, SUM(Total) AS Total From BookingReport
	WHERE Date_Pay > @start_date and Date_Pay < @end_date
	GROUP BY Type
END
GO

-- USP_Chart_Type_Room '2022-11-27'

CREATE TABLE BookingChart
(
	Month int,
	Total int,
)
GO

CREATE PROC USP_Booking_Chart
@year int
AS
BEGIN
	DELETE FROM BookingChart

	DECLARE @start_date DATE = DATEFROMPARTS(@year, 01, 01);
	DECLARE @end_date DATE = DATEFROMPARTS(@year, 12, 31);;

	WHILE @start_date <= @end_date
	BEGIN 
		INSERT INTO BookingChart
		SELECT DATEPART(month, @start_date), Sum(Total) T
		FROM BookingReport
		WHERE DATEPART(year, Date_Pay) = @year AND DATEPART(month, Date_Pay) = DATEPART(month, @start_date)
		SET @start_date = DATEADD(month, 1, @start_date)
	END

	UPDATE BookingChart
	SET Total = 0
	WHERE Total IS NULL

	SELECT * FROM BookingChart

END
GO
	
-- USP_Booking_Chart 2021
----------------
CREATE TABLE ServiceChart
(
	Month int,
	Total int,
)
GO

CREATE PROC USP_Service_Chart
@year int
AS
BEGIN
	DELETE FROM ServiceChart

	DECLARE @start_date DATE = DATEFROMPARTS(@year, 01, 01);
	DECLARE @end_date DATE = DATEFROMPARTS(@year, 12, 31);;

	WHILE @start_date <= @end_date
	BEGIN 
		INSERT INTO ServiceChart
		SELECT DATEPART(month, @start_date), Sum(Total) T
		FROM ServiceReport
		WHERE DATEPART(year, Date_Create) = @year AND DATEPART(month, Date_Create) = DATEPART(month, @start_date)
		SET @start_date = DATEADD(month, 1, @start_date)
	END

	UPDATE ServiceChart
	SET Total = 0
	WHERE Total IS NULL

	SELECT * FROM ServiceChart

END
GO
	
CREATE PROC USP_Chart_Type_Service
@date DATE
AS
BEGIN
	DECLARE @start_date DATE = DATEFROMPARTS(YEAR(@date), MONTH(@date), '01');
	DECLARE @end_date DATE = EOMONTH(@date);

	SELECT Type, SUM(Total) AS Total From ServiceReport
	WHERE Date_Create > @start_date and Date_Create  < @end_date
	GROUP BY Type
END
GO


