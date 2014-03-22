using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Company
{
    class CompanyInfo
    {
        private Dictionary<int, Dictionary<string, string>> _company = new Dictionary<int, Dictionary<string, string>>();
        private Dictionary<int, Dictionary<string, string>> _manager = new Dictionary<int, Dictionary<string, string>>();
        private ManagerInfo _managerObject;
        private int _companyId;
        private string _managerName;
        public string _companyName { get; set; }

        public CompanyInfo() { } 

        private int GetMaxCompanyID()
        {
            int max = 0;
            foreach (int i in this._company.Keys)
            {
                max = Math.Max(max, i);
            }
            return max;
        }

        public void RegisterCompany()
        {
            for (int i = 1; i <= GetMaxCompanyID(); i++)
            {
                if (this._company.Count > 0)
                {

                    if (this._company[i]["name"] == _companyName)
                    {
                        throw new CompanyRegisterException("This company is already registered!");
                    }
                }
            }
            this._companyId = this.GetMaxCompanyID() + 1;
            this._company.Add(this._companyId, new Dictionary<string, string>());
            this._company[this._companyId].Add("name", _companyName);
        }

        public string GetName()
        {
            return this._company[this._companyId]["name"];
        }

        public void SetAddr(string addr)
        {
            this._company[this._companyId].Add("address", addr);
        }

        public string GetAddr()
        {
            return this._company[this._companyId]["address"];
        }

        public void SetPhone(string phone)
        {
            this._company[this._companyId].Add("phone", phone);
        }

        public string GetPhone()
        {
            return this._company[this._companyId]["phone"];
        }

        public void SetFax(string fax)
        {
            this._company[this._companyId].Add("fax", fax);
        }

        public string GetFax()
        {
            return this._company[this._companyId]["fax"];
        }

        public void SetSite(string site)
        {
            this._company[this._companyId].Add("site", site);
        }

        public string GetSite()
        {
            return this._company[this._companyId]["site"];
        }

        public void SetManagerName(string managerName)
        {
            this._managerName = managerName;
            this._company[this._companyId].Add("manager", managerName);
        }

        public string GetManagerName()
        {
            return this._company[this._companyId]["manager"];
        }

        public void SetManagerObject(string lastName, ushort age, string phone)
        {
            if (!String.IsNullOrEmpty(this._managerName))
            {
                this._managerObject = new ManagerInfo(_managerName, lastName, age, phone, this.GetName(), _companyId);
            }
        }

        public Dictionary<string, string> GetManagerObject()
        {
            return this._managerObject.GetManagerObject();
        }

        public void SetManagerInfo()
        {
            this._manager.Add(this._companyId, new Dictionary<string, string>());
            this._manager[this._companyId].Add("firstname", this.GetManagerObject()["firstname"]);
            this._manager[this._companyId].Add("lastname", this.GetManagerObject()["lastname"]);
            this._manager[this._companyId].Add("age", this.GetManagerObject()["age"]);
            this._manager[this._companyId].Add("phone", this.GetManagerObject()["phone"]);
        }

        public string GetManagerFName()
        {
            return this._manager[this._companyId]["firstname"];
        }

        public string GetManagerLName()
        {
            return this._manager[this._companyId]["lastname"];
        }

        public ushort GetManagerAge()
        {
            return Convert.ToUInt16(this._manager[this._companyId]["age"]);
        }

        public string GetManagerPhone()
        {
            return this._manager[this._companyId]["phone"];
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.GetName());
            Console.WriteLine("Address: " + this.GetAddr());
            Console.WriteLine("Tel: " + this.GetPhone());
            Console.WriteLine("Fax: " + this.GetFax());
            Console.WriteLine("Web site: " + this.GetSite());
            Console.WriteLine("Manager: " + this.GetManagerFName() + " " + this.GetManagerLName() + " (age: " + this.GetManagerAge() +
                ", tel. " + this.GetManagerPhone() + ")");
        }

    }


    class CompanyRegisterException : Exception
    {
        public CompanyRegisterException(string message) : base(message) { }
    }
}