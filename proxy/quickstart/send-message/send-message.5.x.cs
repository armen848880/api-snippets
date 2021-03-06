// NOTE: This example uses the ALPHA release of the next generation Twilio
// helper library - for more information on how to download and install this version, visit
// https://www.twilio.com/docs/libraries/csharp#accessing-preview-twilio-features

using System;
using Twilio;
using Twilio.Rest.Preview.Proxy.Service.Session.Participant;

class Example
{
    static void Main(string[] args)
    {
        // Find your Account Sid, Auth Token and Proxy Service sid at twilio.com/console
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string authToken = "your_auth_token";
        const string proxyServiceSid = "KSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string sessionSid = "KCXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        const string participantSid = "KPXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        TwilioClient.Init(accountSid, authToken);

        var msgInteraction = MessageInteractionResource.Create(
            proxyServiceSid,
            sessionSid,
            participantSid,
            "Reply to this message to chat");

        Console.WriteLine(msgInteraction.Sid);
    }
}
