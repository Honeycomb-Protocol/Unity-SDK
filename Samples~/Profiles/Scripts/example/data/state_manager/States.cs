using HplEdgeClient.Inputs;
using HplEdgeClient.Types;

[System.Serializable]
public class AppState
{
    public string AuthToken { get; set; }
    public User CurrentUser { get; set; }
    public Profile CurrentProfile { get; set; }

    // Honeynet Initialized Test Project for this Example you can create also your own project through following https://docs.honeycombprotocol.com/projects/
    public string Project { get; set; } = "7fFLj9toRQkMVomCyECtbyDVfmMsXRDRgaKNQ22NDcZV";


    public UserInfoInput CreateProfileInfo = new()
    {
        Bio = "",
        Name = "",
        Pfp = "",
    };
}
