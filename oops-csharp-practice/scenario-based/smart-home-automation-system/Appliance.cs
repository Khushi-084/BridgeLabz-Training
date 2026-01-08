namespace Training.smart_home_automation
{
    //Appliance class is an abstract class
    // implements IControllable
    internal abstract class Appliance : IControllable
    {
        private string applianceName;
        public string ApplianceName
        {
            get { return applianceName; }
            set { applianceName = value; }
        }
        
        //Constructor to set appliance name
        public Appliance(string name)
        {
            ApplianceName = name;
        }
        
        // Abstract methods to control the appliance
        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
