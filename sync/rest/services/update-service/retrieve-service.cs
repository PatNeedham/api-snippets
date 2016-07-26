// Download the next-gen twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio.Clients;
using Twilio.Resources.Preview.Sync;

class Example
{
  static void Main(string[] args)
  {
    // Find your Account Sid and Auth Token at twilio.com/console
    var accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
    var authToken = "your_auth_token";
    var client = new TwilioRestClient(accountSid, authToken);

    var service = ServiceResource.Update("ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX")
      .setFriendlyName("NEW_FRIENDLY_NAME")
      .Execute(client);

    Console.WriteLine(service.GetFriendlyName());
  }
}