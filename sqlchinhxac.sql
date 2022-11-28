----------------CREATE----------------
DROP DATABASE QLKS1
GO

CREATE DATABASE QLKS1
GO

USE QLKS1
GO

CREATE TABLE PersonalInfor
(
	PersonID varchar(10) PRIMARY KEY,
	Name nvarchar(50) not null,
	Gender nvarchar(5) not null,
	Dob date not null,
	Address nvarchar(100) not null,
	Phone varchar(11) not null,
	IDCard varchar(9) not null,
)
GO

CREATE TABLE Account
(
	Username varchar(10) PRIMARY KEY,
	Password varchar(11) not null,
	Email varchar(50) not null,
	Authority nvarchar(10) not null,
	Avatar IMAGE,
	CONSTRAINT FK_Account FOREIGN KEY (Username) REFERENCES PersonalInfor(PersonID) ON DELETE CASCADE
)	
GO

CREATE TABLE Customer
(
	CustomerID varchar(10) PRIMARY KEY,
	CONSTRAINT FK_Customer FOREIGN KEY(CustomerID) REFERENCES PersonalInfor(PersonID) ON DELETE CASCADE
)
GO

CREATE TABLE Room
(
	RoomID varchar(10) PRIMARY KEY,
	Type nvarchar(15) not null,
	Person varchar(2) not null,
	Price int not null,
	Status nvarchar(50) not null,
)
GO


CREATE TABLE Service
(
	Service_Code varchar(10) PRIMARY KEY,
	Service_Name nvarchar(30) not null,
	Type nvarchar(30) not null,
	Price int not null,
)
GO

CREATE TABLE ServiceInvoice
(
	Service_Invoice_Code varchar(10) PRIMARY KEY,
	CustomerID varchar(10) FOREIGN KEY REFERENCES Customer(CustomerID),
	ManagerID varchar(10) FOREIGN KEY REFERENCES Account(Username),
	RoomID varchar(10) FOREIGN KEY REFERENCES Room(RoomID),
	Date_Created date not null,
	Total int not null,
	Status nvarchar(20) not null,
)
GO

CREATE TABLE Booking
(
	BookingID varchar(10) PRIMARY KEY,
	ManagerID varchar(10) FOREIGN KEY REFERENCES Account(Username),
	CustomerID varchar(10) FOREIGN KEY REFERENCES Customer(CustomerID),
	RoomID varchar(10) FOREIGN KEY REFERENCES Room(RoomID),
	Arrival date not null,
)
GO


CREATE TABLE SelectedService
(	
	No INT,
	Service_Invoice_Code varchar(10) FOREIGN KEY REFERENCES ServiceInvoice(Service_Invoice_Code) ON DELETE CASCADE,
	Service_Code varchar(10) FOREIGN KEY REFERENCES Service(Service_Code),
	Quantity int not null, 
)
GO


CREATE TABLE BookingReport
(
	RoomID VARCHAR(10),
	Type NVARCHAR(15),
	Date_Create date,
	Date_Pay date,
	Total int
)
GO

CREATE TABLE ServiceReport
(
	Service_Name nvarchar(30),
	Type nvarchar(30),
	Date_Create date,
	Quantity int,
	Price int,
	Total AS Quantity * Price
)
GO


CREATE TABLE Detail
(
	DetailID varchar(10) Primary Key,
	Detail nvarchar(50),
)
go
create Table DetailRoom
(
	DetailID varchar(10) FOREIGN KEY REFERENCES Detail(DetailID),
	RoomID  varchar(10) FOREIGN KEY REFERENCES Room(RoomID) ON DELETE CASCADE,
)
go
CREATE TABLE Images
(
	RoomID varchar(10) FOREIGN KEY REFERENCES Room(RoomID) ON DELETE CASCADE,
	Path varchar(255),
)
go

CREATE TABLE BookingChart
(
	Month int,
	Total int,
)
GO

CREATE TABLE ServiceChart
(
	Month int,
	Total int,
)
GO

----------------INSERT---------------

------- ROOM -------
delete from Room
INSERT INTO Room VALUES('P101', 'Standard', 2, 300000, N'Phòng trống')
INSERT INTO Room VALUES('P102', 'Standard', 2, 300000, N'Phòng trống')
INSERT INTO Room VALUES('P103', 'Standard', 2, 300000, N'Phòng trống')
INSERT INTO Room VALUES('P104', 'Standard', 2, 300000, N'Phòng trống')
INSERT INTO Room VALUES('P201', 'Superior', 4, 400000, N'Phòng trống')
INSERT INTO Room VALUES('P202', 'Superior', 4, 400000, N'Phòng trống')
INSERT INTO Room VALUES('P203', 'Superior', 4, 400000, N'Phòng trống')
INSERT INTO Room VALUES('P204', 'Superior', 4, 400000, N'Phòng trống')
INSERT INTO Room VALUES('P301', 'Deluxe', 4, 500000, N'Phòng trống')
INSERT INTO Room VALUES('P302', 'Deluxe', 4, 500000, N'Phòng trống')
INSERT INTO Room VALUES('P303', 'Deluxe', 4, 500000, N'Phòng trống')
INSERT INTO Room VALUES('P304', 'Deluxe', 4, 500000, N'Phòng trống')
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
(@Username varchar(10))
AS 
BEGIN
	 SELECT Account.*, PersonalInfor.*
	 FROM Account Left JOIN PersonalInfor ON Account.Username = PersonalInfor.PersonID
     WHERE Username = @Username
END
GO

---- GET PASSWORD ----DONE
CREATE PROC USP_Get_Password
(@Username VARCHAR(10))
AS
BEGIN
	SELECT Password
	FROM Account
	WHERE Username = @Username
END
GO

---- SEARCH EMAIL ----DONE
CREATE PROC USP_Search_Email
(@Email VARCHAR(50))
AS
BEGIN
	SELECT Email
	FROM Account
	Where Email = @Email
END
GO

----  LOGIN ----DONE
CREATE PROCEDURE USP_Login_Account
(@Username varchar(10), @Password varchar(11))
AS 
BEGIN
     SELECT * FROM dbo.Account
	 WHERE Username = @Username and Password = @Password
END
GO

---- FORGOT  ----DONE
CREATE PROCEDURE USP_Forgot_Account
(@Email varchar(50), 
@Username  VARCHAR(10))
AS 
BEGIN
     SELECT * FROM Account 
	 WHERE Email = @Email AND Username = @Username
END
GO

---- INSERT	 ----DONE
CREATE PROC USP_Insert_Account
(@PersonalID VARCHAR(10),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(11),
@IDCard VARCHAR(9),
@Password VARCHAR(11), 
@Email VARCHAR(50), 
@Authority NVARCHAR(10),
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
--USP_Insert_Account 'ql01', N'Tốt Nguyễn', 'Nam', '11/09/2002', 'Nha Trang', '0824520365', '225957006', '1', 'totnv02@gmail.com', N'Quản lý', '0x00'

---- UPDATE IMAGE ---- DONE
CREATE PROC USP_Update_Image
(@Username varchar(10),
@Avatar image)
AS
BEGIN
	UPDATE Account 
	SET Avatar = @Avatar
	WHERE Username = @Username
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
	SELECT PersonID, Name, RoomID
    FROM PersonalInfor, Booking
    WHERE Booking.CustomerID = PersonalInfor.PersonID
END
GO

--- GET ROOM IN SERVICE --- DONE
CREATE PROC USP_Get_Room_Service
@CustomerID varchar(10)
AS
BEGIN
	Select RoomID
	FROM Booking
	WHERE CustomerID = @CustomerID 
END
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
CREATE PROC USP_Search_Room_ServiceInvoice_CheckOut
@RoomID VARCHAR(10)
AS
BEGIN
	SELECT Service_Invoice_Code, RoomID,  Date_Created, Total 
    FROM ServiceInvoice 
    WHERE RoomID LIKE '%' + @RoomID + '%'
END
GO

---- SEARCH CUSTOMER IN BOOKING CHECK-OUT --- DONE
CREATE  PROC USP_Search_Room_Booking_CheckOut
@RoomID VARCHAR(10)
AS
BEGIN
	SELECT B.BookingID, B.CustomerID, B.RoomID,  R.Price, B.Arrival
    FROM Booking AS B, Room AS R
    WHERE B.RoomID = R.RoomID and B.RoomID LIKE '%' + @RoomID + '%'
END
GO

---- INSERT CUSTOMER --- DONE
CREATE PROC USP_Insert_Customer
(@PersonID VARCHAR(10),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(11),
@IDCard VARCHAR(9))
AS
BEGIN
	INSERT INTO dbo.PersonalInfor VALUES(@PersonID, @Name, @Gender, @Dob, @Address, @Phone, @IDCard)
	INSERT INTO dbo.Customer VALUES(@PersonID)
END
GO

---- UPDATE CUSTOMER --- DONE
CREATE PROC USP_Update_Customer
(@PersonID VARCHAR(10),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(11),
@IDCard VARCHAR(9))
AS
BEGIN
	UPDATE PersonalInfor
	SET Name = @Name, Dob = @Dob, Gender = @Gender, IDCard = @IDCard, Phone = @Phone, Address = @Address
	WHERE PersonID = @PersonID
END
GO

---- DELETE PERSON --- DONE
CREATE PROC USP_Delete_Person
(@PersonID VARCHAR(10))
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
create PROC USP_Get_Booking_CheckOut
AS
BEGIN
	SELECT BookingID, CustomerID, Booking.RoomID, Price, Arrival                        
    FROM Booking, Room 
    WHERE dbo.Booking.RoomID = dbo.Room.RoomID
END
GO

---- SEARCH BOOKING --- DONE
CREATE PROC USP_Search_Booking
(@BookingID VARCHAR(10))
AS
BEGIN
	SELECT * FROM Booking
    WHERE BookingID LIKE '%' + @BookingID + '%'
END
GO

---- INSERT BOOKING --- DONE
CREATE PROC USP_Insert_Booking
(@BookingID VARCHAR(10),
@ManagerID VARCHAR(10),
@CustomerID VARCHAR(10),
@RoomID VARCHAR(10),
@Arrival DATE)
AS
BEGIN
	INSERT INTO Booking VALUES(@BookingID, @ManagerID, @CustomerID, @RoomID, @Arrival)
END
GO


---- DELETE BOOKING --- DONE
CREATE PROC USP_Delete_Booking 
(@BookingID VARCHAR(10))
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


---- SEARCH ROOM --- DONE
CREATE PROC USP_Search_Room 'Person', 2
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
SELECT * FROM Images
---- INSERT ROOM ---- DONE
CREATE PROC USP_Insert_Room
(@RoomID VARCHAR(10),
@Type NVARCHAR(15),
@Person VARCHAR(2),
@Price INT,
@Status NVARCHAR(50))
AS
BEGIN
	INSERT INTO dbo.Room VALUES(@RoomID, @Type, @Person, @Price, @Status)
END
GO

---- UPDATE ROOM ---- DONE
CREATE PROC USP_Update_Room
(@RoomID VARCHAR(10),
@Type NVARCHAR(15),
@Person VARCHAR(2),
@Price INT,
@Status NVARCHAR(50))
AS
BEGIN
	UPDATE dbo.Room
	SET Type = @Type, Person = @Person, Price = @Price, Status = @Status
	WHERE RoomID = @RoomID
END
GO

---- DELETE ROOM ---- DONE
CREATE PROC USP_Delete_Room
(@RoomID VARCHAR(10))
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
	SELECT  SI.Service_Invoice_Code, SI.CustomerID, SI.ManagerID, SI.RoomID, SI.Date_Created, SI.Total
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
@Service_Invoice_Code VARCHAR(10),
@Service_Code VARCHAR(10),
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
(@Service_Invoice_Code VARCHAR(10),
@CustomerID VARCHAR(10),
@ManagerID VARCHAR(10),
@RoomID VARCHAR(10),
@DateCreated DATE,
@Total INT,
@Status NVARCHAR(50))
AS
BEGIN
	INSERT INTO dbo.ServiceInvoice VALUES(@Service_Invoice_Code, @CustomerID, @ManagerID, @RoomID, @DateCreated, @Total, @Status)
END
GO

---- UPDATE SERVICE INVOICE --- DONE
CREATE PROC USP_Update_ServiceInvoice
(@SIC VARCHAR(10))
AS
BEGIN 
	UPDATE dbo.ServiceInvoice 
    SET Total = SS.Total, Status = N'Chưa thanh toán' 
    FROM dbo.ServiceInvoice AS SI INNER JOIN(SELECT Service_Invoice_Code, Sum(Price* Quantity) as Total 
											 FROM dbo.SelectedService, Service
											 WHERE Service_Invoice_Code = @SIC and Service.Service_Code = SelectedService.Service_Code
											 GROUP BY Service_Invoice_Code) as SS 
								  ON SI.Service_Invoice_Code = SS.Service_Invoice_Code

	DECLARE @Total1 int
	SELECT @Total1 = Total FROM dbo.ServiceInvoice WHERE Service_Invoice_Code = @SIC

	IF (@Total1 = 0 or @Total1 = null)
		BEGIN
			DELETE FROM  dbo.ServiceInvoice WHERE Service_Invoice_Code = @SIC
		END
END
GO

--- GET Total ServiceInvoice IN CHECKOUT
CREATE PROC USP_Get_Total_ServiceInvoice
@RoomID varchar(10)
AS
BEGIN
	SELECT Sum(Total)
	FROM ServiceInvoice
	WHERE RoomID = @RoomID
END
---- DELETE SERVICE INVOICE --- DONE
CREATE PROC USP_Delete_ServiceInvoice
(@SIC VARCHAR(10))
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
	SELECT Service_Invoice_Code, RoomID, Date_Created, Total
    FROM ServiceInvoice  
    WHERE Status = N'Chưa thanh toán'
END
GO

--- INSERT BOOKING REPORT ---- DONE
CREATE PROC USP_Insert_BookingReport
(@RoomID VARCHAR(10),
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
(@SIC VARCHAR(10))
AS
BEGIN
	INSERT INTO ServiceReport
	SELECT * FROM (SELECT S.Service_Name, s.Type, SI.Date_Created, SS.Quantity, S.Price
					FROM ((SelectedService SS
					INNER JOIN ServiceInvoice SI ON SS.Service_Invoice_Code = SI.Service_Invoice_Code )
					INNER JOIN Service S ON  SS.Service_Code = S.Service_Code)
					WHERE SI.Service_Invoice_Code = @SIC) AS S
END
GO
---- UPDATE PERSONALINFO --- DONE
CREATE PROC USP_Update_PersonalInfo
(@PersonID VARCHAR(10),
@Name NVARCHAR(50),
@Gender NVARCHAR(5),
@Dob DATE,
@Address NVARCHAR(100),
@Phone VARCHAR(11),
@IDCard VARCHAR(9))
AS
BEGIN
	UPDATE PersonalInfor 
	SET Name = @Name, Gender = @Gender, Dob = @Dob, Address = @Address, Phone = @Phone,  IDCard = @IDCard
	WHERE PersonID = @PersonID
END
GO

---- UPDATE PASSWORD --- DONE
CREATE PROC USP_Update_Password
(@Username VARCHAR(10),
@Password VARCHAR(11))
AS
BEGIN
    UPDATE Account 
	SET Password = @Password 
	WHERE Username = @Username
END
GO

-- UPDATE PASSWORD BY EMAIL --- DONE
CREATE PROC USP_Update_Password_Mail
(@Password NVARCHAR(11),
@Email NVARCHAR(50))
AS
BEGIN
	UPDATE Account 
	SET Password = @Password
	WHERE Email = @Email
END
GO

--- UPDATE ROOM STATUS BOOKING
CREATE PROC USP_Update_Status_Room_Booking
(@RoomID VARCHAR(10),
@Status NVARCHAR(50))
AS
BEGIN
	UPDATE Room
	SET Status = @Status 
	WHERE RoomID = @RoomID 

END
GO

---- UPDATE ROOM STATUS  --- DONE
CREATE PROC USP_Update_Status_Room
(@RoomID VARCHAR(10),
@Status NVARCHAR(50))
AS
BEGIN
	UPDATE Room
	SET Status = @Status 
	WHERE RoomID = @RoomID 

	DELETE FROM ServiceInvoice
	WHERE RoomID = @RoomID
	
	DELETE FROM Booking
	WHERE RoomID = @RoomID
END
GO
---- SEARCH CUSTOMER IN SERVICE --- DONE
CREATE PROC USP_Search_Customer_Service
@Name NVARCHAR(50)
AS
BEGIN 
	SELECT CustomerID, Name, RoomID
	FROM PersonalInfor, Booking 
	WHERE Booking.CustomerID = PersonalInfor.PersonID AND Name LIKE N'%' + @Name + '%'
END
GO

--- GET STATUS EMPLOYEE IN SERVICE --- DONE
CREATE PROC USP_Get_Room_Customer_Service
@CustomerID varchar(10)
AS
BEGIN
	SELECT RoomID FROM Booking
	WHERE CustomerID = @CustomerID
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
@Username VARCHAR(10)
AS
BEGIN
	Select Authority
	FROM Account
	WHERE Username = @Username
END
GO

---- GET CUSTOMERID IN BOOKING ---------------------------------------->
CREATE PROC USP_Get_CustomerID_Booking
(@CustomerID VARCHAR(10))
AS
	SELECT CustomerID FROM (SELECT CustomerID FROM Customer 
							EXCEPT 
							SELECT CustomerID FROM Booking) S
	WHERE CustomerID = @CustomerID
GO

-----CHECK EXIST CUSTOMER IN SERVICE
CREATE PROC USP_Get_CustomerID 
@CustomerID VARCHAR(10)
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

---- INSERT IMAGES ROOM
CREATE PROC USP_Insert_Images_Room
(@RoomID varchar(10),
@Path  VARCHAR (255))
as
begin
	INSERT INTO dbo.Images VALUES(@RoomID, @Path)
end
GO


create PROC USP_Get_Path
@RoomID varchar(10)
as
begin
	select Path from Images
	WHERE RoomID = @RoomID
end
GO


create PROC USP_Get_Detail_Room
(@RoomID varchar(10))
AS
BEGIN
	Select D.*
	FROM DetailRoom DR INNER JOIN Detail D ON DR.DetailID = D.DetailID
	WHERE RoomID = @RoomID
	ORDER BY DetailID
END
GO

CREATE PROC USP_Insert_DetailRoom
(@DetailID varchar(10),
@RoomID varchar(10))
AS
BEGIN
	INSERT INTO DetailRoom VALUES(@DetailID, @RoomID)	
END
GO

CREATE PROC USP_Delete_DetailRoom 
@RoomID varchar(10)
AS
BEGIN
	DELETE FROM DetailRoom
	WHERE RoomID = @RoomID
END
GO


CREATE PROC USP_Get_Person_Room
@RoomID varchar(10)
AS
BEGIN
	Select Person
	From Room
	where RoomID = @RoomID
END
GO

CREATE PROC USP_Get_Type_Room
@RoomID varchar(10)
AS
BEGIN
	Select Type
	From Room
	where RoomID = @RoomID
END
GO

CREATE TABLE BookingChart
(
	Month int,
	Total int,
)
GO

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

---- 
USP_Get_LastServiceCode
---- GET LAST ID EMPLOYEE -- DONE
CREATE PROC USP_Get_LastServiceCode
AS	
BEGIN
	SELECT TOP(1) Service_Code 
	FROM dbo.Service
	ORDER BY Service_Code  DESC
END
GO


CREATE PROC USP_Insert_Service
@ServiceID varchar(10),
@NameService nvarchar(50),
@Type nvarchar(50),
@Price int
AS
BEGIN
	Insert into Service VALUES(@ServiceID, @NameService, @Type, @Price)
END
GO

CREATE PROC USP_Delete_Service
@ServiceID varchar(10)
AS
BEGIN
	DELETE FROM Service
	where Service_Code = @ServiceID
end
GO

CREATE PROC USP_Update_Service
@ServiceID varchar(10),
@NameService nvarchar(50),
@Type nvarchar(50),
@Price int
AS
BEGIN
	UPDATE Service
	Set Service_Name = @NameService , Type = @Type , Price = @Price
	WHERE Service_Code = @ServiceID
END
GO
---
CREATE PROC USP_Search_Service
(@nameCol VARCHAR(15), @value NVARCHAR(50))
AS
BEGIN
	IF(@nameCol = 'Service_Code')
		BEGIN
			SELECT * FROM Service
			WHERE Service_Code LIKE '%' + @value + '%'
		END
	ELSE IF(@nameCol = 'Service_Name')
		BEGIN
			SELECT * FROM Service 
			WHERE Service_Name LIKE N'%' + @value + '%' 
		END	
	ELSE IF(@nameCol = 'Type')
		BEGIN
			SELECT * FROM Service 
			WHERE Type LIKE N'%' + @value + '%' 
		END
END
GO

--------------------------------------------------------