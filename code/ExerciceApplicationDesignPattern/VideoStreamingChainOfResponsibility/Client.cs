using System;


class Client
{
    static void Main(string[] args)
    {
        //Thanks to the chain of responsibility we can display the right vidéo quality depending on the bandwidht
        //of the user. By default is the bandwidth is too low, the video quality is only an audio description. Doing this
        //the user can still watch a video no matter the bandwidth.
        double bandwidth = 0.1;
        Base video4K1 = new Video4K(bandwidth);
        Base videoFullHD1 = new VideoFullHD(bandwidth);
        Base videoSD1 = new VideoSD(bandwidth);

        video4K1.suivant = videoFullHD1;
        videoFullHD1.suivant = videoSD1;

        Console.WriteLine(video4K1.displayVideo());

        bandwidth = 15;
        Base video4K2 = new Video4K(bandwidth);
        Base videoFullHD2 = new VideoFullHD(bandwidth);
        Base videoSD2 = new VideoSD(bandwidth);

        video4K2.suivant = videoFullHD2;
        videoFullHD2.suivant = videoSD2;

        Console.WriteLine(video4K2.displayVideo());

        bandwidth = 25;

        Base video4K3 = new Video4K(bandwidth);
        Base videoFullHD3 = new VideoFullHD(bandwidth);
        Base videoSD3 = new VideoSD(bandwidth);
        
        video4K3.suivant = videoFullHD3;
        videoFullHD3.suivant = videoSD3;

        Console.WriteLine(video4K3.displayVideo());

        bandwidth = 400;

        Base video4K4 = new Video4K(bandwidth);
        Base videoFullHD4 = new VideoFullHD(bandwidth);
        Base videoSD4 = new VideoSD(bandwidth);

        video4K4.suivant = videoFullHD4;
        videoFullHD4.suivant = videoSD4;

        Console.WriteLine(video4K4.displayVideo());
    }
}

