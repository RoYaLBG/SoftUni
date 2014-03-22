using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    class Info
    {
        private static CompanyInfo companyInst = null;

        private static CompanyInfo GetCompanyInstance()
        {
            if (companyInst == null)
            {
                companyInst = new CompanyInfo();
            }
            return companyInst;
        }

        private static Dictionary<string, string> PromptForCompany()
        {
            string[] keys = new string[] { "name", "address", "phone", "fax", "site" };
            Dictionary<string, string> company = new Dictionary<string, string>();
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Enter company's " + keys[i] + ":");
                string toAdd = Console.ReadLine();
                if (String.IsNullOrEmpty(toAdd))
                {
                    toAdd = " (no " + keys[i] + " ) ";
                }
                company.Add(keys[i], toAdd);

            }
            return company;
        }

        private static Dictionary<string, string> PromptForManager()
        {
            string[] keys = new string[] { "first name", "last name", "age", "phone" };
            Dictionary<string, string> manager = new Dictionary<string, string>();
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Enter manager's " + keys[i] + ":");
                string toAdd = Console.ReadLine();
                if (String.IsNullOrEmpty(toAdd) && keys[i] != "age")
                {
                    toAdd = " (no " + keys[i] + " ) ";
                }
                manager.Add(keys[i], toAdd);
            }
            return manager;
        }



        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var company = PromptForCompany();
                    var manager = PromptForManager();

                    GetCompanyInstance()._companyName = company["name"];

                    try
                    {
                        GetCompanyInstance().RegisterCompany();
                    }
                    catch (CompanyRegisterException e)
                    {
                        Console.WriteLine("Caught Fatal CompanyRegisterException: " + e.Message + " the application is terminating");
                        return;
                    }
                    GetCompanyInstance().SetAddr(company["address"]);
                    GetCompanyInstance().SetFax(company["fax"]);
                    GetCompanyInstance().SetPhone(company["phone"]);
                    GetCompanyInstance().SetSite(company["site"]);

                    GetCompanyInstance().SetManagerName(manager["first name"]);

                    GetCompanyInstance().SetManagerObject(manager["last name"], Convert.ToUInt16(manager["age"]), manager["phone"]);

                    GetCompanyInstance().SetManagerInfo();

                    GetCompanyInstance().PrintInfo();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Caught exception: " + e.Message + " the application is restarting");
                }
            }
        }
    }
}
