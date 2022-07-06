using System;

public class Video4K : Base
{
  protected double bandwidth;

  public Video4K(double bandwidth)
  {
    this.bandwidth = bandwidth;
  }
  protected override string videoQuality
  {
    get
    {
        if(bandwidth > 300)
        {
            return "Video 4K";
        }
        else
        {
            return null;
        }
    }
  }
}