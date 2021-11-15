using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHAS
{
    class BusinessLogic
    {
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public float Balance { get; set; } = 1000;

    }
    public class Operations
    {
        User obj;
        public Operations()
        {

        }
        public Operations(User obj)
        {
            this.obj = obj;
        }

        public void SaveUser()
        {
            string query = $"insert into customer([name],username,[password],phone,[address],balance,[Ordered]) values " +
                $"('{obj.Name}','{obj.Username}','{obj.Password}',{obj.Phone},'{obj.Address}',{obj.Balance},{0})";
            DBClass.Insert(query);
        }
        public void UpdateUser(string password, string address)
        {
            string query = $"update customer set password='{password}',address='{address}' where username='{LoginForm.username}'";
            DBClass.Insert(query);
        }
        public DataSet View(string tablename)
        {
            string q = $"select * from {tablename}";
            return DBClass.Select(q);
        }
        public DataSet MenuView(string tablename)
        {
            string q = $"select * from {tablename} where Quantity>0";
            return DBClass.Select(q);
        }
        public DataSet CustomerData(string tablename)
        {
            string q = $"select * from {tablename} where username='{LoginForm.username}'";
            return DBClass.Select(q);
        }

        public DataSet CustomerList(string tablename)
        {
            //Id,name,phone,address
            string q = $"select Id,name,phone,address from {tablename} where ordered={1}";
            return DBClass.Select(q);
        }
        public DataSet GetItemList()
        {
            string q = $"select [Name],[Price],[Quantity] from Orders where CustomerId={ViewOrderForm.CustomerId}";
            return DBClass.Select(q);
        }
        public DataSet MenuForUser(string tablename)
        {
            string q = $"select [Name],[Category],[Price] from {tablename} where Quantity>0";
            return DBClass.Select(q);
        }

        public DataSet ViewOrders(string t1, string t2)
        {
            //[Name],[Category],[Price],[Quantity] 
            //,{t1}.[Name],{t1}.Price,{t1}.Quantity
            //where {t1}.CustomerId={t2}.Id
            //
            //Full join {t1} on
            string q = $"select {t2}.[name], {t2}.[phone], {t2}.[address], {t1}.[Name], {t1}.Price, {t1}.Quantity, {t1}.Amount from {t2},{t1} where {t1}.CustomerId={t2}.Id";
            return DBClass.Select(q);
        }
        public DataSet GetSingleItem(string tablename, string col)
        {
            string q = $"select distinct [{col}] from {tablename}";
            return DBClass.SelectSingleItem(q, col);
        }
        public DataSet SubCategory(string tablename, string col, string condition, string field)
        {
            string q = $"select  [{col}] from {tablename} where {field}='{condition}'";
            return DBClass.SelectSingleItem(q, col);
        }

        public void Update(int newValue, string name, string col, string tablename, string field)
        {
            string q = $"select {col} from {tablename} where {field}='{name}'";
            var res = DBClass.SelectSingleItem(q, col);
            int current = int.Parse(res.Tables[0].Rows[0][col].ToString());
            string query = $"update {tablename} set {col}={newValue + current} where {field}='{name}'";
            DBClass.Insert(query);
        }
        public void UpdatePrice(float newValue, string name, string col, string tablename, string field)
        {

            string query = $"update {tablename} set {col}={newValue } where {field}='{name}'";
            DBClass.Insert(query);
        }
        public void UpdateQuantity(int newValue, string name, string col, string tablename, string field)
        {
            string query = $"update {tablename} set {col}={newValue } where {field}='{name}'";
            DBClass.Insert(query);
        }
        public void AddItem(Item obj)
        {
            string query = $"insert into Item([Name],[Category],[Price],[Status],[Quantity]) values" +
                $"('{obj.Name}','{obj.Category}',{obj.Price},{1},{obj.Quantity})";
            DBClass.Insert(query);
        }
        public void SaveOrder(Order obj)
        {
            string query = $"insert into Orders([Name],[Price],[Status],[Quantity],[Amount],[CustomerId]) values" +
                  $"('{obj.Name}',{obj.Price},{1},{obj.Quantity},{obj.Amount},{obj.Id})";
            DBClass.Insert(query);
            query = $"update customer set ordered={1} where username='{LoginForm.username}'";
            DBClass.Insert(query);
        }
        public void SaveBill(Invoice obj)
        {
            string query = $"insert into Bill([Date],[Time],[Amount],[CustomerId],[Discount]) values" +
                  $"('{obj.Date}','{obj.Time}',{obj.Amount},{obj.CustomerId},{obj.Discount}) ";
            DBClass.Insert(query);
        }
        public void Deliver()
        {
            string query = $"update customer set Ordered={0} where Id={ViewOrderForm.CustomerId}";
            DBClass.Insert(query);
            query = $"delete from Orders where CustomerId={ViewOrderForm.CustomerId}";
            DBClass.Insert(query);

        }
    }
    public class Invoice
    {
        public string Date { get; set; }
        public string Time { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public float Amount { get; set; }
        public float Discount { get; set; } = 0;
    }
    public class Item
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public bool Status { get; set; }
        public int Quantity { get; set; }

    }
    public class Order
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public int Id { get; set; }

    }

    public class Validator
    {
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public Validator()
        {
            MinLength = 2;
            MaxLength = 16;
        }

        public string Validate(string arg)
        {
            if (string.IsNullOrEmpty(arg))
            {
                return " is required.";
            }
            else if (arg.Length < MinLength || arg.Length > MaxLength)
                return $" Must be between {MinLength} and {MaxLength}";
            else
                return null;
        }
        public DataSet CheckCredentials(string uname)
        {
            string query = $"select * from [customer] where Username='{uname}'";
            return DBClass.Select(query);
        }

        //internal object CheckUserExists(string uName)
        //{

        //}
    }
}
