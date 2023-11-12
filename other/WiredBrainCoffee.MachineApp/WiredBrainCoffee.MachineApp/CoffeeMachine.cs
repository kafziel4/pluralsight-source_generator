using WiredBrainCoffee.Generators;

namespace WiredBrainCoffee.MachineApp
{
    [GenerateToString]
    internal partial class CoffeeMachine
    {
        public string? SerialNumber { get; set; }
        public int BeanLevel { get; set; }
    }
}
