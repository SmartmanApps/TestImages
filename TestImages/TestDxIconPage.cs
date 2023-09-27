namespace SmartmanApps.Controls;
public class TestDxIconPage :ContentPage
{
public TestDxIconPage() {
    Label newLabel=new Label{
        Text=$"{nameof(TestDxIconPage)}",
        };
    Image dotnetBotImage=new Image{
        Source="dotnet_bot.png",
//        Source="dropboxicon.png",
//        HeightRequest=200,
        HorizontalOptions=LayoutOptions.Center,
        };
    Image dropboxImage=new Image{
        Source="dropbox1.png",
//        Source="dotnet_bot.png",
        HeightRequest=200,
        HorizontalOptions=LayoutOptions.Center,
        };
//    Content=newLabel;
//    Content=dotnetBotImage;
    Content=dropboxImage;
    }
}
