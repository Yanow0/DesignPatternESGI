using System;

public class VideoSD : Base
{
  protected double bandwidth;
  public VideoSD(double bandwidth)
  {
    this.bandwidth = bandwidth;
  }
  protected override string videoQuality
  {
    get
    {
        if(bandwidth > 1)
        {
            return "Video SD";
        }
        else
        {
            return null;
        }
    }
  }
}