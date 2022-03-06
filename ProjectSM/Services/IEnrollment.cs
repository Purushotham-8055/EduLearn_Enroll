using ProjectSM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSM.Services
{
    public interface IEnrollment
    {
        IEnumerable<Enrollment> GetEnrollments { get; }
        Enrollment GetEnrollment(int? Id);
        void Add(Enrollment _Enrollment);
        void Remove(int? Id);

    }
}