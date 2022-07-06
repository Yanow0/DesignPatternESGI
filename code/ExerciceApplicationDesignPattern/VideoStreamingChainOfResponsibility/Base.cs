using System;

public abstract class Base
{
  public Base suivant { protected get; set; }

  private string defaultVideoQuality()
  {
    return "Audio description";
  }

  protected abstract string videoQuality { get; }

  public string displayVideo()
  {
    if (this.videoQuality != null)
      return this.videoQuality;
    if (suivant != null)
      return suivant.displayVideo();
    else
      return this.defaultVideoQuality();
  }
}
