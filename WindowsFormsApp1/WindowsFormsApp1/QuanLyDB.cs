using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    internal class QuanLyDB
    {
        Database db;

        public QuanLyDB()
        {
            db = new Database();
        }


        /// LOGIN
        public DataTable activeLogin(string username, string password)
        {
            string sql = "SELECT * FROM Account WHERE Username = '" + username + "' AND Password = '" + password + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable forgotLogin(string email)
        {
            string sql = "SELECT * FROM Account WHERE Email = N'" + email + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void UpdatePassword(string password, string email)
        {
            string sql = "UPDATE ACCOUNT SET Password = '" + password + "' WHERE Email = N'" + email + "'";
            db.ExecuteNonQuery(sql);
        }

        // ACCOUNT
        public DataTable GetInfoAccount(string username)
        {
            string sql = "SELECT Username, FullName, PhoneNumber, Email, Avatar " +
                         "FROM Account " +
                         "WHERE Username = '" + username  + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void UpdateInfoAccount(string fullname, string phone, string email, string newpass, string username, string path)
        {
            string sql = "UPDATE Account " +
                         "SET FullName = N'" + fullname + "', PhoneNumber = '" + phone + "', Email = '" + email + "', Password = '" + newpass + "', " +
                         "Avatar = (SELECT * FROM OPENROWSET(BULK'" + path + "', SINGLE_BLOB) AS Picture) " +
                         "WHERE Username = '" + username + "'";
            db.ExecuteNonQuery(sql);
        }

        ///////// MANAGE INFORMATION

        // CUSTOMER
        public DataTable GetAllCustomer()
        {
            string sql = "SELECT * FROM Customer";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchCustomer(string fullname) // by name
        {
            string sql = "SELECT * FROM Customer " + 
                         "WHERE FullName LIKE N'%" + fullname + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchCustomerByPhone(string phone) // by phone
        {
            string sql = "SELECT * FROM Customer " +
                         "WHERE PhoneNumber LIKE N'%" + phone + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchCustomerByIDCard(string idcard) // by id card
        {
            string sql = "SELECT * FROM Customer " +
                         "WHERE ID_Card LIKE N'%" + idcard + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchCustomerByIDCustomer(string idcus) // by id customer
        {
            string sql = "SELECT * FROM Customer " +
                         "WHERE Customer_ID LIKE N'%" + idcus + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void InsertCustomer(string customerid, string fullname, string birthdate, string gender, string idcard, string phonenumber, string address, string path)
        {
            string sql =  "INSERT INTO Customer " +
                          "SELECT '" + customerid + "', N'" + fullname + "', '" + birthdate + "', N'" + gender + "', '" + idcard + "', '" + phonenumber + "', N'" + address + "', BULKCOLUMN " + 
                          "FROM OPENROWSET(BULK'" + path + "', SINGLE_BLOB) AS Picture";
            db.ExecuteNonQuery(sql);
        }

        public void UpdateCustomer(string customerid, string fullname, string birthdate, string gender, string idcard, string phonenumber, string address, string path)
        {
            string sql = "UPDATE Customer " +
                         "SET FullName = N'" + fullname + "', BirthDate = '" + birthdate + "', Gender = N'" + gender + "', ID_Card = '" + idcard + "', PhoneNumber = '" + phonenumber + "', Address = N'" + address + "', " + 
                         "Avatar = (SELECT * FROM OPENROWSET(BULK'" + path + "', SINGLE_BLOB) as Picture) " +
                         "WHERE Customer_ID = '" + customerid + "'";
            db.ExecuteNonQuery(sql);
        }

        public void DeleteCustomer(string customerid)
        {
            string sql = "DELETE FROM Customer WHERE Customer_ID = '" + customerid + "'";
            db.ExecuteNonQuery(sql);
        }

        // EMPLOYEE
        public DataTable GetAllEmployee()
        {
            string sql = "SELECT * FROM Employee";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchEmployee(string fullname)
        {
            string sql = "SELECT * FROM Employee " +
                         "WHERE FullName LIKE N'%" + fullname + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void InsertEmployee(string employeeid, string fullname, string birthdate, string gender, string idcard, string phonenumber, string address)
        {
            string sql = "INSERT INTO Employee " +
                         "VALUES ( '" + employeeid + "', N'" + fullname + "', '" + birthdate + "', N'" + gender + "', '" + idcard + "', '" + phonenumber + "', N'" + address + "') ";
            db.ExecuteNonQuery(sql);
        }

        public void UpdateEmployee(string employeeid, string fullname, string birthdate, string gender, string idcard, string phonenumber, string address)
        {
            string sql = "UPDATE Employee " +
                         "SET FullName = N'" + fullname + "', BirthDate = '" + birthdate + "', Gender = N'" + gender + "', ID_Card = '" + idcard + "', PhoneNumber = '" + phonenumber + "', Address = N'" + address + "' " +
                         "WHERE Employee_ID = '" + employeeid + "'";
            db.ExecuteNonQuery(sql);
        }

        public void DeleteEmployee(string employeeid)
        {
            string sql = "DELETE FROM Employee WHERE Employee_ID = '" + employeeid + "'";
            db.ExecuteNonQuery(sql);
        }

        // ROOM
        public DataTable GetAllRoom()
        {
            string sql = "SELECT * FROM Room";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchRoomByStatus(string status) // by Status
        {
            string sql = "SELECT * FROM Room " +
                         "WHERE Status LIKE N'%" + status + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchRoomByRoomID(string roomid) // by Room_ID
        {
            string sql = "SELECT * FROM Room " + 
                         "WHERE Room_ID LIKE N'%" + roomid + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchRoomByType(string type) // by Type
        {
            string sql = "SELECT * FROM Room " +
                         "WHERE Type LIKE N'%" + type + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchRoomByPerson(int person) // by Person
        {
            string sql = "SELECT * FROM Room " +
                         "WHERE Person  = " + person + "";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
       
        public DataTable SearchRoomByPrice(int price) // by Price

        {
            string sql = "SELECT * FROM Room " +
                         "WHERE Price  = " + price + "";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
    
        public DataTable SearchRoomByDescription(string description) // by Description
        {
            string sql = "SELECT * FROM Room " +
                         "WHERE Description LIKE N'%" + description + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
      
        public void InsertRoom(string roomid, string type, int person, int price, string status, string description)
        {
            string sql = "INSERT INTO Room VALUE('" + roomid + "', '" + type + "', " + person + ", " + price + ", '" + price + "', '" + description + "')";
            db.ExecuteNonQuery(sql);
        }

        public void UpdateRoom(string roomid, string type, int person, int price, string status, string description)
        {
            string sql = "UPDATE Room SET Type = '" + type + "', Person = " + person + ", Price = " + price + ", Status = '" + status + "', Description = '" + description + "' WHERE Room_ID = '" + roomid + "'";
            db.ExecuteNonQuery(sql);
        }

        public void DeleteRoom(string roomid)
        {
            string sql = "DELETE FROM Room WHERE Room_ID = '" + roomid + "'";
            db.ExecuteNonQuery(sql);
        }

        ///////// FUNCTION

        // SERVICE
        public DataTable GetAllCustomer_()
        {
            string sql = "SELECT Booking.Customer_ID, Name, IDCard, Phone " +
                         "FROM Customer, Booking " +
                         "WHERE Booking.Customer_ID = Customer.Customer_ID AND Booking.Departure IS NULL ";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
        
        public DataTable GetAllServiceInvoice()
        {
            string sql = "SELECT * FROM ServiceInvoice " +
                         "WHERE ServiceInvoice.Status = 'UNPAID' ";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetAllService()
        {
            string sql = "SELECT * FROM Service";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetAllSelectedService(string sic)
        {
            string sql = "Select *, (Price * Quantity) as Total " +
                         "From SelectedService  " +
                         "Where SelectedService.Service_Invoice_Code = '" + sic + "'";
;

            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
    
        public DataTable SearchCustomer_(string fullname)
        {
            string sql = "SELECT Customer_ID, Name, ID_Card, Phone FROM Customer " +
                         "WHERE Name LIKE N'%" + fullname + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }
    
        public void InsertService(int no, string sic, string sc, int price, int quantity)
        {
            string sql = "INSERT INTO SelectedService VALUES(" + no + ", '" + sic + "', '" + sc + "', " + price + ", " + quantity + ")";
            db.ExecuteNonQuery(sql);
        }

        public void InsertServiceInvoice(string sic, string cusID, string manID, string empID, DateTime datecreated)
        {
            int total = 0;
            string status = "";
            string sql = "INSERT INTO ServiceInvoice VALUES('" + sic + "', '" + cusID + "', '" + manID + "', '" + empID + "', '" + datecreated + "',  " + total + ", '" + status + "')";
            db.ExecuteNonQuery(sql);
        }

        public void UpdateServiceInvoice(string sic)
        {
            string sql = "UPDATE ServiceInvoice " +
                         "SET Total = SS.Total, Status = 'UNPAID' " +
                         "FROM ServiceInvoice AS SI INNER JOIN(SELECT Service_Invoice_Code, Sum(Price* Quantity) as Total " +
                                                              "FROM SelectedService " +
                                                              "WHERE Service_Invoice_Code = '" + sic + "' " +
                                                              "GROUP BY Service_Invoice_Code) as SS " +
                                                    "ON SI.Service_Invoice_Code = SS.Service_Invoice_Code";
            db.ExecuteNonQuery(sql);
        }

        public void DeleteService(int no)
        {
            string sql = "DELETE FROM SelectedService WHERE No = " + no + "";
            db.ExecuteNonQuery(sql);
        }
        
        public void UpdateNo(int no)
        {
            string sql = "UPDATE SelectedService " +
                         "SET No = " + no + " " +
                         "WHERE No = " + (no + 1) + "";
            db.ExecuteNonQuery(sql);
        }
        
        // BOOKING

        public DataTable GetAllRoom_NB()
        {
            string sql = "SELECT Room_ID, Type, Person, Price, Status FROM Room " +
                         "WHERE Status = 'Free'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetAllCustomer_NB()
        {
            string sql = "SELECT Customer.Customer_ID, Name, IDCard, Phone " +
                         "FROM Customer, (SELECT Customer_ID FROM Customer " +
                                         "EXCEPT " +
                                         "SELECT Customer_ID FROM Booking) AS Customer_N " +
                         "WHERE Customer.Customer_ID = Customer_N.Customer_ID";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetAllBooking()
        {
            string sql = "SELECT * FROM Booking";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void DeleteBooking(string bookingid)
        {
            string sql = "DELETE FROM Booking WHERE Booking_ID = '" + bookingid + "'";
            db.ExecuteNonQuery(sql);
        }

        public void InsertBooking(string bookingid, string managerid, string customerid, string roomid, DateTime arrive)
        {
            string sql = "INSERT INTO Booking(Booking_ID, Manager_ID, Customer_ID, Room_ID, Arrival) " +
                         "VALUES('" + bookingid + "', '" + managerid + "', '" + customerid + "', '" + roomid + "', '" + arrive + "')";
            db.ExecuteNonQuery(sql);
        }

        public void UpdateRoom(string roomid, string status)
        {
            string sql = "UPDATE Room SET Status = '" + status + "' WHERE Room_ID = '" + roomid + "'";
            db.ExecuteNonQuery(sql);
        }

        public DataTable SearchBooking(string bookingid)
        {
            string sql = "SELECT * " +
                         "FROM Booking " +
                         "WHERE Booking_ID LIKE N'%" + bookingid + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        // CHECK - OUT

        public DataTable SearchCustomerInBooking(string idcard) // by id card
        {
            string sql = "SELECT B.Booking_ID, B.Customer_ID, B.Room_ID,  R.Price, B.Arrival, B.Departure, " +
                                "CASE DATEDIFF(day, Arrival, Departure) * Price " +
                                      "WHEN  0  THEN Price " +
                                      "ELSE DATEDIFF(day, Arrival, Departure) * Price " +
                                "END AS Total " +
                         "FROM Booking AS B, Room AS R " +
                         "WHERE B.Room_ID = R.Room_ID and B.Customer_ID LIKE N'%" + idcard + "%'"; 
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable SearchCustomerInSI(string idcard) // by id card
        {
            string sql = "SELECT SI.Service_Invoice_Code, SI.Customer_ID, SI.Date_Created, SI.Total, SI.Status " +
                         "FROM ServiceInvoice AS SI " +
                         "WHERE SI.Customer_ID LIKE N'%" + idcard + "%'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetAllListBooking()
        {
            string sql = "SELECT B.Booking_ID, B.Customer_ID, B.Room_ID, R.Price, B.Arrival, B.Departure, " +
                                "CASE DATEDIFF(day, Arrival, Departure) * Price " +
                                      "WHEN  0  THEN Price " +
                                      "ELSE DATEDIFF(day, Arrival, Departure) * Price "+
                                "END AS Total " +
                         "FROM Booking AS B, Room AS R " +
                         "WHERE B.Room_ID = R.Room_ID AND B.Departure IS NULL";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public DataTable GetAllListServiceInvoice()
        {
            string sql = "SELECT SI.Service_Invoice_Code, SI.Customer_ID, SI.Date_Created, SI.Total, SI.Status " +
                         "FROM ServiceInvoice AS SI " +
                         "WHERE SI.Status = 'UNPAID' ";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void UpdateListBooking(DateTime departure, string cusID, string roomid)
        {
            string sql = "UPDATE Booking SET Departure = '" + departure + "' WHERE Customer_ID = '" + cusID + "'";
            db.ExecuteNonQuery(sql);
           // sql = "UPDATE ServiceInvoice SET Status = 'PAID' WHERE Customer_ID = '" + cusID + "'";
           // db.ExecuteNonQuery(sql);
            sql = "UPDATE Room SET Status = 'Available' " +
                  "FROM Room AS R INNER JOIN(SELECT Room.Room_ID, Room.Status " +
                                            "FROM Room, Booking " +
                                            "WHERE Room.Room_ID = Booking.Room_ID AND Booking.Room_ID = '" + roomid + "') as R1 " +
                                  "ON R.Room_ID = R1.Room_ID ";
            db.ExecuteNonQuery(sql);
        }


        ///////// REPORT
        // SERVICE
        public DataTable GetAllListServiceReport(DateTime dateFrom, DateTime dateTo)
        {
            string sql = "SELECT * FROM ServiceReport " +
                         "WHERE  Date_Created >= '" + dateFrom + "' AND Date_Payment <= '" + dateTo + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void InsertListServiceReport(DateTime dateT, DateTime dateF, int total)
        {
            string sql = "INSERT INTO ServiceReport(Date_Created, Date_Payment, Total) VALUES('" + dateT + "', '" + dateF + "', " + total + ")";
            db.ExecuteNonQuery(sql);
        }

        // BOOKING
        public DataTable GetAllListBookingReport(DateTime dateFrom, DateTime dateTo)
        {
            string sql = "SELECT * FROM BookingReport " +
                         "WHERE  Date_Created >= '" + dateFrom + "' AND Date_Payment <= '" + dateTo + "'";
            DataTable dt = db.ExecuteQuery(sql);
            return dt;
        }

        public void InsertListListBookingReport(DateTime dateT, DateTime dateF, int total)
        {
            string sql = "INSERT INTO BookingReport(Date_Created, Date_Payment, Total) VALUES('" + dateT + "', '" + dateF + "', " + total + ")";
            db.ExecuteNonQuery(sql);
        }

    }
}
