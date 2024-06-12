using Lesson1.Models;

namespace Lesson1.Services;

public class CertServiceImpl : CertService
{
    private List<Cert> certs;

    public CertServiceImpl()
    {
        certs = new List<Cert>()
        {
            new Cert() {
                Id = 1,
                Name = "Cert 1"
            },
            new Cert() {
                Id = 2,
                Name = "Cert 2"
            },
            new Cert() {
                Id = 3,
                Name = "Cert 3"
            }
        };


    }

    public List<Cert> findAll()
    {
        return certs;
    }

}
