﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
       // Application.Run(new LoginForm());

            Application.Run(new frmCustomerCreditPayment());
          //Application.Run(new PurchaseOrder());
        }
    }
}
