using System;

namespace Triangle {

  class Tri
  {
    private int SideOne;
    private int SideTwo;
    private int SideThree;

    public Tri(int sone, int stwo, int sthree)
    {
      SideOne = sone;
      SideTwo = stwo;
      SideThree = sthree;
    }

    public int GetSideOne()
    {
      return SideOne;
    }

    public int GetSideTwo()
    {
      return SideTwo;
    }

    public int GetSideThree()
    {
      return SideThree;
    }
  }
}
