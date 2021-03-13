using FacadePattern.Facade;

namespace FacadePattern.Objects
{
    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
