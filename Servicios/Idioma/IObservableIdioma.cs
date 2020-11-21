namespace Servicios
{
    public interface IObservableIdioma
    {         
        void Suscribir(IObserverTraducible observer);
        void Desuscribir(IObserverTraducible observer);
        void Notificar();
       
    }
}