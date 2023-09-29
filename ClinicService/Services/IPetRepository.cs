using ClinicService.Models;
using System.Security.Cryptography;

namespace ClinicService.Services
{
    public interface IPetRepository : IRepository<Pet, int> {
        List<Pet>  GetByClientId(int id);

    }
}
