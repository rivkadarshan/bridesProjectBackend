using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Models;
using Dto.classes;

namespace Dal.converters
{
    public class CustomerConvert
    {
         public static CustomerDto ToDto(Customer c)
         {
             return new CustomerDto
             {            
                 CustomerId=c.CustomerId,
                 CustomerName=c.CustomerName,
                 CustomerPhone=c.CustomerPhone,
                 CustomerDescription =c.CustomerDescription,              
             };
         }
         public static Customer ToDal(CustomerDto c)
         {
             return new Customer
             {
                 CustomerId = c.CustomerId,
                 CustomerName = c.CustomerName,
                 CustomerPhone = c.CustomerPhone,
                 CustomerDescription = c.CustomerDescription,
             };
         }

         public static List<Customer> ToLDal(List<CustomerDto> lc)
         {
             List<Customer> newl = new List<Customer>();
             foreach (var item in lc)
             {
                 newl.Add(ToDal(item));
             }
             return newl;
         }
         public static List<CustomerDto> ToLDto(List<Customer> lc)
         {
             List<CustomerDto> newl = new List<CustomerDto>();
             foreach (var item in lc)
             {
                 newl.Add(ToDto(item));
             }
             return newl;
            }
        }
    }

