using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company
{
    class ManagerInfo
    {
        private Dictionary<int, Dictionary<string, string>> _companies = new Dictionary<int, Dictionary<string, string>>();
        private Dictionary<int, Dictionary<string, string>> _manager = new Dictionary<int, Dictionary<string, string>>();
        private int _currentCompanyId;
        private string _firstName { get; set; }
        private string _lastName { get; set; }
        private ushort _age { get; set; }
        private string _phone { get; set; }


        public ManagerInfo(string firstName, string lastName, ushort age, string phone, string companyName, int companyId)
        {
            try
            {
                this.RegisterCompany(companyName, companyId);
            }
            catch (ManagerRegisterException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._phone = phone;

            this.CreateCurrentCompanyOject();
            this.CreateManagerObject();
        }

        private void RegisterCompany(string companyName, int companyId)
        {

            for (int i = 1; i <= this.GetMaxCompanyID(); i++)
            {
                if (this._companies.Count > 0)
                {
                    if (this._companies[i]["name"] == companyName)
                    {
                        throw new ManagerRegisterException("You already own that company");
                    }
                }
            }
            this._currentCompanyId = companyId;
            this._companies.Add(companyId, new Dictionary<string, string>());
            this._companies[companyId]["name"] = companyName;
        }

        private void CreateCurrentCompanyOject()
        {
            this._manager.Add(this._currentCompanyId, new Dictionary<string,string>());
        }

        private void CreateManagerObject()
        {
            this._manager[_currentCompanyId].Add("firstname", this._firstName);
            this._manager[_currentCompanyId].Add("lastname", this._lastName);
            this._manager[_currentCompanyId].Add("age", this._age.ToString());
            this._manager[_currentCompanyId].Add("phone", this._phone);
        }

        public Dictionary<string, string> GetManagerObject()
        {
            return this._manager[_currentCompanyId];
        }

        private int GetMaxCompanyID()
        {
            int max = 0;
            foreach (int i in this._companies.Keys)
            {
                max = Math.Max(max, i);
            }
            return max;
        }

    }


    class ManagerRegisterException : Exception
    {
        public ManagerRegisterException(string message) : base(message) { }
    }

 }

