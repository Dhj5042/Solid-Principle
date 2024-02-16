using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.OCP
{
    public class FeesAmount
    {
        public virtual double GetFeesAmount(double amount)
        {
            return amount + 10000;
        }
    }
    public class IndianStudent : FeesAmount
    {
        public override double GetFeesAmount(double amount)
        {
            return base.GetFeesAmount(amount) - 0;
        }
    }
    public class InternationalStudent : FeesAmount
    {
        public override double GetFeesAmount(double amount)
        {
            return base.GetFeesAmount(amount) - 10000;
        }
    }
    public class MYSStudent : FeesAmount
    {
        public override double GetFeesAmount(double amount)
        {
            return base.GetFeesAmount(amount) - 5000;
        }
    }
}
