using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipalsDemo.ISP
{
    interface IStudentFees
    {
        void UniversityFees(decimal universityAmount);
        void ExamFees(decimal examAmount);
        void BusFees(decimal busAmount);
        void PlacementFees(decimal placementAmount);
        void HostelFees(decimal hostelAmount);
    }
    
    public class HostelStudent : IStudentFees
    {
        public void UniversityFees(decimal universityAmount)
        {
            Console.WriteLine("Univeristy Fees: {0}",universityAmount);
        }

        public void ExamFees(decimal examAmount)
        {
            Console.WriteLine("Exam Fees: {0}", examAmount);
        }

        public  void BusFees(decimal busAmount)
        {
            throw new NotImplementedException();
        }
        public void PlacementFees(decimal placementAmount) {
            Console.WriteLine("Placement Fees: {0}", placementAmount);
        }
        public void HostelFees(decimal hostelAmount)
        {
            Console.WriteLine("Hostel Fees: {0}", hostelAmount);
        }
    }

    public class CityStudent : IStudentFees
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
        public void HostelFees(decimal hostelAmount)
        {
            throw new NotImplementedException();
        }
    }
    public class InternationalStudentFees : IStudentFees
    {
        public void UniversityFees(decimal universityAmount)
        {
            throw new NotImplementedException();
        }

        public void ExamFees(decimal examAmount)
        {
            Console.WriteLine("Exam Fees: {0}", examAmount);
        }

        public void BusFees(decimal busAmount)
        {
            throw new NotImplementedException();
        }
        public void PlacementFees(decimal placementAmount)
        {
            Console.WriteLine("Placement Fees: {0}", placementAmount);
        }
        public void HostelFees(decimal hostelAmount)
        {
            throw new NotImplementedException();
        }
    }


}
