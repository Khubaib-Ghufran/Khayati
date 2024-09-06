﻿using Entities;

namespace Khayati.ServiceContracts.DTO
{
    public class AddCustomerDto
    {
        public string CustomerName { get; set; }

        public string CustomerAddress { get; set; }


        public Customer ToCustomer()
        {
            return new Customer
            {
                CustomerName = CustomerName,
                CustomerAddress = CustomerAddress
            };
        }

    }
}
