namespace Events_ObserverPattern;

internal class Program
{
    static void Main(string[] args)
    {
        YoutubeChannel channel1 = new()
        {
            ChannelDesc = "Programming with jokes",
            ChannelName = "Peace of cake"
        };
        YoutubeChannel channel2 = new()
        {
            ChannelDesc = ".NET Full Stack Channel",
            ChannelName = "Metigator"
        };

        Subscriber subscriber1 = new(channel1);
        Subscriber subscriber2 = new(channel1);

        subscriber1.Subscribe(channel2);
        subscriber2.Subscribe(channel2);



        channel1.UploadVideo("Delegates");
        Console.WriteLine("<###########################################################>");
        
        channel1.UploadVideo("Events and ObserverPattern");
        Console.WriteLine("<###########################################################>");
        
        channel2.UploadVideo("Introduction to .NET Framework");
        Console.WriteLine("<###########################################################>");

    }
}

public class ChannelInfo : EventArgs
{
    public string ChannelName { get; set; }
    public string ChannelDesc { get; set; }
    public string ChannelVideoTitle { get; set; }


    public override string ToString()
    {
        return $"{ChannelName}::{ChannelVideoTitle}::{ChannelDesc}";
    }
}
//delegate void EventHandler(string title);
internal class YoutubeChannel
{

    public event EventHandler<ChannelInfo> event_handler; // using event means you can not accsess it direclty outside 
    public string ChannelName { get; set; }
    public string ChannelDesc { get; set; }
    public void UploadVideo(string Tilte)
    {
        Console.WriteLine($"Video {Tilte} Uploaded Succesfully");
        ChannelInfo channelInfo = new ChannelInfo()
        {
            ChannelVideoTitle = Tilte,
            ChannelDesc = this.ChannelDesc,
            ChannelName = this.ChannelName

        };
        event_handler.Invoke(this, channelInfo);
    }
    public override string ToString()
    {
        return $"{ChannelName}::{ChannelDesc}";
    }
}

internal class Subscriber
{
    public Subscriber(YoutubeChannel channel)
    {
        channel.event_handler += WatchVideo;
    }

    public void Subscribe(YoutubeChannel channel)
    {
        channel.event_handler += WatchVideo;
    }
    public void WatchVideo(object e, ChannelInfo channelinfo)
    {
        YoutubeChannel channel = (YoutubeChannel)e;
        //Console.WriteLine($"user watch video {channelinfo.ChannelVideoTitle} from Channel {channel.ChannelName}");
        Console.WriteLine(channel.ToString() + "::" + channelinfo.ChannelVideoTitle);
    }
}