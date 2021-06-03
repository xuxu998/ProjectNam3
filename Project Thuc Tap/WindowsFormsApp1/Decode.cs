using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.IO.Ports;
using System.Xml;

namespace WindowsFormsApp1
{
     class Hiden
    {
        
     static  public int ToInt(string account,string date,string delivering, string receiving,string product)
        {
            string k = "";
            if (account != "")
                k = k + "1";
            else k = k + "0";
            if (date != "        ")
                k = k + "1";
            else k = k + "0";
            if (delivering != " ")
                k = k + "1";
            else k = k + "0";
            if (receiving != " ")
                k = k + "1";
            else k = k + "0";
            if (product != " ")
                k = k + "1";
            else k = k + "0";
            int sum = (k[0]-48) * 2 * 2 * 2 * 2 + (k[1]-48) * 2 * 2 * 2 + (k[2]-48) * 2 * 2 + (k[3]-48) * 2 + (k[4]-48);
            return sum;
        }
        static public DataTable AGVdata(string query)
        {
            DataTable data = new DataTable();
            string connectionString = @"Data Source=DESKTOP-7FQCTM2\SQLEXPRESS;Initial Catalog=Dat;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        static public string decode(int k, string account, string date, string delivering, string receiving, string product)
        {
            if (date.Contains(' ') == false|| date=="        ")
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Date = '" + date + "'";
                    case 9: return "select * from HistoryDelivery where Date = '" + date + "' and Product ='" + product + "'";
                    case 10: return "select * from HistoryDelivery where Date = '" + date + "' and ReceivingStation ='" + receiving + "'";
                    case 11: return "select * from HistoryDelivery where Date = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 12: return "select * from HistoryDelivery where Date = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 13: return "select * from HistoryDelivery where Date = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 14: return "select * from HistoryDelivery where Date = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 15: return "select * from HistoryDelivery where Date = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "' and Product ='" + product + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Date = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                }
            if (date[0] != ' ' && date[1] != ' ' && date[2] != ' ' && date[3] != ' ' && date[4] == ' ' && date[5] == ' ' && date[6] == ' ' && date[7] == ' ')
            {
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Year(Date) = '" + date + "'";
                    case 9: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and Product ='" + product + "'";
                    case 10: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and ReceivingStation ='" + receiving + "'";
                    case 11: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 12: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 13: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 14: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 15: return "select * from HistoryDelivery where Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "' and Product ='" + product + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Year(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                }
            }
            if (date[0] == ' ' && date[1] == ' ' && date[2] == ' ' && date[3] == ' ' && date[4] != ' ' && date[5] != ' ' && date[6] == ' ' && date[7] == ' ')
            {
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Month(Date) = '" + date + "'";
                    case 9: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and Product ='" + product + "'";
                    case 10: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and ReceivingStation ='" + receiving + "'";
                    case 11: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 12: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 13: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 14: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 15: return "select * from HistoryDelivery where Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "' and Product ='" + product + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                }
                
            }
            if (date[0] == ' ' && date[1] == ' ' && date[2] == ' ' && date[3] == ' ' && date[4] == ' ' && date[5] == ' ' && date[6] != ' ' && date[7] != ' ')
            {
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Day(Date) = '" + date + "'";
                    case 9: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and Product ='" + product + "'";
                    case 10: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and ReceivingStation ='" + receiving + "'";
                    case 11: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 12: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 13: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 14: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 15: return "select * from HistoryDelivery where Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "' and Product ='" + product + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + date + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                }
            }
            if (date[0] != ' ' && date[1] != ' ' && date[2] != ' ' && date[3] != ' ' && date[4] == ' ' && date[5] == ' ' && date[6] != ' ' && date[7] != ' ')
            {
                string year = date.Substring(0, 4);
                string day = date.Substring(6, 2);
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and Year(Date)=' "+ year +"'";
                    case 9: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 10: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and ReceivingStation ='" + receiving + "' and Year(Date)='" + year + "'";
                    case 11: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'and Year(Date)='" + year + "'";
                    case 12: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Year(Date)='" + year + "'";
                    case 13: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 14: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Year(Date)='" + year + "'";
                    case 15: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "'and Year(Date)='" + year + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Year(Date)=' " + year + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Year(Date)='" + year + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                }
            }
            if (date[0] != ' ' && date[1] != ' ' && date[2] != ' ' && date[3] != ' ' && date[4] != ' ' && date[5] != ' ' && date[6] == ' ' && date[7] == ' ')
            {
                string year = date.Substring(0, 4);
                string month = date.Substring(4, 2);
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and Year(Date)='"+ year + "'";
                    case 9: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 10: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and ReceivingStation ='" + receiving + "' and Year(Date)='" + year + "'";
                    case 11: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                    case 12: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and Year(Date)='" + year + "'";
                    case 13: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 14: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Year(Date)='" + year + "'";
                    case 15: return "select * from HistoryDelivery where Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and Year(Date)='" + year + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and Year(Date)='" + year + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "' and Year(Date)='" + year + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Year(Date)='" + year + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Month(Date) = '" + month + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Year(Date)='" + year + "'";
                }
            }
            if (date[0] == ' ' && date[1] == ' ' && date[2] == ' ' && date[3] == ' ' && date[4] != ' ' && date[5] != ' ' && date[6] != ' ' && date[7] != ' ')
            {
                string month = date.Substring(4, 2);
                string day = date.Substring(6, 2);
                switch (k)
                {
                    case 0: return "select * from HistoryDelivery ";
                    case 1: return "select * from HistoryDelivery where Product ='" + product + "'";
                    case 2: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "'";
                    case 3: return "select * from HistoryDelivery where ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 4: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "'";
                    case 5: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 6: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 7: return "select * from HistoryDelivery where DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 8: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and Month(Date)='" + month + "'";
                    case 9: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and Product ='" + product + "' and Month(Date)='" + month + "'";
                    case 10: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and ReceivingStation ='" + receiving + "' and Month(Date)=' " + month + "'";
                    case 11: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Month(Date)='" + month + "'";
                    case 12: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Month(Date)='" + month + "'";
                    case 13: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "' and Month(Date)='" + month + "'";
                    case 14: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Month(Date)='" + month + "'";
                    case 15: return "select * from HistoryDelivery where Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Month(Date)='" + month + "'";
                    case 16: return "select * from HistoryDelivery where Account = '" + account + "'";
                    case 17: return "select * from HistoryDelivery where Account = '" + account + "' and Product ='" + product + "'";
                    case 18: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "'";
                    case 19: return "select * from HistoryDelivery where Account = '" + account + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 20: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "'";
                    case 21: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "'";
                    case 22: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "'";
                    case 23: return "select * from HistoryDelivery where Account = '" + account + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "'";
                    case 24: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "'and Month(Date)='" + month + "'";
                    case 25: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and Product ='" + product + "' and Month(Date)='" + month + "'";
                    case 26: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Month(Date)='" + month + "'";
                    case 28: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "'and Month(Date)='" + month + "'";
                    case 29: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and Product ='" + product + "' and Month(Date)='" + month + "'";
                    case 30: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Month(Date)='" + month + "'";
                    case 31: return "select * from HistoryDelivery where Account = '" + account + "' and Day(Date) = '" + day + "' and DeliveringStation ='" + delivering + "' and ReceivingStation ='" + receiving + "' and Product='" + product + "' and Month(Date)='" + month + "'";
                }
            }


            return "select * from HistoryDelivery";
        }
        static public string filter(string s)
        {
            if (s != "")
            {
                string a = "";
                a = a + s[s.Length - 1].ToString();
                return a;
            }
            else return "";
        }
        static public DataTable Data(string query)
        {
            DataTable data = new DataTable();
            string connectionString = @"Data Source=DESKTOP-7FQCTM2\SQLEXPRESS;Initial Catalog=Dat;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        static public string Date(string date)
        {
            string s = "";
            s = date.Substring(0, 9);
            return s;
        }
        static public int StatusStation(string station1,string station2)
        {
            if (station1 == "Deliver" && station2 == "Deliver")
                return 1;
            if (station1 == "Not Deliver" && station2 == "Deliver")
                return 2;
            if (station1 == "Deliver" && station2 == "Not Deliver")
                return 3;
            if (station1 == "Not Deliver" && station2 == "Not Deliver")
                return 4;
            else return 0;

        }
      /*  public string CheckAvailableAGV()
        {
            if(serial)

        }*/
      public string Remove(string s)
        {
            string k="";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]!='-')
                {
                    k = k + s[i];
                }
            }
            return k;
        }
      
    }
}
