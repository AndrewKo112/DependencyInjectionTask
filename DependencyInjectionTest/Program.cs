namespace DependencyInjectionTest {

  class Program {
    static void Main(string[] args) {

      DIContainer.AddInstantiationType(typeof(Engine), 350000);
      DIContainer.AddInstantiationType(typeof(SpaceShip));

      // TASK: Modify DIContainer so you can add interface as instantiation type
      //DIContainer.AddInstantiationType(typeof(Gun));

      var spaceShip = DIContainer.Instantiate<SpaceShip>();
      System.Console.WriteLine(spaceShip.Engine.Power);
    }
  }
}
