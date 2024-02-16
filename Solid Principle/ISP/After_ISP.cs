using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.ISP
{
    interface ICommonFees
    {
        void UniversityFees(decimal universityAmount);
        void ExamFees(decimal examAmount);
        void PlacementFees(decimal placementAmount);
    }
    interface IBusFeesDetails
    {
        void BusFees(decimal busAmount);
    }
    interface IHostelFeesDetails
    {
        void HostelFees(decimal hostelAmount);
    }

    public class HostelStudentFees : ICommonFees, IHostelFeesDetails
    {
        public void UniversityFees(decimal universityAmount)
        {
            Console.WriteLine("Univeristy Fees: {0}", universityAmount);
        }

        public void ExamFees(decimal examAmount)
        {
            Console.WriteLine("Exam Fees: {0}", examAmount);
        }

        public void PlacementFees(decimal placementAmount)
        {
            Console.WriteLine("Placement Fees: {0}", placementAmount);
        }
        public void HostelFees(decimal hostelAmount)
        {
            Console.WriteLine("Hostel Fees: {0}", hostelAmount);
        }
    }

    public class CityStudentFees : ICommonFees, IBusFeesDetails
    {
        public void UniversityFees(decimal universityAmount)
        {
            Console.WriteLine("Univeristy Fees: {0}", universityAmount);
        }

        public void ExamFees(decimal examAmount)
        {
            Console.WriteLine("Exam Fees: {0}", examAmount);
        }

        public void BusFees(decimal busAmount)
        {
            Console.WriteLine("Bus Fees: {0}", busAmount);
        }
        public void PlacementFees(decimal placementAmount)
        {
            Console.WriteLine("Placement Fees: {0}", placementAmount);
        }
    }
}
