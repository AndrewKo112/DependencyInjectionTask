namespace DependencyInjectionTest {
  public class SpaceShip {
    public Engine Engine { get; set; }

    public SpaceShip(Engine engine) {
      this.Engine = engine;
    }
  }
}
