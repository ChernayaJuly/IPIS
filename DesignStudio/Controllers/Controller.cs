﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DesignStudio.Models;


namespace DesignStudio.Controllers
{
    class Controller
    {
        private MyDbContext DbContext;
        

        public Controller()
        {
            DbContext = new MyDbContext();
        }

        public void AddClient(string name,string surname, string middlename,string birthdate,string mobilephone, string address)
        {
            Client client = new Client();
            client.Name = name;
            client.Surname = surname;
            client.MiddleName = middlename;
            client.Birthdate = DateTime.Parse(birthdate);
            client.MobilePhone = mobilephone;
            client.Address = address;
            DbContext.Clients.Add(client);
            DbContext.SaveChanges();
        }

        public void AddDesigner(string name,string surname, string middlename,string birthdate,string mobilephone, string address)
        {
            Designer designer = new Designer();
            designer.Name = name;
            designer.Surname = surname;
            designer.MiddleName = middlename;
            designer.Birthdate = DateTime.Parse(birthdate);
            designer.MobilePhone = mobilephone;
            designer.Address = address;
            DbContext.Designers.Add(designer);
            DbContext.SaveChanges();
        }


        public void AddOrder()
        {
            Order order = new Order();
            order.Number = "0120312030";
            order.Description = "dsjflasjdflkjsa";
            order.ReadyStatus = ReadyStatus.InProgress;
            order.
        }

        public void ShowClients(ref DataGrid dataGrid)
        {
            DbContext.Clients.Load();
            dataGrid.ItemsSource = DbContext.Clients.Local.ToBindingList(); 
    
        }

        public void ShowDesigners(ref DataGrid dataGrid)
        {
            DbContext.Clients.Load();
            dataGrid.ItemsSource = DbContext.Designers.Local.ToBindingList();
        }

        public void ShowOrders(ref DataGrid dataGrid)
        {
            DbContext.Clients.Load();
            dataGrid.ItemsSource = DbContext.Orders.Local.ToBindingList();
        }

        public void Dispose()
        {

        }
    }
}
