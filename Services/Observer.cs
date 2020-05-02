using Problem11;
using Problem11.Model;

namespace Services
{
    public interface Observer
    {
        void AngajatSubmitted(DTOBJCursa[] curse);
    }
}