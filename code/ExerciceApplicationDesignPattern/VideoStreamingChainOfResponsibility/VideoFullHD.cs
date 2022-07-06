using System;

public class VideoFullHD : Base
{
  protected double bandwidth;
  public VideoFullHD(double bandwidth)
  {
    this.bandwidth = bandwidth;
  }
  
  protected override string videoQuality
  {
    get
    {
        if(bandwidth > 20)
        {
            return "Video Full HD";
        }
        else
        {
            return null;
        }
    }
  }
}