﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classTypeArray
{
    class Bank
    {
       private string bankName ;
       private string address ;
       private Account[] account;
       public int count = 0;

       public Bank()
       {
           Console.WriteLine("Empty Constructor \n -------------------------------");
          
       }
       public Bank( string bankName , string address )
       {
           count++;
           Console.WriteLine("Peramiterised Constructor \n -------------------------------");
           this.bankName = bankName;
           this.address = address;
           account = new Account[5];
 
       }

       public string BankName
       {
           set { this.bankName = value; }
           get { return bankName; }
       }


       public string Address
       {
           set { this.address = value; }
           get { return address ; }
       }



       public void addAccount(Account a)
       {
           
           for (int i = 1; i <= count; i++)
           {
               account[i] = a;
           }

           

       }



       public void deleteAccount(Account a)
       {

           for (int i = 1; i <= count; i++)
           {
               if (account[i] == a)
               {
                   account[i] = null;

               }

           }

       }

       public void showDetails()
       {
           Console.WriteLine("Bank name :{0}\nAddress :{1}\n", bankName, address);

           Console.WriteLine("---------- Bank Account holders ----------");

           for (int i = 1; i<=count; i++)
           {
               Console.WriteLine(count);
               Console.WriteLine("Account Holder :{0}\nAccountId :{1}\nBalace:{2}\n", account[i].accountHolderName, account[i].accountId, account[i].balance);
           }
           
       }

    }
}
