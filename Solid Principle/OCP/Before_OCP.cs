using SolidPrincipalsDemo.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.OCP
{
    public class FeesAmountOCP
    {
        public double GetTotalFeesAmount(double amount, StudentType studentType)
        {
            double finalAmount = 0;
            if (studentType == StudentType.IndianStudent)
            {
                finalAmount = amount + 10000;
            }
            else if (studentType == StudentType.InternationalStudent)
            {
                finalAmount = amount + 0;
            }
            return finalAmount;
        }
    }
    public enum StudentType
    {
        IndianStudent,
        InternationalStudent,
    
    };
}
