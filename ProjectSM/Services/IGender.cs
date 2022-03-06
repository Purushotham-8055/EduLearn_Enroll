using ProjectSM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectSM.Services
{
    public interface IGender
    {
        IEnumerable<Gender> GetGenders { get; }
        Gender GetGender(int? Id);
        void Add(Gender _Gender);
        void Remove(int? Id);

    }
}