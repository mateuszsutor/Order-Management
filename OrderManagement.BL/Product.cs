﻿using Common;
using System;

namespace OrderManagement.BL
{
    public class Product : BaseClass, ILogin
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; private set; }

        public Decimal? ActualPrice { get; set; }
        public string Description { get; set; }
        private string _ProductName;


        public string ProductName
        {
            get 
            {
                return _ProductName.InsertSpace(); 
            }

            set { _ProductName = value; }
        }



        /// <summary>
        /// Validates the required field ProductName
        /// </summary>
        /// <returns>returns true if the product name is correct and false if is null </returns>
        public override bool Validate()
        {
            var correct = true;

            if (string.IsNullOrWhiteSpace(ProductName))
                correct = false;

            return correct;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logText = ProductId + ": " +
                          ProductName + " " +
                          "Opis: " + Description + " " +
                          "Status :" + ObjectStatus.ToString();

            return logText;
        }

    }
}
