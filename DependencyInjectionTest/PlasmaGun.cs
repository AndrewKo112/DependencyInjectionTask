using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionTest {
  public class PlasmaGun: IGun {
    public int Damage { get; set; }

    public PlasmaGun(int damage) {
      this.Damage = damage;
    }

    public void Shoot() {
      Console.WriteLine("piu-piu");
    }
  }
}
