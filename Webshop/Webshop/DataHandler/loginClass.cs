using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.DataContext;

namespace Webshop.DataHandler
{
    public class LoginClass
    {
        // Northwnd inherits from System.Data.Linq.DataContext.
        Northwnd nw = new Northwnd(@"Ken.mdf");
        // or, if you are not using SQL Server Express 
        Northwnd nw = new Northwnd("Database=Northwind;Server=server_name;Integrated Security=SSPI");

        var companyNameQuery =
        from cust in nw.Customers
        where cust.City == "London" 
        select cust.CompanyName;

        foreach (var customer in companyNameQuery)
        {
             Console.WriteLine(customer);
        }
    }
}